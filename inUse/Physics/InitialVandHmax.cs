﻿using System;
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

        // Initial V method to get the initial velocity when a bullet it's shooted.
        public string GetInitialV()
        {
            if((totalTimeTb.TextLength == 0) || (System.Text.RegularExpressions.Regex.IsMatch(totalTimeTb.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only numbers.");
                totalTimeTb.Text.Remove(totalTimeTb.Text.Length - 1);
                return totalTimeTb.Text;
            }
            else
            {
                double v0 = 0; double vf = 0;
                double totalTime = Convert.ToDouble(totalTimeTb.Text) / 2;
                v0 = G * totalTime; // Aplying V equation "vf = vo + G * t"
                resultVoTb.Text = Convert.ToString(v0) + " m/s";
                return resultVoTb.Text;
            }
        }

        // Max height that the proyectile can reach.
        public string GetHmax()
        {
            string[] voWithoutUnit = GetInitialV().Split(' '); // Get the value of Vo and remove the "m/s" string
            double v0 = Convert.ToDouble(voWithoutUnit[0]);
            double time = Convert.ToDouble(totalTimeTb.Text) / 2;

            /* Aplying final position formula, as we know the initial position is 0 and we know the time and v0
             * we can calculate the final position incognita with the actual values.
             */
            double Hmax = v0 * time - 0.5 * G * time * time;

            resultHmaxTb.Text = Convert.ToString(Hmax) + " m";
            return resultHmaxTb.Text;
        }

        private void getVoBt_Click(object sender, EventArgs e)
        {
            GetInitialV();
            solveHmaxBt.Visible = true;
            clickbuttonLb.Visible = true;
        }

        private void solveHmaxBt_Click(object sender, EventArgs e)
        {
            if(totalTimeTb.TextLength == 0)
            {
                totalTimeTb.Text = "Enter valid time";
            }
            else
            {
                GetHmax();
                resultHmaxTb.Visible = true;
                SaveHistoricalFile();
            }
           
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }

        public void SaveHistoricalFile()
        {
            // Grab all the textbox values
            string totalTime = totalTimeTb.Text;
            string v0 = resultVoTb.Text;
            string hmax = resultHmaxTb.Text;

            try
            {
                string fileName = "historical.phy";
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write("Vo and Hmax Equation:");
                    writer.WriteLine();
                    writer.Write("\t Total Time = " + totalTime + " | "
                    + "Initial velocity = " + v0 + " | Hmax = " + hmax + "\n");
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
