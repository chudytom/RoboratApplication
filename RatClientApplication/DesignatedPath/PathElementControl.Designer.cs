namespace RatClientApplication.DesignatedPath
{
    partial class PathElementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.speedNumeric = new System.Windows.Forms.NumericUpDown();
            this.timeNumeric = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // directionComboBox
            // 
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(23, 6);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(121, 24);
            this.directionComboBox.TabIndex = 0;
            this.directionComboBox.SelectedIndexChanged += new System.EventHandler(this.directionComboBox_SelectedIndexChanged);
            // 
            // speedNumeric
            // 
            this.speedNumeric.Location = new System.Drawing.Point(159, 8);
            this.speedNumeric.Name = "speedNumeric";
            this.speedNumeric.Size = new System.Drawing.Size(54, 22);
            this.speedNumeric.TabIndex = 1;
            this.speedNumeric.ValueChanged += new System.EventHandler(this.speedNumeric_ValueChanged);
            // 
            // timeNumeric
            // 
            this.timeNumeric.Location = new System.Drawing.Point(228, 8);
            this.timeNumeric.Name = "timeNumeric";
            this.timeNumeric.Size = new System.Drawing.Size(54, 22);
            this.timeNumeric.TabIndex = 2;
            this.timeNumeric.ValueChanged += new System.EventHandler(this.timeNumeric_ValueChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::RatClientApplication.Properties.Resources.delete;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(297, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "\r\n";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PathElementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.timeNumeric);
            this.Controls.Add(this.speedNumeric);
            this.Controls.Add(this.directionComboBox);
            this.Name = "PathElementControl";
            this.Size = new System.Drawing.Size(350, 40);
            ((System.ComponentModel.ISupportInitialize)(this.speedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.NumericUpDown speedNumeric;
        private System.Windows.Forms.NumericUpDown timeNumeric;
        private System.Windows.Forms.Button deleteButton;
    }
}
