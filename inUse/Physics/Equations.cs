using System;
using System.Windows.Forms;

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
            PassValues();
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

        private void goToAngularAccBt_Click(object sender, EventArgs e)
        {
            AngularAcceleration angac = new AngularAcceleration();
            Hide();
            angac.ShowDialog();
        }

        public void PassValues()
        {
            toHmaxBt.Text = MainScreen.toInitVH;
            ToAccelerationBt.Text = MainScreen.toAc;
            energyBt.Text = MainScreen.toKE;
            goToAngularAccBt.Text = MainScreen.toAngAc;
            toVelocityBt.Text = MainScreen.toFinalV;
            backBt.Text = MainScreen.BackBt;
        }
    }
}
