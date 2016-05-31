using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class Energy : Form
    {
        public Energy()
        {
            InitializeComponent();
        }

        private void solveEnergyBt_Click(object sender, EventArgs e)
        {
            if ((velocityTb.TextLength == 0) ||
                (massTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(velocityTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(massTb.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only numbers.");
            }
            else
            {
                GetEnergy();
            }
            
        }

        public string GetEnergy()
        {
            if ((velocityTb.TextLength == 0) || 
                (massTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(velocityTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(massTb.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only numbers.");
                return massTb.Text;
            }
            double v = Convert.ToDouble(velocityTb.Text);
            double mass = Convert.ToDouble(massTb.Text);

            double result = 0.5 * mass * v * v;
            return resultTb.Text = Convert.ToString(result)+" J";
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }

        private void mainScreenBt_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Hide();
            ms.ShowDialog();
        }

        public void SaveHistoricalFile()
        {
            // Grab all the textbox values
            string mass = massTb.Text;
            string velocity = velocityTb.Text;
            string result = resultTb.Text;

            try
            {
                string fileName = "historical.phy";
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write("Energy Equation:");
                    writer.WriteLine();
                    writer.Write("\t Mass of projectile " + mass + " | Velocity of the projectile: " +
                        "" + velocity + " | Result: " + result + "\n");
                    writer.WriteLine();
                    writer.Write("---------------------------------------------------------------------" +
                        "--------------------------------------------------------------------------------");
                    writer.WriteLine();
                }
                //StreamWriter writer = new StreamWriter("historical.phy");


            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/Ouput error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: {0}", ex.Message);
            }
        }
    }
}
