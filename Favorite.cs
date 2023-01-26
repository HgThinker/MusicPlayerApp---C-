using MusicPlayerApp.Playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
 
    public partial class Favorite : Form
    {
        public Main main = null;

        public Favorite( Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        void Restart_time()
        {
            main.time = 0;
            TimeSpan t = TimeSpan.FromSeconds(main.time);
            main.GetStart_Label().Text = t.ToString(@"m\:ss");
            main.GetGuna2TrackBar1().Value = 0;
            main.GetTimer().Stop();
        }
        private void ItemPlaylist_Click(object sender, EventArgs e)
        {
            ((ItemPlaylist)sender).BackColor = Color.Aquamarine;
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Transparent;
            }
            if (main.GetPlayButton().Checked == true)
                main.GetPlayButton().Checked = false;
            main.Find_mp3_file((ItemPlaylist)sender);
            Restart_time();
        }

        private void Favorite_Shown(object sender, EventArgs e)
        {
            Player.CurrentFlowLayoutPanel = FavoriteflowLayoutPanel;

            DataRow[]dataRows = Player.data.Select("Favorite=1");

            foreach (DataRow dr in dataRows)
            {
                ItemPlaylist itemPlaylist = new ItemPlaylist();
                itemPlaylist.SongNameText = dr.Field<string>("SongName");
                itemPlaylist.AuthorNameText = dr.Field<string>("AuthorName");
                itemPlaylist.PlayListID = dr.Field<string>("ID");
                itemPlaylist.ImageChange = dr.Field<Image>("Picture");
                itemPlaylist.RateChange = dr.Field<float>("Rate");
                itemPlaylist.Click += new EventHandler(ItemPlaylist_Click);
                itemPlaylist.GetHeart().Checked = true;
                FavoriteflowLayoutPanel.Controls.Add(itemPlaylist);
            }
        }
        
    }
}
