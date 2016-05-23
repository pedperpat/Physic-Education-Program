namespace Physics
{
    partial class HelpScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eqHelp = new System.Windows.Forms.ListBox();
            this.problemReviewListBox = new System.Windows.Forms.ListBox();
            this.eqScreenBt = new System.Windows.Forms.Button();
            this.constantsListBox = new System.Windows.Forms.ListBox();
            this.constantBt = new System.Windows.Forms.Button();
            this.conceptsListBox = new System.Windows.Forms.ListBox();
            this.problemBt = new System.Windows.Forms.Button();
            this.conceptBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem Review Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equation Screen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Constants Screen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Concepts Screen";
            // 
            // eqHelp
            // 
            this.eqHelp.FormattingEnabled = true;
            this.eqHelp.Items.AddRange(new object[] {
            "-->Ability to plot in a graph the result of a position equation.",
            "",
            "-->Ability to solve a position equation.",
            "",
            "-->Soon more..."});
            this.eqHelp.Location = new System.Drawing.Point(12, 39);
            this.eqHelp.Name = "eqHelp";
            this.eqHelp.Size = new System.Drawing.Size(288, 95);
            this.eqHelp.TabIndex = 4;
            // 
            // problemReviewListBox
            // 
            this.problemReviewListBox.FormattingEnabled = true;
            this.problemReviewListBox.Items.AddRange(new object[] {
            "-->Review of problems by the user.",
            "",
            "-->Plot a graph of equation on the chart.",
            "",
            "-->Save the result into a file (fileName.phy).",
            "",
            "-->Load result of a saved file(fileName.phy)."});
            this.problemReviewListBox.Location = new System.Drawing.Point(317, 39);
            this.problemReviewListBox.Name = "problemReviewListBox";
            this.problemReviewListBox.Size = new System.Drawing.Size(219, 95);
            this.problemReviewListBox.TabIndex = 5;
            // 
            // eqScreenBt
            // 
            this.eqScreenBt.Location = new System.Drawing.Point(81, 140);
            this.eqScreenBt.Name = "eqScreenBt";
            this.eqScreenBt.Size = new System.Drawing.Size(137, 33);
            this.eqScreenBt.TabIndex = 6;
            this.eqScreenBt.Text = "To Equation Screen";
            this.eqScreenBt.UseVisualStyleBackColor = true;
            this.eqScreenBt.Click += new System.EventHandler(this.eqScreenBt_Click);
            // 
            // constantsListBox
            // 
            this.constantsListBox.FormattingEnabled = true;
            this.constantsListBox.Items.AddRange(new object[] {
            "-->Review constants information",
            "",
            "-->Load constants from a file(.phy).",
            "",
            "-->Save constants to a file(.phy)."});
            this.constantsListBox.Location = new System.Drawing.Point(12, 192);
            this.constantsListBox.Name = "constantsListBox";
            this.constantsListBox.Size = new System.Drawing.Size(288, 82);
            this.constantsListBox.TabIndex = 7;
            // 
            // constantBt
            // 
            this.constantBt.Location = new System.Drawing.Point(81, 280);
            this.constantBt.Name = "constantBt";
            this.constantBt.Size = new System.Drawing.Size(137, 23);
            this.constantBt.TabIndex = 8;
            this.constantBt.Text = "To Constants Screen";
            this.constantBt.UseVisualStyleBackColor = true;
            this.constantBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // conceptsListBox
            // 
            this.conceptsListBox.FormattingEnabled = true;
            this.conceptsListBox.Items.AddRange(new object[] {
            "-->Know about essential concepts.",
            "",
            "-->Write concepts at the listbox.",
            "",
            "-->Search concept by word or words.",
            "",
            "-->Save the actual concepts to a file(.phy).",
            "",
            "-->Load concepts from a file(.phy)."});
            this.conceptsListBox.Location = new System.Drawing.Point(317, 192);
            this.conceptsListBox.Name = "conceptsListBox";
            this.conceptsListBox.Size = new System.Drawing.Size(219, 82);
            this.conceptsListBox.TabIndex = 9;
            // 
            // problemBt
            // 
            this.problemBt.Location = new System.Drawing.Point(355, 140);
            this.problemBt.Name = "problemBt";
            this.problemBt.Size = new System.Drawing.Size(139, 33);
            this.problemBt.TabIndex = 10;
            this.problemBt.Text = "To Problems Screen";
            this.problemBt.UseVisualStyleBackColor = true;
            this.problemBt.Click += new System.EventHandler(this.problemBt_Click);
            // 
            // conceptBt
            // 
            this.conceptBt.Location = new System.Drawing.Point(355, 280);
            this.conceptBt.Name = "conceptBt";
            this.conceptBt.Size = new System.Drawing.Size(139, 23);
            this.conceptBt.TabIndex = 11;
            this.conceptBt.Text = "To Concepts Screen";
            this.conceptBt.UseVisualStyleBackColor = true;
            this.conceptBt.Click += new System.EventHandler(this.conceptBt_Click);
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 314);
            this.Controls.Add(this.conceptBt);
            this.Controls.Add(this.problemBt);
            this.Controls.Add(this.conceptsListBox);
            this.Controls.Add(this.constantBt);
            this.Controls.Add(this.constantsListBox);
            this.Controls.Add(this.eqScreenBt);
            this.Controls.Add(this.problemReviewListBox);
            this.Controls.Add(this.eqHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox eqHelp;
        private System.Windows.Forms.ListBox problemReviewListBox;
        private System.Windows.Forms.Button eqScreenBt;
        private System.Windows.Forms.ListBox constantsListBox;
        private System.Windows.Forms.Button constantBt;
        private System.Windows.Forms.ListBox conceptsListBox;
        private System.Windows.Forms.Button problemBt;
        private System.Windows.Forms.Button conceptBt;
    }
}