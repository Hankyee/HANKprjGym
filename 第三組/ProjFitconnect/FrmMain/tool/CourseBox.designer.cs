namespace ProjGym
{
    partial class CourseBox
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
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.lbl_CourseIntro = new System.Windows.Forms.Label();
            this.pb_CoursePhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CoursePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_CourseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseName.Location = new System.Drawing.Point(234, 0);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(349, 43);
            this.lbl_CourseName.TabIndex = 1;
            this.lbl_CourseName.Text = "課程名稱";
            // 
            // lbl_CourseIntro
            // 
            this.lbl_CourseIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_CourseIntro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseIntro.Location = new System.Drawing.Point(234, 43);
            this.lbl_CourseIntro.Name = "lbl_CourseIntro";
            this.lbl_CourseIntro.Size = new System.Drawing.Size(349, 153);
            this.lbl_CourseIntro.TabIndex = 2;
            this.lbl_CourseIntro.Text = "課程介紹";
            // 
            // pb_CoursePhoto
            // 
            this.pb_CoursePhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_CoursePhoto.Location = new System.Drawing.Point(0, 0);
            this.pb_CoursePhoto.Name = "pb_CoursePhoto";
            this.pb_CoursePhoto.Size = new System.Drawing.Size(234, 196);
            this.pb_CoursePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CoursePhoto.TabIndex = 0;
            this.pb_CoursePhoto.TabStop = false;
            // 
            // CourseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_CourseIntro);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.pb_CoursePhoto);
            this.Name = "CourseBox";
            this.Size = new System.Drawing.Size(583, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CoursePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_CoursePhoto;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.Label lbl_CourseIntro;
    }
}
