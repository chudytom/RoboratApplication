namespace RatClientApplication
{
    partial class FormRat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRat));
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
            this.connectButton = new System.Windows.Forms.Button();
            this.timer100 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.outputTCPTextBox = new System.Windows.Forms.TextBox();
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
            this.label10 = new System.Windows.Forms.Label();
            this.automaticModeButton = new System.Windows.Forms.Button();
            this.manualModeButton = new System.Windows.Forms.Button();
            this.randomMovingButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.saveVideoButton = new System.Windows.Forms.Button();
            this.continueStreamingButton = new System.Windows.Forms.Button();
            this.panicStopButton = new System.Windows.Forms.Button();
            this.advancedIPGroupBox = new System.Windows.Forms.GroupBox();
            this.hideAdvancedIPOptionsButton = new System.Windows.Forms.Button();
            this.advancedIPOptionsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pheromoneLeftLabel = new System.Windows.Forms.Label();
            this.timeSoundLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timeSoundScrollbar = new System.Windows.Forms.HScrollBar();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.frequencyScrollbar = new System.Windows.Forms.HScrollBar();
            this.pheromoneReleaseLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pheromoneReleaseScrollbar = new System.Windows.Forms.HScrollBar();
            this.startExtractingScentButton = new System.Windows.Forms.Button();
            this.startPlayingSoundButton = new System.Windows.Forms.Button();
            this.startImpulseButton = new System.Windows.Forms.Button();
            this.timerSound = new System.Windows.Forms.Timer(this.components);
            this.pheromoneProgressBar = new RatClientApplication.ColorfulProgressBar();
            this.batteryProgressBar = new RatClientApplication.ColorfulProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.advancedIPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // upBox
            // 
            this.upBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.upBox.Location = new System.Drawing.Point(441, 223);
            this.upBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.upBox.Name = "upBox";
            this.upBox.Size = new System.Drawing.Size(40, 20);
            this.upBox.TabIndex = 0;
            // 
            // rightBox
            // 
            this.rightBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.rightBox.Location = new System.Drawing.Point(489, 249);
            this.rightBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(40, 20);
            this.rightBox.TabIndex = 1;
            // 
            // leftBox
            // 
            this.leftBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.leftBox.Location = new System.Drawing.Point(393, 249);
            this.leftBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(40, 20);
            this.leftBox.TabIndex = 2;
            // 
            // downBox
            // 
            this.downBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.downBox.Location = new System.Drawing.Point(441, 249);
            this.downBox.MinimumSize = new System.Drawing.Size(30, 10);
            this.downBox.Name = "downBox";
            this.downBox.Size = new System.Drawing.Size(40, 20);
            this.downBox.TabIndex = 3;
            // 
            // linearSpeedHScrollBar
            // 
            this.linearSpeedHScrollBar.Location = new System.Drawing.Point(337, 373);
            this.linearSpeedHScrollBar.Maximum = 270;
            this.linearSpeedHScrollBar.Minimum = 1;
            this.linearSpeedHScrollBar.Name = "linearSpeedHScrollBar";
            this.linearSpeedHScrollBar.Size = new System.Drawing.Size(243, 17);
            this.linearSpeedHScrollBar.TabIndex = 4;
            this.linearSpeedHScrollBar.TabStop = true;
            this.linearSpeedHScrollBar.Value = 100;
            this.linearSpeedHScrollBar.ValueChanged += new System.EventHandler(this.speedHScrollBar_ValueChanged);
            this.linearSpeedHScrollBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speedHScrollBar_KeyDown);
            // 
            // speedLabel2
            // 
            this.speedLabel2.AutoSize = true;
            this.speedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedLabel2.Location = new System.Drawing.Point(396, 353);
            this.speedLabel2.Name = "speedLabel2";
            this.speedLabel2.Size = new System.Drawing.Size(92, 16);
            this.speedLabel2.TabIndex = 5;
            this.speedLabel2.Text = "Linear Speed:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(406, 294);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 16);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Speed Ahead:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(406, 317);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 16);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Speed Around:";
            // 
            // linearSpeedLabel2
            // 
            this.linearSpeedLabel2.AutoSize = true;
            this.linearSpeedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel2.Location = new System.Drawing.Point(507, 293);
            this.linearSpeedLabel2.Name = "linearSpeedLabel2";
            this.linearSpeedLabel2.Size = new System.Drawing.Size(16, 16);
            this.linearSpeedLabel2.TabIndex = 8;
            this.linearSpeedLabel2.Text = "0";
            // 
            // angularSpeedLabel2
            // 
            this.angularSpeedLabel2.AutoSize = true;
            this.angularSpeedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angularSpeedLabel2.Location = new System.Drawing.Point(507, 316);
            this.angularSpeedLabel2.Name = "angularSpeedLabel2";
            this.angularSpeedLabel2.Size = new System.Drawing.Size(16, 16);
            this.angularSpeedLabel2.TabIndex = 9;
            this.angularSpeedLabel2.Text = "0";
            // 
            // linearSpeedLabel1
            // 
            this.linearSpeedLabel1.AutoSize = true;
            this.linearSpeedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel1.Location = new System.Drawing.Point(496, 353);
            this.linearSpeedLabel1.Name = "linearSpeedLabel1";
            this.linearSpeedLabel1.Size = new System.Drawing.Size(32, 16);
            this.linearSpeedLabel1.TabIndex = 10;
            this.linearSpeedLabel1.Text = "100";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Silver;
            this.connectButton.Enabled = false;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(29, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(85, 30);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // timer100
            // 
            this.timer100.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(161, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Connection messages";
            // 
            // outputTCPTextBox
            // 
            this.outputTCPTextBox.Location = new System.Drawing.Point(150, 35);
            this.outputTCPTextBox.Multiline = true;
            this.outputTCPTextBox.Name = "outputTCPTextBox";
            this.outputTCPTextBox.Size = new System.Drawing.Size(150, 75);
            this.outputTCPTextBox.TabIndex = 16;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.Location = new System.Drawing.Point(184, 114);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear the box";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Port:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(43, 45);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 21;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(43, 19);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 22;
            // 
            // setIPButton
            // 
            this.setIPButton.BackColor = System.Drawing.Color.Silver;
            this.setIPButton.Location = new System.Drawing.Point(92, 69);
            this.setIPButton.Name = "setIPButton";
            this.setIPButton.Size = new System.Drawing.Size(51, 23);
            this.setIPButton.TabIndex = 23;
            this.setIPButton.Text = "Set IP";
            this.setIPButton.UseVisualStyleBackColor = false;
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
            this.label8.Location = new System.Drawing.Point(22, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "IP Connection";
            // 
            // tcpConnectionLabel
            // 
            this.tcpConnectionLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.tcpConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcpConnectionLabel.Location = new System.Drawing.Point(51, 29);
            this.tcpConnectionLabel.MinimumSize = new System.Drawing.Size(30, 10);
            this.tcpConnectionLabel.Name = "tcpConnectionLabel";
            this.tcpConnectionLabel.Size = new System.Drawing.Size(40, 30);
            this.tcpConnectionLabel.TabIndex = 27;
            this.tcpConnectionLabel.Text = "OFF";
            this.tcpConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Silver;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(34, 127);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 28;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // angularSpeedHScrollBar
            // 
            this.angularSpeedHScrollBar.Location = new System.Drawing.Point(337, 424);
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
            this.angularSpeedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angularSpeedLabel1.Location = new System.Drawing.Point(496, 401);
            this.angularSpeedLabel1.Name = "angularSpeedLabel1";
            this.angularSpeedLabel1.Size = new System.Drawing.Size(32, 16);
            this.angularSpeedLabel1.TabIndex = 31;
            this.angularSpeedLabel1.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(393, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rotation Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(31, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Video stream messages";
            // 
            // outputUDPTextBox
            // 
            this.outputUDPTextBox.Location = new System.Drawing.Point(25, 185);
            this.outputUDPTextBox.Multiline = true;
            this.outputUDPTextBox.Name = "outputUDPTextBox";
            this.outputUDPTextBox.Size = new System.Drawing.Size(150, 75);
            this.outputUDPTextBox.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 175);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(118, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Video Stream";
            // 
            // automaticModeButton
            // 
            this.automaticModeButton.Location = new System.Drawing.Point(317, 54);
            this.automaticModeButton.Name = "automaticModeButton";
            this.automaticModeButton.Size = new System.Drawing.Size(100, 30);
            this.automaticModeButton.TabIndex = 36;
            this.automaticModeButton.TabStop = false;
            this.automaticModeButton.Text = "Automatic mode";
            this.automaticModeButton.UseVisualStyleBackColor = true;
            this.automaticModeButton.Click += new System.EventHandler(this.automaticModeButton_Click);
            // 
            // manualModeButton
            // 
            this.manualModeButton.Location = new System.Drawing.Point(317, 21);
            this.manualModeButton.Name = "manualModeButton";
            this.manualModeButton.Size = new System.Drawing.Size(100, 30);
            this.manualModeButton.TabIndex = 37;
            this.manualModeButton.TabStop = false;
            this.manualModeButton.Text = "Manual mode";
            this.manualModeButton.UseVisualStyleBackColor = true;
            this.manualModeButton.Click += new System.EventHandler(this.manualModeButton_Click);
            // 
            // randomMovingButton
            // 
            this.randomMovingButton.Location = new System.Drawing.Point(317, 88);
            this.randomMovingButton.Name = "randomMovingButton";
            this.randomMovingButton.Size = new System.Drawing.Size(100, 30);
            this.randomMovingButton.TabIndex = 38;
            this.randomMovingButton.TabStop = false;
            this.randomMovingButton.Text = "Random moving";
            this.randomMovingButton.UseVisualStyleBackColor = true;
            this.randomMovingButton.Click += new System.EventHandler(this.randomMovingButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(414, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Battery Level";
            // 
            // saveVideoButton
            // 
            this.saveVideoButton.BackColor = System.Drawing.Color.Silver;
            this.saveVideoButton.Location = new System.Drawing.Point(229, 264);
            this.saveVideoButton.Name = "saveVideoButton";
            this.saveVideoButton.Size = new System.Drawing.Size(75, 23);
            this.saveVideoButton.TabIndex = 40;
            this.saveVideoButton.Text = "Save frames";
            this.saveVideoButton.UseVisualStyleBackColor = false;
            this.saveVideoButton.Click += new System.EventHandler(this.saveVideoButton_Click);
            // 
            // continueStreamingButton
            // 
            this.continueStreamingButton.BackColor = System.Drawing.Color.Silver;
            this.continueStreamingButton.Location = new System.Drawing.Point(8, 264);
            this.continueStreamingButton.Name = "continueStreamingButton";
            this.continueStreamingButton.Size = new System.Drawing.Size(104, 23);
            this.continueStreamingButton.TabIndex = 41;
            this.continueStreamingButton.Text = "Stop streaming";
            this.continueStreamingButton.UseVisualStyleBackColor = false;
            this.continueStreamingButton.Click += new System.EventHandler(this.continueStreamingButton_Click);
            // 
            // panicStopButton
            // 
            this.panicStopButton.BackColor = System.Drawing.Color.Red;
            this.panicStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panicStopButton.Location = new System.Drawing.Point(229, 175);
            this.panicStopButton.Name = "panicStopButton";
            this.panicStopButton.Size = new System.Drawing.Size(99, 78);
            this.panicStopButton.TabIndex = 43;
            this.panicStopButton.Text = "Panic Stop";
            this.panicStopButton.UseVisualStyleBackColor = false;
            this.panicStopButton.Click += new System.EventHandler(this.panicStopButton_Click);
            // 
            // advancedIPGroupBox
            // 
            this.advancedIPGroupBox.Controls.Add(this.hideAdvancedIPOptionsButton);
            this.advancedIPGroupBox.Controls.Add(this.portTextBox);
            this.advancedIPGroupBox.Controls.Add(this.label5);
            this.advancedIPGroupBox.Controls.Add(this.label6);
            this.advancedIPGroupBox.Controls.Add(this.ipTextBox);
            this.advancedIPGroupBox.Controls.Add(this.setIPButton);
            this.advancedIPGroupBox.Location = new System.Drawing.Point(437, 18);
            this.advancedIPGroupBox.Name = "advancedIPGroupBox";
            this.advancedIPGroupBox.Size = new System.Drawing.Size(158, 100);
            this.advancedIPGroupBox.TabIndex = 44;
            this.advancedIPGroupBox.TabStop = false;
            this.advancedIPGroupBox.Text = "Advanced IP options";
            this.advancedIPGroupBox.Visible = false;
            // 
            // hideAdvancedIPOptionsButton
            // 
            this.hideAdvancedIPOptionsButton.BackColor = System.Drawing.Color.Silver;
            this.hideAdvancedIPOptionsButton.Location = new System.Drawing.Point(6, 69);
            this.hideAdvancedIPOptionsButton.Name = "hideAdvancedIPOptionsButton";
            this.hideAdvancedIPOptionsButton.Size = new System.Drawing.Size(80, 23);
            this.hideAdvancedIPOptionsButton.TabIndex = 24;
            this.hideAdvancedIPOptionsButton.Text = "Hide options";
            this.hideAdvancedIPOptionsButton.UseVisualStyleBackColor = false;
            this.hideAdvancedIPOptionsButton.Click += new System.EventHandler(this.hideAdvancedIPOptionsButton_Click);
            // 
            // advancedIPOptionsButton
            // 
            this.advancedIPOptionsButton.AutoSize = true;
            this.advancedIPOptionsButton.BackColor = System.Drawing.Color.Silver;
            this.advancedIPOptionsButton.Location = new System.Drawing.Point(20, 99);
            this.advancedIPOptionsButton.Name = "advancedIPOptionsButton";
            this.advancedIPOptionsButton.Size = new System.Drawing.Size(103, 23);
            this.advancedIPOptionsButton.TabIndex = 45;
            this.advancedIPOptionsButton.Text = "Advanced options";
            this.advancedIPOptionsButton.UseVisualStyleBackColor = false;
            this.advancedIPOptionsButton.Click += new System.EventHandler(this.advancedIPOptionsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(653, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Scent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(639, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ultrasounds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(636, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Amount left:";
            // 
            // pheromoneLeftLabel
            // 
            this.pheromoneLeftLabel.AutoSize = true;
            this.pheromoneLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pheromoneLeftLabel.Location = new System.Drawing.Point(714, 97);
            this.pheromoneLeftLabel.Name = "pheromoneLeftLabel";
            this.pheromoneLeftLabel.Size = new System.Drawing.Size(17, 17);
            this.pheromoneLeftLabel.TabIndex = 50;
            this.pheromoneLeftLabel.Text = "0";
            // 
            // timeSoundLabel
            // 
            this.timeSoundLabel.AutoSize = true;
            this.timeSoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeSoundLabel.Location = new System.Drawing.Point(698, 378);
            this.timeSoundLabel.Name = "timeSoundLabel";
            this.timeSoundLabel.Size = new System.Drawing.Size(32, 16);
            this.timeSoundLabel.TabIndex = 57;
            this.timeSoundLabel.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(662, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Time:";
            // 
            // timeSoundScrollbar
            // 
            this.timeSoundScrollbar.Location = new System.Drawing.Point(611, 401);
            this.timeSoundScrollbar.Maximum = 49;
            this.timeSoundScrollbar.Name = "timeSoundScrollbar";
            this.timeSoundScrollbar.Size = new System.Drawing.Size(150, 17);
            this.timeSoundScrollbar.TabIndex = 55;
            this.timeSoundScrollbar.TabStop = true;
            this.timeSoundScrollbar.ValueChanged += new System.EventHandler(this.timeSoundScrollbar_ValueChanged);
            this.timeSoundScrollbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeSoundScrollbar_KeyDown);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frequencyLabel.Location = new System.Drawing.Point(707, 288);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(32, 16);
            this.frequencyLabel.TabIndex = 54;
            this.frequencyLabel.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(633, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "Frequency:";
            // 
            // frequencyScrollbar
            // 
            this.frequencyScrollbar.LargeChange = 5;
            this.frequencyScrollbar.Location = new System.Drawing.Point(611, 308);
            this.frequencyScrollbar.Maximum = 8;
            this.frequencyScrollbar.Name = "frequencyScrollbar";
            this.frequencyScrollbar.Size = new System.Drawing.Size(150, 17);
            this.frequencyScrollbar.TabIndex = 52;
            this.frequencyScrollbar.TabStop = true;
            this.frequencyScrollbar.ValueChanged += new System.EventHandler(this.frequencyScrollbar_ValueChanged);
            this.frequencyScrollbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frequencyScrollbar_KeyDown);
            // 
            // pheromoneReleaseLabel
            // 
            this.pheromoneReleaseLabel.AutoSize = true;
            this.pheromoneReleaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pheromoneReleaseLabel.Location = new System.Drawing.Point(726, 143);
            this.pheromoneReleaseLabel.Name = "pheromoneReleaseLabel";
            this.pheromoneReleaseLabel.Size = new System.Drawing.Size(32, 16);
            this.pheromoneReleaseLabel.TabIndex = 60;
            this.pheromoneReleaseLabel.Text = "100";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(609, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 16);
            this.label20.TabIndex = 59;
            this.label20.Text = "Amount to release:";
            // 
            // pheromoneReleaseScrollbar
            // 
            this.pheromoneReleaseScrollbar.LargeChange = 5;
            this.pheromoneReleaseScrollbar.Location = new System.Drawing.Point(609, 163);
            this.pheromoneReleaseScrollbar.Maximum = 39;
            this.pheromoneReleaseScrollbar.Name = "pheromoneReleaseScrollbar";
            this.pheromoneReleaseScrollbar.Size = new System.Drawing.Size(150, 17);
            this.pheromoneReleaseScrollbar.TabIndex = 58;
            this.pheromoneReleaseScrollbar.TabStop = true;
            this.pheromoneReleaseScrollbar.ValueChanged += new System.EventHandler(this.pheromoneReleaseScrollbar_ValueChanged);
            this.pheromoneReleaseScrollbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pheromoneReleaseScrollbar_KeyDown);
            // 
            // startExtractingScentButton
            // 
            this.startExtractingScentButton.AutoSize = true;
            this.startExtractingScentButton.BackColor = System.Drawing.Color.Silver;
            this.startExtractingScentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startExtractingScentButton.Location = new System.Drawing.Point(635, 188);
            this.startExtractingScentButton.Name = "startExtractingScentButton";
            this.startExtractingScentButton.Size = new System.Drawing.Size(105, 26);
            this.startExtractingScentButton.TabIndex = 61;
            this.startExtractingScentButton.Text = "Release scent";
            this.startExtractingScentButton.UseVisualStyleBackColor = false;
            this.startExtractingScentButton.Click += new System.EventHandler(this.startExtractingScentButton_Click);
            // 
            // startPlayingSoundButton
            // 
            this.startPlayingSoundButton.AutoSize = true;
            this.startPlayingSoundButton.BackColor = System.Drawing.Color.Silver;
            this.startPlayingSoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPlayingSoundButton.Location = new System.Drawing.Point(613, 332);
            this.startPlayingSoundButton.Name = "startPlayingSoundButton";
            this.startPlayingSoundButton.Size = new System.Drawing.Size(152, 26);
            this.startPlayingSoundButton.TabIndex = 62;
            this.startPlayingSoundButton.Text = "Start continuous sound";
            this.startPlayingSoundButton.UseVisualStyleBackColor = false;
            this.startPlayingSoundButton.Click += new System.EventHandler(this.startPlayingSoundButton_Click);
            // 
            // startImpulseButton
            // 
            this.startImpulseButton.AutoSize = true;
            this.startImpulseButton.BackColor = System.Drawing.Color.Silver;
            this.startImpulseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startImpulseButton.Location = new System.Drawing.Point(625, 424);
            this.startImpulseButton.Name = "startImpulseButton";
            this.startImpulseButton.Size = new System.Drawing.Size(126, 26);
            this.startImpulseButton.TabIndex = 63;
            this.startImpulseButton.Text = "Start impulse";
            this.startImpulseButton.UseVisualStyleBackColor = false;
            this.startImpulseButton.Click += new System.EventHandler(this.startImpulseButton_Click);
            // 
            // timerSound
            // 
            this.timerSound.Tick += new System.EventHandler(this.soundTimer_Tick);
            // 
            // pheromoneProgressBar
            // 
            this.pheromoneProgressBar.Color = System.Drawing.Color.Yellow;
            this.pheromoneProgressBar.Location = new System.Drawing.Point(635, 116);
            this.pheromoneProgressBar.Maximum = 35;
            this.pheromoneProgressBar.Name = "pheromoneProgressBar";
            this.pheromoneProgressBar.Size = new System.Drawing.Size(100, 23);
            this.pheromoneProgressBar.TabIndex = 48;
            this.pheromoneProgressBar.Value = 20;
            // 
            // batteryProgressBar
            // 
            this.batteryProgressBar.Color = System.Drawing.Color.Yellow;
            this.batteryProgressBar.Location = new System.Drawing.Point(386, 160);
            this.batteryProgressBar.Name = "batteryProgressBar";
            this.batteryProgressBar.Size = new System.Drawing.Size(150, 40);
            this.batteryProgressBar.TabIndex = 42;
            this.batteryProgressBar.Value = 100;
            // 
            // FormRat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(785, 477);
            this.Controls.Add(this.startImpulseButton);
            this.Controls.Add(this.startPlayingSoundButton);
            this.Controls.Add(this.startExtractingScentButton);
            this.Controls.Add(this.pheromoneReleaseLabel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pheromoneReleaseScrollbar);
            this.Controls.Add(this.timeSoundLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.timeSoundScrollbar);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.frequencyScrollbar);
            this.Controls.Add(this.pheromoneLeftLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pheromoneProgressBar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.advancedIPOptionsButton);
            this.Controls.Add(this.advancedIPGroupBox);
            this.Controls.Add(this.panicStopButton);
            this.Controls.Add(this.batteryProgressBar);
            this.Controls.Add(this.continueStreamingButton);
            this.Controls.Add(this.saveVideoButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.randomMovingButton);
            this.Controls.Add(this.manualModeButton);
            this.Controls.Add(this.automaticModeButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputUDPTextBox);
            this.Controls.Add(this.angularSpeedLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.angularSpeedHScrollBar);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.tcpConnectionLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTCPTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.advancedIPGroupBox.ResumeLayout(false);
            this.advancedIPGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Timer timer100;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTCPTextBox;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button manualModeButton;
        private System.Windows.Forms.Button randomMovingButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button automaticModeButton;
        private System.Windows.Forms.Button saveVideoButton;
        private System.Windows.Forms.Button continueStreamingButton;
        private ColorfulProgressBar batteryProgressBar;
        private System.Windows.Forms.Button panicStopButton;
        private System.Windows.Forms.GroupBox advancedIPGroupBox;
        private System.Windows.Forms.Button advancedIPOptionsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private ColorfulProgressBar pheromoneProgressBar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label pheromoneLeftLabel;
        private System.Windows.Forms.Button hideAdvancedIPOptionsButton;
        private System.Windows.Forms.Label timeSoundLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.HScrollBar timeSoundScrollbar;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.HScrollBar frequencyScrollbar;
        private System.Windows.Forms.Label pheromoneReleaseLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.HScrollBar pheromoneReleaseScrollbar;
        private System.Windows.Forms.Button startExtractingScentButton;
        private System.Windows.Forms.Button startPlayingSoundButton;
        private System.Windows.Forms.Button startImpulseButton;
        private System.Windows.Forms.Timer timerSound;
    }
}

