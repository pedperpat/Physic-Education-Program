namespace Physics
{
    partial class VideoReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoReview));
            this.clickLinkLb = new System.Windows.Forms.LinkLabel();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.backBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // clickLinkLb
            // 
            this.clickLinkLb.AutoSize = true;
            this.clickLinkLb.Location = new System.Drawing.Point(44, 433);
            this.clickLinkLb.Name = "clickLinkLb";
            this.clickLinkLb.Size = new System.Drawing.Size(129, 13);
            this.clickLinkLb.TabIndex = 1;
            this.clickLinkLb.TabStop = true;
            this.clickLinkLb.Text = "Click here for more videos";
            this.clickLinkLb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickLinkLb_LinkClicked);
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(47, 50);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(693, 351);
            this.axShockwaveFlash1.TabIndex = 2;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(390, 407);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(350, 65);
            this.backBt.TabIndex = 3;
            this.backBt.Text = "Go back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // VideoReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.clickLinkLb);
            this.Name = "VideoReview";
            this.Text = "VideoReview";
            this.Load += new System.EventHandler(this.VideoReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel clickLinkLb;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button backBt;
    }
}