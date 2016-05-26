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
            this.accelLb = new System.Windows.Forms.Label();
            this.accelTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vFinalPb)).BeginInit();
            this.SuspendLayout();
            // 
            // vFinalPb
            // 
            this.vFinalPb.Image = ((System.Drawing.Image)(resources.GetObject("vFinalPb.Image")));
            this.vFinalPb.Location = new System.Drawing.Point(276, 56);
            this.vFinalPb.Name = "vFinalPb";
            this.vFinalPb.Size = new System.Drawing.Size(107, 23);
            this.vFinalPb.TabIndex = 21;
            this.vFinalPb.TabStop = false;
            // 
            // accelLb
            // 
            this.accelLb.AutoSize = true;
            this.accelLb.Location = new System.Drawing.Point(12, 26);
            this.accelLb.Name = "accelLb";
            this.accelLb.Size = new System.Drawing.Size(69, 13);
            this.accelLb.TabIndex = 24;
            this.accelLb.Text = "Acceleration:";
            // 
            // accelTb
            // 
            this.accelTb.Location = new System.Drawing.Point(77, 23);
            this.accelTb.Name = "accelTb";
            this.accelTb.Size = new System.Drawing.Size(44, 20);
            this.accelTb.TabIndex = 25;
            // 
            // Velocity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 359);
            this.Controls.Add(this.accelTb);
            this.Controls.Add(this.accelLb);
            this.Controls.Add(this.vFinalPb);
            this.Name = "Velocity";
            this.Text = "Velocity";
            ((System.ComponentModel.ISupportInitialize)(this.vFinalPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vFinalPb;
        private System.Windows.Forms.Label accelLb;
        private System.Windows.Forms.TextBox accelTb;
    }
}