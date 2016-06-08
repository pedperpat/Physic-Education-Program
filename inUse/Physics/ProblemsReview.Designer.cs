namespace Physics
{
    partial class ProblemsReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemsReview));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backBt = new System.Windows.Forms.Button();
            this.initTimeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultEq = new System.Windows.Forms.Label();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.btSolve = new System.Windows.Forms.Button();
            this.lbFinalTime = new System.Windows.Forms.Label();
            this.finalTTb = new System.Windows.Forms.TextBox();
            this.initVLb = new System.Windows.Forms.Label();
            this.initVTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.finalVTb = new System.Windows.Forms.TextBox();
            this.solutionLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.solutionTb = new System.Windows.Forms.TextBox();
            this.greenTickPb = new System.Windows.Forms.PictureBox();
            this.redTickPb = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTickPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTickPb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(363, 244);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(133, 33);
            this.backBt.TabIndex = 1;
            this.backBt.Text = "Go back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // initTimeTb
            // 
            this.initTimeTb.Location = new System.Drawing.Point(84, 61);
            this.initTimeTb.Name = "initTimeTb";
            this.initTimeTb.ReadOnly = true;
            this.initTimeTb.Size = new System.Drawing.Size(45, 20);
            this.initTimeTb.TabIndex = 2;
            this.initTimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initial time:";
            // 
            // resultEq
            // 
            this.resultEq.AutoSize = true;
            this.resultEq.Location = new System.Drawing.Point(287, 179);
            this.resultEq.Name = "resultEq";
            this.resultEq.Size = new System.Drawing.Size(40, 13);
            this.resultEq.TabIndex = 5;
            this.resultEq.Text = "Result:";
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(290, 205);
            this.resultTb.Name = "resultTb";
            this.resultTb.ReadOnly = true;
            this.resultTb.Size = new System.Drawing.Size(100, 20);
            this.resultTb.TabIndex = 6;
            this.resultTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSolve
            // 
            this.btSolve.Location = new System.Drawing.Point(193, 190);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(83, 35);
            this.btSolve.TabIndex = 7;
            this.btSolve.Text = "Solve!";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // lbFinalTime
            // 
            this.lbFinalTime.AutoSize = true;
            this.lbFinalTime.Location = new System.Drawing.Point(147, 64);
            this.lbFinalTime.Name = "lbFinalTime";
            this.lbFinalTime.Size = new System.Drawing.Size(54, 13);
            this.lbFinalTime.TabIndex = 8;
            this.lbFinalTime.Text = "Final time:";
            // 
            // finalTTb
            // 
            this.finalTTb.Location = new System.Drawing.Point(207, 61);
            this.finalTTb.Name = "finalTTb";
            this.finalTTb.ReadOnly = true;
            this.finalTTb.Size = new System.Drawing.Size(46, 20);
            this.finalTTb.TabIndex = 9;
            this.finalTTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // initVLb
            // 
            this.initVLb.AutoSize = true;
            this.initVLb.Location = new System.Drawing.Point(274, 64);
            this.initVLb.Name = "initVLb";
            this.initVLb.Size = new System.Drawing.Size(44, 13);
            this.initVLb.TabIndex = 10;
            this.initVLb.Text = "Initial V:";
            // 
            // initVTb
            // 
            this.initVTb.Location = new System.Drawing.Point(331, 61);
            this.initVTb.Name = "initVTb";
            this.initVTb.ReadOnly = true;
            this.initVTb.Size = new System.Drawing.Size(59, 20);
            this.initVTb.TabIndex = 11;
            this.initVTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Final V:";
            // 
            // finalVTb
            // 
            this.finalVTb.Location = new System.Drawing.Point(449, 61);
            this.finalVTb.Name = "finalVTb";
            this.finalVTb.ReadOnly = true;
            this.finalVTb.Size = new System.Drawing.Size(59, 20);
            this.finalVTb.TabIndex = 13;
            this.finalVTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // solutionLb
            // 
            this.solutionLb.AutoSize = true;
            this.solutionLb.Location = new System.Drawing.Point(147, 126);
            this.solutionLb.Name = "solutionLb";
            this.solutionLb.Size = new System.Drawing.Size(60, 13);
            this.solutionLb.TabIndex = 14;
            this.solutionLb.Text = "¿Solution?:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Acceleration equation";
            // 
            // solutionTb
            // 
            this.solutionTb.Location = new System.Drawing.Point(213, 123);
            this.solutionTb.Name = "solutionTb";
            this.solutionTb.Size = new System.Drawing.Size(73, 20);
            this.solutionTb.TabIndex = 16;
            this.solutionTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greenTickPb
            // 
            this.greenTickPb.Image = ((System.Drawing.Image)(resources.GetObject("greenTickPb.Image")));
            this.greenTickPb.Location = new System.Drawing.Point(313, 107);
            this.greenTickPb.Name = "greenTickPb";
            this.greenTickPb.Size = new System.Drawing.Size(23, 22);
            this.greenTickPb.TabIndex = 17;
            this.greenTickPb.TabStop = false;
            this.greenTickPb.Visible = false;
            // 
            // redTickPb
            // 
            this.redTickPb.Image = ((System.Drawing.Image)(resources.GetObject("redTickPb.Image")));
            this.redTickPb.Location = new System.Drawing.Point(313, 135);
            this.redTickPb.Name = "redTickPb";
            this.redTickPb.Size = new System.Drawing.Size(24, 22);
            this.redTickPb.TabIndex = 18;
            this.redTickPb.TabStop = false;
            this.redTickPb.Visible = false;
            // 
            // ProblemsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 349);
            this.Controls.Add(this.redTickPb);
            this.Controls.Add(this.greenTickPb);
            this.Controls.Add(this.solutionTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solutionLb);
            this.Controls.Add(this.finalVTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initVTb);
            this.Controls.Add(this.initVLb);
            this.Controls.Add(this.finalTTb);
            this.Controls.Add(this.lbFinalTime);
            this.Controls.Add(this.btSolve);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.resultEq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initTimeTb);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProblemsReview";
            this.Text = "ProblemsReview";
            this.Load += new System.EventHandler(this.ProblemsReview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTickPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTickPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.TextBox initTimeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultEq;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.Label lbFinalTime;
        private System.Windows.Forms.TextBox finalTTb;
        private System.Windows.Forms.Label initVLb;
        private System.Windows.Forms.TextBox initVTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finalVTb;
        private System.Windows.Forms.Label solutionLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox solutionTb;
        private System.Windows.Forms.PictureBox greenTickPb;
        private System.Windows.Forms.PictureBox redTickPb;
    }
}