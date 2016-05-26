namespace Physics
{
    partial class Acceleration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceleration));
            this.initTimeLb = new System.Windows.Forms.Label();
            this.formulaPb = new System.Windows.Forms.PictureBox();
            this.initTimeTb = new System.Windows.Forms.TextBox();
            this.finalTimeLb = new System.Windows.Forms.Label();
            this.finalTimeTb = new System.Windows.Forms.TextBox();
            this.initMetersLb = new System.Windows.Forms.Label();
            this.initMetersTb = new System.Windows.Forms.TextBox();
            this.finalVLb = new System.Windows.Forms.Label();
            this.finalVTb = new System.Windows.Forms.TextBox();
            this.solveBt = new System.Windows.Forms.Button();
            this.resultLb = new System.Windows.Forms.Label();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultToAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalOfSolutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openHistorial = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // initTimeLb
            // 
            this.initTimeLb.AutoSize = true;
            this.initTimeLb.Location = new System.Drawing.Point(12, 134);
            this.initTimeLb.Name = "initTimeLb";
            this.initTimeLb.Size = new System.Drawing.Size(71, 13);
            this.initTimeLb.TabIndex = 9;
            this.initTimeLb.Text = "Initial Time(s):";
            // 
            // formulaPb
            // 
            this.formulaPb.Image = ((System.Drawing.Image)(resources.GetObject("formulaPb.Image")));
            this.formulaPb.InitialImage = ((System.Drawing.Image)(resources.GetObject("formulaPb.InitialImage")));
            this.formulaPb.Location = new System.Drawing.Point(135, 58);
            this.formulaPb.Name = "formulaPb";
            this.formulaPb.Size = new System.Drawing.Size(264, 54);
            this.formulaPb.TabIndex = 13;
            this.formulaPb.TabStop = false;
            // 
            // initTimeTb
            // 
            this.initTimeTb.Location = new System.Drawing.Point(79, 131);
            this.initTimeTb.Name = "initTimeTb";
            this.initTimeTb.Size = new System.Drawing.Size(47, 20);
            this.initTimeTb.TabIndex = 14;
            // 
            // finalTimeLb
            // 
            this.finalTimeLb.AutoSize = true;
            this.finalTimeLb.Location = new System.Drawing.Point(132, 134);
            this.finalTimeLb.Name = "finalTimeLb";
            this.finalTimeLb.Size = new System.Drawing.Size(69, 13);
            this.finalTimeLb.TabIndex = 18;
            this.finalTimeLb.Text = "Final Time(s):";
            // 
            // finalTimeTb
            // 
            this.finalTimeTb.Location = new System.Drawing.Point(198, 131);
            this.finalTimeTb.Name = "finalTimeTb";
            this.finalTimeTb.Size = new System.Drawing.Size(46, 20);
            this.finalTimeTb.TabIndex = 19;
            // 
            // initMetersLb
            // 
            this.initMetersLb.AutoSize = true;
            this.initMetersLb.Location = new System.Drawing.Point(250, 134);
            this.initMetersLb.Name = "initMetersLb";
            this.initMetersLb.Size = new System.Drawing.Size(68, 13);
            this.initMetersLb.TabIndex = 20;
            this.initMetersLb.Text = "Initial V(m/s):";
            // 
            // initMetersTb
            // 
            this.initMetersTb.Location = new System.Drawing.Point(315, 131);
            this.initMetersTb.Name = "initMetersTb";
            this.initMetersTb.Size = new System.Drawing.Size(44, 20);
            this.initMetersTb.TabIndex = 21;
            // 
            // finalVLb
            // 
            this.finalVLb.AutoSize = true;
            this.finalVLb.Location = new System.Drawing.Point(365, 134);
            this.finalVLb.Name = "finalVLb";
            this.finalVLb.Size = new System.Drawing.Size(66, 13);
            this.finalVLb.TabIndex = 22;
            this.finalVLb.Text = "Final V(m/s):";
            // 
            // finalVTb
            // 
            this.finalVTb.Location = new System.Drawing.Point(428, 131);
            this.finalVTb.Name = "finalVTb";
            this.finalVTb.Size = new System.Drawing.Size(44, 20);
            this.finalVTb.TabIndex = 23;
            // 
            // solveBt
            // 
            this.solveBt.Location = new System.Drawing.Point(207, 189);
            this.solveBt.Name = "solveBt";
            this.solveBt.Size = new System.Drawing.Size(111, 30);
            this.solveBt.TabIndex = 24;
            this.solveBt.Text = "Solve!";
            this.solveBt.UseVisualStyleBackColor = true;
            this.solveBt.Click += new System.EventHandler(this.solveBt_Click);
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLb.Location = new System.Drawing.Point(131, 264);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(66, 20);
            this.resultLb.TabIndex = 25;
            this.resultLb.Text = "Result:";
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(207, 266);
            this.resultTb.Name = "resultTb";
            this.resultTb.ReadOnly = true;
            this.resultTb.Size = new System.Drawing.Size(123, 20);
            this.resultTb.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Acceleration Formula";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportResultToAFileToolStripMenuItem,
            this.historicalOfSolutionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportResultToAFileToolStripMenuItem
            // 
            this.exportResultToAFileToolStripMenuItem.Name = "exportResultToAFileToolStripMenuItem";
            this.exportResultToAFileToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exportResultToAFileToolStripMenuItem.Text = "Export result to a file";
            this.exportResultToAFileToolStripMenuItem.Click += new System.EventHandler(this.exportResultToAFileToolStripMenuItem_Click);
            // 
            // historicalOfSolutionsToolStripMenuItem
            // 
            this.historicalOfSolutionsToolStripMenuItem.Name = "historicalOfSolutionsToolStripMenuItem";
            this.historicalOfSolutionsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.historicalOfSolutionsToolStripMenuItem.Text = "Historical of solutions";
            this.historicalOfSolutionsToolStripMenuItem.Click += new System.EventHandler(this.historicalOfSolutionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "phy";
            // 
            // Acceleration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.solveBt);
            this.Controls.Add(this.finalVTb);
            this.Controls.Add(this.finalVLb);
            this.Controls.Add(this.initMetersTb);
            this.Controls.Add(this.initMetersLb);
            this.Controls.Add(this.finalTimeTb);
            this.Controls.Add(this.finalTimeLb);
            this.Controls.Add(this.initTimeTb);
            this.Controls.Add(this.formulaPb);
            this.Controls.Add(this.initTimeLb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acceleration";
            this.Text = "Acceleration";
            ((System.ComponentModel.ISupportInitialize)(this.formulaPb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initTimeLb;
        private System.Windows.Forms.PictureBox formulaPb;
        private System.Windows.Forms.TextBox initTimeTb;
        private System.Windows.Forms.Label finalTimeLb;
        private System.Windows.Forms.TextBox finalTimeTb;
        private System.Windows.Forms.Label initMetersLb;
        private System.Windows.Forms.TextBox initMetersTb;
        private System.Windows.Forms.Label finalVLb;
        private System.Windows.Forms.TextBox finalVTb;
        private System.Windows.Forms.Button solveBt;
        private System.Windows.Forms.Label resultLb;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportResultToAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalOfSolutionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openHistorial;
    }
}