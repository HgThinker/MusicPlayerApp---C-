using MusicPlayerApp.Playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
    public partial class Genres : Form
    {
        public WindowsMediaPlayer player= null;
        public Main main =null;
        public Genres( Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Genres_Shown(object sender, EventArgs e)
        {
            Player.CurrentFlowLayoutPanel = GenresFlowLayoutPanel;
            string[] genres = Player.data.DefaultView.ToTable(true, "Genres").AsEnumerable().Select(r => r.Field<string>("Genres")).ToArray();
            foreach (string genre in genres)
            {
                DataRow[] dataRows = Player.data.Select(string.Format("Genres ='{0}' ", genre));
                Genre genre1 = new Genre();
                genre1.label1Text = genre;
                GenresFlowLayoutPanel.Controls.Add(genre1);
                GenresFlowLayoutPanel.SetFlowBreak(genre1, true);
                Control lastcontrol = null;
                foreach (DataRow row in dataRows)
                {
                    ItemPlaylist itemPlaylist = new ItemPlaylist();
                    itemPlaylist.SongNameText = row.Field<string>("SongName");
                    itemPlaylist.AuthorNameText = row.Field<string>("AuthorName");
                    itemPlaylist.PlayListID = row.Field<string>("ID");
                    itemPlaylist.ImageChange = row.Field<Image>("Picture");
                    itemPlaylist.RateChange = row.Field<float>("Rate");
                    itemPlaylist.Click += new EventHandler(ItemPlaylist_Click);
                    if (row.Field<int>("Favorite") == 1)
                        itemPlaylist.GetHeart().Checked = true;
                    GenresFlowLayoutPanel.Controls.Add(itemPlaylist);
                    lastcontrol = itemPlaylist;
                }
                GenresFlowLayoutPanel.SetFlowBreak(lastcontrol, true);
            }
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
    }
}
