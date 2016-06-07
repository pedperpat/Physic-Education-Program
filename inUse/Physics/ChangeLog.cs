using System;
using System.IO;
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

                    reader.Close();
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
                MessageBox.Show("Path too long");
            }
            catch(IOException)
            {
                MessageBox.Show("In/Out exception");
            }
            catch(Exception)
            {
                MessageBox.Show("Unkown exception");
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
