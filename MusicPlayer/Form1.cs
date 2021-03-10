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
        private string[] files;
        private string paths;

        public MusicPlayer()
        {
            string[] paths;
            string[] files;

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
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // save the names of the tracks in the files array
                paths = ofd.FileName; // save paths of tracks in path array

                //display the music titles in a listbox
                for (int i=0; i< files.Length; i++)
                {
                    tracks.Items.Add(files[i]);

                }
            }
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the application on button click
            this.Close();
        }

        private void tracks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
