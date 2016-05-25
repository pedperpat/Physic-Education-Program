namespace Physics
{
    partial class Equations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equations));
            this.backBt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.normalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationOfAccelerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationOfPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationOfHmaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationOfVelocityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationOfEnergyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationOfTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eqGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eqMessageLb = new System.Windows.Forms.Label();
            this.drawBt = new System.Windows.Forms.Button();
            this.eqInputTb = new System.Windows.Forms.TextBox();
            this.resultLb = new System.Windows.Forms.Label();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.initTimeLb = new System.Windows.Forms.Label();
            this.initTimeTb = new System.Windows.Forms.TextBox();
            this.initMetersLb = new System.Windows.Forms.Label();
            this.initMetersTb = new System.Windows.Forms.TextBox();
            this.formulaPb = new System.Windows.Forms.PictureBox();
            this.formulaFinalPositionPb = new System.Windows.Forms.PictureBox();
            this.finalTimeLb = new System.Windows.Forms.Label();
            this.finalTimeTb = new System.Windows.Forms.TextBox();
            this.solveBt = new System.Windows.Forms.Button();
            this.vFinalPb = new System.Windows.Forms.PictureBox();
            this.finalVLb = new System.Windows.Forms.Label();
            this.finalVTb = new System.Windows.Forms.TextBox();
            this.accelLb = new System.Windows.Forms.Label();
            this.accelTb = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eqGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaFinalPositionPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFinalPb)).BeginInit();
            this.SuspendLayout();
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(437, 26);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(107, 30);
            this.backBt.TabIndex = 0;
            this.backBt.Text = "Go to main screen";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalModeToolStripMenuItem,
            this.plotGraphToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // normalModeToolStripMenuItem
            // 
            this.normalModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equationOfAccelerationToolStripMenuItem,
            this.equationOfPositionToolStripMenuItem,
            this.equationOfHmaxToolStripMenuItem,
            this.equationOfVelocityToolStripMenuItem,
            this.equationOfEnergyToolStripMenuItem,
            this.equationOfTimeToolStripMenuItem});
            this.normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            this.normalModeToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.normalModeToolStripMenuItem.Text = "Equation types";
            this.normalModeToolStripMenuItem.Click += new System.EventHandler(this.normalModeToolStripMenuItem_Click);
            // 
            // equationOfAccelerationToolStripMenuItem
            // 
            this.equationOfAccelerationToolStripMenuItem.Name = "equationOfAccelerationToolStripMenuItem";
            this.equationOfAccelerationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equationOfAccelerationToolStripMenuItem.Text = "Equation of acceleration";
            this.equationOfAccelerationToolStripMenuItem.Click += new System.EventHandler(this.equationOfAccelerationToolStripMenuItem_Click);
            // 
            // equationOfPositionToolStripMenuItem
            // 
            this.equationOfPositionToolStripMenuItem.Name = "equationOfPositionToolStripMenuItem";
            this.equationOfPositionToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equationOfPositionToolStripMenuItem.Text = "Equation of position";
            this.equationOfPositionToolStripMenuItem.Click += new System.EventHandler(this.equationOfPositionToolStripMenuItem_Click);
            // 
            // equationOfHmaxToolStripMenuItem
            // 
            this.equationOfHmaxToolStripMenuItem.Name = "equationOfHmaxToolStripMenuItem";
            this.equationOfHmaxToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equationOfHmaxToolStripMenuItem.Text = "Equation of initial V and Hmax";
            this.equationOfHmaxToolStripMenuItem.Click += new System.EventHandler(this.equationOfHmaxToolStripMenuItem_Click);
            // 
            // equationOfVelocityToolStripMenuItem
            // 
            this.equationOfVelocityToolStripMenuItem.Name = "equationOfVelocityToolStripMenuItem";
            this.equationOfVelocityToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equationOfVelocityToolStripMenuItem.Text = "Equation of velocity";
            this.equationOfVelocityToolStripMenuItem.Click += new System.EventHandler(this.equationOfVelocityToolStripMenuItem_Click);
            // 
            // equationOfEnergyToolStripMenuItem
            // 
            this.equationOfEnergyToolStripMenuItem.Name = "equationOfEnergyToolStripMenuItem";
            this.equationOfEnergyToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equationOfEnergyToolStripMenuItem.Text = "Equation of energy";
            this.equationOfEnergyToolStripMenuItem.Click += new System.EventHandler(this.equationOfEnergyToolStripMenuItem_Click);
            // 
            // equationOfTimeToolStripMenuItem
            // 
            this.equationOfTimeToolStripMenuItem.Name = "equationOfTimeToolStripMenuItem";
            this.equationOfTimeToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equationOfTimeToolStripMenuItem.Text = "Equation of time";
            this.equationOfTimeToolStripMenuItem.Click += new System.EventHandler(this.equationOfTimeToolStripMenuItem_Click);
            // 
            // plotGraphToolStripMenuItem
            // 
            this.plotGraphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearGraphToolStripMenuItem,
            this.saveGraphToolStripMenuItem,
            this.loadGraphToolStripMenuItem});
            this.plotGraphToolStripMenuItem.Name = "plotGraphToolStripMenuItem";
            this.plotGraphToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.plotGraphToolStripMenuItem.Text = "Plot mode";
            this.plotGraphToolStripMenuItem.Click += new System.EventHandler(this.plotGraphToolStripMenuItem_Click);
            // 
            // clearGraphToolStripMenuItem
            // 
            this.clearGraphToolStripMenuItem.Name = "clearGraphToolStripMenuItem";
            this.clearGraphToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clearGraphToolStripMenuItem.Text = "Clear graph";
            // 
            // saveGraphToolStripMenuItem
            // 
            this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
            this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveGraphToolStripMenuItem.Text = "Save graph";
            // 
            // loadGraphToolStripMenuItem
            // 
            this.loadGraphToolStripMenuItem.Name = "loadGraphToolStripMenuItem";
            this.loadGraphToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadGraphToolStripMenuItem.Text = "Load Graph";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click_1);
            // 
            // eqGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.eqGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.eqGraph.Legends.Add(legend1);
            this.eqGraph.Location = new System.Drawing.Point(278, 62);
            this.eqGraph.Name = "eqGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Position";
            this.eqGraph.Series.Add(series1);
            this.eqGraph.Size = new System.Drawing.Size(266, 228);
            this.eqGraph.TabIndex = 2;
            this.eqGraph.Text = "chart1";
            this.eqGraph.Visible = false;
            // 
            // eqMessageLb
            // 
            this.eqMessageLb.AutoSize = true;
            this.eqMessageLb.Location = new System.Drawing.Point(12, 77);
            this.eqMessageLb.Name = "eqMessageLb";
            this.eqMessageLb.Size = new System.Drawing.Size(78, 13);
            this.eqMessageLb.TabIndex = 3;
            this.eqMessageLb.Text = "Input equation:";
            this.eqMessageLb.Visible = false;
            // 
            // drawBt
            // 
            this.drawBt.Location = new System.Drawing.Point(137, 112);
            this.drawBt.Name = "drawBt";
            this.drawBt.Size = new System.Drawing.Size(100, 44);
            this.drawBt.TabIndex = 4;
            this.drawBt.Text = "Draw!";
            this.drawBt.UseVisualStyleBackColor = true;
            this.drawBt.Visible = false;
            this.drawBt.Click += new System.EventHandler(this.drawBt_Click);
            // 
            // eqInputTb
            // 
            this.eqInputTb.Location = new System.Drawing.Point(121, 77);
            this.eqInputTb.Name = "eqInputTb";
            this.eqInputTb.Size = new System.Drawing.Size(137, 20);
            this.eqInputTb.TabIndex = 5;
            this.eqInputTb.Visible = false;
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Location = new System.Drawing.Point(12, 184);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(40, 13);
            this.resultLb.TabIndex = 6;
            this.resultLb.Text = "Result:";
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(58, 181);
            this.resultTb.Name = "resultTb";
            this.resultTb.ReadOnly = true;
            this.resultTb.Size = new System.Drawing.Size(123, 20);
            this.resultTb.TabIndex = 7;
            // 
            // initTimeLb
            // 
            this.initTimeLb.AutoSize = true;
            this.initTimeLb.Location = new System.Drawing.Point(12, 43);
            this.initTimeLb.Name = "initTimeLb";
            this.initTimeLb.Size = new System.Drawing.Size(71, 13);
            this.initTimeLb.TabIndex = 8;
            this.initTimeLb.Text = "Initial Time(s):";
            // 
            // initTimeTb
            // 
            this.initTimeTb.Location = new System.Drawing.Point(89, 40);
            this.initTimeTb.Name = "initTimeTb";
            this.initTimeTb.Size = new System.Drawing.Size(47, 20);
            this.initTimeTb.TabIndex = 9;
            // 
            // initMetersLb
            // 
            this.initMetersLb.AutoSize = true;
            this.initMetersLb.Location = new System.Drawing.Point(275, 43);
            this.initMetersLb.Name = "initMetersLb";
            this.initMetersLb.Size = new System.Drawing.Size(68, 13);
            this.initMetersLb.TabIndex = 10;
            this.initMetersLb.Text = "Initial V(m/s):";
            // 
            // initMetersTb
            // 
            this.initMetersTb.Location = new System.Drawing.Point(352, 40);
            this.initMetersTb.Name = "initMetersTb";
            this.initMetersTb.Size = new System.Drawing.Size(44, 20);
            this.initMetersTb.TabIndex = 11;
            // 
            // formulaPb
            // 
            this.formulaPb.Image = ((System.Drawing.Image)(resources.GetObject("formulaPb.Image")));
            this.formulaPb.InitialImage = ((System.Drawing.Image)(resources.GetObject("formulaPb.InitialImage")));
            this.formulaPb.Location = new System.Drawing.Point(15, 74);
            this.formulaPb.Name = "formulaPb";
            this.formulaPb.Size = new System.Drawing.Size(264, 54);
            this.formulaPb.TabIndex = 12;
            this.formulaPb.TabStop = false;
            // 
            // formulaFinalPositionPb
            // 
            this.formulaFinalPositionPb.Image = ((System.Drawing.Image)(resources.GetObject("formulaFinalPositionPb.Image")));
            this.formulaFinalPositionPb.InitialImage = ((System.Drawing.Image)(resources.GetObject("formulaFinalPositionPb.InitialImage")));
            this.formulaFinalPositionPb.Location = new System.Drawing.Point(92, 184);
            this.formulaFinalPositionPb.Name = "formulaFinalPositionPb";
            this.formulaFinalPositionPb.Size = new System.Drawing.Size(452, 84);
            this.formulaFinalPositionPb.TabIndex = 15;
            this.formulaFinalPositionPb.TabStop = false;
            this.formulaFinalPositionPb.Visible = false;
            // 
            // finalTimeLb
            // 
            this.finalTimeLb.AutoSize = true;
            this.finalTimeLb.Location = new System.Drawing.Point(142, 43);
            this.finalTimeLb.Name = "finalTimeLb";
            this.finalTimeLb.Size = new System.Drawing.Size(69, 13);
            this.finalTimeLb.TabIndex = 17;
            this.finalTimeLb.Text = "Final Time(s):";
            this.finalTimeLb.Visible = false;
            // 
            // finalTimeTb
            // 
            this.finalTimeTb.Location = new System.Drawing.Point(217, 40);
            this.finalTimeTb.Name = "finalTimeTb";
            this.finalTimeTb.Size = new System.Drawing.Size(46, 20);
            this.finalTimeTb.TabIndex = 18;
            this.finalTimeTb.Visible = false;
            // 
            // solveBt
            // 
            this.solveBt.Location = new System.Drawing.Point(15, 148);
            this.solveBt.Name = "solveBt";
            this.solveBt.Size = new System.Drawing.Size(111, 30);
            this.solveBt.TabIndex = 19;
            this.solveBt.Text = "Solve!";
            this.solveBt.UseVisualStyleBackColor = true;
            this.solveBt.Click += new System.EventHandler(this.solveBt_Click);
            // 
            // vFinalPb
            // 
            this.vFinalPb.Image = ((System.Drawing.Image)(resources.GetObject("vFinalPb.Image")));
            this.vFinalPb.Location = new System.Drawing.Point(15, 74);
            this.vFinalPb.Name = "vFinalPb";
            this.vFinalPb.Size = new System.Drawing.Size(107, 23);
            this.vFinalPb.TabIndex = 20;
            this.vFinalPb.TabStop = false;
            this.vFinalPb.Visible = false;
            // 
            // finalVLb
            // 
            this.finalVLb.AutoSize = true;
            this.finalVLb.Location = new System.Drawing.Point(277, 74);
            this.finalVLb.Name = "finalVLb";
            this.finalVLb.Size = new System.Drawing.Size(66, 13);
            this.finalVLb.TabIndex = 21;
            this.finalVLb.Text = "Final V(m/s):";
            this.finalVLb.Visible = false;
            // 
            // finalVTb
            // 
            this.finalVTb.Location = new System.Drawing.Point(352, 71);
            this.finalVTb.Name = "finalVTb";
            this.finalVTb.Size = new System.Drawing.Size(44, 20);
            this.finalVTb.TabIndex = 22;
            this.finalVTb.Visible = false;
            // 
            // accelLb
            // 
            this.accelLb.AutoSize = true;
            this.accelLb.Location = new System.Drawing.Point(21, 43);
            this.accelLb.Name = "accelLb";
            this.accelLb.Size = new System.Drawing.Size(69, 13);
            this.accelLb.TabIndex = 23;
            this.accelLb.Text = "Acceleration:";
            this.accelLb.Visible = false;
            // 
            // accelTb
            // 
            this.accelTb.Location = new System.Drawing.Point(96, 40);
            this.accelTb.Name = "accelTb";
            this.accelTb.Size = new System.Drawing.Size(44, 20);
            this.accelTb.TabIndex = 24;
            this.accelTb.Visible = false;
            // 
            // Equations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 329);
            this.Controls.Add(this.accelTb);
            this.Controls.Add(this.accelLb);
            this.Controls.Add(this.finalVTb);
            this.Controls.Add(this.finalVLb);
            this.Controls.Add(this.vFinalPb);
            this.Controls.Add(this.solveBt);
            this.Controls.Add(this.finalTimeTb);
            this.Controls.Add(this.finalTimeLb);
            this.Controls.Add(this.formulaFinalPositionPb);
            this.Controls.Add(this.formulaPb);
            this.Controls.Add(this.initMetersTb);
            this.Controls.Add(this.initMetersLb);
            this.Controls.Add(this.initTimeTb);
            this.Controls.Add(this.initTimeLb);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.eqInputTb);
            this.Controls.Add(this.drawBt);
            this.Controls.Add(this.eqMessageLb);
            this.Controls.Add(this.eqGraph);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Equations";
            this.Text = "Equations";
            this.Load += new System.EventHandler(this.Equations_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eqGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaFinalPositionPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFinalPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plotGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart eqGraph;
        private System.Windows.Forms.Label eqMessageLb;
        private System.Windows.Forms.Button drawBt;
        private System.Windows.Forms.TextBox eqInputTb;
        private System.Windows.Forms.Label resultLb;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.ToolStripMenuItem normalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGraphToolStripMenuItem;
        private System.Windows.Forms.Label initTimeLb;
        private System.Windows.Forms.TextBox initTimeTb;
        private System.Windows.Forms.Label initMetersLb;
        private System.Windows.Forms.TextBox initMetersTb;
        private System.Windows.Forms.PictureBox formulaPb;
        private System.Windows.Forms.ToolStripMenuItem equationOfPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationOfHmaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationOfVelocityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationOfEnergyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationOfTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationOfAccelerationToolStripMenuItem;
        private System.Windows.Forms.PictureBox formulaFinalPositionPb;
        private System.Windows.Forms.Label finalTimeLb;
        private System.Windows.Forms.TextBox finalTimeTb;
        private System.Windows.Forms.Button solveBt;
        private System.Windows.Forms.PictureBox vFinalPb;
        private System.Windows.Forms.Label finalVLb;
        private System.Windows.Forms.TextBox finalVTb;
        private System.Windows.Forms.Label accelLb;
        private System.Windows.Forms.TextBox accelTb;
    }
}