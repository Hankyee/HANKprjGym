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
    public partial class CoachReviewBox : UserControl
    {
        private tmember_follow _coachreview;
        public tmember_follow coachreview { get { return _coachreview; } set { _coachreview=value; lbScore.Text = _coachreview.stars.ToString(); lbDescription.Text = _coachreview.describe; } }
        public CoachReviewBox()
        {
            InitializeComponent();
        }
    }
}
