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
    public partial class Concepts : Form
    {
        
        public Concepts()
        {
            InitializeComponent();
            DefaultZoomFactor();
        }

        private void backBt_Click_1(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            //Close();
            Hide();
            mainScreen.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            Hide();
            help.ShowDialog();
        }

        public void ReadConceptsFile()
        {
            try
            {
                if (!File.Exists("concepts.txt"))
                {
                    conceptsRTB.Text = "Concept file not available";
                }
                else
                {
                    //Simplified way to load a formatted text file.
                    TextReader reader = File.OpenText(@"concepts.txt");
                    conceptsRTB.Text = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("In/Out exception {0}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uknown exception {0}", ex);
            }

        }

        private void loadConceptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadConceptsFile();
            conceptsRTB.ReadOnly = true;
        }

        private void writeConceptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conceptsRTB.Clear();
            conceptsRTB.ReadOnly = false;
        }

        public void DefaultZoomFactor()
        {
            conceptsRTB.ZoomFactor = 1.0f;
        }

        private void zoomMore_Click(object sender, EventArgs e)
        {
            if(conceptsRTB.ZoomFactor < 3.0f)
                conceptsRTB.ZoomFactor++;
        }

        private void zoomLess_Click(object sender, EventArgs e)
        {
            if(conceptsRTB.ZoomFactor > 1.0f)
                conceptsRTB.ZoomFactor--;
        }

        public void SaveWrittenConcepts()
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "phy"; // No need the user to input an extension.
                saveFile.AddExtension = true; // Auto add the default extension.
                saveFile.OverwritePrompt = false; // Overwrite alert message not show 
                // *Change OverwritePrompt to true to show alert message.
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // If the file is named correctly, then we start the saving process.
                    using (Stream stream = File.Open(saveFile.FileName, FileMode.Append))
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(conceptsRTB.Text);
                    }
                }
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

        private void saveConceptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWrittenConcepts();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            HighlightAndSearch();
        }

        public void HighlightAndSearch()
        {
            try
            {
                if (conceptsRTB.Text != string.Empty)
                {// If the ritchtextbox is not empty; highlight the search criteria.
                    int index = 0;
                    String temp = conceptsRTB.Text;
                    conceptsRTB.Text = "";
                    conceptsRTB.Text = temp;
                    while (index < conceptsRTB.Text.LastIndexOf(searchBoxTb.Text))
                    {
                        conceptsRTB.Find(searchBoxTb.Text, index, searchBoxTb.TextLength, RichTextBoxFinds.None);
                        conceptsRTB.SelectionBackColor = Color.Yellow; // To highlight the encountered word.
                        index = conceptsRTB.Text.IndexOf(searchBoxTb.Text, index) + 1;
                        conceptsRTB.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
