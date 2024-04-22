using FrmMain.tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmOpenedClassCheck : Form
    {
        public tIdentity Identity { get; set; }
        public FrmOpenedClassCheck()
        {
            InitializeComponent();
        }

        private void FrmOpenedClassCheck_Load(object sender, EventArgs e)
        { 
            gymEntities db = new gymEntities();
            int index = this.Identity.id;// 13;
            var classreserved = from c in db.tclasses
                                join s in db.tclass_schedule on c.class_id equals s.class_id
                                join t in db.ttimes_detail on s.course_time_id equals t.time_id
                                join r in db.tclass_reserve on s.class_schedule_id equals r.class_schedule_id
                                join i in db.tIdentity on r.member_id equals i.id
                                join f in db.tfield on s.field_id equals f.field_id
                                where s.coach_id==index//returnCoachID
                                select new { classes = c, classSchedule = s, time = t,field=f };
            foreach (var item in classreserved)
            {
                ReservedMemberCheck rmc = new ReservedMemberCheck();
                rmc.Width = flowLayoutPanel1.Width *5/ 12;
                rmc.Height = 99;
                rmc.c = item.classes;
                rmc.cs = item.classSchedule ;
                rmc.t = item.time;
                rmc.f = item.field;
                rmc.TextMemberCount=classreserved.ToList().Count.ToString()+" 人"; 
                flowLayoutPanel1.Controls.Add(rmc);
            }
        }
    }
}
