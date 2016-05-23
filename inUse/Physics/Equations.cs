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
            //Close();
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
            accelerationResultTb.Visible = false;
            resultAcLb.Visible = false;
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
            resultLb.Visible = false;
            resultTb.Visible = false;
            initMetersLb.Visible = true;
            initMetersTb.Visible = true;
            initTimeLb.Visible = true;
            initTimeTb.Visible = true;
            formulaPb.Visible = true;
            accelerationResultTb.Visible = true;
            resultAcLb.Visible = true;
            resultOfFinalPositionLb.Visible = false;
            formulaFinalPositionPb.Visible = false;
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
            accelerationResultTb.Visible = false;
            resultAcLb.Visible = false;
            formulaFinalPositionPb.Visible = true;
            finalPositionResultTb.Visible = true;
            finalTimeLb.Visible = true;
            finalTimeTb.Visible = true;
            initMetersLb.Visible = true;
            initMetersTb.Visible = true;
            resultOfFinalPositionLb.Visible = true;
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
            accelerationResultTb.Visible = false;
            resultAcLb.Visible = false;
            resultOfFinalPositionLb.Visible = false;
            formulaFinalPositionPb.Visible = false;
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
            accelerationResultTb.Visible = false;
            resultAcLb.Visible = false;
            resultOfFinalPositionLb.Visible = false;
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
            accelerationResultTb.Visible = false;
            resultAcLb.Visible = false;
            resultOfFinalPositionLb.Visible = false;
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
            accelerationResultTb.Visible = false;
            resultAcLb.Visible = false;
            resultOfFinalPositionLb.Visible = false;
            formulaFinalPositionPb.Visible = false;
        }
    }
}
