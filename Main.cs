using AxWMPLib;
using MusicPlayerApp.Playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.VisualBasic;
using System.Diagnostics.Contracts;

namespace MusicPlayerApp
{
    public partial class Main : Form
    {
        public Form activeForm = null;
        FlowLayoutPanel SearchflowLayoutPanel = new FlowLayoutPanel();
        public int time = 0;
        public double max_time;
        public Main()
        {
                        
            InitializeComponent();
            SearchflowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            SearchflowLayoutPanel.WrapContents = true;
            SearchflowLayoutPanel.Dock= DockStyle.Fill;
            SearchflowLayoutPanel.Visible = true;
            panelDesktop.Controls.Add(SearchflowLayoutPanel);
            SearchflowLayoutPanel.Hide();
        }

        public Label GetStart_Label()
        {
            return this.Start_label;
        }
        public Guna.UI2.WinForms.Guna2TrackBar GetGuna2TrackBar1()
        {
            return this.guna2TrackBar1;
        }
        public Timer GetTimer()
        {
            return this.timer1;
        }
        public Guna.UI2.WinForms.Guna2Button GetPlayButton()
        {
            return this.Play_button;
        }
        void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Player.CurrentFlowLayoutPanel.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = this.BackColor;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();

        }
        private void Exit_pic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string Add_row_return_ID(FileInfo fileInfo,string AuthorName,string Genres)
        {
            int length =Player.data.AsEnumerable().Where(x => x["AuthorName"].ToString() == AuthorName).ToList().Count;
            int name_length = AuthorName.Length;
            AuthorName = AuthorName.ToUpper();
            string ID ="";
            ID += AuthorName[0];
            for (int i = 1; i < name_length;i++)
            {
                if (AuthorName[i-1]==' ')
                    ID += AuthorName[i];
            }
            ID += (length++).ToString();
            Player.data.Rows.Add(ID, fileInfo.Name, AuthorName, fileInfo.FullName.ToString(), 0, Genres);
            return ID;
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|MP3 File (*.mp3)|*.mp3";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                string [] FileEntries =  openFileDialog1.FileNames;
                foreach(string FileEntry in FileEntries )
                {
                    FileInfo fileInfo = new FileInfo(FileEntry);
                    ItemPlaylist itemPlaylist = new ItemPlaylist();
                    string AuthorName = Interaction.InputBox("Please enter the Author name of " + fileInfo.Name);
                    string Genres = Interaction.InputBox("Please enter the Genres of " + fileInfo.Name);
                    itemPlaylist.SongNameText = fileInfo.Name;
                    itemPlaylist.AuthorNameText = AuthorName;
                    itemPlaylist.PlayListID = Add_row_return_ID(fileInfo,AuthorName,Genres);
                    itemPlaylist.Click += new EventHandler(ItemPlaylist_Click);
                    Player.CurrentFlowLayoutPanel.Controls.Add(itemPlaylist);
                }
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Player.KhoiTao();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Player.CurrentFlowLayoutPanel = MainFlowLayoutPanel;
            Player.CurrentFlowLayoutPanel.Show();
            foreach (DataRow dataRow in Player.data.Rows)
            {
                ItemPlaylist itemPlaylist = new ItemPlaylist();
                itemPlaylist.SongNameText = dataRow.Field<string>("SongName");
                itemPlaylist.AuthorNameText = dataRow.Field<string>("AuthorName");
                itemPlaylist.PlayListID = dataRow.Field<string>("ID");
                itemPlaylist.ImageChange = dataRow.Field<Image>("Picture");
                itemPlaylist.RateChange = dataRow.Field<float>("Rate");
                itemPlaylist.Click += new EventHandler(ItemPlaylist_Click);
                if (dataRow.Field<int>("Favorite") == 1)
                    itemPlaylist.GetHeart().Checked = true;
                MainFlowLayoutPanel.Controls.Add(itemPlaylist);
            }
        }


