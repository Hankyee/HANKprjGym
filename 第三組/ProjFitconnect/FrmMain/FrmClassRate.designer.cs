namespace FrmMain
{
    partial class FrmClassRate
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbScore = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClass.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(96, 36);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(200, 26);
            this.cbClass.TabIndex = 0;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(96, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "送出";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbScore
            // 
            this.cbScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbScore.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbScore.FormattingEnabled = true;
            this.cbScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbScore.Location = new System.Drawing.Point(96, 107);
            this.cbScore.Name = "cbScore";
            this.cbScore.Size = new System.Drawing.Size(130, 26);
            this.cbScore.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRate.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(343, 36);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(428, 315);
            this.txtRate.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.ForeColor = System.Drawing.Color.Blue;
            this.lblClass.Location = new System.Drawing.Point(93, 10);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(49, 19);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "課程";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.ForeColor = System.Drawing.Color.Blue;
            this.lblScore.Location = new System.Drawing.Point(93, 76);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 19);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "分數";
            // 
            // lblRate
            // 
            this.lblRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRate.ForeColor = System.Drawing.Color.Blue;
            this.lblRate.Location = new System.Drawing.Point(342, 9);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(49, 19);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "評價";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(145, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 9;
            // 
            // FrmClassRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(840, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.cbScore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbClass);
            this.Name = "FrmClassRate";
            this.Text = "FrmClassRate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClassRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbScore;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}