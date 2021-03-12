using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        string[] files;
        string[] paths;
        bool flag = true;
        public MusicPlayer()
        {
            InitializeComponent();
        }

        
        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code to select song
            OpenFileDialog ofd = new OpenFileDialog();
            // code to select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // save the names of the tracks in the files array
                paths = ofd.FileNames; // save paths of tracks in path array

                //display the music titles in the tracks listbox
                for (int i=0; i< files.Length; i++)
                {
                    tracks.Items.Add(files[i]); // display songs in listbox


                }
            }
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the application on button click
            Application.Exit();
            
            
        }

        private void tracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play music on press
            WindowsMediaPlayer.URL = paths[tracks.SelectedIndex];
        }

        private void WindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void toggleNight_Click(object sender, EventArgs e)
        {
            // pressing this button toggles between night mode
            if (flag == true)
            {
                BackColor = Color.White;
                TopPanel.BackColor = Color.LightGray;
                lblLogo.ForeColor = Color.Black;
                tracks.BackColor = Color.White;
                tracks.ForeColor = Color.Black;
                btnSelectSongs.BackColor = Color.White;
                btnSelectSongs.ForeColor = Color.Black;

                flag = false;
            }
            else
            {
                BackColor = Color.FromArgb(47, 55, 74);
                TopPanel.BackColor = Color.Black;
                lblLogo.ForeColor = Color.White;
                tracks.BackColor = Color.Black;
                tracks.ForeColor = Color.White;
                btnSelectSongs.BackColor = Color.Black;
                btnSelectSongs.ForeColor = Color.White;
                flag = true;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }
    }
}
