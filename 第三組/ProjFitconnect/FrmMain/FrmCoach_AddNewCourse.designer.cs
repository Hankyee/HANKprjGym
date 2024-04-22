namespace ProjGym
{
    
    partial class FrmCoach_AddNewCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoach_AddNewCourse));
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Field = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_TimePeriodStart = new System.Windows.Forms.ComboBox();
            this.cb_TimePeriodEnd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar_Course = new System.Windows.Forms.MonthCalendar();
            this.lb_SelectedDate = new System.Windows.Forms.ListBox();
            this.btn_ClearSelectedDate = new System.Windows.Forms.Button();
            this.btn_SubmitCourse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_MaxStudent = new System.Windows.Forms.NumericUpDown();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Field = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_End = new System.Windows.Forms.Label();
            this.lbl_MaxMember = new System.Windows.Forms.Label();
            this.lbl_SelectedDate = new System.Windows.Forms.Label();
            this.lbl_HoursPerCourse = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Devider = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Days = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Class
            // 
            this.cb_Class.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Class.BackColor = System.Drawing.Color.White;
            this.cb_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(21, 52);
            this.cb_Class.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(150, 27);
            this.cb_Class.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "課程:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(221, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "場地:";
            // 
            // cb_Field
            // 
            this.cb_Field.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Field.FormattingEnabled = true;
            this.cb_Field.Location = new System.Drawing.Point(221, 52);
            this.cb_Field.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Field.Name = "cb_Field";
            this.cb_Field.Size = new System.Drawing.Size(199, 27);
            this.cb_Field.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(303, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "已選擇日期:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(51, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "開始時段:";
            // 
            // cb_TimePeriodStart
            // 
            this.cb_TimePeriodStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TimePeriodStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimePeriodStart.FormattingEnabled = true;
            this.cb_TimePeriodStart.Location = new System.Drawing.Point(139, 392);
            this.cb_TimePeriodStart.Name = "cb_TimePeriodStart";
            this.cb_TimePeriodStart.Size = new System.Drawing.Size(121, 27);
            this.cb_TimePeriodStart.TabIndex = 6;
            this.cb_TimePeriodStart.SelectedIndexChanged += new System.EventHandler(this.cb_TimePeriod_SelectedIndexChanged);
            // 
            // cb_TimePeriodEnd
            // 
            this.cb_TimePeriodEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TimePeriodEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimePeriodEnd.FormattingEnabled = true;
            this.cb_TimePeriodEnd.Location = new System.Drawing.Point(407, 392);
            this.cb_TimePeriodEnd.Name = "cb_TimePeriodEnd";
            this.cb_TimePeriodEnd.Size = new System.Drawing.Size(121, 27);
            this.cb_TimePeriodEnd.TabIndex = 8;
            this.cb_TimePeriodEnd.SelectedIndexChanged += new System.EventHandler(this.cb_TimePeriod_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(319, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "結束時段:";
            // 
            // monthCalendar_Course
            // 
            this.monthCalendar_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar_Course.Location = new System.Drawing.Point(24, 152);
            this.monthCalendar_Course.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.monthCalendar_Course.Name = "monthCalendar_Course";
            this.monthCalendar_Course.TabIndex = 9;
            this.monthCalendar_Course.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_Course_DateSelected);
            // 
            // lb_SelectedDate
            // 
            this.lb_SelectedDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_SelectedDate.BackColor = System.Drawing.Color.White;
            this.lb_SelectedDate.FormattingEnabled = true;
            this.lb_SelectedDate.ItemHeight = 19;
            this.lb_SelectedDate.Location = new System.Drawing.Point(307, 148);
            this.lb_SelectedDate.Name = "lb_SelectedDate";
            this.lb_SelectedDate.Size = new System.Drawing.Size(262, 137);
            this.lb_SelectedDate.TabIndex = 10;
            // 
            // btn_ClearSelectedDate
            // 
            this.btn_ClearSelectedDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ClearSelectedDate.Location = new System.Drawing.Point(499, 279);
            this.btn_ClearSelectedDate.Name = "btn_ClearSelectedDate";
            this.btn_ClearSelectedDate.Size = new System.Drawing.Size(70, 35);
            this.btn_ClearSelectedDate.TabIndex = 11;
            this.btn_ClearSelectedDate.Text = "清除";
            this.btn_ClearSelectedDate.UseVisualStyleBackColor = true;
            this.btn_ClearSelectedDate.Click += new System.EventHandler(this.btn_ClearSelectedDate_Click);
            // 
            // btn_SubmitCourse
            // 
            this.btn_SubmitCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SubmitCourse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_SubmitCourse.FlatAppearance.BorderSize = 0;
            this.btn_SubmitCourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SubmitCourse.Location = new System.Drawing.Point(344, 551);
            this.btn_SubmitCourse.Name = "btn_SubmitCourse";
            this.btn_SubmitCourse.Size = new System.Drawing.Size(89, 39);
            this.btn_SubmitCourse.TabIndex = 12;
            this.btn_SubmitCourse.Text = "提交課程";
            this.btn_SubmitCourse.UseVisualStyleBackColor = false;
            this.btn_SubmitCourse.Click += new System.EventHandler(this.btn_SubmitCourse_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(479, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "人數上限:";
            // 
            // numericUpDown_MaxStudent
            // 
            this.numericUpDown_MaxStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_MaxStudent.Location = new System.Drawing.Point(479, 52);
            this.numericUpDown_MaxStudent.Name = "numericUpDown_MaxStudent";
            this.numericUpDown_MaxStudent.Size = new System.Drawing.Size(78, 28);
            this.numericUpDown_MaxStudent.TabIndex = 15;
            // 
            // lbl_Course
            // 
            this.lbl_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course.Location = new System.Drawing.Point(21, 81);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(0, 21);
            this.lbl_Course.TabIndex = 16;
            // 
            // lbl_Field
            // 
            this.lbl_Field.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Field.AutoSize = true;
            this.lbl_Field.ForeColor = System.Drawing.Color.Red;
            this.lbl_Field.Location = new System.Drawing.Point(221, 81);
            this.lbl_Field.Name = "lbl_Field";
            this.lbl_Field.Size = new System.Drawing.Size(0, 21);
            this.lbl_Field.TabIndex = 17;
            // 
            // lbl_Start
            // 
            this.lbl_Start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.ForeColor = System.Drawing.Color.Red;
            this.lbl_Start.Location = new System.Drawing.Point(51, 422);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(0, 21);
            this.lbl_Start.TabIndex = 18;
            // 
            // lbl_End
            // 
            this.lbl_End.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_End.AutoSize = true;
            this.lbl_End.ForeColor = System.Drawing.Color.Red;
            this.lbl_End.Location = new System.Drawing.Point(319, 422);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(0, 21);
            this.lbl_End.TabIndex = 18;
            // 
            // lbl_MaxMember
            // 
            this.lbl_MaxMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MaxMember.AutoSize = true;
            this.lbl_MaxMember.ForeColor = System.Drawing.Color.Red;
            this.lbl_MaxMember.Location = new System.Drawing.Point(479, 81);
            this.lbl_MaxMember.Name = "lbl_MaxMember";
            this.lbl_MaxMember.Size = new System.Drawing.Size(0, 21);
            this.lbl_MaxMember.TabIndex = 19;
            // 
            // lbl_SelectedDate
            // 
            this.lbl_SelectedDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SelectedDate.AutoSize = true;
            this.lbl_SelectedDate.ForeColor = System.Drawing.Color.Red;
            this.lbl_SelectedDate.Location = new System.Drawing.Point(400, 123);
            this.lbl_SelectedDate.Name = "lbl_SelectedDate";
            this.lbl_SelectedDate.Size = new System.Drawing.Size(0, 21);
            this.lbl_SelectedDate.TabIndex = 20;
            // 
            // lbl_HoursPerCourse
            // 
            this.lbl_HoursPerCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_HoursPerCourse.AutoSize = true;
            this.lbl_HoursPerCourse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoursPerCourse.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_HoursPerCourse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_HoursPerCourse.Location = new System.Drawing.Point(214, 456);
            this.lbl_HoursPerCourse.Name = "lbl_HoursPerCourse";
            this.lbl_HoursPerCourse.Size = new System.Drawing.Size(121, 31);
            this.lbl_HoursPerCourse.TabIndex = 21;
            this.lbl_HoursPerCourse.Text = "預約_小時";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(24, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(545, 82);
            this.label7.TabIndex = 22;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(129, 551);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 39);
            this.btn_Cancel.TabIndex = 23;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Devider
            // 
            this.lbl_Devider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Devider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Devider.Location = new System.Drawing.Point(21, 527);
            this.lbl_Devider.Name = "lbl_Devider";
            this.lbl_Devider.Size = new System.Drawing.Size(550, 2);
            this.lbl_Devider.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(64, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "點擊選擇日期";
            // 
            // lbl_Days
            // 
            this.lbl_Days.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Days.AutoSize = true;
            this.lbl_Days.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Days.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Days.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Days.Location = new System.Drawing.Point(302, 317);
            this.lbl_Days.Name = "lbl_Days";
            this.lbl_Days.Size = new System.Drawing.Size(97, 31);
            this.lbl_Days.TabIndex = 26;
            this.lbl_Days.Text = "預約_天";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCoach_AddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Days);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Devider);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_HoursPerCourse);
            this.Controls.Add(this.lbl_SelectedDate);
            this.Controls.Add(this.lbl_MaxMember);
            this.Controls.Add(this.lbl_End);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.lbl_Field);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.numericUpDown_MaxStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_SubmitCourse);
            this.Controls.Add(this.btn_ClearSelectedDate);
            this.Controls.Add(this.lb_SelectedDate);
            this.Controls.Add(this.monthCalendar_Course);
            this.Controls.Add(this.cb_TimePeriodEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_TimePeriodStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Class);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCoach_AddNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coach | 提交課程";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCoach_CourseReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_TimePeriodStart;
        private System.Windows.Forms.ComboBox cb_TimePeriodEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar_Course;
        private System.Windows.Forms.ListBox lb_SelectedDate;
        private System.Windows.Forms.Button btn_ClearSelectedDate;
        private System.Windows.Forms.Button btn_SubmitCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxStudent;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Field;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Label lbl_MaxMember;
        private System.Windows.Forms.Label lbl_SelectedDate;
        private System.Windows.Forms.Label lbl_HoursPerCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Devider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Days;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}