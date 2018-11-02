using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teewer
{
    public partial class video : Form
    {
        public video()
        {
            InitializeComponent();
        }

        private void video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("mediafile");
        }
    }
}
