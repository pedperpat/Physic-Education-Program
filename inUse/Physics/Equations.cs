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
        protected const double G = 9.80665; // TODO: try to get the value of the variable from the Constants.cs
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

        private void plotGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = true;
            eqInputTb.Visible = true;
            eqMessageLb.Visible = true;
            drawBt.Visible = true;
            resultLb.Visible = true;
            resultTb.Visible = true;
            initMetersLb.Visible = false;
            initMetersTb.Visible = false;
            initTimeLb.Visible = false;
            initTimeTb.Visible = false;
            formulaPb.Visible = false;
            formulaFinalPositionPb.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;
            solveBt.Visible = false;
        }

        private void drawBt_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            for (int i = 0; i < 6; i++)
            {
                eqGraph.Series["Position"].Points.AddXY
                                (rdn.Next(0, 10), rdn.Next(0, 10));
            }

            eqGraph.Series["Position"].ChartType = SeriesChartType.FastLine;
            eqGraph.Series["Position"].Color = Color.Red;
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void equationOfAccelerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = false;
            eqInputTb.Visible = false;
            eqMessageLb.Visible = false;
            drawBt.Visible = false;
            resultLb.Visible = true;
            resultTb.Visible = true;
            initMetersLb.Visible = true;
            initMetersTb.Visible = true;
            initTimeLb.Visible = true;
            initTimeTb.Visible = true;
            formulaPb.Visible = true;
            formulaFinalPositionPb.Visible = false;
            finalTimeLb.Visible = true;
            finalTimeTb.Visible = true;
            finalVLb.Visible = true;
            finalVTb.Visible = true;
        }

        private void equationOfPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = false;
            eqInputTb.Visible = false;
            eqMessageLb.Visible = false;
            drawBt.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;
            initMetersLb.Visible = false;
            initMetersTb.Visible = false;
            initTimeLb.Visible = false;
            initTimeTb.Visible = false;
            formulaPb.Visible = false;
            formulaFinalPositionPb.Visible = true;
            finalTimeLb.Visible = true;
            finalTimeTb.Visible = true;
            initMetersLb.Visible = true;
            initMetersTb.Visible = true;
            initTimeLb.Visible = true;
            initTimeTb.Visible = true;
        }

        private void equationOfHmaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = false;
            eqInputTb.Visible = false;
            eqMessageLb.Visible = false;
            drawBt.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;
            initMetersLb.Visible = false;
            initMetersTb.Visible = false;
            initTimeLb.Visible = false;
            initTimeTb.Visible = false;
            formulaPb.Visible = false;
            formulaFinalPositionPb.Visible = false;
            finalTimeLb.Visible = true;
            finalTimeTb.Visible = true;
            vFinalPb.Visible = true;
        }

        private void equationOfTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = false;
            eqInputTb.Visible = false;
            eqMessageLb.Visible = false;
            drawBt.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;
            initMetersLb.Visible = false;
            initMetersTb.Visible = false;
            initTimeLb.Visible = false;
            initTimeTb.Visible = false;
            formulaPb.Visible = false;
            formulaFinalPositionPb.Visible = false;
        }

        private void equationOfEnergyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = false;
            eqInputTb.Visible = false;
            eqMessageLb.Visible = false;
            drawBt.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;
            initMetersLb.Visible = false;
            initMetersTb.Visible = false;
            initTimeLb.Visible = false;
            initTimeTb.Visible = false;
            formulaPb.Visible = false;
            formulaFinalPositionPb.Visible = false;
        }

        private void equationOfVelocityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqGraph.Visible = false;
            eqInputTb.Visible = false;
            eqMessageLb.Visible = false;
            drawBt.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;
            initMetersLb.Visible = false;
            initMetersTb.Visible = false;
            initTimeLb.Visible = false;
            initTimeTb.Visible = false;
            formulaPb.Visible = false;
            formulaFinalPositionPb.Visible = false;
            finalTimeTb.Visible = true;
            finalTimeLb.Visible = true;
            initMetersTb.Visible = true;
            initMetersLb.Visible = true;
            accelLb.Visible = true;
            accelTb.Visible = true;
        }

        // Final position equation,with know values.
        // DELAYED: Lack of parameters at the equationsWF.cs
        public void SolvePositionEq()
        {
            //posInitial = Convert.ToDouble();
        }

        // Acceleration equation, vInitial, vFinal, tInitial, tFinal
        public void SolveAccelerationEq()
        {
            double vInitial = 0; double vFinal = 0;
            double tInitial = 0; double tFinal = 0;
            double acceleration;
            if (Convert.ToDouble(finalTimeTb.Text) >= 0)
                tFinal = Convert.ToDouble(finalTimeTb.Text);
            if(Convert.ToDouble(initTimeTb.Text) >= 0)
                tInitial = Convert.ToDouble(initTimeTb.Text);
            //if (Convert.ToDouble(finalVTb) >= 0) // No sense,may be a negative velocity
            vFinal = Convert.ToDouble(finalVTb.Text);
            //if (Convert.ToDouble(initTimeTb) >= 0) // No sense,may be a negative velocity
            vInitial = Convert.ToDouble(initMetersTb.Text);

            double deltaOfV = vFinal - vInitial;
            double deltaOfT = tFinal - tInitial;
            acceleration = deltaOfV / deltaOfT;

            resultTb.Text = Convert.ToString(acceleration)+" m/s";
        }

        public void VelocityEquation()
        {
            double vFinal;
            double acceleration = 0;
            double vInitial = 0;
            double t = 0;

            vInitial = Convert.ToDouble(initMetersTb.Text);
            acceleration = Convert.ToDouble(accelTb.Text);
            t = Convert.ToDouble(finalTimeTb.Text);

            vFinal = vInitial * acceleration * t;

            resultTb.Text = Convert.ToString(vFinal) + " m/s";
        }

        private void solveBt_Click(object sender, EventArgs e)
        {
            SolveAccelerationEq();
            //VelocityEquation();
        }
    }
}
