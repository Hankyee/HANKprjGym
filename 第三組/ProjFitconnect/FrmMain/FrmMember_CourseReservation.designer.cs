namespace ProjGym
{
    partial class FrmMember_CourseReservation
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
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Class = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_ClassCategories = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_Start.Location = new System.Drawing.Point(206, 29);
            this.dateTimePicker_Start.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(249, 30);
            this.dateTimePicker_Start.TabIndex = 1;
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_End.Location = new System.Drawing.Point(511, 29);
            this.dateTimePicker_End.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(249, 30);
            this.dateTimePicker_End.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "課程起訖:";
            // 
            // flowLayoutPanel_Class
            // 
            this.flowLayoutPanel_Class.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_Class.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel_Class.Location = new System.Drawing.Point(206, 89);
            this.flowLayoutPanel_Class.Name = "flowLayoutPanel_Class";
            this.flowLayoutPanel_Class.Size = new System.Drawing.Size(925, 199);
            this.flowLayoutPanel_Class.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Location = new System.Drawing.Point(800, 24);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 36);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_ClassCategories
            // 
            this.lbl_ClassCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ClassCategories.AutoSize = true;
            this.lbl_ClassCategories.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ClassCategories.Location = new System.Drawing.Point(84, 96);
            this.lbl_ClassCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ClassCategories.Name = "lbl_ClassCategories";
            this.lbl_ClassCategories.Size = new System.Drawing.Size(116, 31);
            this.lbl_ClassCategories.TabIndex = 3;
            this.lbl_ClassCategories.Text = "課程類型:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(470, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "～";
            // 
            // dataGridView_Test
            // 
            this.dataGridView_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Test.Location = new System.Drawing.Point(60, 294);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.RowHeadersWidth = 51;
            this.dataGridView_Test.RowTemplate.Height = 27;
            this.dataGridView_Test.Size = new System.Drawing.Size(1193, 375);
            this.dataGridView_Test.TabIndex = 6;
            // 
            // FrmMember_CourseReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1265, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ClassCategories);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView_Test);
            this.Controls.Add(this.flowLayoutPanel_Class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_End);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMember_CourseReservation";
            this.Text = "Member | 課程預約";
            this.Load += new System.EventHandler(this.FrmCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Class;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_ClassCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Test;
    }
}