using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class Frmfreetrial : Form
    { 
        private Timer sparkleTimer;
        private Timer Timer_ann;
        private int currentPosition = 0;
        private Timer imageTimer;
        private int currentImageIndex = 0;
        private Image[] images = new Image[]
        {Properties.Resources.gym1, Properties.Resources.gym2, Properties.Resources.gym3, Properties.Resources.gym4, Properties.Resources.gymm};
        private string announcementText = "歡迎來到FitConnect，您可以在首頁查看最新消息以及相關優惠訊息";
        public tIdentity identity { get; set; }
        private tclass_schedule _cs;
        public tclass_schedule cs { get { return _cs; }set { _cs = value; } }
        public Frmfreetrial()
        {
            InitializeComponent(); 
            InitializeSparkleTimer();
            Run_announcementText();
            InitializeImageTimer();
        } 

        private void InitializeSparkleTimer()
        { 
            sparkleTimer = new Timer();
            sparkleTimer.Interval = 567; 
            sparkleTimer.Tick += SparkleTimer_Tick;
            sparklingLabel.Text = "現在預約完成體驗 享二十課程半價 只要 18888 "+"                  "+"名額有限 立即手刀報名體驗";
            sparkleTimer.Start();
        }

        private void SparkleTimer_Tick(object sender, EventArgs e)
        { 
            sparklingLabel.Visible = !sparklingLabel.Visible;
        }
        private void Run_announcementText()
        {
            label_ann.Text = announcementText.Substring(currentPosition) + announcementText.Substring(0, currentPosition);
            Timer_ann = new Timer();
            Timer_ann.Interval = 750;
            Timer_ann.Tick += AnnTimer_Tick; 
            Timer_ann.Start();
        }

        private void AnnTimer_Tick(object sender, EventArgs e)
        {
            currentPosition++;
            if (currentPosition >= announcementText.Length)
            {
                currentPosition = 0;
            }
            label_ann.Text = announcementText.Substring(currentPosition) + announcementText.Substring(0, currentPosition);
        }
        private void InitializeImageTimer()
        { 
            imageTimer = new Timer();
            imageTimer.Interval = 10000;
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        { 
            currentImageIndex++;
             
            if (currentImageIndex >= images.Length)
            {
                currentImageIndex = 0;
            } 
            //pictureBox1.Image = images[currentImageIndex];
            this.BackgroundImage= images[currentImageIndex];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.identity == null) { MessageBox.Show("請登入會員"); return; }
            gymEntities db = new gymEntities();
            int index = this.identity.id;
            tIdentity i = db.tIdentity.FirstOrDefault(x => x.id == index);
            if (i.role_id != 1) { MessageBox.Show("您的身分並非會員, 無法預約課程"); return; }
            tclass_reserve cr = new tclass_reserve();
            //cr.class_schedule_id = p.ts.class_schedule_id;
            cr.member_id = index;
            cr.payment_status = false;
            cr.reserve_status = true;
            db.tclass_reserve.Add(cr);
            //if (afterCourseSubmit() == 0){
            //db.SaveChanges();
            //MessageBox.Show("   課程預約成功!"+"\n請於期限內完成繳費"); 
            //} else return;
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                MessageBox.Show("預約失敗");
            else MessageBox.Show("預約成功");
            this.Close();
        }

        private void Frmfreetrial_Load(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            var items = from r in db.tclass_schedule
                        join p in db.tclasses on r.class_id equals p.class_id   
                        join g in db.ttimes_detail on r.course_time_id equals g.time_id
                        select new { className = p.class_name, classDate = r.course_date,classTime=g.time_name };
            this.comboBox1.Items.Clear(); this.comboBox2.Items.Clear(); this.comboBox3.Items.Clear();
            foreach (var s in items)
            {
                comboBox1.Items.Add(s.className);
                comboBox2.Items.Add(s.classDate);
                comboBox3.Items.Add(s.classTime);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
