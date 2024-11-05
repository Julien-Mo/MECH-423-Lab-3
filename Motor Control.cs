using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MECH_423_Lab_3
{
    public partial class MotorControl : Form
    {
        private const double CountsPerRotation = 244;
        private const int SamplingTime = 50;
        private ConcurrentQueue<Byte> dataQueue = new ConcurrentQueue<Byte>();
        private int state = 0;
        private bool isStepperMotor = true;
        private bool isRunContinuously = true;
        private bool isReverse = false;
        private byte speedHigh = 0;
        private byte speedLow = 0;
        private byte commandByte = 0;
        private byte countLow = 0;
        private byte countHigh = 0;
        private byte countCommand = 0;
        private short countCurrent = 0;
        private short countPrevious = 0;
        private short countTrue = 0;
        private int countDifference = 0;
        private double rotations = 0.0;
        private int time = 0;

        public MotorControl()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            Series positionSeries = new Series("Position");
            positionSeries.ChartType = SeriesChartType.Line;
            chart1.Series.Add(positionSeries);

            Series velocitySeries = new Series("Velocity");
            velocitySeries.ChartType = SeriesChartType.Line;
            chart1.Series.Add(velocitySeries);
            chart1.ChartAreas[0].AxisY.Maximum = 400;
            chart1.ChartAreas[0].AxisY.Minimum = -400;
        }

        private void comboBoxComPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPorts.SelectedItem.ToString();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                buttonConnect.Text = "Disconnect";
            }
            else
            {
                serialPort1.Close();
                buttonConnect.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();
            comboBoxPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count == 0)
            {
                comboBoxPorts.Text = "No COM Ports!";
            }
            else
            {
                comboBoxPorts.SelectedIndex = 0;
            }
            comboBoxMotorType.Items.Clear();
            comboBoxMotorType.Items.Add("Stepper Motor");
            comboBoxMotorType.Items.Add("DC Motor");
            comboBoxMotorType.SelectedIndex = 0;

            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private byte getCommandByte()
        {
            // Process command byte (0x000ABCDE)
            byte commandByte = 0;

            // A = 1 (Stepper Motor), 0 (DC Motor)
            if (isStepperMotor)
            {
                commandByte |= 0b00010000;
            }

            // B = 1 (Run Continuously), 0 (Single Step)
            if (isRunContinuously)
            {
                commandByte |= 0b00001000;
            }

            // C = 1 (Reverse), 0 (Forward)
            if (isReverse)
            {
                commandByte |= 0b00000100;
            }

            // D = 1 (Set Duty Cycle High to 255), 0 (Do Nothing)
            if (speedHigh == 255)
            {
                commandByte |= 0b00000010;
                speedHigh = 254;
            }

            // E = 1 (Set Duty Cycle Low to 255), 0 (Do Nothing)
            if (speedLow == 255)
            {
                commandByte |= 0b00000001;
                speedLow = 254;
            }

            return commandByte;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            int numberOfTicks = trackBar1.Maximum - trackBar1.Minimum;

            // Use the constant value for counts per rotation
            double scalingFactor = 65535 / (numberOfTicks / 2.0);

            // Map the trackbar value to the duty cycle (0 at middle, countsPerRotation at extremes)
            ushort mappedSpeed = (ushort)(Math.Abs(trackBarValue - numberOfTicks / 2.0) * scalingFactor);

            // Update the textbox with the mapped speed
            textBoxDutyCycle.Text = ((double)mappedSpeed / 65535).ToString("P0");

            // Split the mapped speed into two bytes
            speedHigh = (byte)(mappedSpeed >> 8);
            speedLow = (byte)(mappedSpeed & 0xFF);

            // Determine the direction of the motor
            if (trackBarValue < numberOfTicks / 2)
            {
                isReverse = true;
            }
            else
            {
                isReverse = false;
            }

            // Set the stepper to run continuously
            isRunContinuously = true;

            // Get the command byte
            commandByte = getCommandByte();

            sendPacket(255, speedHigh, speedLow, commandByte);
        }

        private void comboBoxMotorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMotorType.SelectedIndex == 0)
            {
                isStepperMotor = true;
            }
            else
            {
                isStepperMotor = false;
            }
        }

        private void buttonStepCCW_Click(object sender, EventArgs e)
        {
            // Determine the direction of the motor
            isReverse = true;

            // Set the stepper to single steps
            isRunContinuously = false;

            // Get the command byte
            commandByte = getCommandByte();

            sendPacket(255, 0, 0, commandByte);
        }

        private void buttonStepCW_Click(object sender, EventArgs e)
        {
            // Determine the direction of the motor
            isReverse = false;

            // Set the stepper to single steps
            isRunContinuously = false;

            // Get the command byte
            commandByte = getCommandByte();

            sendPacket(255, 0, 0, commandByte);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte dequeuedItem;
            while (dataQueue.TryDequeue(out dequeuedItem))
            {
                switch (state)
                {
                    case 0:
                        if (dequeuedItem == 255)
                        {
                            state = 1;
                        }
                        break;
                    case 1:
                        countHigh = dequeuedItem;
                        state = 2;
                        break;
                    case 2:
                        countLow = dequeuedItem;
                        state = 3;
                        break;
                    case 3:
                        countCommand = dequeuedItem;

                        // D = 1 (Set Duty Cycle High to 255), 0 (Do Nothing)
                        if ((countCommand & 0b00000010) != 0)
                        {
                            countHigh = 255;
                        }

                        // E = 1 (Set Duty Cycle Low to 255), 0 (Do Nothing)
                        if ((countCommand & 0b00000001) != 0)
                        {
                            countLow = 255;
                        }

                        // Combine countHigh and countLow into one value
                        countCurrent = (short)((countHigh << 8) | countLow);
                        //countCurrent = (short)(countTrue - zeroCount);
                        countDifference = countCurrent - countPrevious;
                        countPrevious = countCurrent;

                        // Calculate rotational velocity in Hz and RPM
                        rotations = countDifference / CountsPerRotation;

                        // Calculate rotational velocity in Hz and RPM
                        rotations = countDifference / CountsPerRotation;
                        double velocityHz = rotations / (SamplingTime / 1000.0);
                        double velocityRPM = velocityHz * 60;

                        // Update the textboxes with the calculated velocities
                        textBoxVelocity.Text = velocityRPM.ToString("F2");
                        textBoxPosition.Text = countCurrent.ToString(); // Need to modify this to display the correct value, probably loops back to 0 after some count and needs to divide by count/cm

                        // Update chart
                        time += SamplingTime;
                        chart1.Series["Position"].Points.AddXY(time / 1000.0, countCurrent);
                        chart1.Series["Velocity"].Points.AddXY(time / 1000.0, velocityRPM);
                        if (chart1.Series["Position"].Points.Count > 200)
                        {
                            chart1.ChartAreas["ChartArea1"].Axes[0].Minimum = (time - 200 * SamplingTime) / 1000.0;
                        }

                        state = 0;
                        textBoxDistance.Text = (countCurrent/60.0).ToString("F2");
                        //DetermineOrientation();
                        break;
                }
                //textBoxSerialDataStream.AppendText(dequeuedItem.ToString() + ", ");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Determine the number of BytesToRead in the serial buffer
            // Write a while loop to read the bytes, one at a time, from the serial buffer
            // Convert each byte to a string and append it to the serialDataString with “,“ and “ “ characters.
            int newByte = 0;
            int bytesToRead;
            bytesToRead = serialPort1.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = serialPort1.ReadByte();
                dataQueue.Enqueue((byte)newByte);
                bytesToRead = serialPort1.BytesToRead;
            }
        }

        private void buttonZeroCount_Click(object sender, EventArgs e)
        {
            sendPacket(255, 0, 0, 0b00100000);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.ShowDialog();
            String fileName = saveFileDialog.FileName;
            SaveSeriesCollectionToCsv(chart1.Series, fileName);
        }

        public static void SaveSeriesCollectionToCsv(SeriesCollection seriesCollection, string filePath)
        {
            if (seriesCollection == null || !seriesCollection.Any())
                throw new ArgumentException("The series collection is empty or null.");

            // Determine the maximum number of points in any series
            int maxPoints = seriesCollection.Max(series => series.Points.Count);

            using (var writer = new StreamWriter(filePath))
            {
                // Write header row with series names
                var header = string.Join(",", seriesCollection.Select(s => s.Name));
                writer.WriteLine(header);

                // Write each row of data points
                for (int i = 0; i < maxPoints; i++)
                {
                    var row = new List<string>();

                    foreach (var series in seriesCollection)
                    {
                        if (i < series.Points.Count)
                        {
                            row.Add(series.Points[i].YValues[0].ToString());
                        }
                        else
                        {
                            row.Add(""); // Fill missing points with empty value
                        }
                    }

                    writer.WriteLine(string.Join(",", row));
                }
            }
        }

        private void buttonSetDutyCycle_Click(object sender, EventArgs e)
        {
            int val;
            int.TryParse(textBoxTargetDutyCycle.Text, out val);
            System.Console.Out.WriteLine(val.ToString());
            val = 200 + val * 2;
            trackBar1.Value = val;
            trackBar1_Scroll(sender, e);
        }

        private void buttonZeroDutyCycle_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 200;
            trackBar1_Scroll(sender, e);
        }

        private void buttonSetDistance_Click(object sender, EventArgs e)
        {
            short distance = Convert.ToInt16(Convert.ToDouble(textBoxTargetDistance.Text) * 60.0);
            byte distanceHigh = (byte)(distance >> 8);
            byte distanceLow = (byte)(distance & 0xFF);

            sendPacket(255, distanceHigh, distanceLow, 0b01000000);
        }

        private void sendPacket(byte byte0, byte byte1, byte byte2, byte byte3)
        {
            // Transmit the command to the COM port
            if (serialPort1.IsOpen)
            {
                try
                {
                    byte[] packet = new byte[] { byte0, byte1, byte2, byte3 };
                    serialPort1.Write(packet, 0, packet.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Update the textboxes
            textBoxStartByte.Text = byte0.ToString();
            textBoxDutyCycleHigh.Text = byte1.ToString();
            textBoxDutyCycleLow.Text = byte2.ToString();
            textBoxCommandByte.Text = byte3.ToString();
        }

    }
}

