using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class VideoReviewForm : Form
    {
        protected List<string> videos = new List<string>();
        protected int countVideos = 1;
        public VideoReviewForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void clickLinkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo toVideo = new ProcessStartInfo("https://www.youtube.com/playlist?list=PLB5DFED24F5CCEAF4");
            Process.Start(toVideo);
        }

        private void VideoReview_Load(object sender, EventArgs e)
        {
            AddVideos();
            youtubeVideo.Movie = videos[1];
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            Hide();
            mainScreen.ShowDialog();
        }

        private void nextVidBt_Click(object sender, EventArgs e)
        {
            if (countVideos < 10)
            {
                countVideos++;
                youtubeVideo.Movie = videos[countVideos];
            }
            else
                MessageBox.Show("No more videos available");
        }

        private void prevVidBt_Click(object sender, EventArgs e)
        {
            if (countVideos > 0)
            {
                countVideos--;
                youtubeVideo.Movie = videos[countVideos];
            }
            else
                MessageBox.Show("No more previous videos");
        }

        public void AddVideos()
        {
            videos.Add("");
            videos.Add("https://www.youtube.com/v/6wb29I_79lA");
            videos.Add("https://www.youtube.com/v/VVk5mXPlGWM");
            videos.Add("https://www.youtube.com/v/9tAFhZb6DdA");
            videos.Add("https://www.youtube.com/v/iLlBmTQ4zvc");
            videos.Add("https://www.youtube.com/v/h6X3j3SV8fQ");
            videos.Add("https://www.youtube.com/v/kv5NRUOqJs8");
            videos.Add("https://www.youtube.com/v/sMmqLaIs9jk");
            videos.Add("https://www.youtube.com/v/fM6XNxN7yk4");
            videos.Add("https://www.youtube.com/v/lnUiwGGPv6E");
            videos.Add("https://www.youtube.com/v/I4su8ckNJSo");
            videos.Add("https://www.youtube.com/v/Gu2Ak9L0uEs");
        }
    }
}
