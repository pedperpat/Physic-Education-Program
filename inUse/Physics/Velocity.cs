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
    public partial class Velocity : Form
    {
        protected const double G = 9.80665; // TODO: try to get the value of the variable from the Constants.cs
        public Velocity()
        {
            InitializeComponent();
        }
        private void solveBt_Click(object sender, EventArgs e)
        {
            GetFinalVelocity();
        }

        public string GetTime()
        {
            return totalTimeTb.Text;
        }

        public string GetFinalVelocity()
        {
            double totalTime = Convert.ToDouble(GetTime());
            double result = totalTime*G;
            return resultTb.Text = Convert.ToString(result)+" m/s";
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }
    }
}
