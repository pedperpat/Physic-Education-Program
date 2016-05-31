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
    public partial class Velocity : Form
    {
        protected const double G = 9.80665; // TODO: try to get the value of the variable from the Constants.cs
        public Velocity()
        {
            InitializeComponent();
        }
        private void solveBt_Click(object sender, EventArgs e)
        {
            if ((totalTimeTb.TextLength == 0) || 
                (System.Text.RegularExpressions.Regex.IsMatch(totalTimeTb.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only numbers.");
            }
            else
            {
                GetFinalVelocity();
                SaveHistoricalFile();
            }
        }

        public string GetTime()
        {
            return totalTimeTb.Text;
        }

        public string GetFinalVelocity()
        {
            if ((totalTimeTb.TextLength == 0) || 
                (System.Text.RegularExpressions.Regex.IsMatch(totalTimeTb.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only numbers.");
                totalTimeTb.Text.Remove(totalTimeTb.Text.Length - 1);
                return totalTimeTb.Text;
            }
            else
            {
                double totalTime = Convert.ToDouble(GetTime());
                double result = totalTime * G;
                return resultTb.Text = Convert.ToString(result) + " m/s";
            }
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

        public void SaveHistoricalFile()
        {
            // Grab all the textbox values
            string totalTime = totalTimeTb.Text;
            string result = resultTb.Text;

            try
            {
                string fileName = "historical.phy";
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write("Velocity Equation:");
                    writer.WriteLine();
                    writer.Write("\t Total Time = " + totalTime + " | "
                    + "Result = " + result + "\n");
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
