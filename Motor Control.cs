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
        // Constants
        private const double CountsPerRotation = 244.0;
        private const double CountsPerCm = 60.0;
        private const double MillisecondsPerSecond = 1000.0;
        private const int SecondsPerMinute = 60;
        private const int SamplingTime = 50;

        // Variables
        private ConcurrentQueue<Byte> dataQueue = new ConcurrentQueue<Byte>();
        private double midPoint = 0;
        private int count = 0;
        private int time = 0;

        // Command Bits
        private bool isSetDistance = false;
        private bool isZeroCount = false;
        private bool isStepperMotor = false;
        private bool isSingleSteps = false;
        private bool isReverse = false;

        // Data Bytes
        private byte byteHigh = 0;
        private byte byteLow = 0;

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

        private void comboBoxMotorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMotorType.SelectedIndex == 0)
            {
                isStepperMotor = false;
            }
            else
            {
                isStepperMotor = true;
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
            comboBoxMotorType.Items.Add("DC Motor");
            comboBoxMotorType.Items.Add("Stepper Motor");
            comboBoxMotorType.SelectedIndex = 0;

            timer1.Enabled = true;
            timer1.Interval = 100;
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            midPoint = (trackBar1.Maximum - trackBar1.Minimum) / 2.0;
            double scalingFactor = UInt16.MaxValue / midPoint;

            // Map the trackbar value to the duty cycle
            ushort dutyCycle = (ushort)(Math.Abs(trackBar1.Value - midPoint) * scalingFactor);
            textBoxDutyCycle.Text = ((double)dutyCycle / UInt16.MaxValue).ToString("P0");

            // Split the mapped speed into two bytes
            byteHigh = (byte)(dutyCycle >> 8);
            byteLow = (byte)(dutyCycle & 0xFF);

            // Determine the direction of the motor
            if (trackBar1.Value < midPoint)
            {
                isReverse = true;
            }

            sendPacket(Byte.MaxValue, byteHigh, byteLow, getCommandByte());
        }

        private void buttonStepCW_Click(object sender, EventArgs e)
        {
            isSingleSteps = true;
            sendPacket(Byte.MaxValue, 0, 0, getCommandByte());
        }

        private void buttonStepCCW_Click(object sender, EventArgs e)
        {
            isReverse = true;
            isSingleSteps = true;
            sendPacket(Byte.MaxValue, 0, 0, getCommandByte());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte countHigh = 0;
            byte countLow = 0;
            byte countCommand = 0;
            int state = 0;
            while (dataQueue.TryDequeue(out byte dequeuedItem))
            {
                switch (state)
                {
                    case 0:
                        if (dequeuedItem == Byte.MaxValue)
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
                        state = 0;
                        processData(countHigh, countLow, countCommand);
                        break;
                }
            }
        }

        private void processData(byte countHigh, byte countLow, byte countCommand)
        {
            // D = 1 (Set Duty Cycle High to 255), 0 (Do Nothing)
            if ((countCommand & (1 << 1)) != 0)
            {
                countHigh = Byte.MaxValue;
            }

            // E = 1 (Set Duty Cycle Low to 255), 0 (Do Nothing)
            if ((countCommand & (1 << 0)) != 0)
            {
                countLow = Byte.MaxValue;
            }

            // Combine countHigh and countLow into one 16-bit value
            short currentCount = (short)((countHigh << 8) | countLow);
            int difference = currentCount - count;
            count = currentCount;

            // Calculate rotational velocity in Hz and RPM
            double rotations = difference / CountsPerRotation;
            double velocityHz = rotations / (SamplingTime / MillisecondsPerSecond);
            double velocityRPM = velocityHz * SecondsPerMinute;

            // Update the textboxes with the calculated velocities
            textBoxVelocity.Text = velocityRPM.ToString("F2");
            textBoxPosition.Text = count.ToString();
            textBoxDistance.Text = (currentCount / CountsPerCm).ToString("F2");

            // Update chart
            time += SamplingTime;
            chart1.Series["Position"].Points.AddXY(time / MillisecondsPerSecond, count);
            chart1.Series["Velocity"].Points.AddXY(time / MillisecondsPerSecond, velocityRPM);
            if (chart1.Series["Position"].Points.Count > 200)
            {
                chart1.ChartAreas["ChartArea1"].Axes[0].Minimum = (time - 200 * SamplingTime) / MillisecondsPerSecond;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Read the bytes from the serial buffer and store them in the dataQueue
            while (serialPort1.BytesToRead > 0)
            {
                int newByte = serialPort1.ReadByte();
                dataQueue.Enqueue((byte)newByte);
            }
        }

        private void buttonZeroCount_Click(object sender, EventArgs e)
        {
            isZeroCount = true;
            sendPacket(Byte.MaxValue, 0, 0, getCommandByte());
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
            if (int.TryParse(textBoxTargetDutyCycle.Text, out int targetDutyCycle))
            {
                trackBar1.Value = targetDutyCycle * 2 + (int)midPoint;
                trackBar1_Scroll(sender, e);
            }
        }

        private void buttonZeroDutyCycle_Click(object sender, EventArgs e)
        {   
            trackBar1.Value = (int)midPoint;
            trackBar1_Scroll(sender, e);
        }

        private void buttonSetDistance_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTargetDistance.Text, out double targetDistance))
            {
                // Convert the distance from cm to counts
                short distance = Convert.ToInt16(targetDistance * CountsPerCm);
                byteHigh = (byte)(distance >> 8);
                byteLow = (byte)(distance & 0xFF);
                isSetDistance = true;
                sendPacket(Byte.MaxValue, byteHigh, byteLow, getCommandByte());
            }
        }

        private byte getCommandByte()
        {
            // Process command byte (0xABCDEFGH)
            byte commandByte = 0;

            // A: Always 0

            // B: Set Distance Toggle (0 = No, 1 = Yes)
            if (isSetDistance)
            {
                commandByte |= (1 << 6);
            }

            // C: Zero Count Toggle (0 = No, 1 = Yes)
            if (isZeroCount)
            {
                commandByte |= (1 << 5);
            }

            // D: Motor Select (0 = DC Motor, 1 = Stepper Motor)
            if (isStepperMotor)
            {
                commandByte |= (1 << 4);
            }

            // E: Stepper Motor Mode (0 = Run Continuously, 1 = Single Steps)
            if (isSingleSteps)
            {
                commandByte |= (1 << 3);
            }

            // F: Direction (0 = Forward, 1 = Reverse)
            if (isReverse)
            {
                commandByte |= (1 << 2);
            }

            // G: High Escape Byte (0 = Do Nothing, 1 = Set High Byte to 255)
            if (byteHigh == Byte.MaxValue)
            {
                commandByte |= (1 << 1);
                byteHigh = Byte.MaxValue - 1;
            }

            // F: Low Escape Byte  (0 = Do Nothing, 1 = Set Low Byte to 255)
            if (byteLow == Byte.MaxValue)
            {
                commandByte |= (1 << 0);
                byteLow = Byte.MaxValue - 1;
            }

            // Reset the boolean flags
            isSetDistance = false;
            isZeroCount = false;
            isStepperMotor = false;
            isSingleSteps = false;
            isReverse = false;

            return commandByte;
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
            textBoxCommandByte.Text = Convert.ToString(byte3, 2).PadLeft(8, '0');
        }
    }
}

