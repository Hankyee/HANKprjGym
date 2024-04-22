using FrmMain;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym
{
    public partial class FrmField : Form
    {
        private DialogResult _isOk;
        private tfield _field;
        private string _Field_photo = "";
        public tfield field
        {
            get
            {
                if (_field == null)
                {
                    _field = new tfield();
                }
                //_field.region_id = Convert.ToInt32(fbregion.fieldValue);
                _field.floor = fbFieldFloor.fieldValue;
                _field.field_name = fbFieldName.fieldValue;
                _field.field_payment = Convert.ToDecimal(fbFieldPayment.fieldValue);
                //_field.field_photo = _Field_photo;
                return _field;
            }
            set
            {
                _field = value;
                lblfID.Text = _field.field_id.ToString();
                //fbregion.fieldValue = _field.region_id.ToString();
                fbFieldFloor.fieldValue = _field.floor;
                fbFieldName.fieldValue = _field.field_name;
                fbFieldPayment.fieldValue = _field.field_payment.ToString();
                
                //_Field_photo = _field.field_photo;
                //if (!string.IsNullOrEmpty(_Field_photo))
                //{
                //    string path = Application.StartupPath + "\\fieldImages";
                //    pictureBox1.Image = new Bitmap(path + "\\" + _Field_photo);
                //}
                
            }
        }
        public DialogResult isOk
        {
            get
            {
                return _isOk;
            }
        }
        public FrmField()
        {
            InitializeComponent();
            this.Text = "新增場地";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.OK;
            if(this.lblfID.Text !=string.Empty)return;
            //if (this.fbregion.fieldValue == string.Empty) return;
            if (this.fbFieldName.fieldValue == string.Empty) return;
            if (this.fbFieldFloor.fieldValue == string.Empty) return;
            if (this.fbFieldPayment.fieldValue == string.Empty) return;
            if (this.pictureBox1.Image == null) return;
            gymEntities db = new gymEntities();
            db.tfield.Add(this.field);
            db.SaveChanges();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.Cancel;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "場地照片|*.jpg|場地照片|*.png|場地照片|*.bmp";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            _Field_photo = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string path = Application.StartupPath + "\\fieldImages";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.Copy(openFileDialog1.FileName, path + "\\" + _Field_photo);
            pictureBox1.Image = new Bitmap(path + "\\" + _Field_photo);
        }

        private void FrmField_Load(object sender, EventArgs e)
        {
            ShowfieldList();
        }

        private void ShowfieldList()
        {
            gymEntities db = new gymEntities();
            var Field = from f in db.tfield
                        //join r in db.tregion_table on f.region_id equals r.region_id
                        select new
                        {
                            場地編號 = f.field_id,
                            //縣市 = r.city,
                            //地區 = r.region,
                            樓層 = f.floor,
                            場地名稱 = f.field_name,
                            租借金額_每小時 = f.field_payment,
                            //場地圖片 = f.field_photo
                        };
            this.dataGridView1.DataSource = Field.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.Columns["租借金額_每小時"].HeaderText = "租借金額/每小時";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (pictureBox1.Image != null) this.pictureBox1.Image = null;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            dbSelect(id);
        }
        private void dbSelect(int id)
        {
            gymEntities db = new gymEntities();
            tfield field=db.tfield.FirstOrDefault(x=>x.field_id == id);
            if (field == null) return;
            this.fbregion.fieldValue = "台北市 大安區";
            this.lblfID.Text=field.field_id.ToString();
            this.fbFieldName.fieldValue = field.field_name;
            this.fbFieldFloor.fieldValue = field.floor;
            this.fbFieldPayment.fieldValue = field.field_payment.ToString();
            //_Field_photo=field.field_photo;
            //if (!string.IsNullOrEmpty(_Field_photo))
            //{
            //    string path = Application.StartupPath + "\\fieldImages";
            //    pictureBox1.Image = new Bitmap(path + "\\" + _Field_photo);
            //} 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.lblfID.Text.ToString().Equals("id")) return; 
            try
            {
                int id = Convert.ToInt32(lblfID.Text);
                dbEdit(id);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { ShowfieldList(); }
        }
        private void dbEdit(int id)
        {
            gymEntities db = new gymEntities();
            var field = db.tfield.FirstOrDefault(x => x.field_id == id);
            if (field == null) return;
            field.floor=fbFieldFloor.fieldValue;
            field.field_name = fbFieldName.fieldValue;
            field.field_payment=Convert.ToDecimal(fbFieldPayment.fieldValue);
            //field.region_id = 1;
            if (!string.IsNullOrEmpty(_Field_photo))
            {
                string path = Application.StartupPath + "\\fieldImages";
                pictureBox1.Image = new Bitmap(path + "\\" + _Field_photo);
            }
            //field.field_photo = _Field_photo;
            db.SaveChanges();
            MessageBox.Show("場地資料已更新");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.lblfID.Text = string.Empty;
            this.fbregion.fieldValue = string.Empty;
            this.fbFieldName.fieldValue = string.Empty;
            this.fbFieldFloor.fieldValue = string.Empty;
            this.fbFieldPayment.fieldValue = string.Empty;
            this.pictureBox1.Image = null;
        }
    }
}
