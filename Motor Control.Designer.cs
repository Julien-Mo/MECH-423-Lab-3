﻿namespace MECH_423_Lab_3
{
    partial class MotorControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStartByte = new System.Windows.Forms.TextBox();
            this.textBoxXHigh = new System.Windows.Forms.TextBox();
            this.textBoxDutyCycleLow = new System.Windows.Forms.TextBox();
            this.textBoxSpeedHigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBoxDutyCycle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMotorType = new System.Windows.Forms.ComboBox();
            this.buttonStepCW = new System.Windows.Forms.Button();
            this.buttonStepCCW = new System.Windows.Forms.Button();
            this.textBoxNumSteps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.buttonZeroCount = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxTargetDutyCycle = new System.Windows.Forms.TextBox();
            this.buttonSetDutyCycle = new System.Windows.Forms.Button();
            this.buttonZeroDutyCycle = new System.Windows.Forms.Button();
            this.textBoxTargetDistance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSetDistance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSpeedLow = new System.Windows.Forms.TextBox();
            this.textBoxYLow = new System.Windows.Forms.TextBox();
            this.textBoxXLow = new System.Windows.Forms.TextBox();
            this.textBoxCommandByte = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxYHigh = new System.Windows.Forms.TextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTargetX = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxTargetY = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxTargetSpeed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStartByte
            // 
            this.textBoxStartByte.Location = new System.Drawing.Point(12, 52);
            this.textBoxStartByte.Name = "textBoxStartByte";
            this.textBoxStartByte.ReadOnly = true;
            this.textBoxStartByte.Size = new System.Drawing.Size(102, 20);
            this.textBoxStartByte.TabIndex = 0;
            // 
            // textBoxXHigh
            // 
            this.textBoxXHigh.Location = new System.Drawing.Point(125, 52);
            this.textBoxXHigh.Name = "textBoxXHigh";
            this.textBoxXHigh.ReadOnly = true;
            this.textBoxXHigh.Size = new System.Drawing.Size(102, 20);
            this.textBoxXHigh.TabIndex = 1;
            // 
            // textBoxDutyCycleLow
            // 
            this.textBoxDutyCycleLow.Location = new System.Drawing.Point(476, 104);
            this.textBoxDutyCycleLow.Name = "textBoxDutyCycleLow";
            this.textBoxDutyCycleLow.ReadOnly = true;
            this.textBoxDutyCycleLow.Size = new System.Drawing.Size(102, 20);
            this.textBoxDutyCycleLow.TabIndex = 2;
            // 
            // textBoxSpeedHigh
            // 
            this.textBoxSpeedHigh.Location = new System.Drawing.Point(350, 52);
            this.textBoxSpeedHigh.Name = "textBoxSpeedHigh";
            this.textBoxSpeedHigh.ReadOnly = true;
            this.textBoxSpeedHigh.Size = new System.Drawing.Size(102, 20);
            this.textBoxSpeedHigh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Byte";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(125, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 21);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y High";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Speed High";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 13);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(102, 21);
            this.comboBoxPorts.TabIndex = 10;
            this.comboBoxPorts.Text = "Select COM";
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPorts_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(12, 117);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(441, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxDutyCycle
            // 
            this.textBoxDutyCycle.Location = new System.Drawing.Point(125, 247);
            this.textBoxDutyCycle.Name = "textBoxDutyCycle";
            this.textBoxDutyCycle.ReadOnly = true;
            this.textBoxDutyCycle.Size = new System.Drawing.Size(102, 20);
            this.textBoxDutyCycle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Duty Cycle";
            // 
            // comboBoxMotorType
            // 
            this.comboBoxMotorType.FormattingEnabled = true;
            this.comboBoxMotorType.Location = new System.Drawing.Point(12, 169);
            this.comboBoxMotorType.Name = "comboBoxMotorType";
            this.comboBoxMotorType.Size = new System.Drawing.Size(102, 21);
            this.comboBoxMotorType.TabIndex = 14;
            this.comboBoxMotorType.Text = "Select Motor";
            this.comboBoxMotorType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotorType_SelectedIndexChanged);
            // 
            // buttonStepCW
            // 
            this.buttonStepCW.Location = new System.Drawing.Point(350, 169);
            this.buttonStepCW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepCW.Name = "buttonStepCW";
            this.buttonStepCW.Size = new System.Drawing.Size(100, 21);
            this.buttonStepCW.TabIndex = 15;
            this.buttonStepCW.Text = "Step CW";
            this.buttonStepCW.UseVisualStyleBackColor = true;
            this.buttonStepCW.Click += new System.EventHandler(this.buttonStepCW_Click);
            // 
            // buttonStepCCW
            // 
            this.buttonStepCCW.Location = new System.Drawing.Point(238, 169);
            this.buttonStepCCW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepCCW.Name = "buttonStepCCW";
            this.buttonStepCCW.Size = new System.Drawing.Size(100, 21);
            this.buttonStepCCW.TabIndex = 16;
            this.buttonStepCCW.Text = "Step CCW";
            this.buttonStepCCW.UseVisualStyleBackColor = true;
            this.buttonStepCCW.Click += new System.EventHandler(this.buttonStepCCW_Click);
            // 
            // textBoxNumSteps
            // 
            this.textBoxNumSteps.Location = new System.Drawing.Point(125, 169);
            this.textBoxNumSteps.Name = "textBoxNumSteps";
            this.textBoxNumSteps.Size = new System.Drawing.Size(102, 20);
            this.textBoxNumSteps.TabIndex = 18;
            this.textBoxNumSteps.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Number of Steps";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(12, 208);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(102, 20);
            this.textBoxPosition.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Velocity";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Location = new System.Drawing.Point(12, 247);
            this.textBoxVelocity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.ReadOnly = true;
            this.textBoxVelocity.Size = new System.Drawing.Size(102, 20);
            this.textBoxVelocity.TabIndex = 22;
            // 
            // chart1
            // 
            chartArea2.AxisY.Maximum = 400D;
            chartArea2.AxisY.Minimum = -400D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 312);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(438, 130);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Distance";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.ForeColor = System.Drawing.Color.Black;
            this.textBoxDistance.Location = new System.Drawing.Point(125, 208);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.ReadOnly = true;
            this.textBoxDistance.Size = new System.Drawing.Size(102, 20);
            this.textBoxDistance.TabIndex = 28;
            // 
            // buttonZeroCount
            // 
            this.buttonZeroCount.Location = new System.Drawing.Point(238, 13);
            this.buttonZeroCount.Name = "buttonZeroCount";
            this.buttonZeroCount.Size = new System.Drawing.Size(100, 21);
            this.buttonZeroCount.TabIndex = 29;
            this.buttonZeroCount.Text = "Zero Count";
            this.buttonZeroCount.UseVisualStyleBackColor = true;
            this.buttonZeroCount.Click += new System.EventHandler(this.buttonZeroCount_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(350, 423);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 19);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save Series";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxTargetDutyCycle
            // 
            this.textBoxTargetDutyCycle.Location = new System.Drawing.Point(238, 247);
            this.textBoxTargetDutyCycle.Name = "textBoxTargetDutyCycle";
            this.textBoxTargetDutyCycle.Size = new System.Drawing.Size(102, 20);
            this.textBoxTargetDutyCycle.TabIndex = 32;
            // 
            // buttonSetDutyCycle
            // 
            this.buttonSetDutyCycle.Location = new System.Drawing.Point(350, 247);
            this.buttonSetDutyCycle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSetDutyCycle.Name = "buttonSetDutyCycle";
            this.buttonSetDutyCycle.Size = new System.Drawing.Size(100, 21);
            this.buttonSetDutyCycle.TabIndex = 33;
            this.buttonSetDutyCycle.Text = "Set Duty Cycle";
            this.buttonSetDutyCycle.UseVisualStyleBackColor = true;
            this.buttonSetDutyCycle.Click += new System.EventHandler(this.buttonSetDutyCycle_Click);
            // 
            // buttonZeroDutyCycle
            // 
            this.buttonZeroDutyCycle.Location = new System.Drawing.Point(350, 13);
            this.buttonZeroDutyCycle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeroDutyCycle.Name = "buttonZeroDutyCycle";
            this.buttonZeroDutyCycle.Size = new System.Drawing.Size(100, 21);
            this.buttonZeroDutyCycle.TabIndex = 34;
            this.buttonZeroDutyCycle.Text = "Zero Duty Cycle";
            this.buttonZeroDutyCycle.UseVisualStyleBackColor = true;
            this.buttonZeroDutyCycle.Click += new System.EventHandler(this.buttonZeroDutyCycle_Click);
            // 
            // textBoxTargetDistance
            // 
            this.textBoxTargetDistance.Location = new System.Drawing.Point(238, 208);
            this.textBoxTargetDistance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTargetDistance.Name = "textBoxTargetDistance";
            this.textBoxTargetDistance.Size = new System.Drawing.Size(102, 20);
            this.textBoxTargetDistance.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Target Distance";
            // 
            // buttonSetDistance
            // 
            this.buttonSetDistance.Location = new System.Drawing.Point(350, 208);
            this.buttonSetDistance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetDistance.Name = "buttonSetDistance";
            this.buttonSetDistance.Size = new System.Drawing.Size(100, 21);
            this.buttonSetDistance.TabIndex = 37;
            this.buttonSetDistance.Text = "Set Distance";
            this.buttonSetDistance.UseVisualStyleBackColor = true;
            this.buttonSetDistance.Click += new System.EventHandler(this.buttonSetDistance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Target Duty Cycle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Speed Low";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Y Low";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "X Low";
            // 
            // textBoxSpeedLow
            // 
            this.textBoxSpeedLow.Location = new System.Drawing.Point(350, 91);
            this.textBoxSpeedLow.Name = "textBoxSpeedLow";
            this.textBoxSpeedLow.ReadOnly = true;
            this.textBoxSpeedLow.Size = new System.Drawing.Size(102, 20);
            this.textBoxSpeedLow.TabIndex = 42;
            // 
            // textBoxYLow
            // 
            this.textBoxYLow.Location = new System.Drawing.Point(238, 91);
            this.textBoxYLow.Name = "textBoxYLow";
            this.textBoxYLow.ReadOnly = true;
            this.textBoxYLow.Size = new System.Drawing.Size(102, 20);
            this.textBoxYLow.TabIndex = 41;
            // 
            // textBoxXLow
            // 
            this.textBoxXLow.Location = new System.Drawing.Point(125, 91);
            this.textBoxXLow.Name = "textBoxXLow";
            this.textBoxXLow.ReadOnly = true;
            this.textBoxXLow.Size = new System.Drawing.Size(102, 20);
            this.textBoxXLow.TabIndex = 40;
            // 
            // textBoxCommandByte
            // 
            this.textBoxCommandByte.Location = new System.Drawing.Point(12, 91);
            this.textBoxCommandByte.Name = "textBoxCommandByte";
            this.textBoxCommandByte.ReadOnly = true;
            this.textBoxCommandByte.Size = new System.Drawing.Size(102, 20);
            this.textBoxCommandByte.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Command Byte";
            // 
            // textBoxYHigh
            // 
            this.textBoxYHigh.Location = new System.Drawing.Point(238, 52);
            this.textBoxYHigh.Name = "textBoxYHigh";
            this.textBoxYHigh.ReadOnly = true;
            this.textBoxYHigh.Size = new System.Drawing.Size(102, 20);
            this.textBoxYHigh.TabIndex = 47;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(350, 286);
            this.buttonSendCommand.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(100, 21);
            this.buttonSendCommand.TabIndex = 50;
            this.buttonSendCommand.Text = "Send Command";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 273);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Target X";
            // 
            // textBoxTargetX
            // 
            this.textBoxTargetX.Location = new System.Drawing.Point(12, 286);
            this.textBoxTargetX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTargetX.Name = "textBoxTargetX";
            this.textBoxTargetX.Size = new System.Drawing.Size(102, 20);
            this.textBoxTargetX.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(125, 273);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Target Y";
            // 
            // textBoxTargetY
            // 
            this.textBoxTargetY.Location = new System.Drawing.Point(125, 286);
            this.textBoxTargetY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTargetY.Name = "textBoxTargetY";
            this.textBoxTargetY.Size = new System.Drawing.Size(102, 20);
            this.textBoxTargetY.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(238, 273);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "Target Speed";
            // 
            // textBoxTargetSpeed
            // 
            this.textBoxTargetSpeed.Location = new System.Drawing.Point(238, 286);
            this.textBoxTargetSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTargetSpeed.Name = "textBoxTargetSpeed";
            this.textBoxTargetSpeed.Size = new System.Drawing.Size(102, 20);
            this.textBoxTargetSpeed.TabIndex = 53;
            // 
            // MotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 457);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxTargetSpeed);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxTargetY);
            this.Controls.Add(this.buttonSendCommand);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxTargetX);
            this.Controls.Add(this.textBoxYHigh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxSpeedLow);
            this.Controls.Add(this.textBoxYLow);
            this.Controls.Add(this.textBoxXLow);
            this.Controls.Add(this.textBoxCommandByte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSetDistance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxTargetDistance);
            this.Controls.Add(this.buttonZeroDutyCycle);
            this.Controls.Add(this.buttonSetDutyCycle);
            this.Controls.Add(this.textBoxTargetDutyCycle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonZeroCount);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxVelocity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNumSteps);
            this.Controls.Add(this.buttonStepCCW);
            this.Controls.Add(this.buttonStepCW);
            this.Controls.Add(this.comboBoxMotorType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDutyCycle);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpeedHigh);
            this.Controls.Add(this.textBoxDutyCycleLow);
            this.Controls.Add(this.textBoxXHigh);
            this.Controls.Add(this.textBoxStartByte);
            this.Name = "MotorControl";
            this.Text = "Motor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStartByte;
        private System.Windows.Forms.TextBox textBoxXHigh;
        private System.Windows.Forms.TextBox textBoxDutyCycleLow;
        private System.Windows.Forms.TextBox textBoxSpeedHigh;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBoxDutyCycle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMotorType;
        private System.Windows.Forms.Button buttonStepCW;
        private System.Windows.Forms.Button buttonStepCCW;
        private System.Windows.Forms.TextBox textBoxNumSteps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Button buttonZeroCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxTargetDutyCycle;
        private System.Windows.Forms.Button buttonSetDutyCycle;
        private System.Windows.Forms.Button buttonZeroDutyCycle;
        private System.Windows.Forms.TextBox textBoxTargetDistance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSetDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSpeedLow;
        private System.Windows.Forms.TextBox textBoxYLow;
        private System.Windows.Forms.TextBox textBoxXLow;
        private System.Windows.Forms.TextBox textBoxCommandByte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxYHigh;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTargetX;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxTargetY;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTargetSpeed;
    }
}

