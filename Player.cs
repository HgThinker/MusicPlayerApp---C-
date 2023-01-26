using MusicPlayerApp.Playlist;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
    internal class Player
    {
        public static DataTable data { get; set; }
        public static FlowLayoutPanel CurrentFlowLayoutPanel { get; set; }
        public static ItemPlaylist SelectedItemPlaylist { get; set; }
        public static WindowsMediaPlayer player { get; set; }   
        public static DataTable History { get; set; }
        public static Form MainForm { get; set; }   
        public static void KhoiTao()
        {
            player = new WindowsMediaPlayer();
            player.settings.autoStart= false;
            data = new DataTable();
            data.Columns.Add("ID", typeof(string));
            data.Columns.Add("SongName", typeof(string));
            data.Columns.Add("AuthorName", typeof(string));
            data.Columns.Add("URL", typeof(string));
            data.Columns.Add("Favorite", typeof(int));
            data.Columns.Add("Genres", typeof(string));
            data.Columns["Favorite"].DefaultValue = 0;

            data.PrimaryKey = new DataColumn[] { data.Columns["ID"] };

            string URL = "C:\\Users\\Administrator\\source\\repos\\MusicPlayerApp\\Resources\\Ed Sheeran\\";
            data.Rows.Add("ED0", "2step.mp3", "Ed Sheeran", URL + "2step.mp3", 0, "RB");
            data.Rows.Add("ED1", "Bad Habits.mp3", "Ed Sheeran", URL + "Bad Habits.mp3", 0, "RB");
            data.Rows.Add("ED2", "Celestial.mp3", "Ed Sheeran", URL + "Celestial.mp3", 0, "RB");
            data.Rows.Add("ED3", "Happier.mp3", "Ed Sheeran", URL + "Happier.mp3", 0, "Ballad");
            data.Rows.Add("ED4", "Overpass Graffiti.mp3", "Ed Sheeran", URL + "OverPass Graffiti.mp3", 0, "Pop");
            data.Rows.Add("ED5", "Photograph.mp3", "Ed Sheeran", URL + "Photograph.mp3", 0, "Ballad");
            data.Rows.Add("ED6", "Shivers.mp3", "Ed Sheeran", URL + "Shivers.mp3", 0, "RB");
            data.Rows.Add("ED7", "Thinking Out Loud.mp3", "Ed Sheeran", URL + "Thinking Out Loud.mp3", 0, "Ballad");
            data.Rows.Add("ED8", "Galway Girl.mp3", "Ed Sheeran", URL + "Galway Girl.mp3", 0, "RB");
            data.Rows.Add("ED9", "Lego House.mp3", "Ed Sheeran", URL + "Lego House.mp3", 0, "Ballad");
            data.Rows.Add("ED10", "Shape Of You.mp3", "Ed Sheeran", URL + "Shape Of You.mp3", 0, "Pop");
            data.Rows.Add("ED11", "Perfect.mp3", "Ed Sheeran", URL + "Perfect.mp3", 0, "Ballad");



            URL = "C:\\Users\\Administrator\\source\\repos\\MusicPlayerApp\\Resources\\Taylor Swift\\";

            data.Rows.Add("TS0", "Bad Blood.mp3", "Taylor Swift", URL + "Bad Blood.mp3", 0, "Pop");
            data.Rows.Add("TS1", "Blank Space.mp3", "Taylor Swift", URL + "Blank Space.mp3", 0, "Pop");
            data.Rows.Add("TS2", "Enchanted.mp3", "Taylor Swift", URL + "Enchanted.mp3", 0, "Country");
            data.Rows.Add("TS3", "Look What You Make Me Do.mp3", "Taylor Swift", URL + "Look What You Make Me Do.mp3", 0, "Pop");
            data.Rows.Add("TS4", "Love Story.mp3", "Taylor Swift", URL + "Love Story.mp3", 0, "Country");
            data.Rows.Add("TS5", "Lover.mp3", "Taylor Swift", URL + "Lover.mp3", 0, "Balad");
            data.Rows.Add("TS6", "Safe & Sound.mp3", "Taylor Swift", URL + "Safe & Sound.mp3", 0, "Balad");
            data.Rows.Add("TS7", "Shake It Off.mp3", "Taylor Swift", URL + "Shake It Off.mp3", 0, "Pop");
            data.Rows.Add("TS8", "You Belong With Me.mp3", "Taylor Swift", URL + "You Belong With Me.mp3", 0, "Country");
            data.Rows.Add("TS9", "Anti Hero.mp3", "Taylor Swift", URL + "Anti Hero.mp3", 0, "Pop");

            URL = "C:\\Users\\Administrator\\source\\repos\\MusicPlayerApp\\Resources\\The Weeknd\\";

            data.Rows.Add("TW0", "Blinding Lights.mp3", "The Weeknd", URL + "Blinding Lights.mp3", 0, "Pop");
            data.Rows.Add("TW1", "Call Out My Name.mp3", "The Weeknd", URL + "Call Out My Name.mp3", 0, "RB");
            data.Rows.Add("TW2", "In Your Eyes.mp3", "The Weeknd", URL + "In Your Eyes.mp3", 0, "Pop");
            data.Rows.Add("TW3", "Save Your Tears.mp3", "The Weeknd", URL + "Save Your Tears.mp3", 0, "Pop");
            data.Rows.Add("TW4", "The Hill.mp3", "The Weeknd", URL + "The Hills.mp3", 0, "RB");
            data.Rows.Add("TW5", "Wicked Games.mp3", "The Weeknd", URL + "Wicked Games.mp3", 0, "Pop");
            data.Rows.Add("TW6", "After Hours.mp3", "The Weeknd", URL + "After Hours.mp3", 0, "Pop");
            data.Rows.Add("TW7", "Sacrifice.mp3", "The Weeknd", URL + "Sacrifice.mp3", 0, "RB");
            data.Rows.Add("TW8", "Starboy.mp3", "The Weeknd", URL + "Starboy.mp3", 0, "Pop");
            data.Rows.Add("TW9", "Take My Breath.mp3", "The Weeknd", URL + "Take My Breath.mp3", 0, "RB");


            data.Columns.Add("Picture", typeof(Image));
            data.Columns.Add("Rate", typeof(float));
            data.Columns.Add("Lyrics", typeof(string));
            data.Columns.Add("Info", typeof(Info));
            data.Columns["Rate"].DefaultValue= 0;
            foreach (DataRow dr in data.Rows)
            {
                dr["Rate"] = 0;
                dr["Picture"] = Image.FromFile(dr.Field<string>("URL").Replace(".mp3",".jpg"));
                dr["Lyrics"] = dr.Field<string>("URL").Replace(".mp3", ".txt");
            }    

            History = new DataTable();
            History.Columns.Add("ID", typeof(string));
            History.Columns.Add("SongName", typeof(string));
            History.Columns.Add("AuthorName", typeof(string));
            History.Columns.Add("URL", typeof(string));
            History.Columns.Add("Favorite", typeof(int));
            History.Columns.Add("Genres", typeof(string));
            History.Columns.Add("Picture", typeof(Image));
            History.Columns.Add("Rate", typeof(float));
            History.Columns.Add("Lyrics", typeof(string));
            History.Columns.Add("Info", typeof(Info));
            History.Columns.Add("LastTime", typeof(DateTime));
            History.Columns.Add("Played", typeof(int));
 
            History.Columns["Rate"].DefaultValue = 0;
            History.Columns["Played"].DefaultValue = 0;

            History.PrimaryKey = new DataColumn[] { History.Columns["ID"] };

        }
    }
}
