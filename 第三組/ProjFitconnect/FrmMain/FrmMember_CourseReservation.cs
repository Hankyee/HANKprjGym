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
    public partial class FrmMember_CourseReservation : Form
    {
        List<int> _Classlist = new List<int>();
        List<DateTime> _Preiod = new List<DateTime>();
        public FrmMember_CourseReservation()
        {
            InitializeComponent();

        }



        private void FrmCurriculum_Load(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var courses = from classCategory in gymEntities.tclasses
                          select classCategory;
            courses.ToList().ForEach(course =>
            {
                CheckBox c = new CheckBox();
                c.Font = new Font("微軟正黑體", 12);
                c.AutoSize = false;
                c.Tag = course.class_sort2_id.ToString();
                c.Text = $"{course.class_name,-20}";
                c.CheckedChanged += this.afterCategoryChanged;
                this.flowLayoutPanel_Class.Controls.Add(c);
            });


        }

        private void afterCategoryChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                _Classlist.Add(int.Parse(((CheckBox)sender).Tag.ToString()));
            else
                _Classlist.Remove(int.Parse(((CheckBox)sender).Tag.ToString()));

            if (_Classlist.Count == 0)
                return;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker_Start.Value.Date;
            DateTime endDate = dateTimePicker_End.Value.Date;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                _Preiod.Add(date);
            }
            gymEntities gymEntities = new gymEntities();

            //選擇課程類別
            var classQuery = gymEntities.tclass_schedule
                            .Where(classSchedule => _Classlist.Contains((int)classSchedule.class_id));

            //選擇日期
            var dateQuery = gymEntities.tclass_schedule.Where(classSchedule => _Preiod.Contains(classSchedule.course_date));

            //找交集
            var intersections = dateQuery.Intersect(classQuery);

            var finalQuery = from intersection in intersections
                             join category in gymEntities.tclass_sort_訓練
                             on intersection.class_id equals category.class_sort2_id
                             select new
                             {
                                 課程名稱 = intersection.tclasses.class_name,
                                 教練 = intersection.tIdentity.name,
                                 場地 = intersection.tfield.field_name,
                                 時段 = intersection.ttimes_detail.time_name,
                             };
            
            this.dataGridView_Test.DataSource = finalQuery.ToList();
        }
    }
}
