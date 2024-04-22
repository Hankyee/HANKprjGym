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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjGym
{
    public delegate void D2(FrmNewCoachRegister frm);
    public partial class FrmNewCoachRegister : Form
    {
        string filename = "";
        public event D2 savedata;
        public string name { get { return this.tb_Name.Text.ToString(); } }
        public string phone { get { return this.tb_Phone.Text.ToString(); } }
        public string mail { get { return this.tb_Mail.Text.ToString(); } }
        public string password { get { return this.tb_Password.Text.ToString(); } }
        public string file { get { return this.filename.ToString(); } }
        public string birth { get { return this.dateTimePicker_Birth.Text.ToString(); } }
        public string address { get { return this.tb_Address.Text.ToString(); } }
        public string gender { get { return this.cb_GenderList.SelectedItem.ToString(); } }

        public List<string> list { get { return expert_text; } }
        
        List<string> expert_text = new List<string>();

        private int tabindex = 8;
        public string intro { get { return this.tb_intro.Text; } }
        public DialogResult result { get; set; }
        public FrmNewCoachRegister()
        {
            InitializeComponent();
            this.cb_GenderList.DropDownStyle = ComboBoxStyle.DropDownList;
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
            string path = Application.StartupPath + "\\CoachImages";
            filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.Copy(this.openFileDialog1.FileName, path + "\\" + filename);
            pb_Photo.Image = new Bitmap(path + "\\" + filename);
        }

        private void FrmNewCoachRegister_Load(object sender, EventArgs e)
        {
            addnewexpertbox();
            cb_GenderList.Items.Clear();
            gymEntities db = new gymEntities();
            var genders = from gender in db.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_GenderList.Items.Add(gender.gender_text); });
            this.cb_GenderList.Text = "請選擇";
            this.cb_GenderList.ImeMode = ImeMode.Disable;
        }

        private void addnewexpertbox()
        {
            ComboBox expert = new ComboBox
            {
                Text = "請選擇專長",
                TabIndex = tabindex,
                ImeMode = ImeMode.Disable,
                DropDownStyle = ComboBoxStyle.DropDownList,
        };
            tabindex++;

            gymEntities db = new gymEntities();
            var classes = from a in db.tclasses select a;
            classes.ToList().ForEach(a => { expert.Items.Add(a.class_name); });
            expert.Items.Add("其他");
            expert.SelectedIndexChanged += this.Expert_SelectedIndexChanged;
            //expert.Leave += this.Expert_Leave;
            this.panel_expert.Controls.Add(expert);
        }

        private void Expert_Leave(object sender, EventArgs e)
        {
            string s = ((ComboBox)sender).Text;
            if (s == "其他")
            {
                (new FrmNewExpert()).ShowDialog();
                addnewexpertbox();
                return;
            }
            expert_text.Add(s);
            addnewexpertbox();
        }

        private void Expert_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = ((ComboBox)sender).Text;
            if (s == "其他")
            {
                (new FrmNewExpert()).ShowDialog();
                addnewexpertbox();
                return;
            }
            expert_text.Add(s);
            addnewexpertbox();
        }

        private void Expertbox_TextChanged(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("申請為新專長？", "", MessageBoxButtons.OKCancel);
            if (check != DialogResult.OK)
                return;
            expert_text.Add(((TextBox)sender).Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_Name.Text ="安西教練";
            cb_GenderList.SelectedIndex = 0;
            tb_Phone.Text = "0900";
            tb_Password.Text = "ha123";
            tb_Address.Text = "Japan";
            tb_Mail.Text = "AnnXi@ispn.com";
            tb_intro.Text = "年輕時曾是日本國家籃球隊選手，退休後擔任大學籃球教練。";
        }
    } 
}
