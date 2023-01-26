using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp.Playlist
{
    public partial class Genre : UserControl
    {
        public Genre()
        {
            InitializeComponent();
        }
        public string label1Text
        {
            set{ label1.Text = value; }
            get { return label1.Text; }
        }
    }
}
