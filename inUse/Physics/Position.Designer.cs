namespace Physics
{
    partial class Position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Position));
            this.formulaFinalPositionPb = new System.Windows.Forms.PictureBox();
            this.solveBt = new System.Windows.Forms.Button();
            this.resultLb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backBt = new System.Windows.Forms.Button();
            this.toMainBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formulaFinalPositionPb)).BeginInit();
            this.SuspendLayout();
            // 
            // formulaFinalPositionPb
            // 
            this.formulaFinalPositionPb.Image = ((System.Drawing.Image)(resources.GetObject("formulaFinalPositionPb.Image")));
            this.formulaFinalPositionPb.InitialImage = ((System.Drawing.Image)(resources.GetObject("formulaFinalPositionPb.InitialImage")));
            this.formulaFinalPositionPb.Location = new System.Drawing.Point(126, 31);
            this.formulaFinalPositionPb.Name = "formulaFinalPositionPb";
            this.formulaFinalPositionPb.Size = new System.Drawing.Size(452, 84);
            this.formulaFinalPositionPb.TabIndex = 26;
            this.formulaFinalPositionPb.TabStop = false;
            // 
            // solveBt
            // 
            this.solveBt.Location = new System.Drawing.Point(289, 285);
            this.solveBt.Name = "solveBt";
            this.solveBt.Size = new System.Drawing.Size(113, 43);
            this.solveBt.TabIndex = 27;
            this.solveBt.Text = "Solve!";
            this.solveBt.UseVisualStyleBackColor = true;
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Location = new System.Drawing.Point(256, 238);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(40, 13);
            this.resultLb.TabIndex = 28;
            this.resultLb.Text = "Result:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(583, 320);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(101, 39);
            this.backBt.TabIndex = 30;
            this.backBt.Text = "Go back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // toMainBt
            // 
            this.toMainBt.Location = new System.Drawing.Point(583, 275);
            this.toMainBt.Name = "toMainBt";
            this.toMainBt.Size = new System.Drawing.Size(101, 39);
            this.toMainBt.TabIndex = 31;
            this.toMainBt.Text = "Go to main";
            this.toMainBt.UseVisualStyleBackColor = true;
            this.toMainBt.Click += new System.EventHandler(this.toMainBt_Click);
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 371);
            this.Controls.Add(this.toMainBt);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.solveBt);
            this.Controls.Add(this.formulaFinalPositionPb);
            this.Name = "Position";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formulaFinalPositionPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formulaFinalPositionPb;
        private System.Windows.Forms.Button solveBt;
        private System.Windows.Forms.Label resultLb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button toMainBt;
    }
}