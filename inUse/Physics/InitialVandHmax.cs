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
    public partial class InitialVandHmax : Form
    {
        protected const double G = 9.80665; // TODO: try to get the value of the variable from the Constants.cs

        public InitialVandHmax()
        {
            InitializeComponent();
        }

        private void InitialVandHmax_Load(object sender, EventArgs e)
        {

        }

        public string GetInitialV()
        {
            double v0 = 0; double vf = 0;
            double totalTime = Convert.ToDouble(totalTimeTb.Text) / 2;
            v0 = G * totalTime;
            resultVoTb.Text = Convert.ToString(v0)+" m/s";
            return resultVoTb.Text;
        }

        private void getVoBt_Click(object sender, EventArgs e)
        {
            GetInitialV();
        }
    }
}
