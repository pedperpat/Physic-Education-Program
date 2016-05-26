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
            ((System.ComponentModel.ISupportInitialize)(this.formulaFinalPositionPb)).BeginInit();
            this.SuspendLayout();
            // 
            // formulaFinalPositionPb
            // 
            this.formulaFinalPositionPb.Image = ((System.Drawing.Image)(resources.GetObject("formulaFinalPositionPb.Image")));
            this.formulaFinalPositionPb.InitialImage = ((System.Drawing.Image)(resources.GetObject("formulaFinalPositionPb.InitialImage")));
            this.formulaFinalPositionPb.Location = new System.Drawing.Point(129, 44);
            this.formulaFinalPositionPb.Name = "formulaFinalPositionPb";
            this.formulaFinalPositionPb.Size = new System.Drawing.Size(452, 84);
            this.formulaFinalPositionPb.TabIndex = 26;
            this.formulaFinalPositionPb.TabStop = false;
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 371);
            this.Controls.Add(this.formulaFinalPositionPb);
            this.Name = "Position";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formulaFinalPositionPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox formulaFinalPositionPb;
    }
}