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

namespace FrmMain
{
    public delegate void DCoachEdit(tIdentity MM);
    public partial class FrmEditCoachRegister : Form
    {

        public tIdentity identity { get; set; }
        public event DCoachEdit afterEdit;
        private string _filename = string.Empty;
        private string _ImagePath = string.Empty;
        public tIdentity coach { get; set; }
        public TextBox name { get { return this.tb_Name; } }
        public ComboBox gender { get { return this.cb_Gender; } }
        public TextBox phone { get { return this.tb_Phone; } }
        public DateTimePicker birth { get { return this.dateTimePicker_Birth; } }
        public TextBox mail { get { return this.tb_Mail; } }
        public TextBox address { get { return this.tb_Address; } }
        public TextBox password { get { return this.tb_Password; } }
        public PictureBox photo { get { return this.pb_Photo; } }
        public ComboBox expertise { get { return this.cb_Expertise; } }
        public Button save { get { return this.btn_Save; } }
        public Button cancel { get { return this.btn_Cancel; } }

        public FrmEditCoachRegister()
        {
            InitializeComponent();
            cb_Gender.Items.Clear();
            gymEntities db = new gymEntities();
            var genders = from gender in db.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_Gender.Items.Add(gender.gender_text); });

        }

        private void FrmEditCoachRegister_Load(object sender, EventArgs e)
        {
            ShowCoachInfo(); 
        }

        private void ShowCoachInfo()
        {
            gymEntities db = new gymEntities();
            int index = this.identity.id;
            tIdentity MM = db.tIdentity.FirstOrDefault(x => x.id == index);
            this.tb_Name.Text = MM.name;
            this.cb_Gender.SelectedIndex = MM.gender_id - 1;
            this.tb_Phone.Text = MM.phone;
            this.dateTimePicker_Birth.Text = MM.birthday.ToString();
            this.tb_Mail.Text = MM.e_mail;
            this.tb_Address.Text = MM.address;
            this.tb_Password.Text = MM.password;
            this._filename = MM.photo;

            tcoach_info_id CC = db.tcoach_info_id.FirstOrDefault(x => x.coach_id == index);
            tb_intro.Text = CC.coach_intro;

            var expername = from r in db.tclasses
                            select r;
            foreach (var ex in expername)
            {
                cb_Expertise.Items.Add(ex.class_name);
            }

            if (!string.IsNullOrEmpty(_filename))
            {
                string fullpath = Application.StartupPath + "\\CoachImages\\" + _filename;
                this.pb_Photo.Image = new Bitmap(fullpath);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            int index =  this.identity.id;
            tIdentity MM = db.tIdentity.FirstOrDefault(x => x.id == index);
            tgender_Table g = db.tgender_Table.FirstOrDefault(x => x.gender_text.Equals(this.cb_Gender.SelectedItem.ToString()));
            MM.name = this.tb_Name.Text;
            MM.gender_id = g.gender_id;
            MM.phone = this.tb_Phone.Text;
            MM.birthday = DateTime.Parse(this.dateTimePicker_Birth.Text);
            MM.e_mail = this.tb_Mail.Text;
            MM.password = this.tb_Password.Text;
            MM.address = this.tb_Address.Text;
            MM.photo = this._filename;

            tcoach_info_id CC = db.tcoach_info_id.FirstOrDefault(x => x.coach_id == MM.id);
            CC.coach_intro = this.tb_intro.Text;
             
            int expert = (from EE in db.tclasses
                          join FF in db.tcoach_expert
                          on EE.class_id equals FF.class_id
                          where EE.class_name == cb_Expertise.Text
                          select EE.class_id).FirstOrDefault();  // 使用 FirstOrDefault 獲取第一個匹配的 class_id

            if (expert != 0)  // 檢查 expert 是否為 0
            {
                tcoach_expert TT = db.tcoach_expert.FirstOrDefault(x => x.expert_id == MM.id);
                if (TT != null)
                {
                    TT.class_id = expert;  // 賦值
                    //db.SaveChanges();  // 保存變更到資料庫
                }
            } 
            db.SaveChanges(); 
            MessageBox.Show("教練資料已更新"); 
            if (afterEdit != null)
                afterEdit(MM); 
            this.Close();
        }

        private void pb_Photo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "教練照片|*.jpg|教練照片|*.png|教練照片|*.bmp";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            _filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string path = Application.StartupPath + "\\CoachImages";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            File.Copy(openFileDialog1.FileName, path + "\\" + _filename);

            pb_Photo.Image = new Bitmap(path + "\\" + _filename);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}