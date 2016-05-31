namespace Physics
{
    partial class Energy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Energy));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keFormulaLb = new System.Windows.Forms.Label();
            this.velocityLb = new System.Windows.Forms.Label();
            this.massBulletLb = new System.Windows.Forms.Label();
            this.velocityTb = new System.Windows.Forms.TextBox();
            this.massTb = new System.Windows.Forms.TextBox();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solveEnergyBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.mainScreenBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // keFormulaLb
            // 
            this.keFormulaLb.AutoSize = true;
            this.keFormulaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keFormulaLb.Location = new System.Drawing.Point(12, 85);
            this.keFormulaLb.Name = "keFormulaLb";
            this.keFormulaLb.Size = new System.Drawing.Size(279, 20);
            this.keFormulaLb.TabIndex = 1;
            this.keFormulaLb.Text = "This is the Kinetic energy formula:";
            // 
            // velocityLb
            // 
            this.velocityLb.AutoSize = true;
            this.velocityLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityLb.Location = new System.Drawing.Point(179, 161);
            this.velocityLb.Name = "velocityLb";
            this.velocityLb.Size = new System.Drawing.Size(112, 18);
            this.velocityLb.TabIndex = 2;
            this.velocityLb.Text = "Velocity(m/s):";
            // 
            // massBulletLb
            // 
            this.massBulletLb.AutoSize = true;
            this.massBulletLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massBulletLb.Location = new System.Drawing.Point(88, 201);
            this.massBulletLb.Name = "massBulletLb";
            this.massBulletLb.Size = new System.Drawing.Size(206, 18);
            this.massBulletLb.TabIndex = 3;
            this.massBulletLb.Text = "Mass of the projectile(kg):";
            // 
            // velocityTb
            // 
            this.velocityTb.Location = new System.Drawing.Point(297, 162);
            this.velocityTb.Name = "velocityTb";
            this.velocityTb.Size = new System.Drawing.Size(76, 20);
            this.velocityTb.TabIndex = 4;
            // 
            // massTb
            // 
            this.massTb.Location = new System.Drawing.Point(297, 202);
            this.massTb.Name = "massTb";
            this.massTb.Size = new System.Drawing.Size(76, 20);
            this.massTb.TabIndex = 5;
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(297, 312);
            this.resultTb.Name = "resultTb";
            this.resultTb.ReadOnly = true;
            this.resultTb.Size = new System.Drawing.Size(76, 20);
            this.resultTb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result:";
            // 
            // solveEnergyBt
            // 
            this.solveEnergyBt.Location = new System.Drawing.Point(269, 251);
            this.solveEnergyBt.Name = "solveEnergyBt";
            this.solveEnergyBt.Size = new System.Drawing.Size(128, 42);
            this.solveEnergyBt.TabIndex = 8;
            this.solveEnergyBt.Text = "Obtain Energy";
            this.solveEnergyBt.UseVisualStyleBackColor = true;
            this.solveEnergyBt.Click += new System.EventHandler(this.solveEnergyBt_Click);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(489, 327);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(92, 35);
            this.backBt.TabIndex = 9;
            this.backBt.Text = "Go back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // mainScreenBt
            // 
            this.mainScreenBt.Location = new System.Drawing.Point(489, 275);
            this.mainScreenBt.Name = "mainScreenBt";
            this.mainScreenBt.Size = new System.Drawing.Size(92, 36);
            this.mainScreenBt.TabIndex = 10;
            this.mainScreenBt.Text = "Go to main Screen";
            this.mainScreenBt.UseVisualStyleBackColor = true;
            this.mainScreenBt.Click += new System.EventHandler(this.mainScreenBt_Click);
            // 
            // Energy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 393);
            this.Controls.Add(this.mainScreenBt);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.solveEnergyBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.massTb);
            this.Controls.Add(this.velocityTb);
            this.Controls.Add(this.massBulletLb);
            this.Controls.Add(this.velocityLb);
            this.Controls.Add(this.keFormulaLb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Energy";
            this.Text = "Energy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label keFormulaLb;
        private System.Windows.Forms.Label velocityLb;
        private System.Windows.Forms.Label massBulletLb;
        private System.Windows.Forms.TextBox velocityTb;
        private System.Windows.Forms.TextBox massTb;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button solveEnergyBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button mainScreenBt;
    }
}