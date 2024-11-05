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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBoxDutyCycle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMotorType = new System.Windows.Forms.ComboBox();
            this.buttonStepCW = new System.Windows.Forms.Button();
            this.buttonStepCCW = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumSteps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCombinedCount = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.lstBoxData = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZeroDutyCycle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStartByte
            // 
            this.textBoxStartByte.Location = new System.Drawing.Point(24, 100);
            this.textBoxStartByte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxStartByte.Name = "textBoxStartByte";
            this.textBoxStartByte.Size = new System.Drawing.Size(196, 31);
            this.textBoxStartByte.TabIndex = 0;
            // 
            // textBoxDutyCycleHigh
            // 
            this.textBoxDutyCycleHigh.Location = new System.Drawing.Point(236, 100);
            this.textBoxDutyCycleHigh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDutyCycleHigh.Name = "textBoxDutyCycleHigh";
            this.textBoxDutyCycleHigh.Size = new System.Drawing.Size(196, 31);
            this.textBoxDutyCycleHigh.TabIndex = 1;
            // 
            // textBoxDutyCycleLow
            // 
            this.textBoxDutyCycleLow.Location = new System.Drawing.Point(448, 100);
            this.textBoxDutyCycleLow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDutyCycleLow.Name = "textBoxDutyCycleLow";
            this.textBoxDutyCycleLow.Size = new System.Drawing.Size(196, 31);
            this.textBoxDutyCycleLow.TabIndex = 2;
            // 
            // textBoxCommandByte
            // 
            this.textBoxCommandByte.Location = new System.Drawing.Point(660, 100);
            this.textBoxCommandByte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCommandByte.Name = "textBoxCommandByte";
            this.textBoxCommandByte.Size = new System.Drawing.Size(196, 31);
            this.textBoxCommandByte.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 69);
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(448, 17);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(412, 41);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect Serial";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duty Cycle High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duty Cycle Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Command Byte";
            // 
            // comboBoxComPorts
            // 
            this.comboBoxComPorts.FormattingEnabled = true;
            this.comboBoxComPorts.Location = new System.Drawing.Point(24, 23);
            this.comboBoxComPorts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxComPorts.Name = "comboBoxComPorts";
            this.comboBoxComPorts.Size = new System.Drawing.Size(408, 33);
            this.comboBoxComPorts.TabIndex = 10;
            this.comboBoxComPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPorts_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(24, 150);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(836, 90);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxDutyCycle
            // 
            this.textBoxDutyCycle.Location = new System.Drawing.Point(660, 233);
            this.textBoxDutyCycle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDutyCycle.Name = "textBoxDutyCycle";
            this.textBoxDutyCycle.ReadOnly = true;
            this.textBoxDutyCycle.Size = new System.Drawing.Size(196, 31);
            this.textBoxDutyCycle.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Duty Cycle";
            // 
            // comboBoxMotorType
            // 
            this.comboBoxMotorType.FormattingEnabled = true;
            this.comboBoxMotorType.Location = new System.Drawing.Point(24, 231);
            this.comboBoxMotorType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxMotorType.Name = "comboBoxMotorType";
            this.comboBoxMotorType.Size = new System.Drawing.Size(196, 33);
            this.comboBoxMotorType.TabIndex = 14;
            this.comboBoxMotorType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotorType_SelectedIndexChanged);
            // 
            // buttonStepCW
            // 
            this.buttonStepCW.Location = new System.Drawing.Point(556, 228);
            this.buttonStepCW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStepCW.Name = "buttonStepCW";
            this.buttonStepCW.Size = new System.Drawing.Size(96, 41);
            this.buttonStepCW.TabIndex = 15;
            this.buttonStepCW.Text = "CW";
            this.buttonStepCW.UseVisualStyleBackColor = true;
            this.buttonStepCW.Click += new System.EventHandler(this.buttonStepCW_Click);
            // 
            // buttonStepCCW
            // 
            this.buttonStepCCW.Location = new System.Drawing.Point(448, 228);
            this.buttonStepCCW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStepCCW.Name = "buttonStepCCW";
            this.buttonStepCCW.Size = new System.Drawing.Size(96, 41);
            this.buttonStepCCW.TabIndex = 16;
            this.buttonStepCCW.Text = "CCW";
            this.buttonStepCCW.UseVisualStyleBackColor = true;
            this.buttonStepCCW.Click += new System.EventHandler(this.buttonStepCCW_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Step Control";
            // 
            // textBoxNumSteps
            // 
            this.textBoxNumSteps.Location = new System.Drawing.Point(236, 234);
            this.textBoxNumSteps.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxNumSteps.Name = "textBoxNumSteps";
            this.textBoxNumSteps.Size = new System.Drawing.Size(196, 31);
            this.textBoxNumSteps.TabIndex = 18;
            this.textBoxNumSteps.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 202);
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
            this.textBoxPosition.Location = new System.Drawing.Point(30, 316);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(196, 31);
            this.textBoxPosition.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Velocity";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Location = new System.Drawing.Point(242, 316);
            this.textBoxVelocity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(196, 31);
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
            this.chart1.Location = new System.Drawing.Point(30, 498);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(830, 347);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(30, 402);
            this.textBoxHigh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(196, 31);
            this.textBoxHigh.TabIndex = 25;
            // 
            // textBoxLow
            // 
            this.textBoxLow.Location = new System.Drawing.Point(236, 402);
            this.textBoxLow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(196, 31);
            this.textBoxLow.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 372);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Count High and Low";
            // 
            // textBoxCombinedCount
            // 
            this.textBoxCombinedCount.ForeColor = System.Drawing.Color.Black;
            this.textBoxCombinedCount.Location = new System.Drawing.Point(450, 402);
            this.textBoxCombinedCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCombinedCount.Name = "textBoxCombinedCount";
            this.textBoxCombinedCount.Size = new System.Drawing.Size(196, 31);
            this.textBoxCombinedCount.TabIndex = 28;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(660, 402);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(198, 34);
            this.btnZero.TabIndex = 29;
            this.btnZero.Text = "Zero Count";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // lstBoxData
            // 
            this.lstBoxData.FormattingEnabled = true;
            this.lstBoxData.ItemHeight = 25;
            this.lstBoxData.Location = new System.Drawing.Point(898, 23);
            this.lstBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxData.Name = "lstBoxData";
            this.lstBoxData.Size = new System.Drawing.Size(619, 804);
            this.lstBoxData.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(660, 455);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 36);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save Series";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 280);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZeroDutyCycle
            // 
            this.buttonZeroDutyCycle.Location = new System.Drawing.Point(450, 316);
            this.buttonZeroDutyCycle.Name = "buttonZeroDutyCycle";
            this.buttonZeroDutyCycle.Size = new System.Drawing.Size(201, 35);
            this.buttonZeroDutyCycle.TabIndex = 34;
            this.buttonZeroDutyCycle.Text = "Zero Duty Cycle";
            this.buttonZeroDutyCycle.UseVisualStyleBackColor = true;
            this.buttonZeroDutyCycle.Click += new System.EventHandler(this.buttonZeroDutyCycle_Click);
            // 
            // MotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 866);
            this.Controls.Add(this.buttonZeroDutyCycle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstBoxData);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.textBoxCombinedCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxLow);
            this.Controls.Add(this.textBoxHigh);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxVelocity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNumSteps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStepCCW);
            this.Controls.Add(this.buttonStepCW);
            this.Controls.Add(this.comboBoxMotorType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDutyCycle);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBoxComPorts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCommandByte);
            this.Controls.Add(this.textBoxDutyCycleLow);
            this.Controls.Add(this.textBoxDutyCycleHigh);
            this.Controls.Add(this.textBoxStartByte);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBoxDutyCycle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMotorType;
        private System.Windows.Forms.Button buttonStepCW;
        private System.Windows.Forms.Button buttonStepCCW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumSteps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.TextBox textBoxLow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCombinedCount;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.ListBox lstBoxData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonZeroDutyCycle;
    }
}

