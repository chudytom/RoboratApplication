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
            this.SuspendLayout();
            // 
            // pathLayoutPanel
            // 
            this.pathLayoutPanel.AutoScroll = true;
            this.pathLayoutPanel.AutoSize = true;
            this.pathLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pathLayoutPanel.Location = new System.Drawing.Point(22, 84);
            this.pathLayoutPanel.Name = "pathLayoutPanel";
            this.pathLayoutPanel.Size = new System.Drawing.Size(300, 100);
            this.pathLayoutPanel.TabIndex = 0;
            // 
            // addPathElementButton
            // 
            this.addPathElementButton.AutoSize = true;
            this.addPathElementButton.Location = new System.Drawing.Point(339, 97);
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
            this.label2.Location = new System.Drawing.Point(255, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed";
            // 
            // DesignatedPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPathElementButton);
            this.Controls.Add(this.pathLayoutPanel);
            this.Name = "DesignatedPathForm";
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
    }
}