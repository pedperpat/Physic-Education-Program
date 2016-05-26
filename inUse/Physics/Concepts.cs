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
    }
}
