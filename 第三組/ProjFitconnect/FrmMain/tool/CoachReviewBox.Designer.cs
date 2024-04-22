namespace FrmMain.tool
{
    partial class CoachReviewBox
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachReviewBox));
            this.lbScore = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.roundPictureBox1 = new YourNamespace.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("微軟正黑體", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbScore.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbScore.Location = new System.Drawing.Point(118, 13);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(64, 29);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "label1";
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("微軟正黑體", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDescription.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbDescription.Location = new System.Drawing.Point(118, 57);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(357, 37);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "label2";
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(100, 105);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roundPictureBox1.TabIndex = 0;
            this.roundPictureBox1.TabStop = false;
            // 
            // CoachReviewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.roundPictureBox1);
            this.Name = "CoachReviewBox";
            this.Size = new System.Drawing.Size(493, 105);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private YourNamespace.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbDescription;
    }
}
