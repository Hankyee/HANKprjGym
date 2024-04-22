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
        private tcoach_photo _CoachPhoto;

        public Image Image{get { return pictureBox1.Image; }}

        public tcoach_photo CoachPhoto { get { return _CoachPhoto; } set {
                _CoachPhoto = value;
                if (!string.IsNullOrEmpty(_CoachPhoto.coach_photo))
                {
                    string path = Application.StartupPath + "\\CoachPhoto";
                    pictureBox1.Image = new Bitmap(path + "\\" + _CoachPhoto.coach_photo);
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
