using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Physics
{
    partial class ProblemsReview : Form
    {
        protected List<String> problemList;
        protected string equationOfTextbox;
        public ProblemsReview()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProblemsReview_Load(object sender, EventArgs e)
        {
            SetProblems();
            SetFirstProblemToTextboxes();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            Hide();
            mainScreen.ShowDialog();
        }

        private void btSolve_Click(object sender, EventArgs e)
        {
            //PlotInChart();
            SolveAccelerationEq();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        // TODO: Switch to decide the case of the equation to plot 
        public void PlotInChart()
        {
            //string[] splitEq;
            //equationOfTextbox = userEq.Text;
            //    switch(equationOfTextbox)
            //    {
            //        case (equationOfTextbox.Contains("*")):
            //              splitEq = eqTb.Split('*');
            //              graphicPlotter.Series["Graphic Representation"].ChartType = SeriesChartType.Spline;
            //              graphicPlotter.Series["Graphic Representation"].Color = Color.Red;
            //              graphicPoltter.Series["Graohic Representation"].Points.AddXY(splitEq[0], splitEq[1]);
            //        break;
            //        
            //        case(equationOfTextbox.Contains("+")):
            //              splitEq = eqTb.Split('+');
            //              graphicPlotter.Series["Graphic Representation"].ChartType = SeriesChartType.Spline;
            //              graphicPlotter.Series["Graphic Representation"].Color = Color.Red;
            //              graphicPoltter.Series["Graohic Representation"].Points.AddXY(splitEq[0], splitEq[1]);
            //        break;
            //
            //        case(equationOfTextbox.Contains("-")):
            //              splitEq = eqTb.Split('-');
            //              graphicPlotter.Series["Graphic Representation"].ChartType = SeriesChartType.Spline;
            //              graphicPlotter.Series["Graphic Representation"].Color = Color.Red;
            //              graphicPoltter.Series["Graohic Representation"].Points.AddXY(splitEq[0], splitEq[1]);
            //    }

        }

        public void SetProblems()
        {
            problemList = new List<string>();

            StreamReader inFile = File.OpenText("problems.phy");
            string line;
            do
            {
                line = inFile.ReadLine();
                if (line != null)
                {
                    if (!line.Contains(";"))
                    {
                        problemList.Add(line);
                    }
                }
            }
            while (line != null);
            inFile.Close();
        }

        public void SetFirstProblemToTextboxes()
        {
            initTimeTb.Text = problemList[0];
            finalTTb.Text = problemList[1];
            initVTb.Text = problemList[2];
            finalVTb.Text = problemList[3];
        }

        public void SolveAccelerationEq()
        {
            // Checks if at the textboxes is text and the text is a digit and is at least 1 character lenght.
            if ((solutionTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(solutionTb.Text, "[^0-9,]")))
            {
                MessageBox.Show("Please enter only numbers.");
            }
            else
            {
                double vInitial = 0; double vFinal = 0;
                double tInitial = 0; double tFinal = 0;
                double acceleration;
                tFinal = Math.Abs(Convert.ToDouble(finalTTb.Text));
                tInitial = Math.Abs(Convert.ToDouble(initTimeTb.Text));
                vFinal = Convert.ToDouble(finalVTb.Text);
                vInitial = Convert.ToDouble(initVTb.Text);

                double deltaOfV = vFinal - vInitial;
                double deltaOfT = tFinal - tInitial;
                try
                {
                    acceleration = deltaOfV / deltaOfT;
                    resultTb.Text = Convert.ToString(acceleration) + " m/s";

                    if (acceleration == Convert.ToDouble(solutionTb.Text))
                        greenTickPb.Visible = true;
                    else
                        redTickPb.Visible = true;
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Can't divide by zero");
                }
            }
        }
    }
}