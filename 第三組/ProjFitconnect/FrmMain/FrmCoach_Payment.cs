using FrmMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym
{
    public partial class FrmCoach_Payment : Form
    {
        public tIdentity identity { get; set; }
        public FrmCoach_Payment()
        {
            InitializeComponent();
            cb_PaymentStatus.Items.Add("未付款");
            cb_PaymentStatus.Items.Add("已結清");
            cb_ReserveStatus.Items.Add("取消");
            cb_ReserveStatus.Items.Add("保留");
        }

        private void FrmCoach_Payment_Load(object sender, EventArgs e)
        {
            loadCoachpayment();
        }
        private void loadCoachpayment()
        {
            gymEntities db = new gymEntities();
            var tfield_reserves = from f in db.tfield_reserve
                                  join s in db.tclass_schedule on f.coach_id equals s.coach_id
                                  join r in db.tfield on f.field_id equals r.field_id
                                  select new
                                  {
                                      流水號 = f.field_reserve_id,
                                      日期 = s.course_date,
                                      場地名稱 = r.field_name,
                                      教練名稱 = f.tIdentity.name,
                                      付款狀態 = f.payment_status,
                                      保留狀態 = f.reserve_status,
                                      場地費用 = r.field_payment
                                  };
            this.dataGridView_Payment.DataSource = tfield_reserves.ToList();
            this.dataGridView_Payment.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            this.dataGridView_Payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            showLabel(1);
        }
        private void showLabel(int paymentID)
        {
            gymEntities db = new gymEntities();
            var query = (from tr in db.tfield_reserve
                         join ts in db.tclass_schedule on tr.coach_id equals ts.coach_id
                         join tf in db.tfield on ts.field_id equals tf.field_id
                         where tr.field_reserve_id == paymentID
                         select new
                         {
                             Reserve = tr,
                             Schedule = ts,
                             Field = tf
                         }).FirstOrDefault();
            if (query != null)
            {
                this.lbl_Identity.Text = query.Reserve.field_reserve_id.ToString();
                this.lbl_Date.Text = query.Schedule.course_date.ToString("yyyy/MM/dd");
                this.lbl_FieldName.Text = query.Field.field_name;
                this.lbl_CoachName.Text = query.Reserve.tIdentity.name;
                this.cb_PaymentStatus.SelectedIndex = Convert.ToInt32(query.Reserve.payment_status);
                this.cb_ReserveStatus.SelectedIndex = Convert.ToInt32(query.Reserve.reserve_status);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int paymentID = Convert.ToInt32(this.dataGridView_Payment.Rows[e.RowIndex].Cells[0].FormattedValue);

            showLabel(paymentID);
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            loadCoachpayment();
        }

        private void dateTimePicker_Filter_ValueChanged(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            var tfield_reserves = from f in db.tfield_reserve
                                  join s in db.tclass_schedule on f.coach_id equals s.coach_id
                                  join r in db.tfield on f.field_id equals r.field_id
                                  where s.course_date == this.dateTimePicker_Filter.Value
                                  select new
                                  {
                                      流水號 = f.field_reserve_id,
                                      日期 = s.course_date,
                                      場地名稱 = r.field_name,
                                      教練名稱 = f.tIdentity.name,
                                      付款狀態 = f.payment_status,
                                      保留狀態 = f.reserve_status
                                  };
            this.dataGridView_Payment.DataSource = tfield_reserves.ToList();
            this.dataGridView_Payment.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            this.dataGridView_Payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (this.dataGridView_Payment.Rows.Count == 0) return;
            int showFirstRow = (int)this.dataGridView_Payment.Rows[0].Cells[0].Value;
            showLabel(showFirstRow);
        }

        private void dataGridView_Payment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 3)
            {
                FrmEditCoachRegister frmCoach_EditRegister = new FrmEditCoachRegister();
                gymEntities db = new gymEntities();
                string name = this.dataGridView_Payment.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                var coach = db.tIdentity.FirstOrDefault(x => x.name.Equals(name));
                frmCoach_EditRegister.identity = coach;
                frmCoach_EditRegister.coach = coach;
                frmCoach_EditRegister.Text = "查看會員資料";
                frmCoach_EditRegister.name.ReadOnly = true;
                frmCoach_EditRegister.gender.Enabled = false;
                frmCoach_EditRegister.phone.ReadOnly = true;
                frmCoach_EditRegister.birth.Enabled = false;
                frmCoach_EditRegister.mail.ReadOnly = true;
                frmCoach_EditRegister.address.ReadOnly = true;
                frmCoach_EditRegister.password.ReadOnly = true;
                frmCoach_EditRegister.password.PasswordChar = '*';
                frmCoach_EditRegister.photo.Enabled = false;
                frmCoach_EditRegister.expertise.Enabled = false;
                frmCoach_EditRegister.save.Visible = false;
                frmCoach_EditRegister.cancel.Text = "關閉";
                frmCoach_EditRegister.cancel.Location = new Point(1157, 585);
                frmCoach_EditRegister.StartPosition = FormStartPosition.CenterScreen;
                frmCoach_EditRegister.ShowDialog();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            int reserveID = Convert.ToInt32(this.lbl_Identity.Text);

            var reserve = (from tr in db.tfield_reserve
                           where tr.field_reserve_id == reserveID
                           select tr).FirstOrDefault();

            if (reserve != null)
            {
                reserve.payment_status = Convert.ToBoolean(this.cb_PaymentStatus.SelectedIndex);
                reserve.reserve_status = Convert.ToBoolean(this.cb_ReserveStatus.SelectedIndex);

                db.SaveChanges();

                loadCoachpayment();
            }
        }
    }
}
