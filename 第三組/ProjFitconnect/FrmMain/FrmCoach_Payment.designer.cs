namespace ProjGym
{
    partial class FrmCoach_Payment
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
            this.dateTimePicker_Filter = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_DateTitle = new System.Windows.Forms.Label();
            this.lbl_CoachName = new System.Windows.Forms.Label();
            this.lbl_FieldName = new System.Windows.Forms.Label();
            this.lbl_Divider = new System.Windows.Forms.Label();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_ReserveStatus = new System.Windows.Forms.ComboBox();
            this.lbl_ReserveStatusTitle = new System.Windows.Forms.Label();
            this.cb_PaymentStatus = new System.Windows.Forms.ComboBox();
            this.lbl_PayStatusTitle = new System.Windows.Forms.Label();
            this.lbl_CoachIDTitle = new System.Windows.Forms.Label();
            this.lbl_FieldIDTitle = new System.Windows.Forms.Label();
            this.lbl_Identity = new System.Windows.Forms.Label();
            this.lbl_DateFilterTitle = new System.Windows.Forms.Label();
            this.lbl_IdentityTitle = new System.Windows.Forms.Label();
            this.dataGridView_Payment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Filter
            // 
            this.dateTimePicker_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_Filter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Filter.Location = new System.Drawing.Point(13, 26);
            this.dateTimePicker_Filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_Filter.Name = "dateTimePicker_Filter";
            this.dateTimePicker_Filter.Size = new System.Drawing.Size(172, 29);
            this.dateTimePicker_Filter.TabIndex = 63;
            this.dateTimePicker_Filter.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            this.dateTimePicker_Filter.ValueChanged += new System.EventHandler(this.dateTimePicker_Filter_ValueChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(868, 122);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(24, 21);
            this.lbl_Date.TabIndex = 62;
            this.lbl_Date.Text = "--";
            // 
            // lbl_DateTitle
            // 
            this.lbl_DateTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DateTitle.AutoSize = true;
            this.lbl_DateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_DateTitle.Location = new System.Drawing.Point(786, 130);
            this.lbl_DateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateTitle.Name = "lbl_DateTitle";
            this.lbl_DateTitle.Size = new System.Drawing.Size(46, 21);
            this.lbl_DateTitle.TabIndex = 61;
            this.lbl_DateTitle.Text = "日期:";
            // 
            // lbl_CoachName
            // 
            this.lbl_CoachName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CoachName.AutoSize = true;
            this.lbl_CoachName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CoachName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CoachName.ForeColor = System.Drawing.Color.Black;
            this.lbl_CoachName.Location = new System.Drawing.Point(868, 250);
            this.lbl_CoachName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CoachName.Name = "lbl_CoachName";
            this.lbl_CoachName.Size = new System.Drawing.Size(24, 21);
            this.lbl_CoachName.TabIndex = 60;
            this.lbl_CoachName.Text = "--";
            // 
            // lbl_FieldName
            // 
            this.lbl_FieldName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_FieldName.AutoSize = true;
            this.lbl_FieldName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FieldName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_FieldName.ForeColor = System.Drawing.Color.Black;
            this.lbl_FieldName.Location = new System.Drawing.Point(868, 186);
            this.lbl_FieldName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FieldName.Name = "lbl_FieldName";
            this.lbl_FieldName.Size = new System.Drawing.Size(24, 21);
            this.lbl_FieldName.TabIndex = 59;
            this.lbl_FieldName.Text = "--";
            // 
            // lbl_Divider
            // 
            this.lbl_Divider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Divider.Location = new System.Drawing.Point(744, 458);
            this.lbl_Divider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Divider.Name = "lbl_Divider";
            this.lbl_Divider.Size = new System.Drawing.Size(343, 2);
            this.lbl_Divider.TabIndex = 58;
            this.lbl_Divider.Text = "label1";
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ClearFilter.BackColor = System.Drawing.Color.Snow;
            this.btn_ClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_ClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_ClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearFilter.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClearFilter.Location = new System.Drawing.Point(215, 24);
            this.btn_ClearFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(82, 34);
            this.btn_ClearFilter.TabIndex = 56;
            this.btn_ClearFilter.Text = "清除篩選";
            this.btn_ClearFilter.UseVisualStyleBackColor = false;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Snow;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(930, 500);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 42);
            this.btn_Save.TabIndex = 55;
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
            this.btn_Cancel.Location = new System.Drawing.Point(784, 500);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 42);
            this.btn_Cancel.TabIndex = 57;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cb_ReserveStatus
            // 
            this.cb_ReserveStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_ReserveStatus.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_ReserveStatus.FormattingEnabled = true;
            this.cb_ReserveStatus.Location = new System.Drawing.Point(868, 384);
            this.cb_ReserveStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ReserveStatus.Name = "cb_ReserveStatus";
            this.cb_ReserveStatus.Size = new System.Drawing.Size(162, 24);
            this.cb_ReserveStatus.TabIndex = 54;
            this.cb_ReserveStatus.Text = "--";
            // 
            // lbl_ReserveStatusTitle
            // 
            this.lbl_ReserveStatusTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ReserveStatusTitle.AutoSize = true;
            this.lbl_ReserveStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReserveStatusTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ReserveStatusTitle.Location = new System.Drawing.Point(764, 388);
            this.lbl_ReserveStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ReserveStatusTitle.Name = "lbl_ReserveStatusTitle";
            this.lbl_ReserveStatusTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_ReserveStatusTitle.TabIndex = 53;
            this.lbl_ReserveStatusTitle.Text = "保留狀態:";
            // 
            // cb_PaymentStatus
            // 
            this.cb_PaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_PaymentStatus.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_PaymentStatus.FormattingEnabled = true;
            this.cb_PaymentStatus.Location = new System.Drawing.Point(868, 313);
            this.cb_PaymentStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_PaymentStatus.Name = "cb_PaymentStatus";
            this.cb_PaymentStatus.Size = new System.Drawing.Size(162, 24);
            this.cb_PaymentStatus.TabIndex = 52;
            this.cb_PaymentStatus.Text = "--";
            // 
            // lbl_PayStatusTitle
            // 
            this.lbl_PayStatusTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_PayStatusTitle.AutoSize = true;
            this.lbl_PayStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PayStatusTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_PayStatusTitle.Location = new System.Drawing.Point(764, 317);
            this.lbl_PayStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PayStatusTitle.Name = "lbl_PayStatusTitle";
            this.lbl_PayStatusTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_PayStatusTitle.TabIndex = 51;
            this.lbl_PayStatusTitle.Text = "付款狀態:";
            // 
            // lbl_CoachIDTitle
            // 
            this.lbl_CoachIDTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CoachIDTitle.AutoSize = true;
            this.lbl_CoachIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CoachIDTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CoachIDTitle.Location = new System.Drawing.Point(764, 250);
            this.lbl_CoachIDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CoachIDTitle.Name = "lbl_CoachIDTitle";
            this.lbl_CoachIDTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_CoachIDTitle.TabIndex = 49;
            this.lbl_CoachIDTitle.Text = "教練名稱:";
            // 
            // lbl_FieldIDTitle
            // 
            this.lbl_FieldIDTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_FieldIDTitle.AutoSize = true;
            this.lbl_FieldIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FieldIDTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_FieldIDTitle.Location = new System.Drawing.Point(764, 186);
            this.lbl_FieldIDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FieldIDTitle.Name = "lbl_FieldIDTitle";
            this.lbl_FieldIDTitle.Size = new System.Drawing.Size(78, 21);
            this.lbl_FieldIDTitle.TabIndex = 50;
            this.lbl_FieldIDTitle.Text = "場地名稱:";
            // 
            // lbl_Identity
            // 
            this.lbl_Identity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Identity.AutoSize = true;
            this.lbl_Identity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Identity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Identity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Identity.Location = new System.Drawing.Point(868, 70);
            this.lbl_Identity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Identity.Name = "lbl_Identity";
            this.lbl_Identity.Size = new System.Drawing.Size(24, 21);
            this.lbl_Identity.TabIndex = 48;
            this.lbl_Identity.Text = "--";
            // 
            // lbl_DateFilterTitle
            // 
            this.lbl_DateFilterTitle.AutoSize = true;
            this.lbl_DateFilterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateFilterTitle.Location = new System.Drawing.Point(-106, 31);
            this.lbl_DateFilterTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateFilterTitle.Name = "lbl_DateFilterTitle";
            this.lbl_DateFilterTitle.Size = new System.Drawing.Size(80, 12);
            this.lbl_DateFilterTitle.TabIndex = 46;
            this.lbl_DateFilterTitle.Text = "篩選特定日期:";
            // 
            // lbl_IdentityTitle
            // 
            this.lbl_IdentityTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IdentityTitle.AutoSize = true;
            this.lbl_IdentityTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdentityTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IdentityTitle.Location = new System.Drawing.Point(775, 78);
            this.lbl_IdentityTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdentityTitle.Name = "lbl_IdentityTitle";
            this.lbl_IdentityTitle.Size = new System.Drawing.Size(62, 21);
            this.lbl_IdentityTitle.TabIndex = 47;
            this.lbl_IdentityTitle.Text = "流水號:";
            // 
            // dataGridView_Payment
            // 
            this.dataGridView_Payment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView_Payment.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payment.Location = new System.Drawing.Point(11, 67);
            this.dataGridView_Payment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Payment.Name = "dataGridView_Payment";
            this.dataGridView_Payment.RowHeadersWidth = 51;
            this.dataGridView_Payment.RowTemplate.Height = 27;
            this.dataGridView_Payment.Size = new System.Drawing.Size(703, 552);
            this.dataGridView_Payment.TabIndex = 45;
            this.dataGridView_Payment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Payment_CellClick);
            this.dataGridView_Payment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Payment_CellDoubleClick);
            // 
            // FrmCoach_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1145, 632);
            this.Controls.Add(this.dateTimePicker_Filter);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_DateTitle);
            this.Controls.Add(this.lbl_CoachName);
            this.Controls.Add(this.lbl_FieldName);
            this.Controls.Add(this.lbl_Divider);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cb_ReserveStatus);
            this.Controls.Add(this.lbl_ReserveStatusTitle);
            this.Controls.Add(this.cb_PaymentStatus);
            this.Controls.Add(this.lbl_PayStatusTitle);
            this.Controls.Add(this.lbl_CoachIDTitle);
            this.Controls.Add(this.lbl_FieldIDTitle);
            this.Controls.Add(this.lbl_Identity);
            this.Controls.Add(this.lbl_DateFilterTitle);
            this.Controls.Add(this.lbl_IdentityTitle);
            this.Controls.Add(this.dataGridView_Payment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCoach_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCoach_Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCoach_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Filter;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_DateTitle;
        private System.Windows.Forms.Label lbl_CoachName;
        private System.Windows.Forms.Label lbl_FieldName;
        private System.Windows.Forms.Label lbl_Divider;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cb_ReserveStatus;
        private System.Windows.Forms.Label lbl_ReserveStatusTitle;
        private System.Windows.Forms.ComboBox cb_PaymentStatus;
        private System.Windows.Forms.Label lbl_PayStatusTitle;
        private System.Windows.Forms.Label lbl_CoachIDTitle;
        private System.Windows.Forms.Label lbl_FieldIDTitle;
        private System.Windows.Forms.Label lbl_Identity;
        private System.Windows.Forms.Label lbl_DateFilterTitle;
        private System.Windows.Forms.Label lbl_IdentityTitle;
        private System.Windows.Forms.DataGridView dataGridView_Payment;
    }
}