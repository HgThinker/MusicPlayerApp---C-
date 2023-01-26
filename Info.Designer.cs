namespace MusicPlayerApp
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Comment = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.itemPlaylist1 = new MusicPlayerApp.Playlist.ItemPlaylist();
            this.Exit = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Animated = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BorderColor = System.Drawing.Color.Black;
            this.Search.BorderRadius = 20;
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.DefaultText = "";
            this.Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search.IconLeft = global::MusicPlayerApp.Properties.Resources.messenger;
            this.Search.Location = new System.Drawing.Point(4, 507);
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.PlaceholderText = "Comment";
            this.Search.SelectedText = "";
            this.Search.Size = new System.Drawing.Size(451, 36);
            this.Search.TabIndex = 6;
            this.Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.AutoScroll = true;
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.BorderThickness = 3;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(456, 47);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(241, 496);
            this.guna2TextBox2.TabIndex = 2;
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.Color.Transparent;
            this.Comment.BorderColor = System.Drawing.Color.Black;
            this.Comment.BorderThickness = 1;
            this.Comment.Location = new System.Drawing.Point(0, 79);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(455, 405);
            this.Comment.TabIndex = 7;
            this.Comment.Paint += new System.Windows.Forms.PaintEventHandler(this.Comment_Paint);
            // 
            // itemPlaylist1
            // 
            this.itemPlaylist1.AuthorNameText = "Author name";
            this.itemPlaylist1.BackColor = System.Drawing.Color.Transparent;
            this.itemPlaylist1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPlaylist1.ImageChange = null;
            this.itemPlaylist1.Location = new System.Drawing.Point(1, 1);
            this.itemPlaylist1.Name = "itemPlaylist1";
            this.itemPlaylist1.PlayListIDChange = "";
            this.itemPlaylist1.RateChange = 0F;
            this.itemPlaylist1.Size = new System.Drawing.Size(454, 80);
            this.itemPlaylist1.SongNameText = "Song name";
            this.itemPlaylist1.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.Image = global::MusicPlayerApp.Properties.Resources.delete;
            this.Exit.ImageRotate = 0F;
            this.Exit.Location = new System.Drawing.Point(659, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 40);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 543);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.itemPlaylist1);
            this.Controls.Add(this.guna2TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Playlist.ItemPlaylist itemPlaylist1;
        private Guna.UI2.WinForms.Guna2TextBox Search;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Comment;
        private Guna.UI2.WinForms.Guna2PictureBox Exit;
    }
}