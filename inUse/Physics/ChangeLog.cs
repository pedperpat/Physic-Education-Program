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
    public partial class ChangeLog : Form
    {
        public ChangeLog()
        {
            InitializeComponent();
            ReadFile();
        }

        public void ReadFile()
        {
            try
            {
                if (!File.Exists("changelog.txt"))
                {
                    changeLogRTB.Text = "Changelog file is not available";
                }
                else
                {
                    //Simplified way to load a formatted text file.
                    TextReader reader = File.OpenText(@"changelog.txt");
                    changeLogRTB.Text = reader.ReadToEnd();


                    // Old way to load a text file and show at the richtextbox.
                    //StreamReader inFile = new StreamReader("changelog.txt");

                    //string line;
                    //do
                    //{
                    //    line = inFile.ReadLine();

                    //    if (line != null)
                    //    {
                    //        changeLogRTB.Text = line;
                    //    }
                    //}
                    //while (line != null);
                }
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch(IOException ex)
            {
                Console.WriteLine("In/Out exception {0}",ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Uknown exception {0}",ex);
            }
            
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Hide();
            ms.ShowDialog();
        }
    }
}
