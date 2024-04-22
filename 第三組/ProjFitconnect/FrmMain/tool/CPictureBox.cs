using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.tool
{
    public delegate void DPicture(CPictureBox p);
    public partial class CPictureBox : UserControl
    {
        public event DPicture showPicture;
        private tcourse_photo _CouursePhoto;

        public Image Image{get { return pictureBox1.Image; }}

        public tcourse_photo CoursePhoto{ get { return _CouursePhoto; } set {
                _CouursePhoto = value;
                if (!string.IsNullOrEmpty(_CouursePhoto.course_photo))
                {
                    string path = Application.StartupPath + "\\CoursePhoto";
                    pictureBox1.Image = new Bitmap(path + "\\" + _CouursePhoto.course_photo);
                }; } }
        public CPictureBox()
        {
            InitializeComponent();
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.showPicture != null) this.showPicture(this);
        }
    }
}
