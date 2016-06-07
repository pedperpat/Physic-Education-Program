using System;
using System.Windows.Forms;

namespace Physics
{
    public partial class Position : Form
    {
        protected const double G = 9.80665; // TODO: try to get the value of the variable from the Constants.cs
        public Position()
        {
            InitializeComponent();
        }

        private void Position_Load(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }

        private void toMainBt_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Hide();
            ms.ShowDialog();
        }

        public string GetFinalPosition()
        {
            //string[] voWithoutUnit = GetInitialV().Split(' '); // Get the value of Vo and remove the "m/s" string
            //double v0 = Convert.ToDouble(voWithoutUnit[0]);
            //double time = Convert.ToDouble(totalTimeTb.Text) / 2;

            ///* Aplying final position formula, as we know the initial position is 0 and we know the time and v0
            // * we can calculate the final position incognita with the actual values.
            // */
            //double Hmax = v0 * time - 0.5 * G * time * time;

            //resultHmaxTb.Text = Convert.ToString(Hmax) + " m";
            //return resultHmaxTb.Text;
            return "";
        }
    }
}
