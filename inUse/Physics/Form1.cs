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

namespace Physics
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void conceptsBt_Click(object sender, EventArgs e)
        {
            Concepts concepts = new Concepts();
            //Close();
            Hide();
            concepts.ShowDialog();
        }

        private void constantsBt_Click(object sender, EventArgs e)
        {
            Constants cons = new Constants();
            //Close();
            Hide();
            cons.ShowDialog();
        }

        private void problemsBt_Click(object sender, EventArgs e)
        {
            ProblemsReview problems = new ProblemsReview();
            //Close();
            Hide();
            problems.ShowDialog();
        }

        private void equationsBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }

        private void helpBt_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLog changelog = new ChangeLog();
            Hide();
            changelog.ShowDialog();
        }

        private void toVideosBt_Click(object sender, EventArgs e)
        {
            VideoReview video = new VideoReview();
            Hide();
            video.ShowDialog();
        }
    }
}
