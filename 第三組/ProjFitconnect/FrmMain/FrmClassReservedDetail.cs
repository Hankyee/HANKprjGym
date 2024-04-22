using FrmMain.tool;
using Revised_V1._1;
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
    public partial class FrmClassReservedDetail : Form
    {
        public tfield fieldid { get; set; }
        private tclasses _cls; //課程名稱
        private tfield _field; //場地名稱、位置?
        private tclass_schedule _cs; //日期、課程介紹
        private ttimes_detail _time; //時間
        private tIdentity _ID; //教練名稱
        private tcoach_info_id _info; //教練資訊
        private tGym _gym;
        public tclasses cls { get { return _cls; } set { _cls = value; label9.Text = _cls.class_name; label8.Text = _cls.class_introduction; } }
        public tGym gym { get { return _gym; } set { _gym = value; label10.Text +="  "+ _gym.name; label16.Text = _gym.address; } }
        public tfield field { get { return _field; } set { _field = value; label10.Text = _field.floor +"  "+ _field.field_name; } }
        public tclass_schedule cs { get { return _cs; } set { _cs = value; label11.Text = _cs.course_date.ToShortDateString(); } }
        public tIdentity ID { get { return _ID; } set { _ID = value; label12.Text = _ID.name;} }
        public tcoach_info_id info { get { return _info; } set { _info = value; label6.Text = _info.coach_intro; } }
        public ttimes_detail td { get { return _time; } set { _time = value; label11.Text += "    " + _time.time_name; } }
        
        //todo:製作動圖，現在如從中截斷，他會返回原來位置，不會更新位置
        private int currentImageIndex = -1; // 圖片索引
        public FrmClassReservedDetail()
        {
            InitializeComponent();
            timer1.Interval = 2500; // 時間間隔
            timer1.Tick += Timer1_Tick; // 增加Timer的Tick事件
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowNextPicture();
        }
        private void ShowNextPicture()
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                // 取得下一張圖的索引
                currentImageIndex = (currentImageIndex +1) % flowLayoutPanel1.Controls.Count;
                // 取得對應所以的CPictureBox圖片
                CPictureBox nextImage = (CPictureBox)flowLayoutPanel1.Controls[currentImageIndex];
                pictureBox1.Image = nextImage.Image;
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
            FrmCoachInfo frm = new FrmCoachInfo();
            frm.pid = this.ID;
            frm.cid = this.info;
            frm.cl = this.cls;
            frm.ShowDialog();
        }
        private void label12_MouseHover(object sender, EventArgs e)
        {
            
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FrmClassReservedDetail_Load(object sender, EventArgs e)
        {
            showCoachPhoto();
            //點選flowLayoutPanel1中圖片，show在picturebox1用的，加了timer後就沒用了0.0
            //if (flowLayoutPanel1.Controls.Count > 0 && flowLayoutPanel1.Controls[0] is CPictureBox)
            //{
            //    CPictureBox firstImage = (CPictureBox)flowLayoutPanel1.Controls[0];
            //    pictureBox1.Image = firstImage.Image;
            //}
            ShowNextPicture(); // 顯示圖片
            timer1.Start(); // 開啟timer
        }
        private void showCoachPhoto()
        {
            gymEntities db = new gymEntities();
            var photo = from csch in db.tclass_schedule
                        from cp in db.tcourse_photo
                        where cp.class_schedule_id == csch.class_schedule_id
                        select new { coursephoto = cp};
            foreach( var item in photo)
            {
                CPictureBox pb = new CPictureBox();
               
                pb.Width = 180;
                pb.Height = 90;
                pb.Location = new System.Drawing.Point(flowLayoutPanel1.Width / 2 - pb.Width / 2);

                pb.CoursePhoto = item.coursephoto;
                pb.showPicture += showPicture;
                flowLayoutPanel1.Controls.Add(pb);
            }
        }
        private void showPicture(CPictureBox p)
        {
            Image clickedImage = p.Image;
            pictureBox1.Image = clickedImage;
        }
    }
}
