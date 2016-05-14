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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void conceptsBt_Click(object sender, EventArgs e)
        {
            Concepts concepts = new Concepts();
            //Close();
            Hide();
            concepts.ShowDialog();
        }

        private void constantsBt_Click(object sender, EventArgs e)
        {
            Constants cons = new Constants();
            //Close();
            Hide();
            cons.ShowDialog();
        }

        private void problemsBt_Click(object sender, EventArgs e)
        {
            ProblemsReview problems = new ProblemsReview();
            //Close();
            Hide();
            problems.ShowDialog();
        }

        private void equationsBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            //Close();
            Hide();
            eq.ShowDialog();
        }
    }
}
