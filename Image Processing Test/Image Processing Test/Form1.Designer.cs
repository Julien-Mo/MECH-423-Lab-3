namespace Image_Processing_Test
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numBrightThres = new System.Windows.Forms.NumericUpDown();
            this.numGreenThres = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxConvolute = new System.Windows.Forms.PictureBox();
            this.numConvolute = new System.Windows.Forms.NumericUpDown();
            this.numColorLower = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConvolute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConvolute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorLower)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Image files|*.bmp;*.jpg;*.gif;*.png;*.tif\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(13, 13);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(105, 23);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "File Select";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(125, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(217, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(13, 74);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(255, 255);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 2;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxProcessed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProcessed.Location = new System.Drawing.Point(13, 335);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(255, 255);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProcessed.TabIndex = 3;
            this.pictureBoxProcessed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Processed Picture";
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(187, 45);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(81, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // numBrightThres
            // 
            this.numBrightThres.DecimalPlaces = 2;
            this.numBrightThres.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numBrightThres.Location = new System.Drawing.Point(349, 13);
            this.numBrightThres.Name = "numBrightThres";
            this.numBrightThres.Size = new System.Drawing.Size(52, 22);
            this.numBrightThres.TabIndex = 8;
            this.numBrightThres.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numBrightThres.ValueChanged += new System.EventHandler(this.numBrightThres_ValueChanged);
            // 
            // numGreenThres
            // 
            this.numGreenThres.DecimalPlaces = 2;
            this.numGreenThres.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numGreenThres.Location = new System.Drawing.Point(407, 12);
            this.numGreenThres.Name = "numGreenThres";
            this.numGreenThres.Size = new System.Drawing.Size(52, 22);
            this.numGreenThres.TabIndex = 9;
            this.numGreenThres.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numGreenThres.ValueChanged += new System.EventHandler(this.numGreenThres_ValueChanged);
            // 
            // pictureBoxConvolute
            // 
            this.pictureBoxConvolute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxConvolute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxConvolute.Location = new System.Drawing.Point(274, 74);
            this.pictureBoxConvolute.Name = "pictureBoxConvolute";
            this.pictureBoxConvolute.Size = new System.Drawing.Size(544, 516);
            this.pictureBoxConvolute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConvolute.TabIndex = 10;
            this.pictureBoxConvolute.TabStop = false;
            // 
            // numConvolute
            // 
            this.numConvolute.Location = new System.Drawing.Point(465, 12);
            this.numConvolute.Name = "numConvolute";
            this.numConvolute.Size = new System.Drawing.Size(52, 22);
            this.numConvolute.TabIndex = 11;
            this.numConvolute.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numConvolute.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numColorLower
            // 
            this.numColorLower.DecimalPlaces = 2;
            this.numColorLower.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numColorLower.Location = new System.Drawing.Point(407, 40);
            this.numColorLower.Name = "numColorLower";
            this.numColorLower.Size = new System.Drawing.Size(52, 22);
            this.numColorLower.TabIndex = 12;
            this.numColorLower.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numColorLower.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 597);
            this.Controls.Add(this.numColorLower);
            this.Controls.Add(this.numConvolute);
            this.Controls.Add(this.pictureBoxConvolute);
            this.Controls.Add(this.numGreenThres);
            this.Controls.Add(this.numBrightThres);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxProcessed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnFileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConvolute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConvolute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColorLower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numBrightThres;
        private System.Windows.Forms.NumericUpDown numGreenThres;
        private System.Windows.Forms.PictureBox pictureBoxConvolute;
        private System.Windows.Forms.NumericUpDown numConvolute;
        private System.Windows.Forms.NumericUpDown numColorLower;
    }
}

