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
    public partial class ReservedMemberCheck : UserControl
    {
        private tclass_schedule _cs;
        private tclasses _c;
        private ttimes_detail _t;
        private tfield _f;
        public tclass_schedule cs { get { return _cs; }set { _cs = value; lbMAXcount.Text="(MAX)"+_cs.Max_student.ToString()+" 人";  lbDate.Text=_cs.course_date.ToLongDateString(); } }
        public tclasses c { get { return _c; }set { _c = value; lbClassName.Text= _c.class_name; } }
        public ttimes_detail t { get { return _t; }set { _t = value; lbTime.Text= _t.time_name; } }
        public tfield f { get { return _f; }set { _f = value; lbFloor.Text = _f.floor;lbField.Text = _f.field_name; } }
        public ReservedMemberCheck()
        {
            InitializeComponent();
        }
        public string TextMemberCount 
        {
            get { return lbMemberCount.Text; }
            set { lbMemberCount.Text = value; }
        }
    }
}
