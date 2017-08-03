namespace RatClientApplication
{
    partial class CalibrationForm
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxHSV = new System.Windows.Forms.PictureBox();
            this.pictureBoxBinary = new System.Windows.Forms.PictureBox();
            this.hScrollBarHMin = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hScrollBarVMin = new System.Windows.Forms.HScrollBar();
            this.hScrollBarHMax = new System.Windows.Forms.HScrollBar();
            this.hScrollBarSMax = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVMax = new System.Windows.Forms.HScrollBar();
            this.hScrollBarSMin = new System.Windows.Forms.HScrollBar();
            this.labelHMin = new System.Windows.Forms.Label();
            this.labelSMin = new System.Windows.Forms.Label();
            this.labelVMin = new System.Windows.Forms.Label();
            this.labelHMax = new System.Windows.Forms.Label();
            this.labelSMax = new System.Windows.Forms.Label();
            this.labelVMax = new System.Windows.Forms.Label();
            this.buttonSendCalibrationParameters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinary)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxHSV
            // 
            this.pictureBoxHSV.Location = new System.Drawing.Point(338, 23);
            this.pictureBoxHSV.Name = "pictureBoxHSV";
            this.pictureBoxHSV.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxHSV.TabIndex = 1;
            this.pictureBoxHSV.TabStop = false;
            // 
            // pictureBoxBinary
            // 
            this.pictureBoxBinary.Location = new System.Drawing.Point(12, 284);
            this.pictureBoxBinary.Name = "pictureBoxBinary";
            this.pictureBoxBinary.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxBinary.TabIndex = 2;
            this.pictureBoxBinary.TabStop = false;
            // 
            // hScrollBarHMin
            // 
            this.hScrollBarHMin.Location = new System.Drawing.Point(397, 284);
            this.hScrollBarHMin.Maximum = 264;
            this.hScrollBarHMin.Name = "hScrollBarHMin";
            this.hScrollBarHMin.Size = new System.Drawing.Size(261, 17);
            this.hScrollBarHMin.TabIndex = 3;
            this.hScrollBarHMin.ValueChanged += new System.EventHandler(this.hScrollBarHMin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "H Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "S Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "V Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "H Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "S max:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "V max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Original";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "HSV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Binary";
            // 
            // hScrollBarVMin
            // 
            this.hScrollBarVMin.Location = new System.Drawing.Point(395, 355);
            this.hScrollBarVMin.Maximum = 264;
            this.hScrollBarVMin.Name = "hScrollBarVMin";
            this.hScrollBarVMin.Size = new System.Drawing.Size(261, 17);
            this.hScrollBarVMin.TabIndex = 18;
            this.hScrollBarVMin.ValueChanged += new System.EventHandler(this.hScrollBarVMin_ValueChanged);
            // 
            // hScrollBarHMax
            // 
            this.hScrollBarHMax.Location = new System.Drawing.Point(397, 387);
            this.hScrollBarHMax.Maximum = 264;
            this.hScrollBarHMax.Name = "hScrollBarHMax";
            this.hScrollBarHMax.Size = new System.Drawing.Size(261, 17);
            this.hScrollBarHMax.TabIndex = 19;
            this.hScrollBarHMax.Value = 255;
            this.hScrollBarHMax.ValueChanged += new System.EventHandler(this.hScrollBarHMax_ValueChanged);
            // 
            // hScrollBarSMax
            // 
            this.hScrollBarSMax.Location = new System.Drawing.Point(397, 430);
            this.hScrollBarSMax.Maximum = 264;
            this.hScrollBarSMax.Name = "hScrollBarSMax";
            this.hScrollBarSMax.Size = new System.Drawing.Size(261, 17);
            this.hScrollBarSMax.TabIndex = 20;
            this.hScrollBarSMax.Value = 255;
            this.hScrollBarSMax.ValueChanged += new System.EventHandler(this.hScrollBarSMax_ValueChanged);
            // 
            // hScrollBarVMax
            // 
            this.hScrollBarVMax.Location = new System.Drawing.Point(397, 473);
            this.hScrollBarVMax.Maximum = 264;
            this.hScrollBarVMax.Name = "hScrollBarVMax";
            this.hScrollBarVMax.Size = new System.Drawing.Size(261, 17);
            this.hScrollBarVMax.TabIndex = 21;
            this.hScrollBarVMax.Value = 255;
            this.hScrollBarVMax.ValueChanged += new System.EventHandler(this.hScrollBarVMax_ValueChanged);
            // 
            // hScrollBarSMin
            // 
            this.hScrollBarSMin.Location = new System.Drawing.Point(397, 318);
            this.hScrollBarSMin.Maximum = 264;
            this.hScrollBarSMin.Name = "hScrollBarSMin";
            this.hScrollBarSMin.Size = new System.Drawing.Size(261, 17);
            this.hScrollBarSMin.TabIndex = 22;
            this.hScrollBarSMin.ValueChanged += new System.EventHandler(this.hScrollBarSMin_ValueChanged);
            // 
            // labelHMin
            // 
            this.labelHMin.AutoSize = true;
            this.labelHMin.Location = new System.Drawing.Point(379, 284);
            this.labelHMin.Name = "labelHMin";
            this.labelHMin.Size = new System.Drawing.Size(13, 13);
            this.labelHMin.TabIndex = 23;
            this.labelHMin.Text = "0";
            // 
            // labelSMin
            // 
            this.labelSMin.AutoSize = true;
            this.labelSMin.Location = new System.Drawing.Point(378, 318);
            this.labelSMin.Name = "labelSMin";
            this.labelSMin.Size = new System.Drawing.Size(13, 13);
            this.labelSMin.TabIndex = 24;
            this.labelSMin.Text = "0";
            // 
            // labelVMin
            // 
            this.labelVMin.AutoSize = true;
            this.labelVMin.Location = new System.Drawing.Point(381, 355);
            this.labelVMin.Name = "labelVMin";
            this.labelVMin.Size = new System.Drawing.Size(13, 13);
            this.labelVMin.TabIndex = 25;
            this.labelVMin.Text = "0";
            // 
            // labelHMax
            // 
            this.labelHMax.AutoSize = true;
            this.labelHMax.Location = new System.Drawing.Point(381, 389);
            this.labelHMax.Name = "labelHMax";
            this.labelHMax.Size = new System.Drawing.Size(13, 13);
            this.labelHMax.TabIndex = 26;
            this.labelHMax.Text = "0";
            // 
            // labelSMax
            // 
            this.labelSMax.AutoSize = true;
            this.labelSMax.Location = new System.Drawing.Point(381, 432);
            this.labelSMax.Name = "labelSMax";
            this.labelSMax.Size = new System.Drawing.Size(13, 13);
            this.labelSMax.TabIndex = 27;
            this.labelSMax.Text = "0";
            // 
            // labelVMax
            // 
            this.labelVMax.AutoSize = true;
            this.labelVMax.Location = new System.Drawing.Point(381, 475);
            this.labelVMax.Name = "labelVMax";
            this.labelVMax.Size = new System.Drawing.Size(13, 13);
            this.labelVMax.TabIndex = 28;
            this.labelVMax.Text = "0";
            // 
            // buttonSendCalibrationParameters
            // 
            this.buttonSendCalibrationParameters.AutoSize = true;
            this.buttonSendCalibrationParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSendCalibrationParameters.Location = new System.Drawing.Point(420, 502);
            this.buttonSendCalibrationParameters.Name = "buttonSendCalibrationParameters";
            this.buttonSendCalibrationParameters.Size = new System.Drawing.Size(177, 23);
            this.buttonSendCalibrationParameters.TabIndex = 29;
            this.buttonSendCalibrationParameters.Text = "Send Calibration Parameters";
            this.buttonSendCalibrationParameters.UseVisualStyleBackColor = true;
            this.buttonSendCalibrationParameters.Click += new System.EventHandler(this.buttonSendCalibrationParameters_Click);
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 536);
            this.Controls.Add(this.buttonSendCalibrationParameters);
            this.Controls.Add(this.labelVMax);
            this.Controls.Add(this.labelSMax);
            this.Controls.Add(this.labelHMax);
            this.Controls.Add(this.labelVMin);
            this.Controls.Add(this.labelSMin);
            this.Controls.Add(this.labelHMin);
            this.Controls.Add(this.hScrollBarSMin);
            this.Controls.Add(this.hScrollBarVMax);
            this.Controls.Add(this.hScrollBarSMax);
            this.Controls.Add(this.hScrollBarHMax);
            this.Controls.Add(this.hScrollBarVMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBarHMin);
            this.Controls.Add(this.pictureBoxBinary);
            this.Controls.Add(this.pictureBoxHSV);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "CalibrationForm";
            this.Text = "CalibrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxHSV;
        private System.Windows.Forms.PictureBox pictureBoxBinary;
        private System.Windows.Forms.HScrollBar hScrollBarHMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar hScrollBarVMin;
        private System.Windows.Forms.HScrollBar hScrollBarHMax;
        private System.Windows.Forms.HScrollBar hScrollBarSMax;
        private System.Windows.Forms.HScrollBar hScrollBarVMax;
        private System.Windows.Forms.HScrollBar hScrollBarSMin;
        private System.Windows.Forms.Label labelHMin;
        private System.Windows.Forms.Label labelSMin;
        private System.Windows.Forms.Label labelVMin;
        private System.Windows.Forms.Label labelHMax;
        private System.Windows.Forms.Label labelSMax;
        private System.Windows.Forms.Label labelVMax;
        private System.Windows.Forms.Button buttonSendCalibrationParameters;
    }
}