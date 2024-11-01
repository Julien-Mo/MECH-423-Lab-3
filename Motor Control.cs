using System;
using System.Collections.Concurrent;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MECH_423_Lab_3
{
    public partial class MotorControl : Form
    {
        private const double CountsPerRotation = 244;
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
        private short zeroCount = 0;
        private short countCurrent = 0;
        private short countPrevious = 0;
        private short countTrue = 0;
        private int countDifference = 0;
        private double rotations = 0.0;
        private int samplingTime = 50; // Change to whatever Grayson says, in ms
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
        }

        private void comboBoxComPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxComPorts.SelectedItem.ToString();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                btnConnect.Text = "Disconnect";
            }
            else
            {
                serialPort1.Close();
                btnConnect.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxComPorts.Items.Clear();
            comboBoxComPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxComPorts.Items.Count == 0)
            {
                comboBoxComPorts.Text = "No COM Ports!";
            }
            else
            {
                comboBoxComPorts.SelectedIndex = 0;
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

            // Transmit the command to the COM port
            if (serialPort1.IsOpen)
            {
                try
                {
                    byte[] packet = new byte[] { 255, speedHigh, speedLow, commandByte };
                    serialPort1.Write(packet, 0, packet.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Update the textboxes
            textBoxStartByte.Text = "255";
            textBoxDutyCycleHigh.Text = speedHigh.ToString();
            textBoxDutyCycleLow.Text = speedLow.ToString();
            textBoxCommandByte.Text = commandByte.ToString();
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

            // Transmit the command to the COM port
            if (serialPort1.IsOpen)
            {
                try
                {
                    byte[] packet = new byte[] { 255, 0, 0, commandByte };
                    serialPort1.Write(packet, 0, packet.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Update the textboxes
            textBoxStartByte.Text = "255";
            textBoxDutyCycleHigh.Text = "0";
            textBoxDutyCycleLow.Text = "0";
            textBoxCommandByte.Text = commandByte.ToString();
        }

        private void buttonStepCW_Click(object sender, EventArgs e)
        {
            // Determine the direction of the motor
            isReverse = false;

            // Set the stepper to single steps
            isRunContinuously = false;

            // Get the command byte
            commandByte = getCommandByte();

            // Transmit the command to the COM port
            if (serialPort1.IsOpen)
            {
                try
                {
                    byte[] packet = new byte[] { 255, 0, 0, commandByte };
                    serialPort1.Write(packet, 0, packet.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Update the textboxes
            textBoxStartByte.Text = "255";
            textBoxDutyCycleHigh.Text = "0";
            textBoxDutyCycleLow.Text = "0";
            textBoxCommandByte.Text = commandByte.ToString();
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

                        lstBoxData.Items.Add((countHigh).ToString() + " " + (countLow).ToString() + " " + (countCommand).ToString());
                        lstBoxData.SelectedIndex = lstBoxData.Items.Count - 1;

                        // Combine countHigh and countLow into one value
                        countTrue = (short)((countHigh << 8) | countLow);
                        countCurrent = (short)(countTrue - zeroCount);
                        countDifference = countCurrent - countPrevious;
                        countPrevious = countCurrent;

                        // Calculate rotational velocity in Hz and RPM
                        rotations = countDifference / CountsPerRotation;

                        // Calculate rotational velocity in Hz and RPM
                        rotations = countDifference / CountsPerRotation;
                        double velocityHz = rotations / (samplingTime / 1000.0);
                        double velocityRPM = velocityHz * 60;

                        // Update the textboxes with the calculated velocities
                        textBoxVelocity.Text = velocityRPM.ToString("F2");
                        textBoxPosition.Text = countCurrent.ToString(); // Need to modify this to display the correct value, probably loops back to 0 after some count and needs to divide by count/cm

                        // Update chart
                        time += samplingTime;
                        chart1.Series["Position"].Points.AddXY(time/1000.0, countCurrent);
                        chart1.Series["Velocity"].Points.AddXY(time/1000.0, velocityRPM);
                        if (chart1.Series["Position"].Points.Count > 200)
                        {
                            chart1.ChartAreas["ChartArea1"].Axes[0].Minimum = (time - 200 * samplingTime) / 1000.0;
                        }

                        state = 0;
                        textBoxHigh.Text = countHigh.ToString();
                        textBoxLow.Text = countLow.ToString();
                        textBoxCombinedCount.Text = countCurrent.ToString();
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

        private void btnZero_Click(object sender, EventArgs e)
        {
            zeroCount = countTrue;
        }
    }
}

