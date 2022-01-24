using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyPlayer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
            lbl_volume.Text = "50%";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void p_bar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void Volume_Click(object sender, EventArgs e)
        {

        }

        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception ex)
            {

            };
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar .Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch 
            {

            };
        }

        private void lbl_track_end_Click(object sender, EventArgs e)
        {

        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_volume.Text = track_volume.Value.ToString()+"%";
        }

        private void lbl_volume_Click(object sender, EventArgs e)
        {

        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;

                for(int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }

            
        }
    }
}
