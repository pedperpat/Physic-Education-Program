namespace Physics
{
    partial class MainScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.conceptsBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.constantsBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.equationsBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.problemsBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spanishLan = new System.Windows.Forms.RadioButton();
            this.englishLan = new System.Windows.Forms.RadioButton();
            this.germanLan = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.helpBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics review for students of highschool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conceptsBt
            // 
            this.conceptsBt.Location = new System.Drawing.Point(139, 97);
            this.conceptsBt.Name = "conceptsBt";
            this.conceptsBt.Size = new System.Drawing.Size(121, 35);
            this.conceptsBt.TabIndex = 1;
            this.conceptsBt.Text = "Go to Concepts";
            this.conceptsBt.UseVisualStyleBackColor = true;
            this.conceptsBt.Click += new System.EventHandler(this.conceptsBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fundamental Concepts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Most usable constants";
            // 
            // constantsBt
            // 
            this.constantsBt.Location = new System.Drawing.Point(472, 97);
            this.constantsBt.Name = "constantsBt";
            this.constantsBt.Size = new System.Drawing.Size(121, 35);
            this.constantsBt.TabIndex = 4;
            this.constantsBt.Text = "Go to Constants";
            this.constantsBt.UseVisualStyleBackColor = true;
            this.constantsBt.Click += new System.EventHandler(this.constantsBt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Simple physics equations";
            // 
            // equationsBt
            // 
            this.equationsBt.Location = new System.Drawing.Point(139, 222);
            this.equationsBt.Name = "equationsBt";
            this.equationsBt.Size = new System.Drawing.Size(121, 35);
            this.equationsBt.TabIndex = 6;
            this.equationsBt.Text = "Go to Equations";
            this.equationsBt.UseVisualStyleBackColor = true;
            this.equationsBt.Click += new System.EventHandler(this.equationsBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Some problems to review";
            // 
            // problemsBt
            // 
            this.problemsBt.Location = new System.Drawing.Point(472, 222);
            this.problemsBt.Name = "problemsBt";
            this.problemsBt.Size = new System.Drawing.Size(121, 35);
            this.problemsBt.TabIndex = 8;
            this.problemsBt.Text = "Go to problems";
            this.problemsBt.UseVisualStyleBackColor = true;
            this.problemsBt.Click += new System.EventHandler(this.problemsBt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Final programming proyect: Pedro Antonio Pérez Paterna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Change lenguage:";
            // 
            // spanishLan
            // 
            this.spanishLan.AutoSize = true;
            this.spanishLan.Location = new System.Drawing.Point(495, 299);
            this.spanishLan.Name = "spanishLan";
            this.spanishLan.Size = new System.Drawing.Size(63, 17);
            this.spanishLan.TabIndex = 11;
            this.spanishLan.Text = "Spanish";
            this.spanishLan.UseVisualStyleBackColor = true;
            // 
            // englishLan
            // 
            this.englishLan.AutoSize = true;
            this.englishLan.Checked = true;
            this.englishLan.Location = new System.Drawing.Point(564, 299);
            this.englishLan.Name = "englishLan";
            this.englishLan.Size = new System.Drawing.Size(59, 17);
            this.englishLan.TabIndex = 12;
            this.englishLan.TabStop = true;
            this.englishLan.Text = "English";
            this.englishLan.UseVisualStyleBackColor = true;
            // 
            // germanLan
            // 
            this.germanLan.AutoSize = true;
            this.germanLan.Location = new System.Drawing.Point(629, 299);
            this.germanLan.Name = "germanLan";
            this.germanLan.Size = new System.Drawing.Size(62, 17);
            this.germanLan.TabIndex = 13;
            this.germanLan.TabStop = true;
            this.germanLan.Text = "German";
            this.germanLan.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "V: 0.3 Calculate equations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "24/05/2016";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Help";
            // 
            // helpBt
            // 
            this.helpBt.Location = new System.Drawing.Point(319, 153);
            this.helpBt.Name = "helpBt";
            this.helpBt.Size = new System.Drawing.Size(94, 46);
            this.helpBt.TabIndex = 17;
            this.helpBt.Text = "Go to Help";
            this.helpBt.UseVisualStyleBackColor = true;
            this.helpBt.Click += new System.EventHandler(this.helpBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Load changeLog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Current version:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 323);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helpBt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.germanLan);
            this.Controls.Add(this.englishLan);
            this.Controls.Add(this.spanishLan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.problemsBt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.equationsBt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.constantsBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conceptsBt);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conceptsBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button constantsBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button equationsBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button problemsBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton spanishLan;
        private System.Windows.Forms.RadioButton englishLan;
        private System.Windows.Forms.RadioButton germanLan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button helpBt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

