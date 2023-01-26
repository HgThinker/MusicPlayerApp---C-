namespace MusicPlayerApp
{
    partial class RecentPlayed
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
            this.RecentPlayedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // RecentPlayedflowLayoutPanel
            // 
            this.RecentPlayedflowLayoutPanel.AutoScroll = true;
            this.RecentPlayedflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentPlayedflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RecentPlayedflowLayoutPanel.Name = "RecentPlayedflowLayoutPanel";
            this.RecentPlayedflowLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.RecentPlayedflowLayoutPanel.TabIndex = 2;
            // 
            // RecentPlayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecentPlayedflowLayoutPanel);
            this.Name = "RecentPlayed";
            this.Text = "RecentPlayed";
            this.Shown += new System.EventHandler(this.RecentPlayed_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RecentPlayedflowLayoutPanel;
    }
}