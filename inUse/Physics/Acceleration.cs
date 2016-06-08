using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Physics
{
    public partial class Acceleration : Form
    {
        protected List<String> fileLoadedValues;
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
            // Checks if at the textboxes is text and the text is a digit and is at least 1 character lenght.
            if ((initMetersTb.TextLength == 0) || (initTimeTb.TextLength == 0) || 
                (finalVTb.TextLength == 0) || (finalTimeTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initMetersTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalVTb.Text, "[^0-9]")))
            {
                MessageBox.Show("Please enter only numbers.");
            }
            else
            {
                double vInitial = 0; double vFinal = 0;
                double tInitial = 0; double tFinal = 0;
                double acceleration;
                    tFinal = Math.Abs(Convert.ToDouble(finalTimeTb.Text));
                if (Convert.ToDouble(initTimeTb.Text) >= 0)
                    tInitial = Math.Abs(Convert.ToDouble(initTimeTb.Text));
                //if (Convert.ToDouble(finalVTb) >= 0) // No sense,may be a negative velocity
                vFinal = Convert.ToDouble(finalVTb.Text);
                //if (Convert.ToDouble(initTimeTb) >= 0) // No sense,may be a negative velocity
                vInitial = Convert.ToDouble(initMetersTb.Text);

                double deltaOfV = vFinal - vInitial;
                double deltaOfT = tFinal - tInitial;
                try
                {
                    acceleration = deltaOfV / deltaOfT;
                    resultTb.Text = Convert.ToString(acceleration) + " m/s";
                }
                catch(DivideByZeroException)
                {
                    MessageBox.Show("Can't divide by zero");
                }
            }
        }

        private void solveBt_Click(object sender, EventArgs e)
        {
            // If at textboxes is text and the text isn't a digit, prints message.
            if(((initMetersTb.TextLength == 0) || (initTimeTb.TextLength == 0) ||
                (finalVTb.TextLength == 0) || (finalTimeTb.TextLength == 0) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalTimeTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(initMetersTb.Text, "[^0-9]")) ||
                (System.Text.RegularExpressions.Regex.IsMatch(finalVTb.Text, "[^0-9]"))))
            {
                resultTb.Text = "Enter valid time";
            }
            else
            {
                SolveAccelerationEq();
                SaveHistoricalFile();
            }
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
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "phy"; // No need the user to input an extension.
                saveFile.AddExtension = true; // Auto add the default extension.
                saveFile.OverwritePrompt = false; // Overwrite alert message not show | *Change to true to show alert message.
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // If the file is named correctly, then we start the saving process.
                    using (Stream stream = File.Open(saveFile.FileName, FileMode.Append))
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write("Acceleration Equation:");
                        writer.WriteLine();
                        writer.Write("\t Initial Time = " + initT + " | "
                        + "Final time = " + finalT + " | Initial velocity = " + initV + " | " +
                        "Final velocity = " + finalV + " | Result: " + result + "\n");
                        writer.WriteLine();
                        writer.Write("---------------------------------------------------------------------" +
                            "--------------------------------------------------------------------------------");
                        writer.WriteLine();
                    }
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
                MessageBox.Show("Uknown exception");
            }
        }

        // To show the historical file at a richtextbox
        private void historicalOfSolutionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide elements when click the menustrip
            initTimeTb.Visible = false;
            initTimeLb.Visible = false;
            initMetersLb.Visible = false;
            finalTimeLb.Visible = false;
            finalTimeTb.Visible = false;
            initMetersTb.Visible = false;
            initMetersLb.Visible = false;
            finalTimeTb.Visible = false;
            finalTimeLb.Visible = false;
            resultLb.Visible = false;
            resultTb.Visible = false;

            // Show elements when click the menustrip
            historicalLb.Visible = true;
            historicalRTB.Visible = true;
            backBt.Visible = true;

            
                
            OpenFileDialog loadHistorical = new OpenFileDialog();

            // Initialize the filter to look for text files.
            loadHistorical.Filter = "PHY Files|*.phy";

            // If the user selects a file, loads its contents into the RichTextBox. 
            if (loadHistorical.ShowDialog() == DialogResult.OK)
                historicalRTB.LoadFile(loadHistorical.FileName,
                RichTextBoxStreamType.PlainText);
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            // Hide elements
            backBt.Visible = false;
            historicalLb.Visible = false;
            historicalRTB.Visible = false;

            // Show elements
            initTimeTb.Visible = true;
            initMetersLb.Visible = true;
            finalTimeLb.Visible = true;
            finalTimeTb.Visible = true;
            initMetersTb.Visible = true;
            initMetersLb.Visible = true;
            finalTimeTb.Visible = true;
            finalTimeLb.Visible = true;
            resultLb.Visible = true;
            initTimeLb.Visible = true;
            resultTb.Visible = true;
        }

        public void SaveHistoricalFile()
        {
            // Grab all the textbox values
            string initT = initTimeTb.Text;
            string finalT = finalTimeTb.Text;
            string initV = initMetersTb.Text;
            string finalV = finalTimeTb.Text;
            string result = resultTb.Text;

            try
            {
                // Process of writing to a internal historical file.
                string fileName = "historical.phy";
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write("Acceleration Equation:");
                    writer.WriteLine();
                    writer.Write("\t Initial Time = " + initT + " | "
                    + "Final time = " + finalT + " | Initial velocity = " + initV + " | " +
                    "Final velocity = " + finalV + " | Result: " + result + "\n");
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
                MessageBox.Show("Unknown exception");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
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

        public void LoadValuesFromFile()
        {
            DialogResult result = openUserFile.ShowDialog();
            // TODO: Load all the values of the equation to solve 
            // from the file the user puts at the openfiledialog.
        }
    }
}
