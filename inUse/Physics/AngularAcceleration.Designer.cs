namespace Physics
{
    partial class AngularAcceleration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngularAcceleration));
            this.solveBt = new System.Windows.Forms.Button();
            this.initAngVTb = new System.Windows.Forms.TextBox();
            this.initAngVLb = new System.Windows.Forms.Label();
            this.finalAngVLb = new System.Windows.Forms.Label();
            this.finalAngVTb = new System.Windows.Forms.TextBox();
            this.initTimeLb = new System.Windows.Forms.Label();
            this.finalTimeLb = new System.Windows.Forms.Label();
            this.initTimeTb = new System.Windows.Forms.TextBox();
            this.finalTimeTb = new System.Windows.Forms.TextBox();
            this.resultLb = new System.Windows.Forms.Label();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.backBt = new System.Windows.Forms.Button();
            this.goMainBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // solveBt
            // 
            this.solveBt.Location = new System.Drawing.Point(256, 228);
            this.solveBt.Name = "solveBt";
            this.solveBt.Size = new System.Drawing.Size(96, 44);
            this.solveBt.TabIndex = 0;
            this.solveBt.Text = "Solve!";
            this.solveBt.UseVisualStyleBackColor = true;
            this.solveBt.Click += new System.EventHandler(this.solveBt_Click);
            // 
            // initAngVTb
            // 
            this.initAngVTb.Location = new System.Drawing.Point(167, 123);
            this.initAngVTb.Name = "initAngVTb";
            this.initAngVTb.Size = new System.Drawing.Size(100, 20);
            this.initAngVTb.TabIndex = 1;
            // 
            // initAngVLb
            // 
            this.initAngVLb.AutoSize = true;
            this.initAngVLb.Location = new System.Drawing.Point(50, 123);
            this.initAngVLb.Name = "initAngVLb";
            this.initAngVLb.Size = new System.Drawing.Size(111, 13);
            this.initAngVLb.TabIndex = 2;
            this.initAngVLb.Text = "Initial angular velocity:";
            // 
            // finalAngVLb
            // 
            this.finalAngVLb.AutoSize = true;
            this.finalAngVLb.Location = new System.Drawing.Point(52, 180);
            this.finalAngVLb.Name = "finalAngVLb";
            this.finalAngVLb.Size = new System.Drawing.Size(109, 13);
            this.finalAngVLb.TabIndex = 3;
            this.finalAngVLb.Text = "Final angular velocity:";
            // 
            // finalAngVTb
            // 
            this.finalAngVTb.Location = new System.Drawing.Point(167, 177);
            this.finalAngVTb.Name = "finalAngVTb";
            this.finalAngVTb.Size = new System.Drawing.Size(100, 20);
            this.finalAngVTb.TabIndex = 4;
            // 
            // initTimeLb
            // 
            this.initTimeLb.AutoSize = true;
            this.initTimeLb.Location = new System.Drawing.Point(298, 123);
            this.initTimeLb.Name = "initTimeLb";
            this.initTimeLb.Size = new System.Drawing.Size(63, 13);
            this.initTimeLb.TabIndex = 5;
            this.initTimeLb.Text = "Initial Time: ";
            // 
            // finalTimeLb
            // 
            this.finalTimeLb.AutoSize = true;
            this.finalTimeLb.Location = new System.Drawing.Point(307, 180);
            this.finalTimeLb.Name = "finalTimeLb";
            this.finalTimeLb.Size = new System.Drawing.Size(54, 13);
            this.finalTimeLb.TabIndex = 6;
            this.finalTimeLb.Text = "Final time:";
            // 
            // initTimeTb
            // 
            this.initTimeTb.Location = new System.Drawing.Point(367, 120);
            this.initTimeTb.Name = "initTimeTb";
            this.initTimeTb.Size = new System.Drawing.Size(100, 20);
            this.initTimeTb.TabIndex = 7;
            // 
            // finalTimeTb
            // 
            this.finalTimeTb.Location = new System.Drawing.Point(367, 177);
            this.finalTimeTb.Name = "finalTimeTb";
            this.finalTimeTb.Size = new System.Drawing.Size(100, 20);
            this.finalTimeTb.TabIndex = 8;
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Location = new System.Drawing.Point(107, 299);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(40, 13);
            this.resultLb.TabIndex = 9;
            this.resultLb.Text = "Result:";
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(220, 296);
            this.resultTb.Name = "resultTb";
            this.resultTb.ReadOnly = true;
            this.resultTb.Size = new System.Drawing.Size(100, 20);
            this.resultTb.TabIndex = 10;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(519, 299);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(75, 80);
            this.backBt.TabIndex = 11;
            this.backBt.Text = "Go back!";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // goMainBt
            // 
            this.goMainBt.Location = new System.Drawing.Point(519, 210);
            this.goMainBt.Name = "goMainBt";
            this.goMainBt.Size = new System.Drawing.Size(75, 80);
            this.goMainBt.TabIndex = 12;
            this.goMainBt.Text = "To main screen";
            this.goMainBt.UseVisualStyleBackColor = true;
            this.goMainBt.Click += new System.EventHandler(this.goMainBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 79);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AngularAcceleration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.goMainBt);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.finalTimeTb);
            this.Controls.Add(this.initTimeTb);
            this.Controls.Add(this.finalTimeLb);
            this.Controls.Add(this.initTimeLb);
            this.Controls.Add(this.finalAngVTb);
            this.Controls.Add(this.finalAngVLb);
            this.Controls.Add(this.initAngVLb);
            this.Controls.Add(this.initAngVTb);
            this.Controls.Add(this.solveBt);
            this.Name = "AngularAcceleration";
            this.Text = "AngularAcceleration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveBt;
        private System.Windows.Forms.TextBox initAngVTb;
        private System.Windows.Forms.Label initAngVLb;
        private System.Windows.Forms.Label finalAngVLb;
        private System.Windows.Forms.TextBox finalAngVTb;
        private System.Windows.Forms.Label initTimeLb;
        private System.Windows.Forms.Label finalTimeLb;
        private System.Windows.Forms.TextBox initTimeTb;
        private System.Windows.Forms.TextBox finalTimeTb;
        private System.Windows.Forms.Label resultLb;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button goMainBt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}