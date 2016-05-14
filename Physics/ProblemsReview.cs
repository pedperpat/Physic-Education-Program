using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
     partial class ProblemsReview : Form
    {
        public ProblemsReview()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProblemsReview_Load(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            //Close();
            Hide();
            mainScreen.ShowDialog();
        }
    }
}
