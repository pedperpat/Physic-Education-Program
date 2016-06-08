using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Physics
{
    public partial class Constants : Form
    {
        public static Dictionary<string, double> diccOfConstants =
                new Dictionary<string, double>();
        public static string[] constantName;
        public static double[] constantValue;
        public static List<double> variableValues = new List<double>();
        public static double G;
        public Constants()
        {
            InitializeComponent();
            //SetConstantsValue();
            SetConstantsName();
            InitG();
            //GrabConstants();
        }
        private void Constants_Load(object sender, EventArgs e)
        {

        }
        private void backBt_Click_1(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            Hide();
            mainScreen.ShowDialog();
        }

        //public static void GrabConstants()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        diccOfConstants.Add(constantName[i], constantValue[i]);
        //    }
        //}

        public void SetConstantsName()
        {
            constantName = new string[10];

            constantName[0] = variable1.Text;
            constantName[1] = variable2.Text;
            constantName[2] = variable3.Text;
            constantName[3] = variable4.Text;
            constantName[4] = variable5.Text;
            constantName[5] = variable6.Text;
            constantName[6] = variable7.Text;
            constantName[7] = variable8.Text;
            constantName[8] = variable9.Text;
            constantName[9] = variable10.Text;
        }

        //public void SetConstantsValue()
        //{
        //    constantValue = new double[10];

        //    constantValue[0] = Convert.ToDouble(valueOf1.Text);
        //    constantValue[1] = Convert.ToDouble(valueOf2.Text);
        //    constantValue[2] = Convert.ToDouble(valueOf3.Text);
        //    constantValue[3] = Convert.ToDouble(valueOf4.Text);
        //    constantValue[4] = Convert.ToDouble(valueOf5.Text);
        //    constantValue[5] = Convert.ToDouble(valueOf6.Text);
        //    constantValue[6] = Convert.ToDouble(valueOf7.Text);
        //    constantValue[7] = Convert.ToDouble(valueOf8.Text);
        //    constantValue[8] = Convert.ToDouble(valueOf9.Text);
        //    constantValue[9] = Convert.ToDouble(valueOf10.Text);
        //}

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        public void InitG()
        {
            G = Convert.ToDouble(valueOf3.Text);
        }
    }
}
