namespace Physics
{
    partial class Velocity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Velocity));
            this.vFinalPb = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTimeTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.solveBt = new System.Windows.Forms.Button();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.backBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vFinalPb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vFinalPb
            // 
            this.vFinalPb.Image = ((System.Drawing.Image)(resources.GetObject("vFinalPb.Image")));
            this.vFinalPb.Location = new System.Drawing.Point(272, 81);
            this.vFinalPb.Name = "vFinalPb";
            this.vFinalPb.Size = new System.Drawing.Size(107, 23);
            this.vFinalPb.TabIndex = 21;
            this.vFinalPb.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "When you drop an object...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Each second its velocity is growing by the gravity(9.8m/s^2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "If the total time of the drop is: ";
            // 
            // totalTimeTb
            // 
            this.totalTimeTb.Location = new System.Drawing.Point(314, 138);
            this.totalTimeTb.Name = "totalTimeTb";
            this.totalTimeTb.Size = new System.Drawing.Size(65, 20);
            this.totalTimeTb.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "His final velocity is: ";
            // 
            // solveBt
            // 
            this.solveBt.Location = new System.Drawing.Point(385, 136);
            this.solveBt.Name = "solveBt";
            this.solveBt.Size = new System.Drawing.Size(75, 23);
            this.solveBt.TabIndex = 32;
            this.solveBt.Text = "Solve!";
            this.solveBt.UseVisualStyleBackColor = true;
            this.solveBt.Click += new System.EventHandler(this.solveBt_Click);
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(314, 180);
            this.resultTb.Name = "resultTb";
            this.resultTb.ReadOnly = true;
            this.resultTb.Size = new System.Drawing.Size(127, 20);
            this.resultTb.TabIndex = 33;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(527, 237);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(108, 43);
            this.backBt.TabIndex = 34;
            this.backBt.Text = "Go back!";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // Velocity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 359);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.solveBt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalTimeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vFinalPb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Velocity";
            this.Text = "Velocity";
            ((System.ComponentModel.ISupportInitialize)(this.vFinalPb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vFinalPb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalTimeTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button solveBt;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.Button backBt;
    }
}