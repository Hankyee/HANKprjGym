using FrmMain;
using Revised_V1._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_Coonect.Tools
{
    public delegate void DMore(CoachBox p);
    public partial class CoachBox : UserControl
    {
        public event DMore learnMore;
        public event DMore showmember;
        private tclasses _cst;
        private tcoach_info_id _cid;
        private tIdentity _identity;
        public tclasses cst { get { return _cst; } set {
                _cst=value;
                labelCourse.Text=_cst.class_name;
            } }
        public tcoach_info_id cid { get { return _cid; } set { 
                _cid = value; 
                labelCoachinfo.Text =_cid.coach_intro;
            } }
        public tIdentity Identity { get { return _identity; } set {
                _identity = value;
                labelCoachName.Text = _identity.name;
                if (_identity.gender_id == 1) { labelGender.Text = "男性"; }
                if (_identity.gender_id == 2) { labelGender.Text = "女性"; }
                if (_identity.gender_id == 3) { labelGender.Text = "其他"; }
                if (!string.IsNullOrEmpty(_identity.photo))
                {
                    string path = Application.StartupPath + "\\CoachImages";
                    pictureBox1.Image = new Bitmap(path + "\\" + _identity.photo);
                }
            } }

        public CoachBox()
        {
            InitializeComponent();
            this.button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.learnMore != null)
                this.learnMore(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.showmember != null)
                this.showmember(this);
        }
    }
}
