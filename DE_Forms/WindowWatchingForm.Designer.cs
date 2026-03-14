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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.find_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.findText_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel_flowLayoutPanel
            // 
            this.MainPanel_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel_flowLayoutPanel.AutoScroll = true;
            this.MainPanel_flowLayoutPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.MainPanel_flowLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.MainPanel_flowLayoutPanel.Name = "MainPanel_flowLayoutPanel";
            this.MainPanel_flowLayoutPanel.Size = new System.Drawing.Size(800, 424);
            this.MainPanel_flowLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find_toolStripLabel,
            this.findText_toolStripTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // find_toolStripLabel
            // 
            this.find_toolStripLabel.Name = "find_toolStripLabel";
            this.find_toolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.find_toolStripLabel.Text = "Поиск";
            // 
            // findText_toolStripTextBox
            // 
            this.findText_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findText_toolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findText_toolStripTextBox.Name = "findText_toolStripTextBox";
            this.findText_toolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.findText_toolStripTextBox.TextChanged += new System.EventHandler(this.findText_toolStripTextBox_TextChanged);
            // 
            // WindowWatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainPanel_flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowWatchingForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно просмотра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowWatchingForm_FormClosing);
            this.Load += new System.EventHandler(this.WindowWatchingForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel_flowLayoutPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel find_toolStripLabel;
        private System.Windows.Forms.ToolStripTextBox findText_toolStripTextBox;
    }
}