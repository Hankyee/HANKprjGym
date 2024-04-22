using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmClassRate : Form
    {
        private tIdentity Identity { get; set; }
        private tmember_rate_class _rate_Class;
        private int _mid;
        public tIdentity identity;
        public tmember_rate_class rateclass 
        {  
            get
            {  
                return _rate_Class; 
            }
            set
            {
                _rate_Class = value;
                if(_rate_Class != null)
                {
                    _rate_Class.member_id = _mid;
                }
            }
        }
        public FrmClassRate()
        {
            InitializeComponent();
        }

        private void FrmClassRate_Load(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            cbClass.Items.Clear();
            var id = from s in db.tclass_schedule
                     join n in db.tclasses on s.class_id equals n.class_id
                     select new { s, n };
            id.ToList().ForEach( n => { cbClass.Items.Add(n.s.course_date.ToShortDateString() + " " + n.n.class_name); });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = label3.Text = string.Empty;
            if (check() == -1) { return; }
            gymEntities db = new gymEntities();
            tmember_rate_class r = new tmember_rate_class();
            r.member_id = this.identity.id;
            //r.class_schedule_id = _mid;
            r.rate = cbScore.SelectedIndex+1;
            if(r.rate>=10)r.rate = 9.9E0m;
            r.describe = txtRate.Text;
            db.tmember_rate_class.Add(r);
            if (afterCourseSubmit() == 0)
            {
                db.SaveChanges();
                MessageBox.Show("評價成功");
                this.Close();
            }
            else
                return;
        }
        private int check()
        {
            bool hasError = false;
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                label3.Text = "請輸入評價"; hasError = true;
            }
            if (cbClass.SelectedIndex == -1)
            {
                label1.Text = "請選擇課程"; hasError = true;
            }
            if (cbScore.SelectedIndex == -1)
            {
                label2.Text = "請選擇星數"; hasError = true;
            }
            if (hasError)
                return -1;
            else
                return 0;
        }
        private int afterCourseSubmit()
        {
            DialogResult result = MessageBox.Show("確認送出?", "提交評價", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { return 0; }
            else { return -1; }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            tclass_schedule c = db.tclass_schedule.FirstOrDefault(x => x.class_schedule_id.Equals(this.cbClass.SelectedIndex+1));
            _mid = c.class_id;
        }
    }
}
