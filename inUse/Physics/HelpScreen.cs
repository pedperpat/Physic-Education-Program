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
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
        }

        private void eqScreenBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Constants cons = new Constants();
            Hide();
            cons.ShowDialog();
        }

        private void problemBt_Click(object sender, EventArgs e)
        {
            ProblemsReview problem = new ProblemsReview();
            Hide();
            problem.ShowDialog();
        }

        private void conceptBt_Click(object sender, EventArgs e)
        {
            Concepts concepts = new Concepts();
            Hide();
            concepts.ShowDialog();
        }
    }
}
