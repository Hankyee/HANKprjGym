using FrmMain;
using ProjGym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_Coonect
{
    public partial class FrmAdmin_ClassUpdate : Form
    {
        private DialogResult _isOK;
        public DialogResult IsOK { get { return _isOK; } }
        private string _imagepath = "";
        private tclasses _course;
        private tclass_sort_有氧 _sort1;
        private tclass_sort_訓練 _sort2;
        private tclass_limit_details _limitdetails;
        private tclass_status_detail _status_detail;
        int _index = 1;

        public tclass_sort_有氧 sort1
        {
            get
            {
                if (_sort1 == null)
                {
                    _sort1 = new tclass_sort_有氧();
                }
                _sort1.class_sort1_detail = cb_Sort1.Text;
                return _sort1;
            }
            set
            {
                _sort1 = value;
                cb_Sort1.Text = _sort1.class_sort1_detail;
            }
        }
        public tclass_sort_訓練 sort2
        {
            get
            {
                if (_sort2 == null)
                {
                    _sort2 = new tclass_sort_訓練();
                }
                _sort2.class_sort2_detail = cb_Sort2.Text;
                return _sort2;
            }
            set
            {
                _sort2 = value;
                cb_Sort2.Text = _sort2.class_sort2_detail;
            }
        }
        public tclass_limit_details limitdetails
        {
            get
            {
                if (_limitdetails == null)
                {
                    _limitdetails = new tclass_limit_details();
                }
                _limitdetails.describe = cb_Limit.Text;
                return _limitdetails;
            }
            set
            {
                _limitdetails = value;
                cb_Limit.Text = _limitdetails.describe;
            }
        }
        public tclass_status_detail status_detail
        {
            get
            {
                if (_status_detail == null)
                {
                    _status_detail = new tclass_status_detail();
                }
                _status_detail.class_status_discribe = cb_Status.Text;
                return _status_detail;
            }
            set
            {
                _status_detail = value;
                cb_Status.Text = _status_detail.class_status_discribe;
            }
        }

        public tclasses course
        {
            get
            {
                if (_course == null) { _course = new tclasses(); }
                _course.class_id = Convert.ToInt32(tb_ID.Text);
                _course.class_name = txt_ClassName.Text;
                _course.class_introduction = this.txt_Introduction.Text;
                _course.class_photo = _imagepath;
                return _course;
            }
            set
            {
                _course = value;
                tb_ID.Text = _course.class_id.ToString();
                txt_ClassName.Text = _course.class_name;
                txt_Introduction.Text = _course.class_introduction;
                _imagepath = _course.class_photo;
                if (!string.IsNullOrEmpty(_imagepath))
                {
                    string path = Application.StartupPath + "\\ClassPic";
                    pb_ClassPhoto.Image = new Bitmap(path + "\\" + _imagepath);
                }
            }
        }
        public FrmAdmin_ClassUpdate()
        {
            InitializeComponent();
        }

        private void pb_ClassPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "課程照片|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            _imagepath = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string path = Application.StartupPath + "\\ClassPic";
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            File.Copy(openFileDialog1.FileName, Path.Combine(path + "\\" + _imagepath));
            this.pb_ClassPhoto.Image = new Bitmap(Path.Combine(path + "\\" + _imagepath));
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ID.Text) || tb_ID.Text == "id") return;
            _isOK = DialogResult.OK;
            bool isINT = false;
            int id = 0;
            isINT = int.TryParse(tb_ID.Text, out id);
            if (isINT)
            {
                dbEdit(id);
                ShowdbClass();
                MessageBox.Show("資料儲存成功");
            }
        }
        private void ShowdbClass()
        {
            gymEntities db = new gymEntities();
            var classSort = from r in db.tclasses
                            //join c in db.tclass_status_detail on r.class_status equals c.class_status_id
                            join l in db.tclass_limit_details on r.limited_gender equals l.class_limited_id
                            join s1 in db.tclass_sort_有氧 on r.class_sort1_id equals s1.class_sort1_id
                            join s2 in db.tclass_sort_訓練 on r.class_sort2_id equals s2.class_sort2_id
                            select new
                            {
                                編號 = r.class_id,
                                課程名稱 = r.class_name,
                                類型 = s1.class_sort1_detail,
                                分類 = s2.class_sort2_detail,
                                //照片 = r.class_photo,
                                //介紹 = r.class_introduction,
                                //開放 = c.class_status_discribe,
                                限制 = l.describe
                            };
            dataGridView_ClassSortList.DataSource = classSort.ToList();
            dataGridView_ClassSortList.RowHeadersWidth = 20;
            dataGridView_ClassSortList.Columns[0].Width = 70;
            dataGridView_ClassSortList.Columns[1].Width = 100;
            dataGridView_ClassSortList.Columns[2].Width = 70;
            dataGridView_ClassSortList.Columns[3].Width = 100;
            dataGridView_ClassSortList.Columns[4].Width = 100;
        }

        private void FrmClassUpdate_Load(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var sort1s = from sort1 in gymEntities.tclass_sort_有氧 select sort1;
            foreach (var sort1 in sort1s)
                cb_Sort1.Items.Add(sort1.class_sort1_detail);

            var sort2s = from sort2 in gymEntities.tclass_sort_訓練 select sort2;
            foreach (var sort2 in sort2s)
                cb_Sort2.Items.Add(sort2.class_sort2_detail);

            var limits = from limit in gymEntities.tclass_limit_details select limit;
            foreach (var limit in limits)
                cb_Limit.Items.Add(limit.describe);

            var statuses = from status in gymEntities.tclass_status_detail select status;
            foreach (var status in statuses)
                cb_Status.Items.Add(status.class_status_discribe);

            ShowdbClass();
            cb_Sort1.SelectedIndex = 0;
            cb_Sort2.SelectedIndex = 0;
            cb_Limit.SelectedIndex = 0;
            cb_Status.SelectedIndex = 0;
            dbSelect(_index);
        }
        private void dbSelect(int id)
        {
            gymEntities db = new gymEntities();
            pb_ClassPhoto.Image = null;
            tclasses classSort = db.tclasses.FirstOrDefault(x => x.class_id == id);

            if (classSort == null) return;

            tb_ID.Text = classSort.class_id.ToString();
            cb_Sort1.SelectedIndex = (int)classSort.class_sort1_id - 1;
            cb_Sort2.SelectedIndex = (int)classSort.class_sort2_id - 1;
            cb_Limit.SelectedIndex = (int)classSort.limited_gender;
            //cb_Status.SelectedIndex = (int)classSort.class_status;
            txt_ClassName.Text = classSort.class_name;
            txt_Introduction.Text = classSort.class_introduction;
            _imagepath = classSort.class_photo;
            if (!string.IsNullOrEmpty(_imagepath))
            {
                string path = Application.StartupPath + "\\ClassPic";
                pb_ClassPhoto.Image = new Bitmap(path + "\\" + _imagepath);
            }
            Change_lbl_CurrentIndex();
        }
        private void dbEdit(int id)
        {
            gymEntities db = new gymEntities();
            var classSort = db.tclasses.FirstOrDefault(x => x.class_id == id);
            var classSort1 = db.tclass_sort_有氧.FirstOrDefault(x => x.class_sort1_id == id);
            var classSort2 = db.tclass_sort_訓練.FirstOrDefault(x => x.class_sort2_id == id);
            var classSlm = db.tclass_limit_details.FirstOrDefault(x => x.class_limited_id == id);
            var classSst = db.tclass_status_detail.FirstOrDefault(x => x.class_status_id == id);

            if (classSort == null || classSort1 == null || classSort2 == null || classSlm == null || classSst == null) return;

            classSort1.class_sort1_detail = cb_Sort1.Text;
            classSort2.class_sort2_detail = cb_Sort2.Text;
            classSlm.describe = cb_Limit.Text;
            classSort.class_name = txt_ClassName.Text;
            classSort.class_introduction = txt_Introduction.Text;
            classSst.class_status_discribe = cb_Status.Text;

            if (!string.IsNullOrEmpty(_imagepath))
            {
                string path = Path.Combine(Application.StartupPath, "ClassPic");
                pb_ClassPhoto.Image = new Bitmap(Path.Combine(path, _imagepath));
            }
            classSort.class_photo = _imagepath;

            MessageBox.Show("資料儲存成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
        }
        private void DataGridView_ClassSortList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0) return; 
            _index = (int)dataGridView_ClassSortList.Rows[e.RowIndex].Cells[0].Value;
            dbSelect(_index);
        }
        private void Btn_Begin_Click(object sender, EventArgs e)
        {
            _index = 1;
            dbSelect(_index);
            this.dataGridView_ClassSortList.CurrentCell = dataGridView_ClassSortList.Rows[_index - 1].Cells[0];
            Change_lbl_CurrentIndex();
        }


        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            _index--;
            if (_index < 1) _index = 1;

            dbSelect(_index);
            this.dataGridView_ClassSortList.CurrentCell = dataGridView_ClassSortList.Rows[_index - 1].Cells[0];
            Change_lbl_CurrentIndex();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            _index++;
            int total = TotalAmount();
            if (_index > total)
                _index = total;

            dbSelect(_index);
            this.dataGridView_ClassSortList.CurrentCell = dataGridView_ClassSortList.Rows[_index - 1].Cells[0];
            Change_lbl_CurrentIndex();
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {
            int total = TotalAmount();
            _index = total;

            dbSelect(_index);
            this.dataGridView_ClassSortList.CurrentCell = dataGridView_ClassSortList.Rows[_index - 1].Cells[0];
            Change_lbl_CurrentIndex();
        }

        private static int TotalAmount()
        {
            gymEntities gymEntities = new gymEntities();
            var courses = from course in gymEntities.tclasses select course;
            int total = courses.Count();
            return total;
        }

        private void Change_lbl_CurrentIndex()
        {
            int total = TotalAmount();
            this.lbl_CurrentIndex.Text = $"{_index}/{total}";
        }

    }
}
