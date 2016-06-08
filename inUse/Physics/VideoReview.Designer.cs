namespace Physics
{
    partial class VideoReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoReviewForm));
            this.clickLinkLb = new System.Windows.Forms.LinkLabel();
            this.youtubeVideo = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.backBt = new System.Windows.Forms.Button();
            this.nextVidBt = new System.Windows.Forms.Button();
            this.prevVidBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeVideo)).BeginInit();
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
            // youtubeVideo
            // 
            this.youtubeVideo.Enabled = true;
            this.youtubeVideo.Location = new System.Drawing.Point(47, 50);
            this.youtubeVideo.Name = "youtubeVideo";
            this.youtubeVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtubeVideo.OcxState")));
            this.youtubeVideo.Size = new System.Drawing.Size(693, 351);
            this.youtubeVideo.TabIndex = 2;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(579, 413);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(161, 52);
            this.backBt.TabIndex = 3;
            this.backBt.Text = "Go back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // nextVidBt
            // 
            this.nextVidBt.Location = new System.Drawing.Point(595, 12);
            this.nextVidBt.Name = "nextVidBt";
            this.nextVidBt.Size = new System.Drawing.Size(90, 32);
            this.nextVidBt.TabIndex = 4;
            this.nextVidBt.Text = "Next Video";
            this.nextVidBt.UseVisualStyleBackColor = true;
            this.nextVidBt.Click += new System.EventHandler(this.nextVidBt_Click);
            // 
            // prevVidBt
            // 
            this.prevVidBt.Location = new System.Drawing.Point(499, 12);
            this.prevVidBt.Name = "prevVidBt";
            this.prevVidBt.Size = new System.Drawing.Size(90, 32);
            this.prevVidBt.TabIndex = 5;
            this.prevVidBt.Text = "Previous Video";
            this.prevVidBt.UseVisualStyleBackColor = true;
            this.prevVidBt.Click += new System.EventHandler(this.prevVidBt_Click);
            // 
            // VideoReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.prevVidBt);
            this.Controls.Add(this.nextVidBt);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.youtubeVideo);
            this.Controls.Add(this.clickLinkLb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoReviewForm";
            this.Text = "VideoReview";
            this.Load += new System.EventHandler(this.VideoReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.youtubeVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel clickLinkLb;
        private AxShockwaveFlashObjects.AxShockwaveFlash youtubeVideo;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button nextVidBt;
        private System.Windows.Forms.Button prevVidBt;
    }
}