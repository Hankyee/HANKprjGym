using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.tool
{

    public delegate void DConfirm(ClassReservingBox p);
    public partial class ClassReservingBox : UserControl
    {
        private tmember_rate_class _mrc;
        public event DConfirm reserveConfirm;
        private tclasses _tc;
        private tclass_schedule _ts;
        private tIdentity _i;
        private ttimes_detail _td; 
        public tmember_rate_class mrc {get { return _mrc;}set { _mrc = value; labelScore.Text = _mrc.rate.ToString(); } }
        public tclass_sort_訓練 train { get; set; }
        public tclasses tc
        {
            get { return _tc; }
            set
            {
                _tc = value;
                lbClassName.Text = _tc.class_name;
                if (!string.IsNullOrEmpty(_tc.class_photo))
                {
                    string path = Application.StartupPath + "\\ClassPic";
                    pictureBox1.Image = new Bitmap(path + "\\" + _tc.class_photo);
                }
                lbDescription.Text = _tc.class_introduction;
            }
        }
        public tIdentity i { get { return _i; } set { _i = value; lbCoachName.Text = _i.name; } }
        public tclass_schedule ts
        {
            get { return _ts; }
            set
            {
                _ts = value; lbDate.Text = _ts.course_date.ToShortDateString();
                _ts = value; lbPrice.Text = "$ " + _ts.class_payment.ToString();
            }
        }
        public ttimes_detail td { get { return _td; } set { _td = value; lbTime.Text = _td.time_name; } }
         
        public ClassReservingBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.reserveConfirm != null) this.reserveConfirm(this);
        }
    }
}
