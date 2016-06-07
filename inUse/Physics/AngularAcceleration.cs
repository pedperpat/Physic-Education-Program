using System;
using System.IO;
using System.Windows.Forms;

namespace Physics
{
    public partial class AngularAcceleration : Form
    {
        public AngularAcceleration()
        {
            InitializeComponent();
        }

        private void goMainBt_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Hide();
            ms.ShowDialog();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Equations eq = new Equations();
            Hide();
            eq.ShowDialog();
        }

        private void solveBt_Click(object sender, EventArgs e)
        {
            // If at textboxes is text and the text isn't a digit, prints message.
            if (((initAngVTb.TextLength == 0) || (finalAngVTb.TextLength == 0) ||
                (initTimeTb.TextLength == 0) || (finalTimeTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initAngVTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalAngVTb.Text, "[^0-9]"))))
            {
                resultTb.Text = "Enter valid values";
            }
            else
            {
                SolveAngularAcceleration();
                SaveHistoricalFile();
            }
        }

        public void SaveHistoricalFile()
        {
            // Grab all the textbox values
            string initT = initTimeTb.Text;
            string finalT = finalTimeTb.Text;
            string initAngV = initAngVTb.Text;
            string finalAngV = finalAngVTb.Text;
            string result = resultTb.Text;

            try
            {
                // Process of writing to a internal historical file.
                string fileName = "historical.phy";
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write("Angular Acceleration Equation:");
                    writer.WriteLine();
                    writer.Write("\t Initial Time = " + initT + " | "
                    + "Final time = " + finalT + " | Initial angular velocity = " + initAngV + " | " +
                    "Final angular velocity = " + finalAngV + " | Result: " + result + "\n");
                    writer.WriteLine();
                    writer.Write("---------------------------------------------------------------------" +
                        "--------------------------------------------------------------------------------");
                    writer.WriteLine();
                }
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Path too long");
            }
            catch (IOException)
            {
                MessageBox.Show("In/Out exception");
            }
            catch (Exception)
            {
                MessageBox.Show("Unkown exception");
            }
        }

        // Method to solve the angular acceleration using the formula of angular acceleration
        public void SolveAngularAcceleration()
        {

            // If at textboxes is text and the text isn't a digit, prints message.
            if (((initAngVTb.TextLength == 0) || (finalAngVTb.TextLength == 0) ||
                (initTimeTb.TextLength == 0) || (finalTimeTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initAngVTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalAngVTb.Text, "[^0-9]"))))
            {
                resultTb.Text = "Enter valid values";
            }
            // If there are valid data, proceed with the logic of the formula.
            else
            {
                double initAngV = Convert.ToDouble(initAngVTb.Text);
                double finalAngV = Convert.ToDouble(finalAngVTb.Text);
                double initTime = Math.Abs(Convert.ToDouble(initTimeTb.Text));
                double finalTime = Math.Abs(Convert.ToDouble(finalTimeTb.Text));
                double deltaAngV = finalAngV - initAngV;
                double deltaTime = finalTime - initTime;
                try
                {
                    double result = deltaAngV / deltaTime;
                    resultTb.Text = Convert.ToString(result) + " m/s";
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("I can't divide by zero");
                }
            }
        }
    }
}
