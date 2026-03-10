namespace DE_Forms
{
    partial class WindowWatchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowWatchingForm));
            this.MainPanel_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MainPanel_flowLayoutPanel
            // 
            this.MainPanel_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel_flowLayoutPanel.Name = "MainPanel_flowLayoutPanel";
            this.MainPanel_flowLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel_flowLayoutPanel.TabIndex = 0;
            // 
            // WindowWatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel_flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowWatchingForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно просмотра";
            this.Load += new System.EventHandler(this.WindowWatchingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel_flowLayoutPanel;
    }
}