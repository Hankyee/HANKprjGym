namespace ProjGym
{
    partial class FrmMember_CourseReservationV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_CourseReservationV2));
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Reserve = new System.Windows.Forms.DataGridView();
            this.dataGridView_ClassInfo = new System.Windows.Forms.DataGridView();
            this.lbl_DateError = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Start.Location = new System.Drawing.Point(210, 32);
            this.dateTimePicker_Start.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(298, 29);
            this.dateTimePicker_Start.TabIndex = 1;
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_End.Location = new System.Drawing.Point(555, 32);
            this.dateTimePicker_End.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(298, 29);
            this.dateTimePicker_End.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(101, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "課程起訖:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Location = new System.Drawing.Point(881, 30);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(68, 33);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "篩選";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(517, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "～";
            // 
            // dataGridView_Reserve
            // 
            this.dataGridView_Reserve.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_Reserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reserve.Location = new System.Drawing.Point(134, 104);
            this.dataGridView_Reserve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Reserve.Name = "dataGridView_Reserve";
            this.dataGridView_Reserve.RowHeadersWidth = 51;
            this.dataGridView_Reserve.RowTemplate.Height = 27;
            this.dataGridView_Reserve.Size = new System.Drawing.Size(938, 502);
            this.dataGridView_Reserve.TabIndex = 6;
            this.dataGridView_Reserve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Reserve_CellContentClick);
            // 
            // dataGridView_ClassInfo
            // 
            this.dataGridView_ClassInfo.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_ClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClassInfo.Location = new System.Drawing.Point(134, 624);
            this.dataGridView_ClassInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_ClassInfo.Name = "dataGridView_ClassInfo";
            this.dataGridView_ClassInfo.RowHeadersWidth = 51;
            this.dataGridView_ClassInfo.RowTemplate.Height = 27;
            this.dataGridView_ClassInfo.Size = new System.Drawing.Size(285, 72);
            this.dataGridView_ClassInfo.TabIndex = 9;
            // 
            // lbl_DateError
            // 
            this.lbl_DateError.AutoSize = true;
            this.lbl_DateError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateError.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_DateError.ForeColor = System.Drawing.Color.Red;
            this.lbl_DateError.Location = new System.Drawing.Point(206, 66);
            this.lbl_DateError.Name = "lbl_DateError";
            this.lbl_DateError.Size = new System.Drawing.Size(31, 21);
            this.lbl_DateError.TabIndex = 10;
            this.lbl_DateError.Text = "---";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Snow;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(966, 30);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(68, 33);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // FrmMember_CourseReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 799);
            this.Controls.Add(this.lbl_DateError);
            this.Controls.Add(this.dataGridView_ClassInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView_Reserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_End);
            this.Controls.Add(this.dateTimePicker_Start);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_CourseReservation";
            this.Text = "Member | 課程預約";
            this.Load += new System.EventHandler(this.FrmCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Reserve;
        private System.Windows.Forms.DataGridView dataGridView_ClassInfo;
        private System.Windows.Forms.Label lbl_DateError;
        private System.Windows.Forms.Button btn_Clear;
    }
}