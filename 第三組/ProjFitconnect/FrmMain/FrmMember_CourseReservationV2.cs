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
    public partial class FrmMember_CourseReservationV2 : Form
    {
        List<int> _Classlist = new List<int>();
        List<DateTime> _Preiod = new List<DateTime>();
        public tIdentity member { get; set; }
        public string course { get; set; }
        public FrmMember_CourseReservationV2()
        {
            InitializeComponent();
            this.lbl_DateError.Text = string.Empty;
        }

        private void FrmCurriculum_Load(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var courses = from schedule in gymEntities.tclass_schedule.AsEnumerable()
                          join tclass in gymEntities.tclasses
                          on schedule.class_id equals tclass.class_id
                          where tclass.class_name.Equals(course)
                          select new
                          {
                              流水號 = schedule.class_schedule_id,
                              課程種類 = schedule.tclasses.class_name,
                              教練 = schedule.tIdentity.name,
                              場地 = schedule.tfield.field_name,
                              日期 = schedule.course_date,
                              時段 = schedule.ttimes_detail.time_name,
                              人數上限 = schedule.Max_student,
                              課程費用 = schedule.class_payment.ToString("C0"),
                          };

            this.dataGridView_Reserve.Font = new Font("微軟正黑體", 14, FontStyle.Bold);

            this.dataGridView_Reserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Reserve.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "操作";
            buttonColumn.Text = "預約";
            buttonColumn.UseColumnTextForButtonValue = true; // 設置按鈕文本
            buttonColumn.DefaultCellStyle.Padding = new Padding(2, 1, 2, 1);
            buttonColumn.DefaultCellStyle.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            dataGridView_Reserve.Columns.Add(buttonColumn);




            this.dataGridView_Reserve.DataSource = courses.ToList();
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.lbl_DateError.Text = string.Empty;
            DateTime start = this.dateTimePicker_Start.Value.Date;
            DateTime end = this.dateTimePicker_End.Value.Date;
            TimeSpan period = end - start;
            if (period < TimeSpan.Zero)
            {
                this.lbl_DateError.Text = "開始日期必須小於結束日期";
                return;
            }

            List<object> list = new List<object>();
            gymEntities gymEntities = new gymEntities();
            for (int i = 0; i <= period.Days; i++)
            {
                var queries = from query in gymEntities.tclass_schedule.AsEnumerable()
                              where query.course_date.Equals(start.AddDays(i).Date)
                              && query.tclasses.class_name.Equals(course)
                              select new
                              {
                                  流水號 = query.class_schedule_id,
                                  課程種類 = query.tclasses.class_name,
                                  教練 = query.tIdentity.name,
                                  場地 = query.tfield.field_name,
                                  日期 = query.course_date,
                                  時段 = query.ttimes_detail.time_name,
                                  人數上限 = query.Max_student,
                                  課程費用 = query.class_payment.ToString("C0"),
                              };
                list.AddRange(queries.ToList());
            }
            this.dataGridView_Reserve.DataSource = list;
        }

        private void dataGridView_Reserve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView_Reserve.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                bool haveQuota = checkQuota(sender, e);
                if (haveQuota)
                {
                    gymEntities gymEntities = new gymEntities();
                    int index = (int)this.dataGridView_Reserve.Rows[e.RowIndex].Cells[1].Value;
                    tclass_reserve reserve = new tclass_reserve();
                    reserve.class_schedule_id = index;
                    reserve.member_id = member.id;
                    reserve.payment_status = true;
                    reserve.reserve_status = true;
                    gymEntities.tclass_reserve.Add(reserve);
                    gymEntities.SaveChanges();
                    showInfo(sender, e);
                    MessageBox.Show("預約成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showInfo(sender, e);
                    MessageBox.Show("課程人數已滿，無法預約", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void showInfo(object sender, DataGridViewCellEventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            int index = (int)this.dataGridView_Reserve.Rows[e.RowIndex].Cells[1].Value;
            var quotas = from quota in gymEntities.tclass_reserve
                         where quota.class_schedule_id == index
                         group quota by quota.class_schedule_id into g
                         select new
                         {
                             流水號 = g.Key,
                             已預約人數 = g.Count()
                         };
            this.dataGridView_ClassInfo.Font = new Font("微軟正黑體", 14, FontStyle.Bold);

            this.dataGridView_ClassInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_ClassInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ClassInfo.DataSource = quotas.ToList();
        }

        private bool checkQuota(object sender, DataGridViewCellEventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            int index = (int)this.dataGridView_Reserve.Rows[e.RowIndex].Cells[1].Value;
            var quotas = from quota in gymEntities.tclass_reserve
                         where quota.class_schedule_id == index
                         group quota by quota.class_schedule_id into g
                         select new
                         {
                             流水號 = g.Key,
                             已預約人數 = g.Count()
                         };

            int max = gymEntities.tclass_schedule.FirstOrDefault(x => x.class_schedule_id == index).Max_student;
            int reserved = quotas.FirstOrDefault().已預約人數;
            if (reserved < max)
                return true;
            else
                return false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var courses = from schedule in gymEntities.tclass_schedule.AsEnumerable()
                          join tclass in gymEntities.tclasses
                          on schedule.class_id equals tclass.class_id
                          where tclass.class_name.Equals(course)
                          select new
                          {
                              流水號 = schedule.class_schedule_id,
                              課程種類 = schedule.tclasses.class_name,
                              教練 = schedule.tIdentity.name,
                              場地 = schedule.tfield.field_name,
                              日期 = schedule.course_date,
                              時段 = schedule.ttimes_detail.time_name,
                              人數上限 = schedule.Max_student,
                              課程費用 = schedule.class_payment.ToString("C0"),
                          };

            this.dataGridView_Reserve.Font = new Font("微軟正黑體", 14, FontStyle.Bold);

            this.dataGridView_Reserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Reserve.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
