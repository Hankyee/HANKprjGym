using FrmMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjGym
{ 
    public delegate void Dlogin(tIdentity m);
    public partial class FrmLogin : Form
    {
        private DialogResult _isOK;
        public DialogResult isOK{ get { return _isOK; } set { _isOK = value; } }  
        int loginTimes = 0; 
        public event Dlogin afterLogin;
        public tIdentity auth { get; set; }
        public FrmLogin()
        {
            InitializeComponent(); 

            SetRoundButton(btn_Cancel, 55);
            SetRoundButton(btn_Login, 55);
            SetRoundButton(btn_Register, 55);

            lbl_ErrorLogin.Text = string.Empty; 
            tb_Password.PasswordChar = '●';
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
         
        private void btn_Login_Click(object sender, EventArgs e)
        { 
            string username = this.tb_UserName.Text;
            string password = this.tb_Password.Text; 
            gymEntities db = new gymEntities(); 
            tIdentity m = db.tIdentity.FirstOrDefault(x => x.e_mail == username || x.phone == username && x.password == password);
            
            if (m != null)
            {
                _isOK=DialogResult.OK;  
                afterLogin(m); 
                this.Close(); 
                return;
            } 
            loginTimes++; 
            lbl_ErrorLogin.Text = $"帳號或密碼錯誤: 錯誤次數{loginTimes}次,剩餘錯誤次數{3 - loginTimes}次"; 
            if (loginTimes > 3)
            {
                MessageBox.Show("多次登入失敗,系統鎖定");
                Application.Exit();
            } 
        } 
         
        private void btn_Cancel_Click(object sender, EventArgs e)
        {  
            this.Close();
        }
         
        private void btn_Register_Click(object sender, EventArgs e)
        { 
            FrmNewMemberRegister frmNewMemberRegister = new FrmNewMemberRegister();
            frmNewMemberRegister.savedata += this.savedata_member; 
            frmNewMemberRegister.ShowDialog(); 
            if (frmNewMemberRegister.result == DialogResult.No) return;
        }
         
        private void savedata_member(FrmNewMemberRegister frm) 
        { 
            gymEntities db = new gymEntities(); 
            tIdentity member = new tIdentity(); 
            tgender_Table g = db.tgender_Table.FirstOrDefault(x => x.gender_text.Equals(frm.gender)); 
            member.role_id = 1;
            member.name = frm.name;
            member.phone = frm.phone;
            member.address = frm.address;
            member.birthday = DateTime.Parse(frm.birth);
            member.e_mail = frm.mail;
            member.password = frm.password;
            member.photo = frm.file;
            member.gender_id = g.gender_id;
            db.tIdentity.Add(member); 
            db.SaveChanges();
            MessageBox.Show("註冊成功，請使用電話/信箱 + 密碼登入");
        }
        private void coach_signin(object sender, EventArgs e)
        {
            FrmNewCoachRegister frmNewCoachRegister = new FrmNewCoachRegister();
            frmNewCoachRegister.savedata += this.savedata_coach; 
            frmNewCoachRegister.ShowDialog(); 
            if (frmNewCoachRegister.result == DialogResult.No) return;
        }
        private void savedata_coach(FrmNewCoachRegister frm)
        { 
            gymEntities db = new gymEntities(); 
            tIdentity coach = new tIdentity();
             
            tgender_Table g = db.tgender_Table.FirstOrDefault(x => x.gender_text.Equals(frm.gender)); 
            coach.role_id = 2;
            coach.name = frm.name;
            coach.phone = frm.phone;
            coach.e_mail = frm.mail;
            coach.password = frm.password;
            coach.photo = frm.file;
            coach.birthday = DateTime.Parse(frm.birth);
            coach.address = frm.address;
            coach.gender_id = g.gender_id;

            if (DateTime.Now - DateTime.Parse(frm.birth) < TimeSpan.FromDays(365 * 14 + 3))
            {
                MessageBox.Show("小朋友 你還太小了");
                return;
            }
            if (DateTime.Now - DateTime.Parse(frm.birth) < TimeSpan.FromDays(365 * 18 + 4))
            {
                MessageBox.Show("未成年請監護人陪同\n至現場辦理加入會員");
                return;
            } 
            coach.activated = false; 
            db.tIdentity.Add(coach);
            
            tcoach_info_id coach_i = new tcoach_info_id();
            coach_i.coach_id = coach.id;
            coach_i.coach_intro = frm.intro;
            db.tcoach_info_id.Add(coach_i);

            foreach (var text in frm.list)
            {
                tcoach_expert coach_e = new tcoach_expert();
                coach_e.coach_id = coach.id;
                tclasses c = db.tclasses.FirstOrDefault(x => x.class_name == text);
                coach_e.class_id = c.class_id;
                db.tcoach_expert.Add(coach_e);
            } 
            db.SaveChanges();
            MessageBox.Show("註冊教練成功，請使用電話/信箱 + 密碼登入\n" + "若要開課，請等待管理員審核");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { tb_Password.PasswordChar = '\0'; }
            else { tb_Password.PasswordChar = '●'; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = "maple@gmail.com";
            tb_Password.Text = "maple";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = "martin@gmail.com";
            tb_Password.Text = "Y7nk";
        }
    }
}
