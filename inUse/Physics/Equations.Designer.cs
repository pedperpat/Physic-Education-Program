namespace Physics
{
    partial class Equations
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
            this.backBt = new System.Windows.Forms.Button();
            this.ToAccelerationBt = new System.Windows.Forms.Button();
            this.toHmaxBt = new System.Windows.Forms.Button();
            this.toVelocityBt = new System.Windows.Forms.Button();
            this.energyBt = new System.Windows.Forms.Button();
            this.goToAngularAccBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(437, 12);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(107, 30);
            this.backBt.TabIndex = 0;
            this.backBt.Text = "Go to main screen";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // ToAccelerationBt
            // 
            this.ToAccelerationBt.Location = new System.Drawing.Point(122, 84);
            this.ToAccelerationBt.Name = "ToAccelerationBt";
            this.ToAccelerationBt.Size = new System.Drawing.Size(136, 46);
            this.ToAccelerationBt.TabIndex = 1;
            this.ToAccelerationBt.Text = "Obtain acceleration";
            this.ToAccelerationBt.UseVisualStyleBackColor = true;
            this.ToAccelerationBt.Click += new System.EventHandler(this.ToAccelerationBt_Click);
            // 
            // toHmaxBt
            // 
            this.toHmaxBt.Location = new System.Drawing.Point(334, 84);
            this.toHmaxBt.Name = "toHmaxBt";
            this.toHmaxBt.Size = new System.Drawing.Size(138, 46);
            this.toHmaxBt.TabIndex = 2;
            this.toHmaxBt.Text = "Obtain initial V and Hmax";
            this.toHmaxBt.UseVisualStyleBackColor = true;
            this.toHmaxBt.Click += new System.EventHandler(this.toHmaxBt_Click);
            // 
            // toVelocityBt
            // 
            this.toVelocityBt.Location = new System.Drawing.Point(122, 209);
            this.toVelocityBt.Name = "toVelocityBt";
            this.toVelocityBt.Size = new System.Drawing.Size(136, 46);
            this.toVelocityBt.TabIndex = 3;
            this.toVelocityBt.Text = "Obtain final velocity when you drop an item";
            this.toVelocityBt.UseVisualStyleBackColor = true;
            this.toVelocityBt.Click += new System.EventHandler(this.toVelocityBt_Click);
            // 
            // energyBt
            // 
            this.energyBt.Location = new System.Drawing.Point(334, 209);
            this.energyBt.Name = "energyBt";
            this.energyBt.Size = new System.Drawing.Size(138, 46);
            this.energyBt.TabIndex = 4;
            this.energyBt.Text = "Obtain kinetic energy";
            this.energyBt.UseVisualStyleBackColor = true;
            this.energyBt.Click += new System.EventHandler(this.energyBt_Click);
            // 
            // goToAngularAccBt
            // 
            this.goToAngularAccBt.Location = new System.Drawing.Point(225, 147);
            this.goToAngularAccBt.Name = "goToAngularAccBt";
            this.goToAngularAccBt.Size = new System.Drawing.Size(136, 46);
            this.goToAngularAccBt.TabIndex = 5;
            this.goToAngularAccBt.Text = "Obtain angular acceleration";
            this.goToAngularAccBt.UseVisualStyleBackColor = true;
            this.goToAngularAccBt.Click += new System.EventHandler(this.goToAngularAccBt_Click);
            // 
            // Equations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 329);
            this.Controls.Add(this.goToAngularAccBt);
            this.Controls.Add(this.energyBt);
            this.Controls.Add(this.toVelocityBt);
            this.Controls.Add(this.toHmaxBt);
            this.Controls.Add(this.ToAccelerationBt);
            this.Controls.Add(this.backBt);
            this.Name = "Equations";
            this.Text = "Equations";
            this.Load += new System.EventHandler(this.Equations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button ToAccelerationBt;
        private System.Windows.Forms.Button toHmaxBt;
        private System.Windows.Forms.Button toVelocityBt;
        private System.Windows.Forms.Button energyBt;
        private System.Windows.Forms.Button goToAngularAccBt;
    }
}