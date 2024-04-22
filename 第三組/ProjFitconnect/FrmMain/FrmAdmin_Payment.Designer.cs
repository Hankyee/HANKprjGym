namespace ProjGym
{
    partial class FrmAdmin_Payment
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
            this.dataGridView_Payment = new System.Windows.Forms.DataGridView();
            this.cb_ReserveStatus = new System.Windows.Forms.ComboBox();
            this.lbl_ReserveStatusTitle = new System.Windows.Forms.Label();
            this.cb_PaymentStatus = new System.Windows.Forms.ComboBox();
            this.lbl_PayStatusTitle = new System.Windows.Forms.Label();
            this.lbl_MemberIDTitle = new System.Windows.Forms.Label();
            this.lbl_CourseIDTitle = new System.Windows.Forms.Label();
            this.lbl_Identity = new System.Windows.Forms.Label();
            this.lbl_IdentityTitle = new System.Windows.Forms.Label();
            this.lbl_Divider = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.lbl_MemberName = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_DateTitle = new System.Windows.Forms.Label();
            this.dateTimePicker_Filter = new System.Windows.Forms.DateTimePicker();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateFilterTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Payment
            // 
            this.dataGridView_Payment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView_Payment.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payment.Location = new System.Drawing.Point(107, 56);
            this.dataGridView_Payment.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_Payment.Name = "dataGridView_Payment";
            this.dataGridView_Payment.RowHeadersWidth = 51;
            this.dataGridView_Payment.RowTemplate.Height = 27;
            this.dataGridView_Payment.Size = new System.Drawing.Size(715, 574);
            this.dataGridView_Payment.TabIndex = 0;
            this.dataGridView_Payment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Payment_CellClick);
            this.dataGridView_Payment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Payment_CellDoubleClick);
            // 
            // cb_ReserveStatus
            // 
            this.cb_ReserveStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_ReserveStatus.FormattingEnabled = true;
            this.cb_ReserveStatus.Location = new System.Drawing.Point(1107, 431);
            this.cb_ReserveStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ReserveStatus.Name = "cb_ReserveStatus";
            this.cb_ReserveStatus.Size = new System.Drawing.Size(189, 29);
            this.cb_ReserveStatus.TabIndex = 36;
            this.cb_ReserveStatus.Text = "--";
            // 
            // lbl_ReserveStatusTitle
            // 
            this.lbl_ReserveStatusTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ReserveStatusTitle.AutoSize = true;
            this.lbl_ReserveStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReserveStatusTitle.Location = new System.Drawing.Point(986, 435);
            this.lbl_ReserveStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ReserveStatusTitle.Name = "lbl_ReserveStatusTitle";
            this.lbl_ReserveStatusTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_ReserveStatusTitle.TabIndex = 35;
            this.lbl_ReserveStatusTitle.Text = "保留狀態:";
            // 
            // cb_PaymentStatus
            // 
            this.cb_PaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_PaymentStatus.FormattingEnabled = true;
            this.cb_PaymentStatus.Location = new System.Drawing.Point(1107, 354);
            this.cb_PaymentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cb_PaymentStatus.Name = "cb_PaymentStatus";
            this.cb_PaymentStatus.Size = new System.Drawing.Size(189, 29);
            this.cb_PaymentStatus.TabIndex = 34;
            this.cb_PaymentStatus.Text = "--";
            // 
            // lbl_PayStatusTitle
            // 
            this.lbl_PayStatusTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_PayStatusTitle.AutoSize = true;
            this.lbl_PayStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PayStatusTitle.Location = new System.Drawing.Point(986, 358);
            this.lbl_PayStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PayStatusTitle.Name = "lbl_PayStatusTitle";
            this.lbl_PayStatusTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_PayStatusTitle.TabIndex = 33;
            this.lbl_PayStatusTitle.Text = "付款狀態:";
            // 
            // lbl_MemberIDTitle
            // 
            this.lbl_MemberIDTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MemberIDTitle.AutoSize = true;
            this.lbl_MemberIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MemberIDTitle.Location = new System.Drawing.Point(986, 285);
            this.lbl_MemberIDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MemberIDTitle.Name = "lbl_MemberIDTitle";
            this.lbl_MemberIDTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_MemberIDTitle.TabIndex = 27;
            this.lbl_MemberIDTitle.Text = "會員名稱:";
            // 
            // lbl_CourseIDTitle
            // 
            this.lbl_CourseIDTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CourseIDTitle.AutoSize = true;
            this.lbl_CourseIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CourseIDTitle.Location = new System.Drawing.Point(986, 216);
            this.lbl_CourseIDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CourseIDTitle.Name = "lbl_CourseIDTitle";
            this.lbl_CourseIDTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_CourseIDTitle.TabIndex = 28;
            this.lbl_CourseIDTitle.Text = "課程名稱:";
            // 
            // lbl_Identity
            // 
            this.lbl_Identity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Identity.AutoSize = true;
            this.lbl_Identity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Identity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Identity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Identity.Location = new System.Drawing.Point(1107, 78);
            this.lbl_Identity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identity.Name = "lbl_Identity";
            this.lbl_Identity.Size = new System.Drawing.Size(24, 21);
            this.lbl_Identity.TabIndex = 26;
            this.lbl_Identity.Text = "--";
            // 
            // lbl_IdentityTitle
            // 
            this.lbl_IdentityTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IdentityTitle.AutoSize = true;
            this.lbl_IdentityTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdentityTitle.Location = new System.Drawing.Point(1006, 78);
            this.lbl_IdentityTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdentityTitle.Name = "lbl_IdentityTitle";
            this.lbl_IdentityTitle.Size = new System.Drawing.Size(62, 21);
            this.lbl_IdentityTitle.TabIndex = 25;
            this.lbl_IdentityTitle.Text = "流水號:";
            // 
            // lbl_Divider
            // 
            this.lbl_Divider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Divider.Location = new System.Drawing.Point(963, 511);
            this.lbl_Divider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Divider.Name = "lbl_Divider";
            this.lbl_Divider.Size = new System.Drawing.Size(400, 2);
            this.lbl_Divider.TabIndex = 39;
            this.lbl_Divider.Text = "label1";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Snow;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(1180, 557);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(103, 45);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.Color.Snow;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(1010, 557);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 45);
            this.btn_Cancel.TabIndex = 38;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CourseName.AutoSize = true;
            this.lbl_CourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CourseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseName.ForeColor = System.Drawing.Color.Black;
            this.lbl_CourseName.Location = new System.Drawing.Point(1107, 216);
            this.lbl_CourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(24, 21);
            this.lbl_CourseName.TabIndex = 40;
            this.lbl_CourseName.Text = "--";
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MemberName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_MemberName.ForeColor = System.Drawing.Color.Black;
            this.lbl_MemberName.Location = new System.Drawing.Point(1107, 285);
            this.lbl_MemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(24, 21);
            this.lbl_MemberName.TabIndex = 41;
            this.lbl_MemberName.Text = "--";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(1107, 147);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(24, 21);
            this.lbl_Date.TabIndex = 43;
            this.lbl_Date.Text = "--";
            // 
            // lbl_DateTitle
            // 
            this.lbl_DateTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DateTitle.AutoSize = true;
            this.lbl_DateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateTitle.Location = new System.Drawing.Point(1026, 147);
            this.lbl_DateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateTitle.Name = "lbl_DateTitle";
            this.lbl_DateTitle.Size = new System.Drawing.Size(46, 21);
            this.lbl_DateTitle.TabIndex = 42;
            this.lbl_DateTitle.Text = "日期:";
            // 
            // dateTimePicker_Filter
            // 
            this.dateTimePicker_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_Filter.Location = new System.Drawing.Point(241, 3);
            this.dateTimePicker_Filter.Name = "dateTimePicker_Filter";
            this.dateTimePicker_Filter.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker_Filter.TabIndex = 44;
            this.dateTimePicker_Filter.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dateTimePicker_Filter.ValueChanged += new System.EventHandler(this.dateTimePicker_Filter_ValueChanged);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ClearFilter.BackColor = System.Drawing.Color.Snow;
            this.btn_ClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_ClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_ClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearFilter.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClearFilter.Location = new System.Drawing.Point(489, 2);
            this.btn_ClearFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(96, 36);
            this.btn_ClearFilter.TabIndex = 38;
            this.btn_ClearFilter.Text = "清除篩選";
            this.btn_ClearFilter.UseVisualStyleBackColor = false;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(-636, -499);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker_Filter_ValueChanged);
            // 
            // lbl_DateFilterTitle
            // 
            this.lbl_DateFilterTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DateFilterTitle.AutoSize = true;
            this.lbl_DateFilterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateFilterTitle.Location = new System.Drawing.Point(102, 8);
            this.lbl_DateFilterTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateFilterTitle.Name = "lbl_DateFilterTitle";
            this.lbl_DateFilterTitle.Size = new System.Drawing.Size(110, 21);
            this.lbl_DateFilterTitle.TabIndex = 25;
            this.lbl_DateFilterTitle.Text = "篩選特定日期:";
            // 
            // FrmAdmin_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1716, 710);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker_Filter);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_DateTitle);
            this.Controls.Add(this.lbl_MemberName);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.lbl_Divider);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cb_ReserveStatus);
            this.Controls.Add(this.lbl_ReserveStatusTitle);
            this.Controls.Add(this.cb_PaymentStatus);
            this.Controls.Add(this.lbl_PayStatusTitle);
            this.Controls.Add(this.lbl_MemberIDTitle);
            this.Controls.Add(this.lbl_CourseIDTitle);
            this.Controls.Add(this.lbl_Identity);
            this.Controls.Add(this.lbl_DateFilterTitle);
            this.Controls.Add(this.lbl_IdentityTitle);
            this.Controls.Add(this.dataGridView_Payment);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAdmin_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin_Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Payment;
        private System.Windows.Forms.ComboBox cb_ReserveStatus;
        private System.Windows.Forms.Label lbl_ReserveStatusTitle;
        private System.Windows.Forms.ComboBox cb_PaymentStatus;
        private System.Windows.Forms.Label lbl_PayStatusTitle;
        private System.Windows.Forms.Label lbl_MemberIDTitle;
        private System.Windows.Forms.Label lbl_CourseIDTitle;
        private System.Windows.Forms.Label lbl_Identity;
        private System.Windows.Forms.Label lbl_IdentityTitle;
        private System.Windows.Forms.Label lbl_Divider;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.Label lbl_MemberName;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_DateTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Filter;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_DateFilterTitle;
    }
}