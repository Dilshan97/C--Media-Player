using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_player_V._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "(*.mp4) | *.mp4";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.playlist.add();
            }
        }

                
       

        private void button2_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("my Play list");
            WMPLib.IWMPMedia Media;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int ii = 1;
                Media = axWindowsMediaPlayer1.newMedia(listView1.Items[i].SubItems[ii].Text);
                playlist.appendItem(Media);
                ii++;

                axWindowsMediaPlayer1.currentPlaylist = playlist;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string selectedFile = listView1.FocusedItem.SubItems[1].Text;
            axWindowsMediaPlayer1.URL = @selectedFile;
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
