using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmMain
{
    public partial class FrmCoachVerify : Form
    {
        private string _imagepath;
        private tIdentity _identity;
        public tIdentity Identity { get; set; }
        public FrmCoachVerify()
        {
            InitializeComponent();
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            gymEntities db=new gymEntities();
            if(lbID==null)return;
            try
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    int i = Convert.ToInt32(lbID.Text);
                    tcoach_expert EE = db.tcoach_expert.FirstOrDefault(z => z.coach_id == i);
                    db.tcoach_expert.Remove(EE);
                    db.SaveChanges(); 

                    tcoach_info_id CC = db.tcoach_info_id.FirstOrDefault(y => y.coach_id == i); 
                    db.tcoach_info_id.Remove(CC);
                    db.SaveChanges();

                    tIdentity TT = db.tIdentity.FirstOrDefault(x => x.id == i);
                    db.tIdentity.Remove(TT);
                    db.SaveChanges();
                    transaction.Commit();
                }
            }
            catch (Exception ex) { /*MessageBox.Show("" + ex);*/ }
            finally { ShowCoachUnvertify(); }
        }

        private void btAggre_Click(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            if (lbID == null) return;
            try
            {
                int i = Convert.ToInt32(lbID.Text);
                tIdentity TT = db.tIdentity.FirstOrDefault(x => x.id == i);
                TT.activated = true;
                db.SaveChanges();
            }
            catch (Exception ex) { }
            finally { ShowCoachUnvertify(); } 
        }

        private void FrmCoachVertify_Load(object sender, EventArgs e)
        {
            ShowCoachUnvertify();
        }

        private void ShowCoachUnvertify()
        {
            gymEntities db = new gymEntities();
            var CoachUnvertify = from r in db.tIdentity
                                 where r.role_id == 2 && r.activated == false
                                 select new { ID = r.id, 教練姓名 = r.name, 審核通過 = r.activated };
            dataGridView1.DataSource = CoachUnvertify.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        } 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex <0) return;
            if(pb_Photo.Image!=null)this.pb_Photo.Image=null;  
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //MessageBox.Show("" + id);
            dbSelect(id);
        }
        private void dbSelect(int id)
        {
            gymEntities db = new gymEntities();
            tIdentity y = db.tIdentity.FirstOrDefault(x => x.id == id);
            if (y == null) { return; }
            this.Identity = y;
            this.lbID.Text=y.id.ToString();
            this.tb_Name.Text = y.name;
            if (y.gender_id == 1) this.tb_Gender.Text = "男";
            if (y.gender_id == 2) this.tb_Gender.Text = "女";
            if (y.gender_id == 3) this.tb_Gender.Text = "其他";
            this.tb_Phone.Text = y.phone;
            this.dateTimePicker_Birth.Text = y.birthday.ToString();
            this.tb_Mail.Text = y.e_mail;
            this.tb_Address.Text = y.address;
            this.tb_Password.Text = "****";
            this._imagepath = y.photo;
            if (!string.IsNullOrEmpty(_imagepath))
            {
                string path = Application.StartupPath + "\\CoachImages";
                pb_Photo.Image = new Bitmap(path + "\\" + _imagepath);
            } 
            var contents = from r in db.tIdentity
                            join e in db.tcoach_expert on r.id equals e.coach_id
                            join c in db.tclasses on e.class_id equals c.class_id
                            join p in db.tcoach_info_id on r.id equals p.coach_id 
                            where r.id == id
                           select new { ExpertName = c.class_name, CoachIntro = p.coach_intro };

            if (contents.Any())
            {
                var firstResult = contents.First();
                this.tb_Expert.Text = firstResult.ExpertName;
                this.tb_intro.Text = firstResult.CoachIntro; 
            }
            else
            {
                this.tb_Expert.Text = "No information found";
                this.tb_intro.Text = "No information found";
            }
        }
    }
}
