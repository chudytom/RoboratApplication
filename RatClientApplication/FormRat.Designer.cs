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
            this.designatedPathModeButton = new System.Windows.Forms.Button();
            this.outgoingJsonTextBox = new System.Windows.Forms.TextBox();
            this.incomingJsonTextBox = new System.Windows.Forms.TextBox();
            this.incomingJsonLabel = new System.Windows.Forms.Label();
            this.outgoingJsonLabel = new System.Windows.Forms.Label();
            this.jsonGroupBox = new System.Windows.Forms.GroupBox();
            this.pheromoneProgressBar = new RatClientApplication.ColorfulProgressBar();
            this.batteryProgressBar = new RatClientApplication.ColorfulProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.advancedIPGroupBox.SuspendLayout();
            this.jsonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // upBox
            // 
            this.upBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.upBox.Location = new System.Drawing.Point(588, 274);
            this.upBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upBox.MinimumSize = new System.Drawing.Size(40, 12);
            this.upBox.Name = "upBox";
            this.upBox.Size = new System.Drawing.Size(53, 25);
            this.upBox.TabIndex = 0;
            // 
            // rightBox
            // 
            this.rightBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.rightBox.Location = new System.Drawing.Point(652, 306);
            this.rightBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightBox.MinimumSize = new System.Drawing.Size(40, 12);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(53, 25);
            this.rightBox.TabIndex = 1;
            // 
            // leftBox
            // 
            this.leftBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.leftBox.Location = new System.Drawing.Point(524, 306);
            this.leftBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftBox.MinimumSize = new System.Drawing.Size(40, 12);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(53, 25);
            this.leftBox.TabIndex = 2;
            // 
            // downBox
            // 
            this.downBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.downBox.Location = new System.Drawing.Point(588, 306);
            this.downBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downBox.MinimumSize = new System.Drawing.Size(40, 12);
            this.downBox.Name = "downBox";
            this.downBox.Size = new System.Drawing.Size(53, 25);
            this.downBox.TabIndex = 3;
            // 
            // linearSpeedHScrollBar
            // 
            this.linearSpeedHScrollBar.Location = new System.Drawing.Point(449, 459);
            this.linearSpeedHScrollBar.Maximum = 259;
            this.linearSpeedHScrollBar.Minimum = 1;
            this.linearSpeedHScrollBar.Name = "linearSpeedHScrollBar";
            this.linearSpeedHScrollBar.Size = new System.Drawing.Size(324, 17);
            this.linearSpeedHScrollBar.SmallChange = 2;
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
            this.speedLabel2.Location = new System.Drawing.Point(528, 434);
            this.speedLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speedLabel2.Name = "speedLabel2";
            this.speedLabel2.Size = new System.Drawing.Size(113, 20);
            this.speedLabel2.TabIndex = 5;
            this.speedLabel2.Text = "Linear Speed:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(541, 362);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(113, 20);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Speed Ahead:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(541, 390);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(119, 20);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Speed Around:";
            // 
            // linearSpeedLabel2
            // 
            this.linearSpeedLabel2.AutoSize = true;
            this.linearSpeedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel2.Location = new System.Drawing.Point(676, 361);
            this.linearSpeedLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linearSpeedLabel2.Name = "linearSpeedLabel2";
            this.linearSpeedLabel2.Size = new System.Drawing.Size(19, 20);
            this.linearSpeedLabel2.TabIndex = 8;
            this.linearSpeedLabel2.Text = "0";
            // 
            // angularSpeedLabel2
            // 
            this.angularSpeedLabel2.AutoSize = true;
            this.angularSpeedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angularSpeedLabel2.Location = new System.Drawing.Point(676, 389);
            this.angularSpeedLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.angularSpeedLabel2.Name = "angularSpeedLabel2";
            this.angularSpeedLabel2.Size = new System.Drawing.Size(19, 20);
            this.angularSpeedLabel2.TabIndex = 9;
            this.angularSpeedLabel2.Text = "0";
            // 
            // linearSpeedLabel1
            // 
            this.linearSpeedLabel1.AutoSize = true;
            this.linearSpeedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSpeedLabel1.Location = new System.Drawing.Point(661, 434);
            this.linearSpeedLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linearSpeedLabel1.Name = "linearSpeedLabel1";
            this.linearSpeedLabel1.Size = new System.Drawing.Size(39, 20);
            this.linearSpeedLabel1.TabIndex = 10;
            this.linearSpeedLabel1.Text = "100";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Silver;
            this.connectButton.Enabled = false;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(39, 81);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(113, 37);
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
            this.label3.Location = new System.Drawing.Point(215, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Connection messages";
            // 
            // outputTCPTextBox
            // 
            this.outputTCPTextBox.Location = new System.Drawing.Point(200, 43);
            this.outputTCPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputTCPTextBox.Multiline = true;
            this.outputTCPTextBox.Name = "outputTCPTextBox";
            this.outputTCPTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTCPTextBox.Size = new System.Drawing.Size(199, 91);
            this.outputTCPTextBox.TabIndex = 16;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.Location = new System.Drawing.Point(245, 140);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 28);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear the box";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Port:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(57, 55);
            this.ipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(132, 22);
            this.ipTextBox.TabIndex = 21;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(57, 23);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(132, 22);
            this.portTextBox.TabIndex = 22;
            // 
            // setIPButton
            // 
            this.setIPButton.BackColor = System.Drawing.Color.Silver;
            this.setIPButton.Location = new System.Drawing.Point(123, 85);
            this.setIPButton.Margin = new System.Windows.Forms.Padding(4);
            this.setIPButton.Name = "setIPButton";
            this.setIPButton.Size = new System.Drawing.Size(68, 28);
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
            this.label8.Location = new System.Drawing.Point(8, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Remote Connection";
            // 
            // tcpConnectionLabel
            // 
            this.tcpConnectionLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.tcpConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcpConnectionLabel.Location = new System.Drawing.Point(68, 38);
            this.tcpConnectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcpConnectionLabel.MinimumSize = new System.Drawing.Size(40, 12);
            this.tcpConnectionLabel.Name = "tcpConnectionLabel";
            this.tcpConnectionLabel.Size = new System.Drawing.Size(53, 37);
            this.tcpConnectionLabel.TabIndex = 27;
            this.tcpConnectionLabel.Text = "OFF";
            this.tcpConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Silver;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(45, 124);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(100, 28);
            this.disconnectButton.TabIndex = 28;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // angularSpeedHScrollBar
            // 
            this.angularSpeedHScrollBar.Location = new System.Drawing.Point(449, 522);
            this.angularSpeedHScrollBar.Maximum = 49;
            this.angularSpeedHScrollBar.Minimum = 1;
            this.angularSpeedHScrollBar.Name = "angularSpeedHScrollBar";
            this.angularSpeedHScrollBar.Size = new System.Drawing.Size(324, 17);
            this.angularSpeedHScrollBar.TabIndex = 29;
            this.angularSpeedHScrollBar.TabStop = true;
            this.angularSpeedHScrollBar.Value = 49;
            this.angularSpeedHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.angularSpeedHScrollBar_Scroll);
            this.angularSpeedHScrollBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.angularSpeedHScrollBar_KeyDown);
            // 
            // angularSpeedLabel1
            // 
            this.angularSpeedLabel1.AutoSize = true;
            this.angularSpeedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angularSpeedLabel1.Location = new System.Drawing.Point(661, 494);
            this.angularSpeedLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.angularSpeedLabel1.Name = "angularSpeedLabel1";
            this.angularSpeedLabel1.Size = new System.Drawing.Size(39, 20);
            this.angularSpeedLabel1.TabIndex = 31;
            this.angularSpeedLabel1.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(524, 494);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rotation Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(41, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Video stream messages";
            // 
            // outputUDPTextBox
            // 
            this.outputUDPTextBox.Location = new System.Drawing.Point(33, 228);
            this.outputUDPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputUDPTextBox.Multiline = true;
            this.outputUDPTextBox.Name = "outputUDPTextBox";
            this.outputUDPTextBox.Size = new System.Drawing.Size(199, 91);
            this.outputUDPTextBox.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(9, 363);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 215);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(157, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Video Stream";
            // 
            // automaticModeButton
            // 
            this.automaticModeButton.Location = new System.Drawing.Point(424, 50);
            this.automaticModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.automaticModeButton.Name = "automaticModeButton";
            this.automaticModeButton.Size = new System.Drawing.Size(133, 37);
            this.automaticModeButton.TabIndex = 36;
            this.automaticModeButton.TabStop = false;
            this.automaticModeButton.Text = "Automatic mode";
            this.automaticModeButton.UseVisualStyleBackColor = true;
            this.automaticModeButton.Click += new System.EventHandler(this.automaticModeButton_Click);
            // 
            // manualModeButton
            // 
            this.manualModeButton.Location = new System.Drawing.Point(424, 10);
            this.manualModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.manualModeButton.Name = "manualModeButton";
            this.manualModeButton.Size = new System.Drawing.Size(133, 37);
            this.manualModeButton.TabIndex = 37;
            this.manualModeButton.Text = "Manual mode";
            this.manualModeButton.UseVisualStyleBackColor = true;
            this.manualModeButton.Click += new System.EventHandler(this.manualModeButton_Click);
            // 
            // randomMovingButton
            // 
            this.randomMovingButton.Location = new System.Drawing.Point(424, 92);
            this.randomMovingButton.Margin = new System.Windows.Forms.Padding(4);
            this.randomMovingButton.Name = "randomMovingButton";
            this.randomMovingButton.Size = new System.Drawing.Size(133, 37);
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
            this.label11.Location = new System.Drawing.Point(552, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Battery Level";
            // 
            // saveVideoButton
            // 
            this.saveVideoButton.BackColor = System.Drawing.Color.Silver;
            this.saveVideoButton.Location = new System.Drawing.Point(305, 325);
            this.saveVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveVideoButton.Name = "saveVideoButton";
            this.saveVideoButton.Size = new System.Drawing.Size(100, 28);
            this.saveVideoButton.TabIndex = 40;
            this.saveVideoButton.Text = "Save frames";
            this.saveVideoButton.UseVisualStyleBackColor = false;
            this.saveVideoButton.Click += new System.EventHandler(this.saveVideoButton_Click);
            // 
            // continueStreamingButton
            // 
            this.continueStreamingButton.BackColor = System.Drawing.Color.Silver;
            this.continueStreamingButton.Location = new System.Drawing.Point(11, 325);
            this.continueStreamingButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueStreamingButton.Name = "continueStreamingButton";
            this.continueStreamingButton.Size = new System.Drawing.Size(139, 28);
            this.continueStreamingButton.TabIndex = 41;
            this.continueStreamingButton.Text = "Stop streaming";
            this.continueStreamingButton.UseVisualStyleBackColor = false;
            this.continueStreamingButton.Click += new System.EventHandler(this.continueStreamingButton_Click);
            // 
            // panicStopButton
            // 
            this.panicStopButton.BackColor = System.Drawing.Color.Red;
            this.panicStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panicStopButton.Location = new System.Drawing.Point(275, 197);
            this.panicStopButton.Margin = new System.Windows.Forms.Padding(4);
            this.panicStopButton.Name = "panicStopButton";
            this.panicStopButton.Size = new System.Drawing.Size(192, 114);
            this.panicStopButton.TabIndex = 43;
            this.panicStopButton.Text = "Emergency Stop";
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
            this.advancedIPGroupBox.Location = new System.Drawing.Point(583, 22);
            this.advancedIPGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.advancedIPGroupBox.Name = "advancedIPGroupBox";
            this.advancedIPGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.advancedIPGroupBox.Size = new System.Drawing.Size(211, 123);
            this.advancedIPGroupBox.TabIndex = 44;
            this.advancedIPGroupBox.TabStop = false;
            this.advancedIPGroupBox.Text = "Advanced IP options";
            this.advancedIPGroupBox.Visible = false;
            // 
            // hideAdvancedIPOptionsButton
            // 
            this.hideAdvancedIPOptionsButton.BackColor = System.Drawing.Color.Silver;
            this.hideAdvancedIPOptionsButton.Location = new System.Drawing.Point(8, 85);
            this.hideAdvancedIPOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.hideAdvancedIPOptionsButton.Name = "hideAdvancedIPOptionsButton";
            this.hideAdvancedIPOptionsButton.Size = new System.Drawing.Size(107, 28);
            this.hideAdvancedIPOptionsButton.TabIndex = 24;
            this.hideAdvancedIPOptionsButton.Text = "Hide options";
            this.hideAdvancedIPOptionsButton.UseVisualStyleBackColor = false;
            this.hideAdvancedIPOptionsButton.Click += new System.EventHandler(this.hideAdvancedIPOptionsButton_Click);
            // 
            // advancedIPOptionsButton
            // 
            this.advancedIPOptionsButton.AutoSize = true;
            this.advancedIPOptionsButton.BackColor = System.Drawing.Color.Silver;
            this.advancedIPOptionsButton.Location = new System.Drawing.Point(27, 158);
            this.advancedIPOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.advancedIPOptionsButton.Name = "advancedIPOptionsButton";
            this.advancedIPOptionsButton.Size = new System.Drawing.Size(139, 28);
            this.advancedIPOptionsButton.TabIndex = 45;
            this.advancedIPOptionsButton.Text = "Advanced options";
            this.advancedIPOptionsButton.UseVisualStyleBackColor = false;
            this.advancedIPOptionsButton.Click += new System.EventHandler(this.advancedIPOptionsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(871, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Scent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(852, 325);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ultrasounds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(848, 163);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Amount left:";
            // 
            // pheromoneLeftLabel
            // 
            this.pheromoneLeftLabel.AutoSize = true;
            this.pheromoneLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pheromoneLeftLabel.Location = new System.Drawing.Point(952, 163);
            this.pheromoneLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pheromoneLeftLabel.Name = "pheromoneLeftLabel";
            this.pheromoneLeftLabel.Size = new System.Drawing.Size(19, 20);
            this.pheromoneLeftLabel.TabIndex = 50;
            this.pheromoneLeftLabel.Text = "0";
            // 
            // timeSoundLabel
            // 
            this.timeSoundLabel.AutoSize = true;
            this.timeSoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeSoundLabel.Location = new System.Drawing.Point(931, 465);
            this.timeSoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeSoundLabel.Name = "timeSoundLabel";
            this.timeSoundLabel.Size = new System.Drawing.Size(39, 20);
            this.timeSoundLabel.TabIndex = 57;
            this.timeSoundLabel.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(883, 465);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 56;
            this.label16.Text = "Time:";
            // 
            // timeSoundScrollbar
            // 
            this.timeSoundScrollbar.Location = new System.Drawing.Point(815, 494);
            this.timeSoundScrollbar.Maximum = 49;
            this.timeSoundScrollbar.Name = "timeSoundScrollbar";
            this.timeSoundScrollbar.Size = new System.Drawing.Size(200, 17);
            this.timeSoundScrollbar.TabIndex = 55;
            this.timeSoundScrollbar.TabStop = true;
            this.timeSoundScrollbar.ValueChanged += new System.EventHandler(this.timeSoundScrollbar_ValueChanged);
            this.timeSoundScrollbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeSoundScrollbar_KeyDown);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frequencyLabel.Location = new System.Drawing.Point(943, 354);
            this.frequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(39, 20);
            this.frequencyLabel.TabIndex = 54;
            this.frequencyLabel.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(844, 354);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "Frequency:";
            // 
            // frequencyScrollbar
            // 
            this.frequencyScrollbar.LargeChange = 5;
            this.frequencyScrollbar.Location = new System.Drawing.Point(815, 379);
            this.frequencyScrollbar.Maximum = 8;
            this.frequencyScrollbar.Name = "frequencyScrollbar";
            this.frequencyScrollbar.Size = new System.Drawing.Size(200, 17);
            this.frequencyScrollbar.TabIndex = 52;
            this.frequencyScrollbar.TabStop = true;
            this.frequencyScrollbar.ValueChanged += new System.EventHandler(this.frequencyScrollbar_ValueChanged);
            this.frequencyScrollbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frequencyScrollbar_KeyDown);
            // 
            // pheromoneReleaseLabel
            // 
            this.pheromoneReleaseLabel.AutoSize = true;
            this.pheromoneReleaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pheromoneReleaseLabel.Location = new System.Drawing.Point(968, 220);
            this.pheromoneReleaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pheromoneReleaseLabel.Name = "pheromoneReleaseLabel";
            this.pheromoneReleaseLabel.Size = new System.Drawing.Size(39, 20);
            this.pheromoneReleaseLabel.TabIndex = 60;
            this.pheromoneReleaseLabel.Text = "100";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(812, 220);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 20);
            this.label20.TabIndex = 59;
            this.label20.Text = "Amount to release:";
            // 
            // pheromoneReleaseScrollbar
            // 
            this.pheromoneReleaseScrollbar.LargeChange = 5;
            this.pheromoneReleaseScrollbar.Location = new System.Drawing.Point(812, 245);
            this.pheromoneReleaseScrollbar.Maximum = 25;
            this.pheromoneReleaseScrollbar.Name = "pheromoneReleaseScrollbar";
            this.pheromoneReleaseScrollbar.Size = new System.Drawing.Size(200, 17);
            this.pheromoneReleaseScrollbar.TabIndex = 58;
            this.pheromoneReleaseScrollbar.TabStop = true;
            this.pheromoneReleaseScrollbar.Value = 21;
            this.pheromoneReleaseScrollbar.ValueChanged += new System.EventHandler(this.pheromoneReleaseScrollbar_ValueChanged);
            this.pheromoneReleaseScrollbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pheromoneReleaseScrollbar_KeyDown);
            // 
            // startExtractingScentButton
            // 
            this.startExtractingScentButton.AutoSize = true;
            this.startExtractingScentButton.BackColor = System.Drawing.Color.Silver;
            this.startExtractingScentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startExtractingScentButton.Location = new System.Drawing.Point(847, 275);
            this.startExtractingScentButton.Margin = new System.Windows.Forms.Padding(4);
            this.startExtractingScentButton.Name = "startExtractingScentButton";
            this.startExtractingScentButton.Size = new System.Drawing.Size(140, 32);
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
            this.startPlayingSoundButton.Location = new System.Drawing.Point(817, 409);
            this.startPlayingSoundButton.Margin = new System.Windows.Forms.Padding(4);
            this.startPlayingSoundButton.Name = "startPlayingSoundButton";
            this.startPlayingSoundButton.Size = new System.Drawing.Size(203, 32);
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
            this.startImpulseButton.Location = new System.Drawing.Point(833, 522);
            this.startImpulseButton.Margin = new System.Windows.Forms.Padding(4);
            this.startImpulseButton.Name = "startImpulseButton";
            this.startImpulseButton.Size = new System.Drawing.Size(168, 32);
            this.startImpulseButton.TabIndex = 63;
            this.startImpulseButton.Text = "Start impulse";
            this.startImpulseButton.UseVisualStyleBackColor = false;
            this.startImpulseButton.Click += new System.EventHandler(this.startImpulseButton_Click);
            // 
            // timerSound
            // 
            this.timerSound.Tick += new System.EventHandler(this.soundTimer_Tick);
            // 
            // designatedPathModeButton
            // 
            this.designatedPathModeButton.Location = new System.Drawing.Point(424, 133);
            this.designatedPathModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.designatedPathModeButton.Name = "designatedPathModeButton";
            this.designatedPathModeButton.Size = new System.Drawing.Size(133, 37);
            this.designatedPathModeButton.TabIndex = 64;
            this.designatedPathModeButton.TabStop = false;
            this.designatedPathModeButton.Text = "Designated path";
            this.designatedPathModeButton.UseVisualStyleBackColor = true;
            this.designatedPathModeButton.Click += new System.EventHandler(this.designatedPathModeButton_Click);
            // 
            // outgoingJsonTextBox
            // 
            this.outgoingJsonTextBox.Location = new System.Drawing.Point(224, 53);
            this.outgoingJsonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outgoingJsonTextBox.Multiline = true;
            this.outgoingJsonTextBox.Name = "outgoingJsonTextBox";
            this.outgoingJsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outgoingJsonTextBox.Size = new System.Drawing.Size(199, 91);
            this.outgoingJsonTextBox.TabIndex = 66;
            // 
            // incomingJsonTextBox
            // 
            this.incomingJsonTextBox.Location = new System.Drawing.Point(6, 53);
            this.incomingJsonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.incomingJsonTextBox.Multiline = true;
            this.incomingJsonTextBox.Name = "incomingJsonTextBox";
            this.incomingJsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.incomingJsonTextBox.Size = new System.Drawing.Size(199, 91);
            this.incomingJsonTextBox.TabIndex = 67;
            // 
            // incomingJsonLabel
            // 
            this.incomingJsonLabel.AutoSize = true;
            this.incomingJsonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incomingJsonLabel.Location = new System.Drawing.Point(34, 27);
            this.incomingJsonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomingJsonLabel.Name = "incomingJsonLabel";
            this.incomingJsonLabel.Size = new System.Drawing.Size(113, 18);
            this.incomingJsonLabel.TabIndex = 67;
            this.incomingJsonLabel.Text = "Incoming JSON";
            // 
            // outgoingJsonLabel
            // 
            this.outgoingJsonLabel.AutoSize = true;
            this.outgoingJsonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outgoingJsonLabel.Location = new System.Drawing.Point(255, 26);
            this.outgoingJsonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outgoingJsonLabel.Name = "outgoingJsonLabel";
            this.outgoingJsonLabel.Size = new System.Drawing.Size(113, 18);
            this.outgoingJsonLabel.TabIndex = 68;
            this.outgoingJsonLabel.Text = "Outgoing JSON";
            // 
            // jsonGroupBox
            // 
            this.jsonGroupBox.Controls.Add(this.incomingJsonTextBox);
            this.jsonGroupBox.Controls.Add(this.incomingJsonLabel);
            this.jsonGroupBox.Controls.Add(this.outgoingJsonLabel);
            this.jsonGroupBox.Controls.Add(this.outgoingJsonTextBox);
            this.jsonGroupBox.Location = new System.Drawing.Point(599, 5);
            this.jsonGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.jsonGroupBox.Name = "jsonGroupBox";
            this.jsonGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.jsonGroupBox.Size = new System.Drawing.Size(431, 155);
            this.jsonGroupBox.TabIndex = 45;
            this.jsonGroupBox.TabStop = false;
            this.jsonGroupBox.Text = "JSON messages";
            this.jsonGroupBox.Visible = false;
            // 
            // pheromoneProgressBar
            // 
            this.pheromoneProgressBar.Color = System.Drawing.Color.Yellow;
            this.pheromoneProgressBar.Location = new System.Drawing.Point(847, 187);
            this.pheromoneProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.pheromoneProgressBar.Maximum = 21;
            this.pheromoneProgressBar.Name = "pheromoneProgressBar";
            this.pheromoneProgressBar.Size = new System.Drawing.Size(133, 28);
            this.pheromoneProgressBar.TabIndex = 48;
            // 
            // batteryProgressBar
            // 
            this.batteryProgressBar.Color = System.Drawing.Color.Yellow;
            this.batteryProgressBar.Location = new System.Drawing.Point(515, 209);
            this.batteryProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.batteryProgressBar.Name = "batteryProgressBar";
            this.batteryProgressBar.Size = new System.Drawing.Size(200, 49);
            this.batteryProgressBar.TabIndex = 42;
            // 
            // FormRat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 587);
            this.Controls.Add(this.jsonGroupBox);
            this.Controls.Add(this.designatedPathModeButton);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.jsonGroupBox.ResumeLayout(false);
            this.jsonGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button designatedPathModeButton;
        private System.Windows.Forms.TextBox incomingJsonTextBox;
        private System.Windows.Forms.TextBox outgoingJsonTextBox;
        private System.Windows.Forms.Label incomingJsonLabel;
        private System.Windows.Forms.Label outgoingJsonLabel;
        private System.Windows.Forms.GroupBox jsonGroupBox;
    }
}

