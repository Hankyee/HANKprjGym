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
    public partial class FrmClassReserved : Form
    {
        public tIdentity identity { get; set; }
        
        public FrmClassReserved()
        {
            InitializeComponent();
        }

        private void FrmClassReserved_Load(object sender, EventArgs e)
        {
            ShowClassReserved();

        }

        private void ShowClassReserved()
        {
            gymEntities db = new gymEntities();
            int findID = this.identity.id;
            var classreserved = from c in db.tclasses
                                from cr in db.tclass_reserve
                                from i in db.tIdentity
                                from cs in db.tclass_schedule
                                from t in db.ttimes_detail
                                from fd in db.tfield
                                from cif in db.tcoach_info_id
                                where i.id == cif.coach_id
                                where cs.field_id == fd.field_id
                                where cr.member_id == findID
                                where cr.class_schedule_id == cs.class_schedule_id
                                where cs.class_id == c.class_id
                                where cs.coach_id == i.id
                                where cs.course_time_id == t.time_id
                                where cr.reserve_status == true
                                select new { classes = c ,identity = i, classSchedule = cs, time = t ,field = fd,coachinfo = cif};

            foreach (var item in classreserved)
            {
                reservebox rb = new reservebox();

                rb.Width = 800;
                rb.Height = 180;
                rb.Location = new System.Drawing.Point(flowLayoutPanel1.Width / 2 - rb.Width / 2);
                
                rb.tc=item.classes;
                rb.ids = item.identity;
                rb.csch = item.classSchedule;
                rb.td = item.time;
                rb.f = item.field;
                rb.coachInfo = item.coachinfo;
                rb.showReserve += showReserve;
                rb.showDetail += showDetail;
                flowLayoutPanel1.Controls.Add(rb);
            }
        }

        private void showDetail(reservebox p)
        {
            int x = p.ids.id;
            gymEntities db = new gymEntities();
            tclasses cl = db.tclasses.FirstOrDefault(a => a.class_id == p.tc.class_id);
            if(cl == null) return;
            tfield tfield = db.tfield.FirstOrDefault(b => b.field_id == p.f.field_id);
            if (tfield == null) return;
            tclass_schedule cs = db.tclass_schedule.FirstOrDefault(c=>c.class_schedule_id == p.csch.class_schedule_id);
            if (cs == null) return;
            tIdentity identity = db.tIdentity.FirstOrDefault(d => d.id == x);
            if(identity == null) return;
            tcoach_info_id c_info = db.tcoach_info_id.FirstOrDefault(e => e.coach_id == x);
            if(c_info==null) return;
            tcoach_photo c_photo = db.tcoach_photo.FirstOrDefault(g => g.coach_id == x);
            //var c_photo = from cp in db.tcoach_photo
            //              where cp.coach_id == 13
            //              select cp;
            if (c_photo == null) return;
            ttimes_detail time = db.ttimes_detail.FirstOrDefault(t => t.time_id == p.td.time_id);
            if(time == null) return;

            //tclass_reserve cr = db.tclass_reserve.FirstOrDefault(r=>r.member_id==this.identity.id&&r.tclass_schedule.tclasses.class_name==p.cls);

            FrmClassReservedDetail f = new FrmClassReservedDetail
            { cls = cl, field = tfield, cs = cs ,ID=identity,info =c_info, td=time/*coachphoto = c_photo*/ };
            
            f.Show();
        }

        private void showReserve(reservebox p)
        {
            using (gymEntities db = new gymEntities())
            {
                tclass_reserve reservation = db.tclass_reserve.FirstOrDefault(r => r.member_id == this.identity.id && r.tclass_schedule.tclasses.class_name == p.cls);
                if (reservation != null)
                {
                    reservation.reserve_status = false;
                    db.SaveChanges();
                    db.Entry(reservation).Reload();

                    MessageBox.Show("取消成功");
                    this.flowLayoutPanel1.Controls.Clear();
                    ShowClassReserved();
                }
            }
        }
    }
}
