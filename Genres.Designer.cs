namespace MusicPlayerApp
{
    partial class Genres
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
            this.GenresFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // GenresFlowLayoutPanel
            // 
            this.GenresFlowLayoutPanel.AutoScroll = true;
            this.GenresFlowLayoutPanel.AutoSize = true;
            this.GenresFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenresFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenresFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.GenresFlowLayoutPanel.Name = "GenresFlowLayoutPanel";
            this.GenresFlowLayoutPanel.Size = new System.Drawing.Size(635, 348);
            this.GenresFlowLayoutPanel.TabIndex = 1;
            this.GenresFlowLayoutPanel.TabStop = true;
            // 
            // Genres
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(635, 348);
            this.Controls.Add(this.GenresFlowLayoutPanel);
            this.Name = "Genres";
            this.Shown += new System.EventHandler(this.Genres_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GenresFlowLayoutPanel;
    }
}