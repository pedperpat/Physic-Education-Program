using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Physics
{
    public partial class Equations : Form
    {
        public Equations()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Equations_Load(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            Hide();
            mainScreen.ShowDialog();
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        private void ToAccelerationBt_Click(object sender, EventArgs e)
        {
            Acceleration ac = new Acceleration();
            Hide();
            ac.ShowDialog();
        }

        private void toHmaxBt_Click(object sender, EventArgs e)
        {
            InitialVandHmax initV = new InitialVandHmax();
            Hide();
            initV.ShowDialog();
        }

        private void toVelocityBt_Click(object sender, EventArgs e)
        {
            Velocity v = new Velocity();
            Hide();
            v.ShowDialog();
        }

        private void energyBt_Click(object sender, EventArgs e)
        {
            Energy energy = new Energy();
            Hide();
            energy.ShowDialog();
        }


    }
}