        public void Find_mp3_file(ItemPlaylist SelectedItem)
        { 
            Player.SelectedItemPlaylist = SelectedItem;
            SongName.Text = SelectedItem.SongNameText;
            AuthorName.Text = SelectedItem.AuthorNameText;

            DataRow dr = Player.data.Rows.Find(SelectedItem.PlayListID);
            Player.player.URL = dr.Field<string>("URL");

            End_label.Text = Player.player.currentMedia.durationString;
            max_time = Player.player.currentMedia.duration;
            if(max_time!=0)
                guna2TrackBar1.Maximum = (int)max_time;
        }



        void Restart_time()
        {
            time = 0;
            TimeSpan t = TimeSpan.FromSeconds(time);
            Start_label.Text = t.ToString(@"m\:ss");
            guna2TrackBar1.Value = 0;
            timer1.Stop();
        }
        public void ItemPlaylist_Click(object sender, EventArgs e)
        {
            ((ItemPlaylist)sender).BackColor = Color.Aquamarine;

            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Transparent;
            }
            Player.SelectedItemPlaylist = (ItemPlaylist)sender;
            DataRow dr = Player.data.NewRow();
            dr = Player.data.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
            this.Picture_Playlist.Image = dr.Field<Image>("Picture");
            if (Play_button.Checked == true)
                Play_button.Checked = false;
            Find_mp3_file((ItemPlaylist)sender);
            Restart_time();
        }
        public void Play_button_Click(object sender, EventArgs e)
        {
            if(Play_button.Checked==false) 
            {
                Play_button.Checked = true;
                Player.player.controls.play();
                timer1.Start();

                DataRow dr = Player.History.NewRow();
                dr = Player.data.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
                DataRow History_row = Player.History.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
                int played = 1;
                if (History_row != null)
                {
                    played = History_row.Field<int>("Played") + 1;

                    Player.History.Rows.Remove(History_row);
                }
                Player.History.Rows.Add(dr.ItemArray);
                dr = Player.History.Rows.Find(Player.SelectedItemPlaylist.PlayListID);
                dr.SetField<DateTime>("LastTime", DateTime.Now);
                dr.SetField<int>("Played", played);
            }
            else
            {
                Play_button.Checked = false;
                Player.player.controls.pause();
                timer1.Stop();
            }
        }
        private void Forward_button_Click(object sender, EventArgs e)
        {
            Player.player.controls.stop();
            Restart_time();
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Transparent;
            }
            if (Play_button.Checked == true)
                Play_button.Checked = false;
            Player.SelectedItemPlaylist = (ItemPlaylist)Player.CurrentFlowLayoutPanel.GetNextControl(Player.SelectedItemPlaylist, true);
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Aquamarine;
                Find_mp3_file(Player.SelectedItemPlaylist);
            }
        }

        private void Backward_button_Click(object sender, EventArgs e)
        {
            Player.player.controls.stop();
            Restart_time();
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Transparent;
            }
            if (Play_button.Checked == true)
                Play_button.Checked = false;
            Player.SelectedItemPlaylist =(ItemPlaylist) Player.CurrentFlowLayoutPanel.GetNextControl(Player.SelectedItemPlaylist, false);
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Aquamarine;
                Find_mp3_file(Player.SelectedItemPlaylist);
            }
        }
        private void Replay_button_Click(object sender, EventArgs e)
        {
            Player.player.controls.stop();
            Restart_time();
            if (Play_button.Checked == false)
                Play_button.Checked = true;
            Find_mp3_file(Player.SelectedItemPlaylist);
            Player.player.controls.play();
        }

        private void Shuffle_button_Click(object sender, EventArgs e)
        {
            Player.player.controls.stop();
            Restart_time();
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Transparent;
            }
            if (Play_button.Checked == true)
                Play_button.Checked = false;
            Random random= new Random();
            Player.SelectedItemPlaylist =(ItemPlaylist) Player.CurrentFlowLayoutPanel.Controls[random.Next(Player.CurrentFlowLayoutPanel.Controls.Count)];
            if (Player.SelectedItemPlaylist != null)
            {
                Player.SelectedItemPlaylist.BackColor = Color.Aquamarine;
                Find_mp3_file(Player.SelectedItemPlaylist);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Player.SelectedItemPlaylist !=null && max_time!=0)
            {
                TimeSpan t = TimeSpan.FromSeconds(time++);
                Start_label.Text = t.ToString(@"m\:ss");
                guna2TrackBar1.Value = time;
            }

        }

        private void Album_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (Player.SelectedItemPlaylist != null && max_time != 0)
            {
                guna2TrackBar1.Maximum = (int)max_time;
                Player.player.controls.currentPosition = guna2TrackBar1.Value;
                time = guna2TrackBar1.Value;
            }    
        }

        private void Speaker_Click(object sender, EventArgs e)
        {
            if(Speaker.Checked == true)
            {
                Speaker.Checked = false;
                Player.player.settings.mute = false;
            }
            else
            {
                Speaker.Checked = true;
                Player. player.settings.mute = true;
            }   
        }

        private void Volume_Scroll(object sender, ScrollEventArgs e)
        {
            Player.player.settings.volume = Volume.Value;
        }

        private void Songs_Click(object sender, EventArgs e)
        {
            Label.Text = "All Songs You Need"; 
            if(activeForm !=null)
                activeForm.Close();
            Player.CurrentFlowLayoutPanel = MainFlowLayoutPanel;
            MainFlowLayoutPanel.Show();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Genres_Click(object sender, EventArgs e)
        {
            Label.Text = "Genres Of Songs";
            Genres genres = new Genres(this);
            OpenChildForm(genres);
        }

        private void Favorite_Click(object sender, EventArgs e)
        {
            Label.Text = "Your Favorite Songs";
            Favorite favorite = new Favorite(this);
            OpenChildForm(favorite);
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Songs_MouseClick(object sender, MouseEventArgs e)
        {
            Songs_Click(sender, e);
        }

        private void Genres_MouseClick(object sender, MouseEventArgs e)
        {
            Genres_Click(sender,e);
        }

        private void Recent_Played_Click(object sender, EventArgs e)
        {
            Label.Text = "Your Recent Played Songs";
            RecentPlayed recentPlayed = new RecentPlayed(this);
            OpenChildForm(recentPlayed);
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            SearchflowLayoutPanel.AutoScroll = true;
            string input = Search.Text.ToLower();
            if (input == "")
                SearchflowLayoutPanel.Controls.Clear();
                
            if (e.KeyCode == Keys.Enter)
            {
                Player.CurrentFlowLayoutPanel.Hide();
                SearchflowLayoutPanel.Show();
                Player.CurrentFlowLayoutPanel = SearchflowLayoutPanel;

                foreach (DataRow dataRow in Player.data.Rows)
                {
                    if (dataRow.Field<string>("SongName").ToLower() == input + ".mp3" || dataRow.Field<string>("AuthorName").ToLower() == input|| dataRow.Field<string>("Genres").ToLower() == input)
                    {
                        ItemPlaylist itemPlaylist = new ItemPlaylist();
                        itemPlaylist.SongNameText = dataRow.Field<string>("SongName");
                        itemPlaylist.AuthorNameText = dataRow.Field<string>("AuthorName");
                        itemPlaylist.PlayListID = dataRow.Field<string>("ID");
                        itemPlaylist.ImageChange = dataRow.Field<Image>("Picture");
                        itemPlaylist.RateChange = dataRow.Field<float>("Rate");
                        itemPlaylist.Click += new EventHandler(ItemPlaylist_Click);
                        if (dataRow.Field<int>("Favorite") == 1)
                            itemPlaylist.GetHeart().Checked = true;
                        SearchflowLayoutPanel.Controls.Add(itemPlaylist);
                    }
                }
            }
        }
    }
}
