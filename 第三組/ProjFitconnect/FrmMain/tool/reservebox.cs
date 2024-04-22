using mid_Coonect.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public delegate void Dshow(reservebox p);
    public partial class reservebox : UserControl
    {
        
        public event Dshow showReserve;
        public event Dshow showDetail;
        private tclasses _tc;
        private tclass_schedule _ts;
        //private tclass_reserve _tr;
        private tIdentity _i;
        private tfield _f;
        private ttimes_detail _td;
        private tcoach_info_id _coachInfo;
        //private tcoach_photo _coachPhoto;
        public tclasses tc
        {
            get { return _tc; }
            set
            {
                _tc = value;
                label5.Text = _tc.class_name;
                if (!string.IsNullOrEmpty(_tc.class_photo))
                {
                    string path = Application.StartupPath + "\\ClassPic";
                    pictureBox1.Image = new Bitmap(path + "\\" + _tc.class_photo);
                }
            }
        }
        public tIdentity ids { get { return _i; } set { _i = value; label6.Text = _i.name; } }
        public tclass_schedule csch { get { return _ts; } set { _ts = value; label7.Text = _ts.course_date.ToShortDateString(); } }
        //public ttimes_detail td { get { return _td; } set { _td = value; } }

        public string cls 
        {
            get { return this.label5.Text; }
            set { this.label5.Text = value;}
        }

        //public string time { set { this.label8.Text = value; } }
        public ttimes_detail td { get { return _td; } set { _td = value; label8.Text = _td.time_name; } }
        public tfield f { get { return _f; } set { _f = value; } }

        public tcoach_info_id coachInfo { get { return _coachInfo; } set { _coachInfo = value; } }
        //public tcoach_photo coachPhoto { get { return _coachPhoto; }set { _coachPhoto = value;
        //        if (!string.IsNullOrEmpty(_coachPhoto.coach_photo))
        //        {
        //            string path = Application.StartupPath + "\\CoachPhoto";
        //            pictureBox1.Image = new Bitmap(path + "\\" + _coachPhoto.coach_photo);
        //        }
        //    } }

        public reservebox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.showReserve != null) this.showReserve(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.showDetail != null) this.showDetail(this);
        }
    }
}
