namespace ProjGym
{
    partial class FrmNewCoachRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewCoachRegister));
            this.cb_GenderList = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Birth = new System.Windows.Forms.DateTimePicker();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_intro = new System.Windows.Forms.RichTextBox();
            this.panel_expert = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_GenderList
            // 
            this.cb_GenderList.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_GenderList.FormattingEnabled = true;
            this.cb_GenderList.Location = new System.Drawing.Point(153, 100);
            this.cb_GenderList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_GenderList.Name = "cb_GenderList";
            this.cb_GenderList.Size = new System.Drawing.Size(140, 25);
            this.cb_GenderList.TabIndex = 2;
            // 
            // dateTimePicker_Birth
            // 
            this.dateTimePicker_Birth.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Birth.Location = new System.Drawing.Point(153, 218);
            this.dateTimePicker_Birth.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateTimePicker_Birth.Name = "dateTimePicker_Birth";
            this.dateTimePicker_Birth.Size = new System.Drawing.Size(152, 25);
            this.dateTimePicker_Birth.TabIndex = 4;
            // 
            // pb_Photo
            // 
            this.pb_Photo.BackColor = System.Drawing.Color.Snow;
            this.pb_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photo.Location = new System.Drawing.Point(573, 51);
            this.pb_Photo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(306, 305);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Photo.TabIndex = 50;
            this.pb_Photo.TabStop = false;
            this.pb_Photo.Click += new System.EventHandler(this.pb_Photo_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(617, 658);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 45);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(760, 658);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 45);
            this.btn_Save.TabIndex = 21;
            this.btn_Save.Text = "註冊";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Password.Location = new System.Drawing.Point(153, 392);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(378, 25);
            this.tb_Password.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(53, 391);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "密碼:";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Address.Location = new System.Drawing.Point(153, 276);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(378, 25);
            this.tb_Address.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(53, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "地址:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Mail.Location = new System.Drawing.Point(153, 333);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(378, 25);
            this.tb_Mail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(53, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "電郵:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(53, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 46;
            this.label4.Text = "生日:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Phone.Location = new System.Drawing.Point(153, 160);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(378, 25);
            this.tb_Phone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "電話:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "性別:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Name.Location = new System.Drawing.Point(153, 45);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(378, 25);
            this.tb_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "姓名:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(53, 443);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 31);
            this.label8.TabIndex = 51;
            this.label8.Text = "專長:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 16.14953F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(53, 533);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 31);
            this.label9.TabIndex = 52;
            this.label9.Text = "簡介:";
            // 
            // tb_intro
            // 
            this.tb_intro.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_intro.Location = new System.Drawing.Point(153, 539);
            this.tb_intro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_intro.Name = "tb_intro";
            this.tb_intro.Size = new System.Drawing.Size(728, 104);
            this.tb_intro.TabIndex = 20;
            this.tb_intro.Text = "";
            // 
            // panel_expert
            // 
            this.panel_expert.BackColor = System.Drawing.Color.Transparent;
            this.panel_expert.Location = new System.Drawing.Point(153, 440);
            this.panel_expert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_expert.Name = "panel_expert";
            this.panel_expert.Size = new System.Drawing.Size(727, 88);
            this.panel_expert.TabIndex = 54;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(799, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 55;
            this.button1.Text = "Demo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNewCoachRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(938, 716);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_expert);
            this.Controls.Add(this.tb_intro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_GenderList);
            this.Controls.Add(this.dateTimePicker_Birth);
            this.Controls.Add(this.pb_Photo);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmNewCoachRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewCoachRegister";
            this.Load += new System.EventHandler(this.FrmNewCoachRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_GenderList;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birth;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tb_intro;
        private System.Windows.Forms.FlowLayoutPanel panel_expert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}