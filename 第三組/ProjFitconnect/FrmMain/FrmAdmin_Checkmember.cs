using System;
using System.Collections;
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
    public partial class FrmAdmin_Checkmember : Form
    {
        public FrmAdmin_Checkmember()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            this.checkBox1.Text = "會員";
            this.checkBox2.Text = "教練";
            this.checkBox3.Text = "全部清單";
            this.checkBox4.Text = "管理員";
            showdata();
        }

        private void showdata()
        {
            this.dataGridView1.Controls.Clear();
            gymEntities db = new gymEntities();
            var members = from a in db.tIdentity
                          from b in db.tgender_Table
                          where b.gender_id == a.gender_id
                          select new
                          {
                              編號 = a.id,
                              名稱 = a.name,
                              電話 = a.phone,
                              email = a.e_mail,
                              //密碼 = a.password,
                              照片 = a.photo,
                              生日 = a.birthday,
                              地址 = a.address,
                              性別 = b.gender_text
                          };
            this.dataGridView1.DataSource = members.ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState != CheckState.Checked)
                return;
            this.dataGridView1.Controls.Clear();

            gymEntities db = new gymEntities();
            var members = from a in db.tIdentity
                          from b in db.tgender_Table
                          where (a.role_id == 1)&&(b.gender_id == a.gender_id)
                          select new
                          {
                              編號 = a.id,
                              名稱 = a.name,
                              電話 = a.phone,
                              email = a.e_mail,
                              //密碼 = a.password,
                              照片 = a.photo,
                              生日 = a.birthday,
                              地址 = a.address,
                              性別 = b.gender_text
                          }; ;
            this.dataGridView1.DataSource = members.ToList();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState != CheckState.Checked)
                return;
            this.dataGridView1.Controls.Clear();

            gymEntities db = new gymEntities();
            var coaches = from a in db.tIdentity
                          from b in db.tgender_Table
                          where (a.role_id == 2) && (b.gender_id == a.gender_id)
                          select new
                          {
                              編號 = a.id,
                              名稱 = a.name,
                              電話 = a.phone,
                              email = a.e_mail,
                              //密碼 = a.password,
                              照片 = a.photo,
                              生日 = a.birthday,
                              地址 = a.address,
                              性別 = b.gender_text
                          }; ;
            this.dataGridView1.DataSource = coaches.ToList();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState != CheckState.Checked)
                return;
            this.dataGridView1.Controls.Clear();

            gymEntities db = new gymEntities();
            var admins = from a in db.tIdentity
                         from b in db.tgender_Table
                         where (a.role_id == 3) && (b.gender_id == a.gender_id)
                         select new
                         {
                             編號 = a.id,
                             名稱 = a.name,
                             //密碼 = a.password,
                             創建日期 = a.birthday,
                             是否啟用 = a.activated,
                         }; ;
            this.dataGridView1.DataSource = admins.ToList();
        }
        private void FrmAdmin_Checkmember_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.CheckState != CheckState.Checked)
                return;
            init();
        }
    }
}
