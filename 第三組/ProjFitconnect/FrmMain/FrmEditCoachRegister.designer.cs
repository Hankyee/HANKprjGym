namespace FrmMain
{
    partial class FrmEditCoachRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditCoachRegister));
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Birth = new System.Windows.Forms.DateTimePicker();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_intro = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Expertise = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Address.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Address.Location = new System.Drawing.Point(149, 318);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(432, 31);
            this.tb_Address.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(51, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 38;
            this.label7.Text = "地址:";
            // 
            // dateTimePicker_Birth
            // 
            this.dateTimePicker_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_Birth.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Birth.Location = new System.Drawing.Point(149, 255);
            this.dateTimePicker_Birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_Birth.Name = "dateTimePicker_Birth";
            this.dateTimePicker_Birth.Size = new System.Drawing.Size(265, 31);
            this.dateTimePicker_Birth.TabIndex = 37;
            // 
            // cb_Gender
            // 
            this.cb_Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Gender.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Location = new System.Drawing.Point(149, 129);
            this.cb_Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(160, 31);
            this.cb_Gender.TabIndex = 36;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(695, 801);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 52);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Location = new System.Drawing.Point(857, 801);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 52);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Password.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Password.Location = new System.Drawing.Point(149, 435);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(432, 31);
            this.tb_Password.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(51, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "密碼:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Mail.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Mail.Location = new System.Drawing.Point(149, 375);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(432, 31);
            this.tb_Mail.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(51, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "電郵:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(51, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "生日:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Phone.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Phone.Location = new System.Drawing.Point(149, 192);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(432, 31);
            this.tb_Phone.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(51, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "電話:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(51, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "性別:";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Name.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Name.Location = new System.Drawing.Point(149, 68);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(432, 31);
            this.tb_Name.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "姓名:";
            // 
            // pb_Photo
            // 
            this.pb_Photo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_Photo.BackColor = System.Drawing.Color.White;
            this.pb_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photo.Location = new System.Drawing.Point(629, 68);
            this.pb_Photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(351, 352);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Photo.TabIndex = 35;
            this.pb_Photo.TabStop = false;
            this.pb_Photo.Click += new System.EventHandler(this.pb_Photo_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(51, 568);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 31);
            this.label9.TabIndex = 53;
            this.label9.Text = "簡介:";
            // 
            // tb_intro
            // 
            this.tb_intro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_intro.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_intro.Location = new System.Drawing.Point(149, 572);
            this.tb_intro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_intro.Name = "tb_intro";
            this.tb_intro.Size = new System.Drawing.Size(831, 196);
            this.tb_intro.TabIndex = 54;
            this.tb_intro.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(51, 500);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 31);
            this.label8.TabIndex = 55;
            this.label8.Text = "專長:";
            // 
            // cb_Expertise
            // 
            this.cb_Expertise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Expertise.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Expertise.FormattingEnabled = true;
            this.cb_Expertise.Location = new System.Drawing.Point(149, 508);
            this.cb_Expertise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Expertise.Name = "cb_Expertise";
            this.cb_Expertise.Size = new System.Drawing.Size(101, 31);
            this.cb_Expertise.TabIndex = 57;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label10.Location = new System.Drawing.Point(488, 920);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "-end-";
            // 
            // FrmEditCoachRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 959);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_Expertise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_intro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_Birth);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.pb_Photo);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEditCoachRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditCoachRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEditCoachRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birth;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tb_intro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Expertise;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
    }
}