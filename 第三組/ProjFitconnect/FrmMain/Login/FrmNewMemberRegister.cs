using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using FrmMain;
using System.Drawing.Drawing2D;

namespace ProjGym
{
    public delegate void D1(FrmNewMemberRegister frm);
    public partial class FrmNewMemberRegister : Form
    {
        //C_RegisterMng data = new C_RegisterMng();
        string filename = "";
        public event D1 savedata;
        public string name { get { return this.tb_Name.Text.ToString(); } }
        public string gender { get { return this.cb_GenderList.SelectedItem.ToString() ; } }
        public string phone { get { return this.tb_Phone.Text.ToString(); } }
        public string birth { get { return this.dateTimePicker_Birth.Text.ToString(); } }
        public string address { get { return this.tb_Address.Text.ToString(); } }
        public string mail { get { return this.tb_Mail.Text.ToString(); } }
        public string password { get { return this.tb_Password.Text.ToString(); } }
        public string file { get { return this.filename.ToString(); } }
        public DialogResult result { get; set; }
        public FrmNewMemberRegister()
        {
            InitializeComponent();
            this.cb_GenderList.DropDownStyle = ComboBoxStyle.DropDownList;
            SetRoundButton(btn_Cancel, 40);
            SetRoundButton(btn_Save, 40);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //savedatacheck();
            this.result = DialogResult.OK;
            if (this.savedata != null)
            {
                savedata(this);
            }
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.result = DialogResult.No;
            this.Close();
        }

        private void pb_Photo_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "圖片|*.jpeg;*.jpg;*.png";
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string path = Application.StartupPath + "\\MemberImages";
            filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.Copy(this.openFileDialog1.FileName, path + "\\" + filename);
            pb_Photo.Image = new Bitmap(path + "\\" + filename);
        }

        private void FrmNewMemberRegister_Load(object sender, EventArgs e)
        {
            cb_GenderList.Items.Clear();
            gymEntities db = new gymEntities();
            var genders = from gender in db.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_GenderList.Items.Add(gender.gender_text); });
        }
        private void SetRoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "流川楓";
            tb_Address.Text = "Japan";
            tb_Mail.Text = "maple@gmail.com";
            tb_Phone.Text = "09876";
            tb_Password.Text = "maple";
            cb_GenderList.SelectedIndex = 0;
        }
    }
}
