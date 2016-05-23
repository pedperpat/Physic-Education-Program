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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backBt = new System.Windows.Forms.Button();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graphicPlotter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultEq = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btSolve = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicPlotter)).BeginInit();
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
            this.backBt.Location = new System.Drawing.Point(375, 27);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(133, 33);
            this.backBt.TabIndex = 1;
            this.backBt.Text = "Go back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // tbProblem
            // 
            this.tbProblem.Location = new System.Drawing.Point(119, 68);
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(120, 20);
            this.tbProblem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter physic equation:";
            // 
            // graphicPlotter
            // 
            chartArea1.Name = "ChartArea1";
            this.graphicPlotter.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graphicPlotter.Legends.Add(legend1);
            this.graphicPlotter.Location = new System.Drawing.Point(4, 104);
            this.graphicPlotter.Name = "graphicPlotter";
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Graphic Result";
            this.graphicPlotter.Series.Add(series1);
            this.graphicPlotter.Size = new System.Drawing.Size(305, 173);
            this.graphicPlotter.TabIndex = 4;
            this.graphicPlotter.Text = "graphicEq";
            this.graphicPlotter.Click += new System.EventHandler(this.graphicPlotter_Click);
            // 
            // resultEq
            // 
            this.resultEq.AutoSize = true;
            this.resultEq.Location = new System.Drawing.Point(329, 104);
            this.resultEq.Name = "resultEq";
            this.resultEq.Size = new System.Drawing.Size(40, 13);
            this.resultEq.TabIndex = 5;
            this.resultEq.Text = "Result:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // btSolve
            // 
            this.btSolve.Location = new System.Drawing.Point(248, 68);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(83, 20);
            this.btSolve.TabIndex = 7;
            this.btSolve.Text = "Solve!";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // ProblemsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 349);
            this.Controls.Add(this.btSolve);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.resultEq);
            this.Controls.Add(this.graphicPlotter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProblemsReview";
            this.Text = "ProblemsReview";
            this.Load += new System.EventHandler(this.ProblemsReview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicPlotter)).EndInit();
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
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphicPlotter;
        private System.Windows.Forms.Label resultEq;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btSolve;
    }
}