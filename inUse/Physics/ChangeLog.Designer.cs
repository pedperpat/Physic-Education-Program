namespace Physics
{
    partial class ChangeLog
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
            this.changeLogRTB = new System.Windows.Forms.RichTextBox();
            this.backBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeLogRTB
            // 
            this.changeLogRTB.Location = new System.Drawing.Point(12, 12);
            this.changeLogRTB.Name = "changeLogRTB";
            this.changeLogRTB.ReadOnly = true;
            this.changeLogRTB.Size = new System.Drawing.Size(529, 278);
            this.changeLogRTB.TabIndex = 0;
            this.changeLogRTB.Text = "";
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(194, 296);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(149, 34);
            this.backBt.TabIndex = 1;
            this.backBt.Text = "Ok, send me back!";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 342);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.changeLogRTB);
            this.Name = "ChangeLog";
            this.Text = "ChangeLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox changeLogRTB;
        private System.Windows.Forms.Button backBt;
    }
}