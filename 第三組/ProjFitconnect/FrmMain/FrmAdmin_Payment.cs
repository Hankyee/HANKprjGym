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
    public partial class FrmAdmin_Payment : Form
    {
        public tIdentity Identity { get; set; }
        public FrmAdmin_Payment()
        {
            InitializeComponent();
            cb_PaymentStatus.Items.Add("未付款");
            cb_PaymentStatus.Items.Add("已結清");
            cb_ReserveStatus.Items.Add("取消");
            cb_ReserveStatus.Items.Add("保留");
        }

        private void FrmAdmin_Payment_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            gymEntities gymEntities = new gymEntities();
            var tclass_reserves = from tclass_reserve in gymEntities.tclass_reserve
                                  //where tclass_reserve.tclass_schedule.course_date == this.dateTimePicker_Filter.Value
                                  select new
                                  {
                                      流水號 = tclass_reserve.reserve_id,
                                      日期 = tclass_reserve.tclass_schedule.course_date,
                                      課程名稱 = tclass_reserve.tclass_schedule.tclasses.class_name,
                                      會員名稱 = tclass_reserve.tIdentity.name,
                                      付款狀態 = tclass_reserve.payment_status,
                                      保留狀態 = tclass_reserve.reserve_status
                                  };
            this.dataGridView_Payment.DataSource = tclass_reserves.ToList();
            this.dataGridView_Payment.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            this.dataGridView_Payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            showLabel(1);
        }

        private void dataGridView_Payment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 3)
            {
                FrmEditMemberRegister f = new FrmEditMemberRegister();
                gymEntities gymEntities = new gymEntities();
                string name = this.dataGridView_Payment.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                var member = gymEntities.tIdentity.FirstOrDefault(x => x.name.Equals(name));
                f.member = member;
                f.Text = "查看會員資料";
                f.name.ReadOnly = true;
                f.gender.Enabled = false;
                f.phone.ReadOnly = true;
                f.birth.Enabled = false;
                f.mail.ReadOnly = true;
                f.address.ReadOnly = true;
                f.password.ReadOnly = true;
                f.password.PasswordChar = '*';
                f.photo.Enabled = false;
                f.save.Visible = false;
                f.cancel.Text = "關閉";
                f.cancel.Location = new Point(1157, 585);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
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


        private void showLabel(int paymentID)
        {
            gymEntities gymEntities = new gymEntities();
            var query = gymEntities.tclass_reserve.FirstOrDefault(x => x.reserve_id == paymentID);
            this.lbl_Identity.Text = query.reserve_id.ToString();
            this.lbl_Date.Text = query.tclass_schedule.course_date.ToString("yyyy/MM/dd");
            this.lbl_CourseName.Text = query.tclass_schedule.tclasses.class_name;
            this.lbl_MemberName.Text = query.tIdentity.name;
            this.cb_PaymentStatus.SelectedIndex = Convert.ToInt32(query.payment_status);
            this.cb_ReserveStatus.SelectedIndex = Convert.ToInt32(query.reserve_status);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //todo將新資料取得之後，寫入資料庫
            //再重整dataGridView的內容
            gymEntities gymEntities = new gymEntities();
            int reserveID = Convert.ToInt32(this.lbl_Identity.Text);
            var reserve = gymEntities.tclass_reserve.FirstOrDefault(x => x.reserve_id == reserveID);

            reserve.class_schedule_id = gymEntities.tclass_schedule.FirstOrDefault(x => x.tclasses.class_name.Equals(this.lbl_CourseName.Text)).class_schedule_id;

            reserve.member_id = gymEntities.tIdentity.FirstOrDefault(x => x.name.Equals(this.lbl_MemberName.Text)).id;

            reserve.payment_status = Convert.ToBoolean(this.cb_PaymentStatus.SelectedIndex);
            reserve.reserve_status = Convert.ToBoolean(this.cb_ReserveStatus.SelectedIndex);
            gymEntities.SaveChanges();
            loadDataGridView();
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dateTimePicker_Filter_ValueChanged(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var tclass_reserves = from tclass_reserve in gymEntities.tclass_reserve
                                      where tclass_reserve.tclass_schedule.course_date == this.dateTimePicker_Filter.Value
                                  select new
                                  {
                                      流水號 = tclass_reserve.reserve_id,
                                      日期 = tclass_reserve.tclass_schedule.course_date,
                                      課程名稱 = tclass_reserve.tclass_schedule.tclasses.class_name,
                                      會員名稱 = tclass_reserve.tIdentity.name,
                                      付款狀態 = tclass_reserve.payment_status,
                                      保留狀態 = tclass_reserve.reserve_status
                                  };
            this.dataGridView_Payment.DataSource = tclass_reserves.ToList();
            this.dataGridView_Payment.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            this.dataGridView_Payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (this.dataGridView_Payment.Rows.Count == 0) return;
            int showFirstRow = (int)this.dataGridView_Payment.Rows[0].Cells[0].Value;
            showLabel(showFirstRow);
        }
    }
}
