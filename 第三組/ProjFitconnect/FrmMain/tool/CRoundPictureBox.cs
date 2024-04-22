using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace YourNamespace
{
    public class RoundPictureBox : PictureBox
    {
        private Image _image;

        public new Image Image
        {
            get => _image;
            set
            {
                _image = value;
                Invalidate(); // Redraw the control when the image changes
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (Image != null)
            {
                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(ClientRectangle);
                    pe.Graphics.SetClip(path); // Clip the graphics object to the circular path
                }

                // Draw the clipped image
                pe.Graphics.DrawImage(Image, ClientRectangle);
            }
        }
    }
}
