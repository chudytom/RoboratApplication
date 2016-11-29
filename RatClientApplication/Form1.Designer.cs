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
            this.speedHScrollBar = new System.Windows.Forms.HScrollBar();
            this.speedLabel2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.linearSpeedLabel = new System.Windows.Forms.Label();
            this.rotationSpeedLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.timer100 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.setIPButton = new System.Windows.Forms.Button();
            this.timer2000 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
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
            // speedHScrollBar
            // 
            this.speedHScrollBar.Location = new System.Drawing.Point(15, 323);
            this.speedHScrollBar.Maximum = 270;
            this.speedHScrollBar.Minimum = 1;
            this.speedHScrollBar.Name = "speedHScrollBar";
            this.speedHScrollBar.Size = new System.Drawing.Size(243, 17);
            this.speedHScrollBar.TabIndex = 4;
            this.speedHScrollBar.TabStop = true;
            this.speedHScrollBar.Value = 100;
            this.speedHScrollBar.ValueChanged += new System.EventHandler(this.speedHScrollBar_ValueChanged);
            this.speedHScrollBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedHScrollBar_KeyDown);
            this.speedHScrollBar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.speedHScrollBar_PreviewKeyDown);
            // 
            // speedLabel2
            // 
            this.speedLabel2.AutoSize = true;
            this.speedLabel2.Location = new System.Drawing.Point(96, 304);
            this.speedLabel2.Name = "speedLabel2";
            this.speedLabel2.Size = new System.Drawing.Size(41, 13);
            this.speedLabel2.TabIndex = 5;
            this.speedLabel2.Text = "Speed:";
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
            // linearSpeedLabel
            // 
            this.linearSpeedLabel.AutoSize = true;
            this.linearSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel.Location = new System.Drawing.Point(365, 283);
            this.linearSpeedLabel.Name = "linearSpeedLabel";
            this.linearSpeedLabel.Size = new System.Drawing.Size(14, 13);
            this.linearSpeedLabel.TabIndex = 8;
            this.linearSpeedLabel.Text = "0";
            // 
            // rotationSpeedLabel
            // 
            this.rotationSpeedLabel.AutoSize = true;
            this.rotationSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotationSpeedLabel.Location = new System.Drawing.Point(365, 306);
            this.rotationSpeedLabel.Name = "rotationSpeedLabel";
            this.rotationSpeedLabel.Size = new System.Drawing.Size(14, 13);
            this.rotationSpeedLabel.TabIndex = 9;
            this.rotationSpeedLabel.Text = "0";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedLabel.Location = new System.Drawing.Point(131, 304);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(28, 13);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "100";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(242, 150);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(150, 75);
            this.inputTextBox.TabIndex = 12;
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(190, 102);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(284, 230);
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
            this.label3.Location = new System.Drawing.Point(53, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Messages form the server:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(45, 150);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(150, 75);
            this.outputTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type your message to server:";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(74, 230);
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
            this.label5.Location = new System.Drawing.Point(40, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "IP Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Port:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(101, 15);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 21;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(242, 15);
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
            // timer2000
            // 
            this.timer2000.Interval = 2000;
            this.timer2000.Tick += new System.EventHandler(this.timer2000_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(185, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Connection:";
            // 
            // connectionLabel
            // 
            this.connectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectionLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.connectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionLabel.Location = new System.Drawing.Point(207, 61);
            this.connectionLabel.MinimumSize = new System.Drawing.Size(30, 10);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(40, 30);
            this.connectionLabel.TabIndex = 27;
            this.connectionLabel.Text = "OFF";
            this.connectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(452, 352);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.setIPButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.rotationSpeedLabel);
            this.Controls.Add(this.linearSpeedLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.speedLabel2);
            this.Controls.Add(this.speedHScrollBar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upBox;
        private System.Windows.Forms.Label rightBox;
        private System.Windows.Forms.Label leftBox;
        private System.Windows.Forms.Label downBox;
        private System.Windows.Forms.HScrollBar speedHScrollBar;
        private System.Windows.Forms.Label speedLabel2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label linearSpeedLabel;
        private System.Windows.Forms.Label rotationSpeedLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Timer timer100;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button setIPButton;
        private System.Windows.Forms.Timer timer2000;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label connectionLabel;
    }
}

