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

namespace ProjGym
{
    //宣告一個委派作為[編輯會員資料]表單的事件
    public delegate void D_Register(tIdentity m);
    public partial class FrmEditMemberRegister : Form
    {
        //宣告一個資料型別為D_Register、名稱為afterEdit的事件
        public event D_Register afterEdit;
        //全域變數_filename用來記錄[登入者]的照片檔案名稱，預設為空字串(因為會員可以不放照片)
        private string _filename = string.Empty;
        public tIdentity member { get; set; }
        public TextBox name { get { return this.tb_Name; } }
        public ComboBox gender { get { return this.cb_Gender; } }
        public TextBox phone { get { return this.tb_Phone; } }
        public DateTimePicker birth { get { return this.dateTimePicker_Birth; } }
        public TextBox mail { get { return this.tb_Mail; } }
        public TextBox address { get { return this.tb_Address; } }
        public TextBox password { get { return this.tb_Password; } }
        public PictureBox photo { get { return this.pb_Photo; } }
        public Button save { get { return this.btn_Save; } }
        public Button cancel { get { return this.btn_Cancel; } }
        //[編輯會員資料]表單的建構子，在new FrmEditMemberRegister()時被執行
        public FrmEditMemberRegister()
        {
            InitializeComponent();
            //清除combobox_Gender的選項
            cb_Gender.Items.Clear();
            //產生[gym資料庫實體]
            gymEntities db = new gymEntities();
            //從[gym資料庫實體]內的[gender_Table]資料表取得性別ID與對應的性別名稱
            var genders = from gender in db.tgender_Table select gender;
            //將取得的性別名稱作為combobox_Gender的選項
            genders.ToList().ForEach(gender => { cb_Gender.Items.Add(gender.gender_text); });
        }

        //[編輯會員資料]表單在載入階段要做的事情(此時的[編輯會員資料]表單還沒顯示出來)
        private void FrmMemberRegister_Load(object sender, EventArgs e)
        {
            //產生[gym資料庫實體]
            gymEntities gymEntities = new gymEntities();
            //利用[編輯會員資料]表單的MdiParent屬性取得[主程式表單]
            //利用[主程式表單]的member屬性取得[登入者]資料
            //取得[登入者]資料中唯一不變的id屬性(流水號)
            int index = this.member.id;
            //在[Identity]資料表內，利用[登入者]的流水號找出對應的會員(m)
            tIdentity m = gymEntities.tIdentity.FirstOrDefault(x => x.id == index);
            //利用m的名稱、身分ID、性別ID、電話、地址、生日、電郵、密碼、照片檔案名稱，
            //分別設定至[編輯會員資料]表單的textbox、combobox與dateTimePicker
            this.tb_Name.Text = m.name;
            this.cb_Gender.SelectedIndex = m.gender_id - 1;
            this.tb_Phone.Text = m.phone;
            this.dateTimePicker_Birth.Text = m.birthday.ToString();
            this.tb_Mail.Text = m.e_mail;
            this.tb_Address.Text = m.address;
            this.tb_Password.Text = m.password;
            this._filename = m.photo;
            //全域變數_filename如果不是空字串(代表有放入照片)，執行以下程式碼
            //------------------------------------------------------------------------------↓
            if (!string.IsNullOrEmpty(_filename))
            {
                //完整照片路徑為: exe路徑\MemberImages\照片名.jpg
                string fullpath = Application.StartupPath + "\\MemberImages\\" + _filename;
                //將路徑上的照片路徑轉換為照片，顯示在picturebox上
                this.pb_Photo.Image = new Bitmap(fullpath);
            }
            //------------------------------------------------------------------------------↑
        }
        //如果[編輯會員資料]表單內的[保存]按鈕按下時，執行以下程式碼
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //產生[gym資料庫實體]
            gymEntities gymEntities = new gymEntities();
            //利用[編輯會員資料]表單的MdiParent屬性取得[主程式表單]
            //利用[主程式表單]的member屬性取得[登入者]資料
            //取得[登入者]資料中唯一不變的id屬性(流水號)
            int index = this.member.id;
            //在[Identity]資料表內，利用[登入者]的流水號找出對應的會員欄位(m)
            tIdentity m = gymEntities.tIdentity.FirstOrDefault(x => x.id == index);
            //依照combobox_Gender所選的性別，找出對應的性別ID
            tgender_Table g = gymEntities.tgender_Table.FirstOrDefault(x => x.gender_text.Equals(this.cb_Gender.SelectedItem.ToString()));
            //將[登入者]的會員資料修改為[編輯會員資料]表單上的textbox、combobox與dateTimePicker
            m.name = this.tb_Name.Text;
            m.gender_id = g.gender_id;
            m.phone = this.tb_Phone.Text;
            m.birthday = DateTime.Parse(this.dateTimePicker_Birth.Text);
            m.e_mail = this.tb_Mail.Text;
            m.password = this.tb_Password.Text;
            m.address = this.tb_Address.Text;
            m.photo = this._filename;
            gymEntities.SaveChanges();
            MessageBox.Show("資料已成功儲存");
            //先前已在[主程式]表單內的[修改會員資料ToolStripMenuItem_Click]方法內，
            //註冊showinfo方法來處理afterLogin事件
            //觸發afterLogin事件
            if (afterEdit != null)
                afterEdit(m);
            //關閉[編輯會員資料]表單
            this.Close();

        }
        //如果[編輯會員資料]表單內的[取消]按鈕按下時，執行以下程式碼
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //如果[編輯會員資料]表單內的[picturebox]被滑鼠左鍵連點兩下時，執行以下程式碼
        private void pb_Photo_Click(object sender, EventArgs e)
        {
            //過濾[登入者]可以開啟的檔案類型為.jpeg /.jpg /.png
            this.openFileDialog_FrmMemberRegister.Filter = "圖片|*.jpeg;*.jpg;*.png";
            //開啟檔案瀏覽視窗
            //如果[登入者]取消匯入照片，就將程式控制權歸還給[編輯會員資料]表單
            if (this.openFileDialog_FrmMemberRegister.ShowDialog() != DialogResult.OK)
                return;
            //[用來存放照片的資料夾]路徑
            string path = Application.StartupPath + "\\MemberImages";
            //將照片名稱設定為[現在時間.jpg]，並由全域變數_filename紀錄
            _filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            //若[用來存放照片的資料夾]不存在，就創建一個用來存放照片的資料夾
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            //將[登入者]選擇的照片複製到[用來存放照片的資料夾]
            File.Copy(this.openFileDialog_FrmMemberRegister.FileName, path + "\\" + _filename);
            //將[登入者]所選的照片顯示在picturebox上
            pb_Photo.Image = new Bitmap(path + "\\" + _filename);
        }
    }
}
