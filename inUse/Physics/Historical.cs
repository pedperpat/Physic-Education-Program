using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class Historical : Form
    {
        private Button backBt;
        private RichTextBox historicalRTB;

        public Historical()
        {
            InitializeComponent();
        }

        public void LoadHistoricalFile()
        {
            try
            {
                if (!File.Exists("historical.phy"))
                {
                    historicalRTB.Text = "Historical file is not available";
                }
                else
                {
                    //Simplified way to load a formatted text file.
                    TextReader reader = File.OpenText("historical.phy");
                    historicalRTB.Text = reader.ReadToEnd();

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

        private void InitializeComponent()
        {
            this.backBt = new System.Windows.Forms.Button();
            this.historicalRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(252, 350);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(156, 55);
            this.backBt.TabIndex = 0;
            this.backBt.Text = "Go back!";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click_1);
            // 
            // historicalRTB
            // 
            this.historicalRTB.Location = new System.Drawing.Point(12, 12);
            this.historicalRTB.Name = "historicalRTB";
            this.historicalRTB.ReadOnly = true;
            this.historicalRTB.Size = new System.Drawing.Size(616, 332);
            this.historicalRTB.TabIndex = 1;
            this.historicalRTB.Text = "";
            // 
            // Historical
            // 
            this.ClientSize = new System.Drawing.Size(640, 417);
            this.Controls.Add(this.historicalRTB);
            this.Controls.Add(this.backBt);
            this.Name = "Historical";
            this.Load += new System.EventHandler(this.Historical_Load);
            this.ResumeLayout(false);

        }

        private void Historical_Load(object sender, EventArgs e)
        {
            LoadHistoricalFile();
        }

        private void backBt_Click_1(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Hide();
            ms.ShowDialog();
        }
    }
}
