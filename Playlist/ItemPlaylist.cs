using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp.Playlist
{
    public partial class ItemPlaylist : UserControl
    {
        public string PlayListID="";
        public Info info;
        public ItemPlaylist()
        {
            InitializeComponent();
        }

        public string SongNameText
        {
            get { return this.SongName.Text; }
            set { this.SongName.Text = value; }
        }
        public string AuthorNameText
        {
            get { return this.AuthorName.Text;}
            set { this.AuthorName.Text = value;}
        }
        public string PlayListIDChange
        {
            get { return PlayListID; }
            set { PlayListID = value; }
        }
        public Image ImageChange
        {
            get { return this.guna2PictureBox1.Image; }
            set { this.guna2PictureBox1.Image = value; }
        }
        public float RateChange
        {
            get { return this.guna2RatingStar1.Value; }
            set { this.guna2RatingStar1.Value = value; }
        }

        public Guna2Button GetInfoButton() 
        {
            return this.Info;
        }

        private void ItemPlaylist_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ItemPlaylist_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }
        public Guna.UI2.WinForms.Guna2CircleButton GetDelete_button()
        {
            return this.Delete;
        }
        
        public Guna.UI2.WinForms.Guna2Button GetHeart()
        {
            return this.Heart;
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            DataRow dr = Player.data.Rows.Find(this.PlayListID);
            DataRow history_row = Player.History.Rows.Find(this.PlayListID);
            if(history_row != null)
            {
                history_row["Rate"] = this.guna2RatingStar1.Value;
            }
            dr["Rate"] = this.guna2RatingStar1.Value;
        }

        public void Info_Click(object sender, EventArgs e)
        {
            Player.SelectedItemPlaylist= this;
            DataRow dr = Player.data.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
            if(dr.Field<Info>("Info")==null)
                dr["Info"] = this.info;
            dr.Field<Info>("Info").Show();
        }
        private void Heart_Click(object sender, EventArgs e)
        {
            Player.SelectedItemPlaylist=this;

            DataRow dr = Player.data.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
            DataRow history_row = Player.History.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
            if (((Guna2Button)sender).Checked == false)
            {
                ((Guna2Button)sender).Checked = true;
                dr["Favorite"] = 1;
                if (history_row != null)
                    history_row["Favorite"] = 1;
            }
            else
            {
                MessageBox.Show("UnChecked");
                ((Guna2Button)sender).Checked = false;
                dr["Favorite"] = 0;
                if (history_row != null)
                    history_row["Favorite"] = 0;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Player.player.controls.stop();
            Guna.UI2.WinForms.Guna2CircleButton button = (Guna.UI2.WinForms.Guna2CircleButton)sender;
            
            DataRow dr = Player.data.Rows.Find((Player.SelectedItemPlaylist).PlayListID);
            Player.data.Rows.Remove(dr);
            Player.CurrentFlowLayoutPanel.Controls.Remove(Player.SelectedItemPlaylist);
        }

        private void DownLoad_Click(object sender, EventArgs e)
        {
            Player.SelectedItemPlaylist = this;
            DataRow dr = Player.data.Rows.Find((Player.SelectedItemPlaylist).PlayListID);

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Media|*.mp3";
            dialog.Title = "SaveFile";
            
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                 string folderPath = dialog.FileName;
                 File.Copy(dr.Field<string>("URL"),folderPath);
            }
        }

        private void ItemPlaylist_Load(object sender, EventArgs e)
        {
            info = new Info(this);
        }
    }
}
