namespace RatClientApplication
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
            this.components = new System.ComponentModel.Container();
            this.upBox = new System.Windows.Forms.Label();
            this.rightBox = new System.Windows.Forms.Label();
            this.leftBox = new System.Windows.Forms.Label();
            this.downBox = new System.Windows.Forms.Label();
            this.linearSpeedHScrollBar = new System.Windows.Forms.HScrollBar();
            this.speedLabel2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.linearSpeedLabel2 = new System.Windows.Forms.Label();
            this.angularSpeedLabel2 = new System.Windows.Forms.Label();
            this.linearSpeedLabel1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.tcpConnectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.timer100 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.outputTCPTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.setIPButton = new System.Windows.Forms.Button();
            this.timer3000 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tcpConnectionLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.angularSpeedHScrollBar = new System.Windows.Forms.HScrollBar();
            this.angularSpeedLabel1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.outputUDPTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upBox
            // 
            this.upBox.AutoSize = true;
            this.upBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.upBox.Location = new System.Drawing.Point(107, 263);
            this.upBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.upBox.Name = "upBox";
            this.upBox.Size = new System.Drawing.Size(30, 13);
            this.upBox.TabIndex = 0;
            // 
            // rightBox
            // 
            this.rightBox.AutoSize = true;
            this.rightBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.rightBox.Location = new System.Drawing.Point(143, 285);
            this.rightBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(30, 13);
            this.rightBox.TabIndex = 1;
            // 
            // leftBox
            // 
            this.leftBox.AutoSize = true;
            this.leftBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.leftBox.Location = new System.Drawing.Point(71, 285);
            this.leftBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(30, 13);
            this.leftBox.TabIndex = 2;
            // 
            // downBox
            // 
            this.downBox.AutoSize = true;
            this.downBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.downBox.Location = new System.Drawing.Point(107, 285);
            this.downBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.downBox.Name = "downBox";
            this.downBox.Size = new System.Drawing.Size(30, 13);
            this.downBox.TabIndex = 3;
            // 
            // linearSpeedHScrollBar
            // 
            this.linearSpeedHScrollBar.Location = new System.Drawing.Point(15, 323);
            this.linearSpeedHScrollBar.Maximum = 270;
            this.linearSpeedHScrollBar.Minimum = 1;
            this.linearSpeedHScrollBar.Name = "linearSpeedHScrollBar";
            this.linearSpeedHScrollBar.Size = new System.Drawing.Size(243, 17);
            this.linearSpeedHScrollBar.TabIndex = 4;
            this.linearSpeedHScrollBar.TabStop = true;
            this.linearSpeedHScrollBar.Value = 100;
            this.linearSpeedHScrollBar.ValueChanged += new System.EventHandler(this.speedHScrollBar_ValueChanged);
            this.linearSpeedHScrollBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedHScrollBar_KeyDown);
            this.linearSpeedHScrollBar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.speedHScrollBar_PreviewKeyDown);
            // 
            // speedLabel2
            // 
            this.speedLabel2.AutoSize = true;
            this.speedLabel2.Location = new System.Drawing.Point(71, 303);
            this.speedLabel2.Name = "speedLabel2";
            this.speedLabel2.Size = new System.Drawing.Size(73, 13);
            this.speedLabel2.TabIndex = 5;
            this.speedLabel2.Text = "Linear Speed:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(281, 283);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Speed Ahead:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(281, 306);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Speed Around:";
            // 
            // linearSpeedLabel2
            // 
            this.linearSpeedLabel2.AutoSize = true;
            this.linearSpeedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel2.Location = new System.Drawing.Point(365, 283);
            this.linearSpeedLabel2.Name = "linearSpeedLabel2";
            this.linearSpeedLabel2.Size = new System.Drawing.Size(14, 13);
            this.linearSpeedLabel2.TabIndex = 8;
            this.linearSpeedLabel2.Text = "0";
            // 
            // angularSpeedLabel2
            // 
            this.angularSpeedLabel2.AutoSize = true;
            this.angularSpeedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angularSpeedLabel2.Location = new System.Drawing.Point(365, 306);
            this.angularSpeedLabel2.Name = "angularSpeedLabel2";
            this.angularSpeedLabel2.Size = new System.Drawing.Size(14, 13);
            this.angularSpeedLabel2.TabIndex = 9;
            this.angularSpeedLabel2.Text = "0";
            // 
            // linearSpeedLabel1
            // 
            this.linearSpeedLabel1.AutoSize = true;
            this.linearSpeedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel1.Location = new System.Drawing.Point(157, 303);
            this.linearSpeedLabel1.Name = "linearSpeedLabel1";
            this.linearSpeedLabel1.Size = new System.Drawing.Size(28, 13);
            this.linearSpeedLabel1.TabIndex = 10;
            this.linearSpeedLabel1.Text = "100";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(175, 151);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(150, 75);
            this.inputTextBox.TabIndex = 12;
            // 
            // tcpConnectButton
            // 
            this.tcpConnectButton.Enabled = false;
            this.tcpConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcpConnectButton.Location = new System.Drawing.Point(176, 102);
            this.tcpConnectButton.Name = "tcpConnectButton";
            this.tcpConnectButton.Size = new System.Drawing.Size(79, 30);
            this.tcpConnectButton.TabIndex = 13;
            this.tcpConnectButton.Text = "Connect";
            this.tcpConnectButton.UseVisualStyleBackColor = true;
            this.tcpConnectButton.Click += new System.EventHandler(this.tcpConnectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(208, 231);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 14;
            this.sendButton.Text = "Send text";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // timer100
            // 
            this.timer100.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Messages from TCP server:";
            // 
            // outputTCPTextBox
            // 
            this.outputTCPTextBox.Location = new System.Drawing.Point(9, 152);
            this.outputTCPTextBox.Multiline = true;
            this.outputTCPTextBox.Name = "outputTCPTextBox";
            this.outputTCPTextBox.Size = new System.Drawing.Size(150, 75);
            this.outputTCPTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type your message to server:";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(38, 232);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear the box";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "IP Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Port:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(74, 15);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 21;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(215, 15);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 22;
            // 
            // setIPButton
            // 
            this.setIPButton.Location = new System.Drawing.Point(361, 12);
            this.setIPButton.Name = "setIPButton";
            this.setIPButton.Size = new System.Drawing.Size(75, 23);
            this.setIPButton.TabIndex = 23;
            this.setIPButton.Text = "Set IP";
            this.setIPButton.UseVisualStyleBackColor = true;
            this.setIPButton.Click += new System.EventHandler(this.setIPButton_Click);
            // 
            // timer3000
            // 
            this.timer3000.Interval = 3000;
            this.timer3000.Tick += new System.EventHandler(this.timer3000_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(163, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "IP Connection:";
            // 
            // tcpConnectionLabel
            // 
            this.tcpConnectionLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.tcpConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcpConnectionLabel.Location = new System.Drawing.Point(205, 63);
            this.tcpConnectionLabel.MinimumSize = new System.Drawing.Size(30, 10);
            this.tcpConnectionLabel.Name = "tcpConnectionLabel";
            this.tcpConnectionLabel.Size = new System.Drawing.Size(40, 30);
            this.tcpConnectionLabel.TabIndex = 27;
            this.tcpConnectionLabel.Text = "OFF";
            this.tcpConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(317, 62);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 28;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // angularSpeedHScrollBar
            // 
            this.angularSpeedHScrollBar.Location = new System.Drawing.Point(15, 374);
            this.angularSpeedHScrollBar.Maximum = 50;
            this.angularSpeedHScrollBar.Minimum = 1;
            this.angularSpeedHScrollBar.Name = "angularSpeedHScrollBar";
            this.angularSpeedHScrollBar.Size = new System.Drawing.Size(243, 17);
            this.angularSpeedHScrollBar.TabIndex = 29;
            this.angularSpeedHScrollBar.TabStop = true;
            this.angularSpeedHScrollBar.Value = 50;
            this.angularSpeedHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.angularSpeedHScrollBar_Scroll);
            this.angularSpeedHScrollBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.angularSpeedHScrollBar_KeyDown);
            // 
            // angularSpeedLabel1
            // 
            this.angularSpeedLabel1.AutoSize = true;
            this.angularSpeedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angularSpeedLabel1.Location = new System.Drawing.Point(157, 351);
            this.angularSpeedLabel1.Name = "angularSpeedLabel1";
            this.angularSpeedLabel1.Size = new System.Drawing.Size(28, 13);
            this.angularSpeedLabel1.TabIndex = 31;
            this.angularSpeedLabel1.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Angular Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Messages from UDP client";
            // 
            // outputUDPTextBox
            // 
            this.outputUDPTextBox.Location = new System.Drawing.Point(338, 152);
            this.outputUDPTextBox.Multiline = true;
            this.outputUDPTextBox.Name = "outputUDPTextBox";
            this.outputUDPTextBox.Size = new System.Drawing.Size(150, 75);
            this.outputUDPTextBox.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(401, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 175);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(704, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputUDPTextBox);
            this.Controls.Add(this.angularSpeedLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.angularSpeedHScrollBar);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.tcpConnectionLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.setIPButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputTCPTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.tcpConnectButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.linearSpeedLabel1);
            this.Controls.Add(this.angularSpeedLabel2);
            this.Controls.Add(this.linearSpeedLabel2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.speedLabel2);
            this.Controls.Add(this.linearSpeedHScrollBar);
            this.Controls.Add(this.downBox);
            this.Controls.Add(this.leftBox);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.upBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upBox;
        private System.Windows.Forms.Label rightBox;
        private System.Windows.Forms.Label leftBox;
        private System.Windows.Forms.Label downBox;
        private System.Windows.Forms.HScrollBar linearSpeedHScrollBar;
        private System.Windows.Forms.Label speedLabel2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label linearSpeedLabel2;
        private System.Windows.Forms.Label angularSpeedLabel2;
        private System.Windows.Forms.Label linearSpeedLabel1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button tcpConnectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Timer timer100;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTCPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button setIPButton;
        private System.Windows.Forms.Timer timer3000;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tcpConnectionLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.HScrollBar angularSpeedHScrollBar;
        private System.Windows.Forms.Label angularSpeedLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox outputUDPTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

