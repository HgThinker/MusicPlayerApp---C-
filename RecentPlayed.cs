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

    public partial class RecentPlayed : Form
    {
        public WindowsMediaPlayer player = null;
        public Main main = null;
        public RecentPlayed( Main main)
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

        private void RecentPlayed_Shown(object sender, EventArgs e)
        {
            var UniqueRows = Player.History.AsEnumerable().Distinct(DataRowComparer.Default);
            DataTable dt2 = new DataTable();
            if (UniqueRows.Count()!=0)
                dt2 = UniqueRows.CopyToDataTable();
            Player.CurrentFlowLayoutPanel = RecentPlayedflowLayoutPanel;
            foreach (DataRow dr in dt2.Rows)
            {
                Label label = new Label();
                label.Text = "Last Played: " + dr.Field<DateTime>("LastTime").ToString();
                label.Font = new Font("Segoe Script",14);
                label.AutoSize = true;

                Label label1 = new Label();
                label1.Text = "Played: "+dr.Field<int>("Played").ToString() + " times";
                label1.Font = new Font("Segoe Script", 14);
                label1.AutoSize = true;

                ItemPlaylist itemPlaylist = new ItemPlaylist();
                itemPlaylist.SongNameText = dr.Field<string>("SongName");
                itemPlaylist.AuthorNameText = dr.Field<string>("AuthorName");
                itemPlaylist.PlayListID = dr.Field<string>("ID");
                itemPlaylist.ImageChange = dr.Field<Image>("Picture");
                itemPlaylist.RateChange = dr.Field<float>("Rate");


                if (dr.Field<int>("Favorite") == 1)
                    itemPlaylist.GetHeart().Checked = true;
                else
                    itemPlaylist.GetHeart().Checked = false;

                itemPlaylist.Click += new EventHandler(ItemPlaylist_Click);

                RecentPlayedflowLayoutPanel.Controls.Add(itemPlaylist);
                RecentPlayedflowLayoutPanel.SetFlowBreak(itemPlaylist, true);
                RecentPlayedflowLayoutPanel.Controls.Add(label);
                RecentPlayedflowLayoutPanel.Controls.Add(label1);
                RecentPlayedflowLayoutPanel.SetFlowBreak(label1, true);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
