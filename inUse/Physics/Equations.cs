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

        // Final position equation,with know values.
        // DELAYED: Lack of parameters at the equationsWF.cs
        //public void SolvePositionEq()
        //{
        //    double posInitial = 0; double vInitial = 0;
        //    double tInit = 0; double tFinal = 0;

        //    posInitial = Convert.ToDouble();
        //}

        // Acceleration equation, vInitial, vFinal, tInitial, tFinal
        

        //public void VelocityEquation()
        //{
        //    double vFinal;
        //    double acceleration = 0;
        //    double vInitial = 0;
        //    double t = 0;

        //    vInitial = Convert.ToDouble(initMetersTb.Text);
        //    acceleration = Convert.ToDouble(accelTb.Text);
        //    t = Convert.ToDouble(finalTimeTb.Text);

        //    vFinal = vInitial * acceleration * t;

        //    resultTb.Text = Convert.ToString(vFinal) + " m/s";
        //}

        private void ToAccelerationBt_Click(object sender, EventArgs e)
        {
            Acceleration ac = new Acceleration();
            Hide();
            ac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialVandHmax initV = new InitialVandHmax();
            Hide();
            initV.ShowDialog();
        }
    }
}
