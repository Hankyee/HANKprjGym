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
    
    public partial class FrmCoach_AddNewCourse : Form
    {
        public tIdentity coach;
        private List<string> list = new List<string> ();
        public FrmCoach_AddNewCourse()
        {
            InitializeComponent();
            this.monthCalendar_Course.MinDate = DateTime.Now;
            this.lbl_HoursPerCourse.Text = string.Empty;
            this.lbl_Days.Text = string.Empty;
        }

        private void FrmCoach_CourseReservation_Load(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            var courses = from a in db.tclasses
                          from b in db.tcoach_expert
                          where b.coach_id == coach.id
                          where a.class_id == b.class_id
                          select b;
            courses.ToList().ForEach(course => { this.cb_Class.Items.Add(course.tclasses.class_name); });
            foreach (var items in courses)
            {
                list.Add(items.tclasses.class_id.ToString());
                list.Add(items.tclasses.class_name);
            }
            var fields = from field in db.tfield
                         select field;
            fields.ToList().ForEach(field => { this.cb_Field.Items.Add($"{field.field_name} | {field.field_payment:C0}"); });

            var periods = from period in db.ttimes_detail
                          select period;
            periods.ToList().ForEach(period =>
            {
                this.cb_TimePeriodStart.Items.Add(period.time_name.ToString().Substring(0, 5));
                this.cb_TimePeriodEnd.Items.Add(period.time_name.ToString().Substring(0, 5));
            });
        }

        private void monthCalendar_Course_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (lb_SelectedDate.Items.Contains(e.Start.ToShortDateString()))
                return;

            this.lb_SelectedDate.Items.Add(e.Start.ToShortDateString());
            List<string> times = new List<string>();
            foreach (string item in lb_SelectedDate.Items)
            {
                times.Add(item);
            }
            times.Sort((time1, time2) => DateTime.Parse(time1).CompareTo(DateTime.Parse(time2)));
            lb_SelectedDate.Items.Clear();
            foreach (string time in times)
            {
                lb_SelectedDate.Items.Add(time);
            }
            
            afterDateSelected();
        }

        private void btn_ClearSelectedDate_Click(object sender, EventArgs e)
        {
            this.lb_SelectedDate.Items.Clear();
            this.lbl_Days.Text = string.Empty;
        }

        private void btn_SubmitCourse_Click(object sender, EventArgs e)
        {
            setEmpty();
            if (check() == -1) { return; }
            string classname=cb_Class.Text;
            int timePeriodStartIndex = cb_TimePeriodStart.SelectedIndex;
            int timePeriodEndIndex = cb_TimePeriodEnd.SelectedIndex;
            if (timePeriodEndIndex < timePeriodStartIndex)
                timePeriodEndIndex += 24;

            gymEntities db = new gymEntities();
            var nameofclass = from c in db.tclasses
                            where c.class_name == cb_Class.Text
                            select c.class_id;
            int classID = nameofclass.FirstOrDefault();
            int courseHours = lb_SelectedDate.Items.Count * (timePeriodEndIndex - timePeriodStartIndex);
            decimal unitprice = 0;
            for (int i = 0; i < lb_SelectedDate.Items.Count; i++)
            {
                for (int j = 0; j < timePeriodEndIndex - timePeriodStartIndex; j++)
                {
                    tclass_schedule schedule = new tclass_schedule();
                    //schedule.class_id = this.cb_Class.SelectedIndex + 1;
                    schedule.class_id = classID;
                    schedule.field_id = this.cb_Field.SelectedIndex + 1;
                    
                    schedule.coach_id = coach.id;
                    schedule.class_status_id = 4;
                    schedule.Max_student = (int)this.numericUpDown_MaxStudent.Value;
                    schedule.course_date = DateTime.Parse(lb_SelectedDate.Items[i].ToString());
                    schedule.course_time_id = timePeriodStartIndex + 1 + j;
                    var field = db.tfield.FirstOrDefault(x => x.field_id == schedule.field_id);
                    unitprice = schedule.class_payment = field.field_payment;
                    db.tclass_schedule.Add(schedule);
                }
            }
            if (afterCourseSubmit() == 0)
            {
                db.SaveChanges();
                MessageBox.Show($"課程已成功預約，待付場地費用為:{courseHours * unitprice:C0}元");
                this.Close();
            }
            else
                return;

        }

        private int afterCourseSubmit()
        {
            DialogResult result = MessageBox.Show("請再次確認課程是否正確", "提交課程", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { return 0; }
            else { return -1; }
        }

        private void setEmpty()
        {
            lbl_Course.Text = lbl_Field.Text = lbl_Start.Text = lbl_End.Text = lbl_MaxMember.Text = lbl_SelectedDate.Text = string.Empty;
        }

        private int check()
        {
            bool hasError = false;
            if (cb_Class.SelectedIndex == -1)
            {
                lbl_Course.Text = "請選擇課程類別"; hasError = true;
            }
            if (cb_Field.SelectedIndex == -1)
            {
                lbl_Field.Text = "請選擇場地"; hasError = true;
            }
            if (cb_TimePeriodStart.SelectedIndex == -1)
            {
                lbl_Start.Text = "請選擇課程開始時段"; hasError = true;
            }
            if (cb_TimePeriodEnd.SelectedIndex == -1)
            {
                lbl_End.Text = "請選擇課程結束時段"; hasError = true;
            }
            if (numericUpDown_MaxStudent.Value <= 0)
            {
                lbl_MaxMember.Text = "學生上限人數不得為0"; hasError = true;
            }
            if (lb_SelectedDate.Items.Count == 0)
            {
                lbl_SelectedDate.Text = "請選擇上課日期"; hasError = true;
            }
            if (hasError)
                return -1;
            else
                return 0;
        }

        private void cb_TimePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TimePeriodStart.SelectedIndex == -1 || cb_TimePeriodEnd.SelectedIndex == -1)
            {
                lbl_HoursPerCourse.Text = string.Empty;
                return;
            }

            int timePeriodStartIndex = cb_TimePeriodStart.SelectedIndex;
            int timePeriodEndIndex = cb_TimePeriodEnd.SelectedIndex;
            if (timePeriodEndIndex < timePeriodStartIndex)
                timePeriodEndIndex += 24;
            this.lbl_HoursPerCourse.Text = $"已預約{timePeriodEndIndex - timePeriodStartIndex}小時";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void afterDateSelected()
        {
            if (lb_SelectedDate.Items.Count <= 0)
            {
                lbl_Days.Text = string.Empty;
                return;
            }
            lbl_Days.Text = $"已預約{lb_SelectedDate.Items.Count}天";
        }
    }
}
