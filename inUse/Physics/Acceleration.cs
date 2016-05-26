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
    public partial class Acceleration : Form
    {
        public Acceleration()
        {
            InitializeComponent();
        }

        // Method to solve the acceleration equation
        /* Follow the formula of the equation to understand it.
         * If a class named as position or energy needs a method to solve its equation,
         * follow the formula and apply to solve the equation. As I do above. 
         * */
        public void SolveAccelerationEq()
        {
            double vInitial = 0; double vFinal = 0;
            double tInitial = 0; double tFinal = 0;
            double acceleration;
            if (Convert.ToDouble(finalTimeTb.Text) >= 0)
                tFinal = Convert.ToDouble(finalTimeTb.Text);
            if (Convert.ToDouble(initTimeTb.Text) >= 0)
                tInitial = Convert.ToDouble(initTimeTb.Text);
            //if (Convert.ToDouble(finalVTb) >= 0) // No sense,may be a negative velocity
            vFinal = Convert.ToDouble(finalVTb.Text);
            //if (Convert.ToDouble(initTimeTb) >= 0) // No sense,may be a negative velocity
            vInitial = Convert.ToDouble(initMetersTb.Text);

            double deltaOfV = vFinal - vInitial;
            double deltaOfT = tFinal - tInitial;
            acceleration = deltaOfV / deltaOfT;

            resultTb.Text = Convert.ToString(acceleration) + " m/s";
        }

        private void solveBt_Click(object sender, EventArgs e)
        {
            SolveAccelerationEq();
        }

        private void exportResultToAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolveAccelerationEq();

            // Grab all the textbox values
            string initT = initTimeTb.Text;
            string finalT = finalTimeTb.Text;
            string initV = initMetersTb.Text;
            string finalV = finalTimeTb.Text;
            string result = resultTb.Text;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "phy"; // No need the user to input an extension.
            saveFile.AddExtension = true; // Auto add the default extension.
            saveFile.OverwritePrompt = false; // Overwrite alert message not show | *Change to true to show alert message.
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(saveFile.FileName, FileMode.Append))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write("Acceleration Equation:");
                    writer.WriteLine();
                    writer.Write("\t Initial Time = " + initT + " | "
                    + "Final time = " + finalT + " | Initial velocity = " + initV + " | " +
                    "Final velocity = " + finalV + " | Result: " + result + "\n");
                    writer.WriteLine();
                    writer.Write("-------------------------------------------------------------"+
                        "-----------------------------------------------");
                    writer.WriteLine();
                }
            }
        }

        // Export to a file as a history of solved acceleration equations
        // Code to test
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //Method nº1 of export
            //################################################################
            // Get all values of the textboxes as a string
            string initT = initTimeTb.Text;
            string finalT = finalTimeTb.Text;
            string initV = initMetersTb.Text;
            string finalV = finalTimeTb.Text;
            string result = resultTb.Text;

            SaveFileDialog saveFile = new SaveFileDialog();
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(saveFile.FileName, FileMode.CreateNew))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write("Acceleration Equation: Initial Time = " + initT + " | "
                    +"Final time = "+ finalT +" | Initial velocity = "+ initV +" | " +
                    "Final velocity = "+ finalV +" | Result: "+ result +"\n");
                }
            }
            //Method nº2 of export 
            //##################################################################

            // Get all values of the textboxes as a string
            //string initT = initTimeTb.Text;
            //string finalT = finalTimeTb.Text;
            //string initV = initMetersTb.Text;
            //string finalV = finalTimeTb.Text;
            //string result = resultTb.Text;

            //string fileName = saveFileDialog.FileName; // To get the name of the file.

            //// This string is gonna be saved at the file as a line, each solution will be at a new line. 
            //string data = "Acceleration Equation: Initial Time = "+ initT +" | "
            //    +"Final time = "+ finalT +" | Initial velocity = "+ initV +" | " +
            //    "Final velocity = "+ finalV +" | Result: "+ result +"\n";

            //if (!File.Exists(fileName))
            //    File.CreateText(fileName);
            //// No need to close the file, this method autoclose the file when finished writing.
            //File.AppendAllText(fileName, data); 
        }

        // To show the historical file at a richtextbox
        private void historicalOfSolutionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // For more info about using the openfiledialog: http://stackoverflow.com/questions/16136383/reading-a-text-file-using-openfiledialog-in-windows-forms
            // I need to show the historical of all the acceleration results at a richtextbox by now
            // in a future the load of historical results will be at a new windows forms class called solved
            // equations and it will load al the results that are recorded in a file. Such as acceleration,
            // position, energy,etc... all loaded at the richtextbox.
        }
    }
}
