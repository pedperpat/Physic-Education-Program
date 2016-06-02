namespace Physics
{
    partial class Concepts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concepts));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBoxTb = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.nextSearchBt = new System.Windows.Forms.Button();
            this.previousSearchBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveActualConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConceptsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConceptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptsRTB = new System.Windows.Forms.RichTextBox();
            this.zoomMore = new System.Windows.Forms.Button();
            this.zoomLess = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some concepts to remember:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter something to search: ";
            // 
            // searchBoxTb
            // 
            this.searchBoxTb.Location = new System.Drawing.Point(296, 46);
            this.searchBoxTb.Name = "searchBoxTb";
            this.searchBoxTb.Size = new System.Drawing.Size(100, 20);
            this.searchBoxTb.TabIndex = 3;
            this.searchBoxTb.Text = "word to search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(402, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nextSearchBt
            // 
            this.nextSearchBt.Location = new System.Drawing.Point(564, 44);
            this.nextSearchBt.Name = "nextSearchBt";
            this.nextSearchBt.Size = new System.Drawing.Size(75, 23);
            this.nextSearchBt.TabIndex = 5;
            this.nextSearchBt.Text = "Next";
            this.nextSearchBt.UseVisualStyleBackColor = true;
            // 
            // previousSearchBt
            // 
            this.previousSearchBt.Location = new System.Drawing.Point(483, 43);
            this.previousSearchBt.Name = "previousSearchBt";
            this.previousSearchBt.Size = new System.Drawing.Size(75, 23);
            this.previousSearchBt.TabIndex = 6;
            this.previousSearchBt.Text = "Previous";
            this.previousSearchBt.UseVisualStyleBackColor = true;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(678, 32);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(72, 46);
            this.backBt.TabIndex = 7;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveActualConceptsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveActualConceptsToolStripMenuItem
            // 
            this.saveActualConceptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeConceptsToolStripMenuItem,
            this.loadConceptsToolStripMenuItem,
            this.loadConceptsToolStripMenuItem1,
            this.saveConceptFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.saveActualConceptsToolStripMenuItem.Name = "saveActualConceptsToolStripMenuItem";
            this.saveActualConceptsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveActualConceptsToolStripMenuItem.Text = "File";
            // 
            // writeConceptsToolStripMenuItem
            // 
            this.writeConceptsToolStripMenuItem.Name = "writeConceptsToolStripMenuItem";
            this.writeConceptsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.writeConceptsToolStripMenuItem.Text = "Write concepts";
            this.writeConceptsToolStripMenuItem.Click += new System.EventHandler(this.writeConceptsToolStripMenuItem_Click);
            // 
            // loadConceptsToolStripMenuItem
            // 
            this.loadConceptsToolStripMenuItem.Name = "loadConceptsToolStripMenuItem";
            this.loadConceptsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadConceptsToolStripMenuItem.Text = "Example concepts";
            this.loadConceptsToolStripMenuItem.Click += new System.EventHandler(this.loadConceptsToolStripMenuItem_Click);
            // 
            // loadConceptsToolStripMenuItem1
            // 
            this.loadConceptsToolStripMenuItem1.Name = "loadConceptsToolStripMenuItem1";
            this.loadConceptsToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.loadConceptsToolStripMenuItem1.Text = "Load concepts";
            // 
            // saveConceptFileToolStripMenuItem
            // 
            this.saveConceptFileToolStripMenuItem.Name = "saveConceptFileToolStripMenuItem";
            this.saveConceptFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveConceptFileToolStripMenuItem.Text = "Save concepts";
            this.saveConceptFileToolStripMenuItem.Click += new System.EventHandler(this.saveConceptFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // conceptsRTB
            // 
            this.conceptsRTB.Location = new System.Drawing.Point(72, 114);
            this.conceptsRTB.Name = "conceptsRTB";
            this.conceptsRTB.Size = new System.Drawing.Size(701, 262);
            this.conceptsRTB.TabIndex = 9;
            this.conceptsRTB.Text = resources.GetString("conceptsRTB.Text");
            // 
            // zoomMore
            // 
            this.zoomMore.Location = new System.Drawing.Point(402, 85);
            this.zoomMore.Name = "zoomMore";
            this.zoomMore.Size = new System.Drawing.Size(75, 23);
            this.zoomMore.TabIndex = 10;
            this.zoomMore.Text = "Zoom +";
            this.zoomMore.UseVisualStyleBackColor = true;
            this.zoomMore.Click += new System.EventHandler(this.zoomMore_Click);
            // 
            // zoomLess
            // 
            this.zoomLess.Location = new System.Drawing.Point(483, 85);
            this.zoomLess.Name = "zoomLess";
            this.zoomLess.Size = new System.Drawing.Size(75, 23);
            this.zoomLess.TabIndex = 11;
            this.zoomLess.Text = "Zoom -";
            this.zoomLess.UseVisualStyleBackColor = true;
            this.zoomLess.Click += new System.EventHandler(this.zoomLess_Click);
            // 
            // Concepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 388);
            this.Controls.Add(this.zoomLess);
            this.Controls.Add(this.zoomMore);
            this.Controls.Add(this.conceptsRTB);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.previousSearchBt);
            this.Controls.Add(this.nextSearchBt);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBoxTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Concepts";
            this.Text = "Concepts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBoxTb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button nextSearchBt;
        private System.Windows.Forms.Button previousSearchBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveActualConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConceptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox conceptsRTB;
        private System.Windows.Forms.ToolStripMenuItem loadConceptsToolStripMenuItem1;
        private System.Windows.Forms.Button zoomMore;
        private System.Windows.Forms.Button zoomLess;
    }
}