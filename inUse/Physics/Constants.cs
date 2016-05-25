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
    public partial class Constants : Form
    {   
        protected double[] variableValues = new double[10];
        //protected List<double> variableValues = new List<double>();
        public Constants()
        {
            InitializeComponent();
        }
        private void Constants_Load(object sender, EventArgs e)
        {

        }
        private void backBt_Click_1(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            //Close();
            Hide();
            mainScreen.ShowDialog();
        }

        //public List<double> GetVariableValues()
        //{
        //    variableValues.Add(Convert.ToDouble(valueOfAtm));
        //    variableValues.Add(Convert.ToDouble(valueOfAtomicMass));
        //    variableValues.Add(Convert.ToDouble(valueOfAvogadro));
        //    variableValues.Add(Convert.ToDouble(valueOfElectron));
        //    variableValues.Add(Convert.ToDouble(valueOfGravitation));
        //    variableValues.Add(Convert.ToDouble(valueOfLight));
        //    variableValues.Add(Convert.ToDouble(valueOfMassElectron));
        //    variableValues.Add(Convert.ToDouble(valueOfMassNeutron));
        //    variableValues.Add(Convert.ToDouble(valueOfMassProton));
        //    variableValues.Add(Convert.ToDouble(valueOfPlanck));

        //    return variableValues;
        //}

        //Trying to get the constant values to an array of double.
        public double[] GetVariableValues()
        {
            variableValues[0] = Convert.ToDouble(valueOfAtm);
            variableValues[1] = Convert.ToDouble(valueOfAtomicMass);
            variableValues[2] = Convert.ToDouble(valueOfAvogadro);
            variableValues[3] = Convert.ToDouble(valueOfElectron);
            variableValues[4] = Convert.ToDouble(valueOfGravitation);
            variableValues[5] = Convert.ToDouble(valueOfLight);
            variableValues[6] = Convert.ToDouble(valueOfMassElectron);
            variableValues[7] = Convert.ToDouble(valueOfMassNeutron);
            variableValues[8] = Convert.ToDouble(valueOfMassProton);
            variableValues[9] = Convert.ToDouble(valueOfPlanck);


            return variableValues;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }
    }
}
