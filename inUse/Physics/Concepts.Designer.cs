namespace Physics
{
    partial class Concepts
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.nextSearchBt = new System.Windows.Forms.Button();
            this.previousSearchBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveActualConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConceptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some concepts to remember:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Acceleration: Is the rate of change of velocity of an object. An object\'s acceler" +
                "ation is the net result of any and all forces acting ",
            "\t\ton the object, as described by Newton\'s Second Law.The SI unit for acceleration" +
                " is metre per second ",
            "\t\tsquared (m s-2). Accelerations are vector quantities (they have magnitude and d" +
                "irection) and add ",
            "\t\taccording to the parallelogram law. As a vector, the calculated net force is eq" +
                "ual to the product of ",
            "\t\tthe object\'s mass (a scalar quantity) and its acceleration.",
            "",
            "Center of mass: Is the unique point where the weighted relative position of the d" +
                "istributed mass sums to zero or the point where",
            "\t\tif a force is applied causes it to move in direction of force without rotation." +
                " The distribution of mass is ",
            "\t\tbalanced around the center of mass and the average of the weighted position coo" +
                "rdinates of the distributed ",
            "\t\tmass defines its coordinates. Calculations in mechanics are often simplified wh" +
                "en formulated with respect to",
            "\t\t the center of mass.",
            "",
            "Force: Can cause an object with mass to change its velocity (which includes to be" +
                "gin moving from a state of rest), i.e., to accelerate. ",
            "\t\tForce can also be described by intuitive concepts such as a push or a pull. A f" +
                "orce has both magnitude and ",
            "\t\tdirection, making it a vector quantity. It is measured in the SI unit of newton" +
                "s and represented by the symbol F.",
            "",
            "Mass: It is generally a measure of an object\'s resistance to changing its state o" +
                "f motion when a force is applied. It is determined by ",
            "\t\tthe strength of its mutual gravitational attraction to other bodies, its resist" +
                "ance to acceleration or directional ",
            "\t\tchanges, and in the theory of relativity gives the mass–energy content of a sys" +
                "tem. The SI unit of mass is the kilogram (kg)."});
            this.listBox1.Location = new System.Drawing.Point(16, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(701, 238);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter something to search: ";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(296, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "word to search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(402, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // nextSearchBt
            // 
            this.nextSearchBt.Location = new System.Drawing.Point(564, 22);
            this.nextSearchBt.Name = "nextSearchBt";
            this.nextSearchBt.Size = new System.Drawing.Size(75, 23);
            this.nextSearchBt.TabIndex = 5;
            this.nextSearchBt.Text = "Next";
            this.nextSearchBt.UseVisualStyleBackColor = true;
            // 
            // previousSearchBt
            // 
            this.previousSearchBt.Location = new System.Drawing.Point(483, 22);
            this.previousSearchBt.Name = "previousSearchBt";
            this.previousSearchBt.Size = new System.Drawing.Size(75, 23);
            this.previousSearchBt.TabIndex = 6;
            this.previousSearchBt.Text = "Previous";
            this.previousSearchBt.UseVisualStyleBackColor = true;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(645, 20);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(72, 46);
            this.backBt.TabIndex = 7;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveActualConceptsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveActualConceptsToolStripMenuItem
            // 
            this.saveActualConceptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConceptsToolStripMenuItem});
            this.saveActualConceptsToolStripMenuItem.Name = "saveActualConceptsToolStripMenuItem";
            this.saveActualConceptsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.saveActualConceptsToolStripMenuItem.Text = "Save actual concepts";
            // 
            // loadConceptsToolStripMenuItem
            // 
            this.loadConceptsToolStripMenuItem.Name = "loadConceptsToolStripMenuItem";
            this.loadConceptsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadConceptsToolStripMenuItem.Text = "Load Concepts";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Concepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 327);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.previousSearchBt);
            this.Controls.Add(this.nextSearchBt);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Concepts";
            this.Text = "Concepts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button nextSearchBt;
        private System.Windows.Forms.Button previousSearchBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveActualConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConceptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}