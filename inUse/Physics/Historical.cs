using System;
using System.IO;
using System.Windows.Forms;

namespace Physics
{
    public partial class Historical : Form
    {
        private Button backBt;
        private Button resetBt;
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

        private void InitializeComponent()
        {
            this.backBt = new System.Windows.Forms.Button();
            this.historicalRTB = new System.Windows.Forms.RichTextBox();
            this.resetBt = new System.Windows.Forms.Button();
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
            // resetBt
            // 
            this.resetBt.Location = new System.Drawing.Point(67, 354);
            this.resetBt.Name = "resetBt";
            this.resetBt.Size = new System.Drawing.Size(76, 46);
            this.resetBt.TabIndex = 2;
            this.resetBt.Text = "Reset historical file";
            this.resetBt.UseVisualStyleBackColor = true;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
            // 
            // Historical
            // 
            this.ClientSize = new System.Drawing.Size(640, 417);
            this.Controls.Add(this.resetBt);
            this.Controls.Add(this.historicalRTB);
            this.Controls.Add(this.backBt);
            this.Name = "Historical";
            this.Load += new System.EventHandler(this.Historical_Load);
            this.ResumeLayout(false);

        }

        private void Historical_Load(object sender, EventArgs e)
        {


            LoadHistoricalFile();
            PassDataFromMainScreen();
        }

        private void backBt_Click_1(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Hide();
            ms.ShowDialog();
        }

        public void DeleteHistorical()
        {
            File.Delete("historical.phy");
        }

        // When the user click the button to reset,a prompt appears to confirm the action or abort.
        private void resetBt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to wipe the internal historical" +
               " file? Are you sure", "Caution",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteHistorical();
                LoadHistoricalFile();
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("Operation aborted");
            }
        }

        private void PassDataFromMainScreen()
        {
            backBt.Text = MainScreen.BackBt;
            resetBt.Text = MainScreen.HistResetBt;
        }
    }
}
