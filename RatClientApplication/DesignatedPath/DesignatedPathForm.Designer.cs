namespace RatClientApplication.DesignatedPath
{
    partial class DesignatedPathForm
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
            this.pathLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addPathElementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.executePathButton = new System.Windows.Forms.Button();
            this.savePathButton = new System.Windows.Forms.Button();
            this.loadPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathLayoutPanel
            // 
            this.pathLayoutPanel.AutoSize = true;
            this.pathLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pathLayoutPanel.Location = new System.Drawing.Point(22, 84);
            this.pathLayoutPanel.Name = "pathLayoutPanel";
            this.pathLayoutPanel.Size = new System.Drawing.Size(350, 100);
            this.pathLayoutPanel.TabIndex = 0;
            // 
            // addPathElementButton
            // 
            this.addPathElementButton.AutoSize = true;
            this.addPathElementButton.Location = new System.Drawing.Point(388, 107);
            this.addPathElementButton.Name = "addPathElementButton";
            this.addPathElementButton.Size = new System.Drawing.Size(129, 27);
            this.addPathElementButton.TabIndex = 1;
            this.addPathElementButton.Text = "Add path element";
            this.addPathElementButton.UseVisualStyleBackColor = true;
            this.addPathElementButton.Click += new System.EventHandler(this.addPathElementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Direction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed";
            // 
            // executePathButton
            // 
            this.executePathButton.AutoSize = true;
            this.executePathButton.Location = new System.Drawing.Point(388, 166);
            this.executePathButton.Name = "executePathButton";
            this.executePathButton.Size = new System.Drawing.Size(129, 27);
            this.executePathButton.TabIndex = 5;
            this.executePathButton.Text = "Execute path";
            this.executePathButton.UseVisualStyleBackColor = true;
            this.executePathButton.Click += new System.EventHandler(this.executePathButton_Click);
            // 
            // savePathButton
            // 
            this.savePathButton.AutoSize = true;
            this.savePathButton.Location = new System.Drawing.Point(388, 226);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(129, 27);
            this.savePathButton.TabIndex = 6;
            this.savePathButton.Text = "Save path";
            this.savePathButton.UseVisualStyleBackColor = true;
            this.savePathButton.Click += new System.EventHandler(this.savePathButton_Click);
            // 
            // loadPathButton
            // 
            this.loadPathButton.AutoSize = true;
            this.loadPathButton.Location = new System.Drawing.Point(388, 291);
            this.loadPathButton.Name = "loadPathButton";
            this.loadPathButton.Size = new System.Drawing.Size(129, 27);
            this.loadPathButton.TabIndex = 7;
            this.loadPathButton.Text = " Load path";
            this.loadPathButton.UseVisualStyleBackColor = true;
            this.loadPathButton.Click += new System.EventHandler(this.loadPathButton_Click);
            // 
            // DesignatedPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.loadPathButton);
            this.Controls.Add(this.savePathButton);
            this.Controls.Add(this.executePathButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPathElementButton);
            this.Controls.Add(this.pathLayoutPanel);
            this.Name = "DesignatedPathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DesignatedPathForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pathLayoutPanel;
        private System.Windows.Forms.Button addPathElementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button executePathButton;
        private System.Windows.Forms.Button savePathButton;
        private System.Windows.Forms.Button loadPathButton;
    }
}