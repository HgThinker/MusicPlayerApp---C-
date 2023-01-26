using MusicPlayerApp.Playlist;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MusicPlayerApp
{
    public partial class Info : Form
    {

        public Info(ItemPlaylist itemPlaylist)
        {
            InitializeComponent();
            this.itemPlaylist1.SongNameText =itemPlaylist.SongNameText;
            this.itemPlaylist1.AuthorNameText = itemPlaylist.AuthorNameText;
            this.itemPlaylist1.PlayListID = itemPlaylist.PlayListID;
            this.itemPlaylist1.ImageChange = itemPlaylist.ImageChange;
            this.itemPlaylist1.RateChange = itemPlaylist.RateChange;
            this.itemPlaylist1.GetInfoButton().Hide();
            this.itemPlaylist1.GetDelete_button().Hide();
            itemPlaylist.RateChange = this.itemPlaylist1.RateChange;

            DataRow dr = Player.data.Rows.Find(this.itemPlaylist1.PlayListID);
            this.guna2TextBox2.Text = File.ReadAllText( dr.Field<string>("Lyrics"));
        }



        private void InfoflowLayoutPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Label newlabel = new Label();
                Label time = new Label();
                newlabel.Text = Search.Text;
                newlabel.Font = new Font("Segoe Script", 10);
                newlabel.AutoSize = true;
                newlabel.Dock= DockStyle.Bottom;
                time.Text = DateTime.Now.ToString();
                time.Font = new Font("Segoe UI Semibold", 5);
                time.AutoSize = true;
                time.Dock = DockStyle.Bottom;
                this.Comment.Controls.Add(newlabel);
                this.Comment.Controls.Add(time);
                Search.Text= "";
            }
        }

        private void InfoflowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Comment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
