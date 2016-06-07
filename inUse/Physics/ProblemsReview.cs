using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Globalization;

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
            Hide();
            mainScreen.ShowDialog();
        }

        private void graphicPlotter_Click(object sender, EventArgs e)
        {

        }

        private void btSolve_Click(object sender, EventArgs e)
        {
            PlotInChart();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        // TODO: Improve the switch to decide where to split the equation.
        public void PlotInChart()
        {
        //    switch()
        //    {
        //        case (("*")):
        //            string[] splitEq = eqTb.Split('*');
        //            break;
        //    }
        //    for (int i = 0; i < 10; i++)
        //    {

        //    }

        //    graphicPlotter.Series["Graphic Result"].ChartType = SeriesChartType.Spline;
        //    graphicPlotter.Series["Graphic Result"].Color = Color.Red;
        }
    }
}
