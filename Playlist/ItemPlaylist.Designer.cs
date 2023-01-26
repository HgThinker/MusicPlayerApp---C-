namespace MusicPlayerApp.Playlist
{
    partial class ItemPlaylist
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
            this.SongName = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.Delete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Info = new Guna.UI2.WinForms.Guna2Button();
            this.Heart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.DownLoad = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.Location = new System.Drawing.Point(86, 11);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(200, 17);
            this.SongName.TabIndex = 2;
            this.SongName.Text = "Song name";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.ForeColor = System.Drawing.Color.DimGray;
            this.AuthorName.Location = new System.Drawing.Point(86, 44);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(77, 15);
            this.AuthorName.TabIndex = 2;
            this.AuthorName.Text = "Author name";
            // 
            // Delete
            // 
            this.Delete.Animated = true;
            this.Delete.BorderColor = System.Drawing.Color.Transparent;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.Transparent;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.Delete.Image = global::MusicPlayerApp.Properties.Resources.delete;
            this.Delete.Location = new System.Drawing.Point(419, -1);
            this.Delete.Name = "Delete";
            this.Delete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Delete.Size = new System.Drawing.Size(23, 20);
            this.Delete.TabIndex = 3;
            this.Delete.UseTransparentBackground = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Info
            // 
            this.Info.Animated = true;
            this.Info.AutoRoundedCorners = true;
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.BorderColor = System.Drawing.Color.White;
            this.Info.BorderRadius = 18;
            this.Info.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Info.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Info.FillColor = System.Drawing.Color.Transparent;
            this.Info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Info.ForeColor = System.Drawing.Color.DarkGray;
            this.Info.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Info.HoverState.CustomBorderColor = System.Drawing.Color.Pink;
            this.Info.HoverState.FillColor = System.Drawing.Color.Pink;
            this.Info.HoverState.ForeColor = System.Drawing.Color.White;
            this.Info.Image = global::MusicPlayerApp.Properties.Resources.info;
            this.Info.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Info.ImageSize = new System.Drawing.Size(18, 18);
            this.Info.Location = new System.Drawing.Point(374, 0);
            this.Info.Name = "Info";
            this.Info.PressedColor = System.Drawing.Color.Violet;
            this.Info.Size = new System.Drawing.Size(39, 45);
            this.Info.TabIndex = 1;
            this.Info.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.Info.UseTransparentBackground = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Heart
            // 
            this.Heart.Animated = true;
            this.Heart.AutoRoundedCorners = true;
            this.Heart.BackColor = System.Drawing.Color.Transparent;
            this.Heart.BorderColor = System.Drawing.Color.White;
            this.Heart.BorderRadius = 18;
            this.Heart.CheckedState.Image = global::MusicPlayerApp.Properties.Resources.heart_on;
            this.Heart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Heart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Heart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Heart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Heart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Heart.FillColor = System.Drawing.Color.Transparent;
            this.Heart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Heart.ForeColor = System.Drawing.Color.DarkGray;
            this.Heart.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Heart.HoverState.CustomBorderColor = System.Drawing.Color.Pink;
            this.Heart.HoverState.FillColor = System.Drawing.Color.Pink;
            this.Heart.HoverState.ForeColor = System.Drawing.Color.White;
            this.Heart.HoverState.Image = global::MusicPlayerApp.Properties.Resources.heart_on;
            this.Heart.Image = global::MusicPlayerApp.Properties.Resources.Heart;
            this.Heart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Heart.ImageSize = new System.Drawing.Size(18, 18);
            this.Heart.Location = new System.Drawing.Point(334, 1);
            this.Heart.Name = "Heart";
            this.Heart.PressedColor = System.Drawing.Color.Violet;
            this.Heart.Size = new System.Drawing.Size(39, 45);
            this.Heart.TabIndex = 1;
            this.Heart.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.Heart.UseTransparentBackground = true;
            this.Heart.Click += new System.EventHandler(this.Heart_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.guna2RatingStar1.Location = new System.Drawing.Point(318, 48);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Yellow;
            this.guna2RatingStar1.Size = new System.Drawing.Size(120, 30);
            this.guna2RatingStar1.TabIndex = 4;
            this.guna2RatingStar1.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            // 
            // DownLoad
            // 
            this.DownLoad.Animated = true;
            this.DownLoad.AutoRoundedCorners = true;
            this.DownLoad.BackColor = System.Drawing.Color.Transparent;
            this.DownLoad.BorderColor = System.Drawing.Color.White;
            this.DownLoad.BorderRadius = 18;
            this.DownLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DownLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DownLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DownLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DownLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DownLoad.FillColor = System.Drawing.Color.Transparent;
            this.DownLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.DownLoad.ForeColor = System.Drawing.Color.DarkGray;
            this.DownLoad.HoverState.BorderColor = System.Drawing.Color.Black;
            this.DownLoad.HoverState.CustomBorderColor = System.Drawing.Color.Pink;
            this.DownLoad.HoverState.FillColor = System.Drawing.Color.Pink;
            this.DownLoad.HoverState.ForeColor = System.Drawing.Color.White;
            this.DownLoad.Image = global::MusicPlayerApp.Properties.Resources.download;
            this.DownLoad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DownLoad.ImageSize = new System.Drawing.Size(18, 18);
            this.DownLoad.Location = new System.Drawing.Point(291, 1);
            this.DownLoad.Name = "DownLoad";
            this.DownLoad.PressedColor = System.Drawing.Color.Violet;
            this.DownLoad.Size = new System.Drawing.Size(39, 45);
            this.DownLoad.TabIndex = 1;
            this.DownLoad.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.DownLoad.UseTransparentBackground = true;
            this.DownLoad.Click += new System.EventHandler(this.DownLoad_Click);
            // 
            // ItemPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.DownLoad);
            this.Controls.Add(this.Heart);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "ItemPlaylist";
            this.Size = new System.Drawing.Size(440, 80);
            this.Load += new System.EventHandler(this.ItemPlaylist_Load);
            this.MouseLeave += new System.EventHandler(this.ItemPlaylist_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ItemPlaylist_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label AuthorName;
        private Guna.UI2.WinForms.Guna2Button Heart;
        private Guna.UI2.WinForms.Guna2CircleButton Delete;
        private Guna.UI2.WinForms.Guna2Button Info;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2Button DownLoad;
    }
}
