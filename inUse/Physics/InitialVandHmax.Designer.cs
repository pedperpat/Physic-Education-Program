namespace Physics
{
    partial class InitialVandHmax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialVandHmax));
            this.initVelocityPb = new System.Windows.Forms.PictureBox();
            this.positionPb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTimeTb = new System.Windows.Forms.TextBox();
            this.getVoBt = new System.Windows.Forms.Button();
            this.resultVoTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.solveHmaxBt = new System.Windows.Forms.Button();
            this.resultHmaxTb = new System.Windows.Forms.TextBox();
            this.backBt = new System.Windows.Forms.Button();
            this.clickbuttonLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initVelocityPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionPb)).BeginInit();
            this.SuspendLayout();
            // 
            // initVelocityPb
            // 
            this.initVelocityPb.Image = ((System.Drawing.Image)(resources.GetObject("initVelocityPb.Image")));
            this.initVelocityPb.Location = new System.Drawing.Point(229, 69);
            this.initVelocityPb.Name = "initVelocityPb";
            this.initVelocityPb.Size = new System.Drawing.Size(104, 26);
            this.initVelocityPb.TabIndex = 0;
            this.initVelocityPb.TabStop = false;
            // 
            // positionPb
            // 
            this.positionPb.Image = ((System.Drawing.Image)(resources.GetObject("positionPb.Image")));
            this.positionPb.Location = new System.Drawing.Point(89, 254);
            this.positionPb.Name = "positionPb";
            this.positionPb.Size = new System.Drawing.Size(451, 86);
            this.positionPb.TabIndex = 1;
            this.positionPb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1º Known the time and final velocity it\'s 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "We use the v final equation ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "2º Then we obtain the value of Vo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total time:";
            // 
            // totalTimeTb
            // 
            this.totalTimeTb.Location = new System.Drawing.Point(401, 69);
            this.totalTimeTb.Name = "totalTimeTb";
            this.totalTimeTb.Size = new System.Drawing.Size(58, 20);
            this.totalTimeTb.TabIndex = 6;
            // 
            // getVoBt
            // 
            this.getVoBt.Location = new System.Drawing.Point(465, 66);
            this.getVoBt.Name = "getVoBt";
            this.getVoBt.Size = new System.Drawing.Size(75, 23);
            this.getVoBt.TabIndex = 7;
            this.getVoBt.Text = "Get Vo";
            this.getVoBt.UseVisualStyleBackColor = true;
            this.getVoBt.Click += new System.EventHandler(this.getVoBt_Click);
            // 
            // resultVoTb
            // 
            this.resultVoTb.Location = new System.Drawing.Point(546, 68);
            this.resultVoTb.Name = "resultVoTb";
            this.resultVoTb.ReadOnly = true;
            this.resultVoTb.Size = new System.Drawing.Size(99, 20);
            this.resultVoTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result of Vo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "3º Grab calculated Vo and the same time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "4º Initial position = 0,final height is on the ground";
            // 
            // solveHmaxBt
            // 
            this.solveHmaxBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveHmaxBt.Location = new System.Drawing.Point(246, 216);
            this.solveHmaxBt.Name = "solveHmaxBt";
            this.solveHmaxBt.Size = new System.Drawing.Size(87, 32);
            this.solveHmaxBt.TabIndex = 12;
            this.solveHmaxBt.Text = "Solve Hmax";
            this.solveHmaxBt.UseVisualStyleBackColor = true;
            this.solveHmaxBt.Visible = false;
            this.solveHmaxBt.Click += new System.EventHandler(this.solveHmaxBt_Click);
            // 
            // resultHmaxTb
            // 
            this.resultHmaxTb.Location = new System.Drawing.Point(359, 223);
            this.resultHmaxTb.Name = "resultHmaxTb";
            this.resultHmaxTb.ReadOnly = true;
            this.resultHmaxTb.Size = new System.Drawing.Size(122, 20);
            this.resultHmaxTb.TabIndex = 13;
            this.resultHmaxTb.Visible = false;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(15, 16);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(78, 40);
            this.backBt.TabIndex = 14;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // clickbuttonLb
            // 
            this.clickbuttonLb.AutoSize = true;
            this.clickbuttonLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickbuttonLb.Location = new System.Drawing.Point(120, 221);
            this.clickbuttonLb.Name = "clickbuttonLb";
            this.clickbuttonLb.Size = new System.Drawing.Size(103, 20);
            this.clickbuttonLb.TabIndex = 15;
            this.clickbuttonLb.Text = "-------------->";
            this.clickbuttonLb.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(478, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "5º Use the values at the equation position with negative acceleration";
            // 
            // InitialVandHmax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 352);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clickbuttonLb);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.resultHmaxTb);
            this.Controls.Add(this.solveHmaxBt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultVoTb);
            this.Controls.Add(this.getVoBt);
            this.Controls.Add(this.totalTimeTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.positionPb);
            this.Controls.Add(this.initVelocityPb);
            this.Name = "InitialVandHmax";
            this.Text = "InitialVandHmax";
            this.Load += new System.EventHandler(this.InitialVandHmax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initVelocityPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox initVelocityPb;
        private System.Windows.Forms.PictureBox positionPb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalTimeTb;
        private System.Windows.Forms.Button getVoBt;
        private System.Windows.Forms.TextBox resultVoTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button solveHmaxBt;
        private System.Windows.Forms.TextBox resultHmaxTb;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Label clickbuttonLb;
        private System.Windows.Forms.Label label8;
    }
}