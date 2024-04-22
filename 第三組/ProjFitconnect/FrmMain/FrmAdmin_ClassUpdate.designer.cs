using ProjGym;
using System.Linq;
namespace mid_Coonect
{
    partial class FrmAdmin_ClassUpdate
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
            this.pb_ClassPhoto = new System.Windows.Forms.PictureBox();
            this.lbl_Divider = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_IDTitle = new System.Windows.Forms.Label();
            this.lbl_Sort1Title = new System.Windows.Forms.Label();
            this.cb_Sort1 = new System.Windows.Forms.ComboBox();
            this.lbl_Sort2Title = new System.Windows.Forms.Label();
            this.cb_Sort2 = new System.Windows.Forms.ComboBox();
            this.lbl_ClassNameTitle = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.TextBox();
            this.txt_Introduction = new System.Windows.Forms.TextBox();
            this.lbl_IntroductionTitle = new System.Windows.Forms.Label();
            this.cb_Limit = new System.Windows.Forms.ComboBox();
            this.lbl_LimitTitle = new System.Windows.Forms.Label();
            this.btn_Begin = new System.Windows.Forms.Button();
            this.dataGridView_ClassSortList = new System.Windows.Forms.DataGridView();
            this.lbl_PhotoTitle = new System.Windows.Forms.Label();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_CurrentIndex = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClassPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassSortList)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ClassPhoto
            // 
            this.pb_ClassPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_ClassPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.pb_ClassPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ClassPhoto.Location = new System.Drawing.Point(746, 403);
            this.pb_ClassPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_ClassPhoto.Name = "pb_ClassPhoto";
            this.pb_ClassPhoto.Size = new System.Drawing.Size(514, 170);
            this.pb_ClassPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ClassPhoto.TabIndex = 7;
            this.pb_ClassPhoto.TabStop = false;
            this.pb_ClassPhoto.Click += new System.EventHandler(this.pb_ClassPhoto_Click);
            // 
            // lbl_Divider
            // 
            this.lbl_Divider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Divider.Location = new System.Drawing.Point(731, 589);
            this.lbl_Divider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Divider.Name = "lbl_Divider";
            this.lbl_Divider.Size = new System.Drawing.Size(500, 2);
            this.lbl_Divider.TabIndex = 6;
            this.lbl_Divider.Text = "label1";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(1018, 600);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 41);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(863, 600);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 41);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_IDTitle
            // 
            this.lbl_IDTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IDTitle.AutoSize = true;
            this.lbl_IDTitle.Location = new System.Drawing.Point(743, 52);
            this.lbl_IDTitle.Name = "lbl_IDTitle";
            this.lbl_IDTitle.Size = new System.Drawing.Size(69, 19);
            this.lbl_IDTitle.TabIndex = 8;
            this.lbl_IDTitle.Text = "課程編號";
            // 
            // lbl_Sort1Title
            // 
            this.lbl_Sort1Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Sort1Title.AutoSize = true;
            this.lbl_Sort1Title.Location = new System.Drawing.Point(883, 54);
            this.lbl_Sort1Title.Name = "lbl_Sort1Title";
            this.lbl_Sort1Title.Size = new System.Drawing.Size(39, 19);
            this.lbl_Sort1Title.TabIndex = 10;
            this.lbl_Sort1Title.Text = "類型";
            // 
            // cb_Sort1
            // 
            this.cb_Sort1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Sort1.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Sort1.FormattingEnabled = true;
            this.cb_Sort1.Location = new System.Drawing.Point(935, 51);
            this.cb_Sort1.Name = "cb_Sort1";
            this.cb_Sort1.Size = new System.Drawing.Size(114, 26);
            this.cb_Sort1.TabIndex = 11;
            this.cb_Sort1.Text = "--";
            // 
            // lbl_Sort2Title
            // 
            this.lbl_Sort2Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Sort2Title.AutoSize = true;
            this.lbl_Sort2Title.Location = new System.Drawing.Point(1055, 54);
            this.lbl_Sort2Title.Name = "lbl_Sort2Title";
            this.lbl_Sort2Title.Size = new System.Drawing.Size(39, 19);
            this.lbl_Sort2Title.TabIndex = 10;
            this.lbl_Sort2Title.Text = "分類";
            // 
            // cb_Sort2
            // 
            this.cb_Sort2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Sort2.FormattingEnabled = true;
            this.cb_Sort2.Location = new System.Drawing.Point(1135, 50);
            this.cb_Sort2.Name = "cb_Sort2";
            this.cb_Sort2.Size = new System.Drawing.Size(125, 26);
            this.cb_Sort2.TabIndex = 11;
            this.cb_Sort2.Text = "--";
            // 
            // lbl_ClassNameTitle
            // 
            this.lbl_ClassNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ClassNameTitle.AutoSize = true;
            this.lbl_ClassNameTitle.Location = new System.Drawing.Point(742, 151);
            this.lbl_ClassNameTitle.Name = "lbl_ClassNameTitle";
            this.lbl_ClassNameTitle.Size = new System.Drawing.Size(69, 19);
            this.lbl_ClassNameTitle.TabIndex = 12;
            this.lbl_ClassNameTitle.Text = "課程名稱";
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ClassName.Location = new System.Drawing.Point(746, 173);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(514, 27);
            this.txt_ClassName.TabIndex = 13;
            // 
            // txt_Introduction
            // 
            this.txt_Introduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Introduction.Location = new System.Drawing.Point(746, 245);
            this.txt_Introduction.Multiline = true;
            this.txt_Introduction.Name = "txt_Introduction";
            this.txt_Introduction.Size = new System.Drawing.Size(514, 107);
            this.txt_Introduction.TabIndex = 15;
            // 
            // lbl_IntroductionTitle
            // 
            this.lbl_IntroductionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IntroductionTitle.AutoSize = true;
            this.lbl_IntroductionTitle.Location = new System.Drawing.Point(742, 223);
            this.lbl_IntroductionTitle.Name = "lbl_IntroductionTitle";
            this.lbl_IntroductionTitle.Size = new System.Drawing.Size(39, 19);
            this.lbl_IntroductionTitle.TabIndex = 14;
            this.lbl_IntroductionTitle.Text = "介紹";
            // 
            // cb_Limit
            // 
            this.cb_Limit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Limit.FormattingEnabled = true;
            this.cb_Limit.Location = new System.Drawing.Point(963, 95);
            this.cb_Limit.Name = "cb_Limit";
            this.cb_Limit.Size = new System.Drawing.Size(86, 26);
            this.cb_Limit.TabIndex = 17;
            this.cb_Limit.Text = "--";
            // 
            // lbl_LimitTitle
            // 
            this.lbl_LimitTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_LimitTitle.AutoSize = true;
            this.lbl_LimitTitle.Location = new System.Drawing.Point(883, 98);
            this.lbl_LimitTitle.Name = "lbl_LimitTitle";
            this.lbl_LimitTitle.Size = new System.Drawing.Size(69, 19);
            this.lbl_LimitTitle.TabIndex = 16;
            this.lbl_LimitTitle.Text = "性別限制";
            // 
            // btn_Begin
            // 
            this.btn_Begin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Begin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Begin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Begin.Location = new System.Drawing.Point(81, 603);
            this.btn_Begin.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Begin.Name = "btn_Begin";
            this.btn_Begin.Size = new System.Drawing.Size(57, 38);
            this.btn_Begin.TabIndex = 21;
            this.btn_Begin.Text = "|<<";
            this.btn_Begin.UseVisualStyleBackColor = false;
            this.btn_Begin.Click += new System.EventHandler(this.Btn_Begin_Click);
            // 
            // dataGridView_ClassSortList
            // 
            this.dataGridView_ClassSortList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView_ClassSortList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ClassSortList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClassSortList.Location = new System.Drawing.Point(81, 50);
            this.dataGridView_ClassSortList.Name = "dataGridView_ClassSortList";
            this.dataGridView_ClassSortList.RowHeadersWidth = 100;
            this.dataGridView_ClassSortList.RowTemplate.Height = 27;
            this.dataGridView_ClassSortList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_ClassSortList.Size = new System.Drawing.Size(622, 532);
            this.dataGridView_ClassSortList.TabIndex = 22;
            this.dataGridView_ClassSortList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClassSortList_CellDoubleClick);
            this.dataGridView_ClassSortList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClassSortList_CellDoubleClick);
            this.dataGridView_ClassSortList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClassSortList_CellDoubleClick);
            this.dataGridView_ClassSortList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClassSortList_CellDoubleClick);
            // 
            // lbl_PhotoTitle
            // 
            this.lbl_PhotoTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_PhotoTitle.AutoSize = true;
            this.lbl_PhotoTitle.Location = new System.Drawing.Point(742, 379);
            this.lbl_PhotoTitle.Name = "lbl_PhotoTitle";
            this.lbl_PhotoTitle.Size = new System.Drawing.Size(39, 19);
            this.lbl_PhotoTitle.TabIndex = 14;
            this.lbl_PhotoTitle.Text = "照片";
            // 
            // btn_Previous
            // 
            this.btn_Previous.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Previous.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Previous.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Location = new System.Drawing.Point(148, 603);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(57, 38);
            this.btn_Previous.TabIndex = 23;
            this.btn_Previous.Text = "<";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // btn_End
            // 
            this.btn_End.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_End.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_End.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_End.Location = new System.Drawing.Point(617, 603);
            this.btn_End.Margin = new System.Windows.Forms.Padding(5);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(57, 38);
            this.btn_End.TabIndex = 25;
            this.btn_End.Text = ">>|";
            this.btn_End.UseVisualStyleBackColor = false;
            this.btn_End.Click += new System.EventHandler(this.Btn_End_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Next.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(550, 603);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(57, 38);
            this.btn_Next.TabIndex = 24;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // lbl_CurrentIndex
            // 
            this.lbl_CurrentIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CurrentIndex.AutoSize = true;
            this.lbl_CurrentIndex.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CurrentIndex.Location = new System.Drawing.Point(12, 612);
            this.lbl_CurrentIndex.Name = "lbl_CurrentIndex";
            this.lbl_CurrentIndex.Size = new System.Drawing.Size(32, 19);
            this.lbl_CurrentIndex.TabIndex = 26;
            this.lbl_CurrentIndex.Text = "../..";
            // 
            // lb_Status
            // 
            this.lb_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(1055, 98);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(69, 19);
            this.lb_Status.TabIndex = 27;
            this.lb_Status.Text = "課程狀態";
            // 
            // cb_Status
            // 
            this.cb_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(1135, 98);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(125, 26);
            this.cb_Status.TabIndex = 28;
            this.cb_Status.Text = "--";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ID.Font = new System.Drawing.Font("微軟正黑體 Light", 10.76635F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ID.Location = new System.Drawing.Point(787, 48);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(40, 27);
            this.txt_ID.TabIndex = 29;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_ID.BackColor = System.Drawing.Color.White;
            this.tb_ID.Location = new System.Drawing.Point(818, 54);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(44, 27);
            this.tb_ID.TabIndex = 29;
            // 
            // FrmAdmin_ClassUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1296, 690);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lbl_CurrentIndex);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.dataGridView_ClassSortList);
            this.Controls.Add(this.btn_Begin);
            this.Controls.Add(this.cb_Limit);
            this.Controls.Add(this.lbl_LimitTitle);
            this.Controls.Add(this.txt_Introduction);
            this.Controls.Add(this.lbl_PhotoTitle);
            this.Controls.Add(this.lbl_IntroductionTitle);
            this.Controls.Add(this.txt_ClassName);
            this.Controls.Add(this.lbl_ClassNameTitle);
            this.Controls.Add(this.cb_Sort2);
            this.Controls.Add(this.cb_Sort1);
            this.Controls.Add(this.lbl_Sort2Title);
            this.Controls.Add(this.lbl_Sort1Title);
            this.Controls.Add(this.lbl_IDTitle);
            this.Controls.Add(this.pb_ClassPhoto);
            this.Controls.Add(this.lbl_Divider);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin_ClassUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin | 課程管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClassUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClassPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassSortList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ClassPhoto;
        private System.Windows.Forms.Label lbl_Divider;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_IDTitle;
        private System.Windows.Forms.Label lbl_Sort1Title;
        private System.Windows.Forms.ComboBox cb_Sort1;
        private System.Windows.Forms.Label lbl_Sort2Title;
        private System.Windows.Forms.ComboBox cb_Sort2;
        private System.Windows.Forms.Label lbl_ClassNameTitle;
        private System.Windows.Forms.TextBox txt_ClassName;
        private System.Windows.Forms.TextBox txt_Introduction;
        private System.Windows.Forms.Label lbl_IntroductionTitle;
        private System.Windows.Forms.ComboBox cb_Limit;
        private System.Windows.Forms.Label lbl_LimitTitle;
        private System.Windows.Forms.Button btn_Begin;
        private System.Windows.Forms.DataGridView dataGridView_ClassSortList;
        private System.Windows.Forms.Label lbl_PhotoTitle;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_CurrentIndex;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox tb_ID;
    }
}