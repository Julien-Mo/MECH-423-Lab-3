namespace MECH_423_Lab_3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStartByte = new System.Windows.Forms.TextBox();
            this.textBoxDutyCycleHigh = new System.Windows.Forms.TextBox();
            this.textBoxDutyCycleLow = new System.Windows.Forms.TextBox();
            this.textBoxCommandByte = new System.Windows.Forms.TextBox();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxTargetDutyCycle = new System.Windows.Forms.TextBox();
            this.buttonSetDutyCycle = new System.Windows.Forms.Button();
            this.buttonZeroDutyCycle = new System.Windows.Forms.Button();
            this.textBoxTargetDistance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSetDistance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStartByte
            // 
            this.textBoxStartByte.Location = new System.Drawing.Point(25, 100);
            this.textBoxStartByte.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxStartByte.Name = "textBoxStartByte";
            this.textBoxStartByte.Size = new System.Drawing.Size(200, 31);
            this.textBoxStartByte.TabIndex = 0;
            // 
            // textBoxDutyCycleHigh
            // 
            this.textBoxDutyCycleHigh.Location = new System.Drawing.Point(250, 100);
            this.textBoxDutyCycleHigh.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDutyCycleHigh.Name = "textBoxDutyCycleHigh";
            this.textBoxDutyCycleHigh.Size = new System.Drawing.Size(200, 31);
            this.textBoxDutyCycleHigh.TabIndex = 1;
            // 
            // textBoxDutyCycleLow
            // 
            this.textBoxDutyCycleLow.Location = new System.Drawing.Point(475, 100);
            this.textBoxDutyCycleLow.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDutyCycleLow.Name = "textBoxDutyCycleLow";
            this.textBoxDutyCycleLow.Size = new System.Drawing.Size(200, 31);
            this.textBoxDutyCycleLow.TabIndex = 2;
            // 
            // textBoxCommandByte
            // 
            this.textBoxCommandByte.Location = new System.Drawing.Point(700, 100);
            this.textBoxCommandByte.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCommandByte.Name = "textBoxCommandByte";
            this.textBoxCommandByte.Size = new System.Drawing.Size(200, 31);
            this.textBoxCommandByte.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Byte";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(250, 25);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(200, 40);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duty Cycle High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duty Cycle Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Command Byte";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(25, 25);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(200, 33);
            this.comboBoxPorts.TabIndex = 10;
            this.comboBoxPorts.Text = "Select COM";
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPorts_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(25, 150);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(882, 90);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxDutyCycle
            // 
            this.textBoxDutyCycle.Location = new System.Drawing.Point(250, 400);
            this.textBoxDutyCycle.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDutyCycle.Name = "textBoxDutyCycle";
            this.textBoxDutyCycle.Size = new System.Drawing.Size(200, 31);
            this.textBoxDutyCycle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Duty Cycle";
            // 
            // comboBoxMotorType
            // 
            this.comboBoxMotorType.FormattingEnabled = true;
            this.comboBoxMotorType.Location = new System.Drawing.Point(25, 250);
            this.comboBoxMotorType.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxMotorType.Name = "comboBoxMotorType";
            this.comboBoxMotorType.Size = new System.Drawing.Size(200, 33);
            this.comboBoxMotorType.TabIndex = 14;
            this.comboBoxMotorType.Text = "Select Motor";
            this.comboBoxMotorType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotorType_SelectedIndexChanged);
            // 
            // buttonStepCW
            // 
            this.buttonStepCW.Location = new System.Drawing.Point(700, 250);
            this.buttonStepCW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStepCW.Name = "buttonStepCW";
            this.buttonStepCW.Size = new System.Drawing.Size(200, 40);
            this.buttonStepCW.TabIndex = 15;
            this.buttonStepCW.Text = "Step CW";
            this.buttonStepCW.UseVisualStyleBackColor = true;
            this.buttonStepCW.Click += new System.EventHandler(this.buttonStepCW_Click);
            // 
            // buttonStepCCW
            // 
            this.buttonStepCCW.Location = new System.Drawing.Point(475, 250);
            this.buttonStepCCW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStepCCW.Name = "buttonStepCCW";
            this.buttonStepCCW.Size = new System.Drawing.Size(200, 40);
            this.buttonStepCCW.TabIndex = 16;
            this.buttonStepCCW.Text = "Step CCW";
            this.buttonStepCCW.UseVisualStyleBackColor = true;
            this.buttonStepCCW.Click += new System.EventHandler(this.buttonStepCCW_Click);
            // 
            // textBoxNumSteps
            // 
            this.textBoxNumSteps.Location = new System.Drawing.Point(250, 250);
            this.textBoxNumSteps.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumSteps.Name = "textBoxNumSteps";
            this.textBoxNumSteps.Size = new System.Drawing.Size(200, 31);
            this.textBoxNumSteps.TabIndex = 18;
            this.textBoxNumSteps.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Number of Steps";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(25, 325);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(200, 31);
            this.textBoxPosition.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 300);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 375);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Velocity";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Location = new System.Drawing.Point(25, 400);
            this.textBoxVelocity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(200, 31);
            this.textBoxVelocity.TabIndex = 22;
            // 
            // chart1
            // 
            chartArea1.AxisY.Maximum = 400D;
            chartArea1.AxisY.Minimum = -400D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 475);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(875, 375);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Distance";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.ForeColor = System.Drawing.Color.Black;
            this.textBoxDistance.Location = new System.Drawing.Point(250, 325);
            this.textBoxDistance.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(200, 31);
            this.textBoxDistance.TabIndex = 28;
            // 
            // buttonZeroCount
            // 
            this.buttonZeroCount.Location = new System.Drawing.Point(475, 25);
            this.buttonZeroCount.Margin = new System.Windows.Forms.Padding(6);
            this.buttonZeroCount.Name = "buttonZeroCount";
            this.buttonZeroCount.Size = new System.Drawing.Size(200, 40);
            this.buttonZeroCount.TabIndex = 29;
            this.buttonZeroCount.Text = "Zero Count";
            this.buttonZeroCount.UseVisualStyleBackColor = true;
            this.buttonZeroCount.Click += new System.EventHandler(this.buttonZeroCount_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(700, 814);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 36);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save Series";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxTargetDutyCycle
            // 
            this.textBoxTargetDutyCycle.Location = new System.Drawing.Point(475, 400);
            this.textBoxTargetDutyCycle.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTargetDutyCycle.Name = "textBoxTargetDutyCycle";
            this.textBoxTargetDutyCycle.Size = new System.Drawing.Size(200, 31);
            this.textBoxTargetDutyCycle.TabIndex = 32;
            // 
            // buttonSetDutyCycle
            // 
            this.buttonSetDutyCycle.Location = new System.Drawing.Point(700, 400);
            this.buttonSetDutyCycle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSetDutyCycle.Name = "buttonSetDutyCycle";
            this.buttonSetDutyCycle.Size = new System.Drawing.Size(200, 40);
            this.buttonSetDutyCycle.TabIndex = 33;
            this.buttonSetDutyCycle.Text = "Set Duty Cycle";
            this.buttonSetDutyCycle.UseVisualStyleBackColor = true;
            this.buttonSetDutyCycle.Click += new System.EventHandler(this.buttonSetDutyCycle_Click);
            // 
            // buttonZeroDutyCycle
            // 
            this.buttonZeroDutyCycle.Location = new System.Drawing.Point(700, 25);
            this.buttonZeroDutyCycle.Name = "buttonZeroDutyCycle";
            this.buttonZeroDutyCycle.Size = new System.Drawing.Size(200, 40);
            this.buttonZeroDutyCycle.TabIndex = 34;
            this.buttonZeroDutyCycle.Text = "Zero Duty Cycle";
            this.buttonZeroDutyCycle.UseVisualStyleBackColor = true;
            this.buttonZeroDutyCycle.Click += new System.EventHandler(this.buttonZeroDutyCycle_Click);
            // 
            // textBoxTargetDistance
            // 
            this.textBoxTargetDistance.Location = new System.Drawing.Point(475, 325);
            this.textBoxTargetDistance.Name = "textBoxTargetDistance";
            this.textBoxTargetDistance.Size = new System.Drawing.Size(200, 31);
            this.textBoxTargetDistance.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Target Distance";
            // 
            // buttonSetDistance
            // 
            this.buttonSetDistance.Location = new System.Drawing.Point(700, 325);
            this.buttonSetDistance.Name = "buttonSetDistance";
            this.buttonSetDistance.Size = new System.Drawing.Size(200, 40);
            this.buttonSetDistance.TabIndex = 37;
            this.buttonSetDistance.Text = "Set Distance";
            this.buttonSetDistance.UseVisualStyleBackColor = true;
            this.buttonSetDistance.Click += new System.EventHandler(this.buttonSetDistance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Target Duty Cycle";
            // 
            // MotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 879);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSetDistance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxTargetDistance);
            this.Controls.Add(this.buttonZeroDutyCycle);
            this.Controls.Add(this.buttonSetDutyCycle);
            this.Controls.Add(this.textBoxTargetDutyCycle);
            this.Controls.Add(this.btnSave);
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
            this.Controls.Add(this.textBoxCommandByte);
            this.Controls.Add(this.textBoxDutyCycleLow);
            this.Controls.Add(this.textBoxDutyCycleHigh);
            this.Controls.Add(this.textBoxStartByte);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.TextBox textBoxDutyCycleHigh;
        private System.Windows.Forms.TextBox textBoxDutyCycleLow;
        private System.Windows.Forms.TextBox textBoxCommandByte;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxTargetDutyCycle;
        private System.Windows.Forms.Button buttonSetDutyCycle;
        private System.Windows.Forms.Button buttonZeroDutyCycle;
        private System.Windows.Forms.TextBox textBoxTargetDistance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSetDistance;
        private System.Windows.Forms.Label label6;
    }
}

