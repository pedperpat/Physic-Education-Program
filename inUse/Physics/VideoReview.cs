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
            
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            Hide();
            mainScreen.ShowDialog();
        }

        
    }
}
