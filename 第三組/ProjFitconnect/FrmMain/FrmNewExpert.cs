using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmNewExpert : Form
    {
        private tclasses _classset;
        private tclass_sort_有氧 _sort1;
        private tclass_sort_訓練 _sort2;
        private tclass_limit_details _limit;
        private string _Class_photo = "";
        public FrmNewExpert()
        {
            InitializeComponent();
            this.Text = " Coach | 新增專長";
        }
        private void FrmNewExpert_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            this.lbl_Name.Text = "新增課程名稱";
            this.lbl_sr1.Text = "課程分類：有氧/無氧";
            this.lbl_sr2.Text = "課程分類：類別";
            this.lbl_limit.Text = "課程限制條件";
            this.lbl_disc.Text = "新增課程描述：";
            this.cbSort1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSort2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbLm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort1.Items.Clear();
            gymEntities db = new gymEntities();
            var srt1s = from a in db.tclass_sort_有氧 select a;
            srt1s.ToList().ForEach(a => { this.cbSort1.Items.Add(a.class_sort1_detail); });

            cbSort2.Items.Clear();
            var srt2s = from a in db.tclass_sort_訓練 select a;
            srt2s.ToList().ForEach(a => { this.cbSort2.Items.Add(a.class_sort2_detail); });

            cbLm.Items.Clear();
            var limits = from a in db.tclass_limit_details select a;
            limits.ToList().ForEach(a => { this.cbLm.Items.Add(a.describe); });
        }
        private int check()
        {
            bool hasError = false;
            if (string.IsNullOrEmpty(txtClassName.Text))
            {
                label1.Text = "請輸入課程名稱"; hasError = true;
            }
            if (cbSort1.SelectedIndex == -1)
            {
                label2.Text = "請選課程分類：有氧/無氧"; hasError = true;
            }
            if (cbSort2.SelectedIndex == -1)
            {
                label3.Text = "請選擇課程分類：類別"; hasError = true;
            }
            if (cbLm.SelectedIndex == -1)
            {
                label4.Text = "請選擇課程限制條件"; hasError = true;
            }
            if (string.IsNullOrEmpty(txtInfo.Text))
            {
                label5.Text = "請輸入課程描述"; hasError = true;
            }
            if (hasError)
                return -1;
            else
                return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text= label3.Text = label4.Text = label5.Text = string.Empty;
            if (check() == -1) { return; }
            gymEntities db = new gymEntities();
            tclasses t = new tclasses();
            t.class_sort1_id = this.cbSort1.SelectedIndex + 1;
            t.class_sort2_id = this.cbSort2.SelectedIndex + 1;
            t.class_name = txtClassName.Text;
            t.class_introduction = txtInfo.Text;
            t.limited_gender = this.cbLm.SelectedIndex;
            db.tclasses.Add(t);
            if (afterCourseSubmit() == 0)
            {
                db.SaveChanges();
                MessageBox.Show("課程新增成功");
                this.Close();
            }
            else
                return;
        }
        private int afterCourseSubmit()
        {
            DialogResult result = MessageBox.Show("請再次確認課程是否正確", "提交課程", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { return 0; }
            else { return -1; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
