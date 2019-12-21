using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLCauHoi_Click(object sender, EventArgs e)
        {
            GV_QLCauHoi frm = new GV_QLCauHoi();
            frm.ShowDialog();
        }

        private void btnQLDeThi_Click(object sender, EventArgs e)
        {
            GV_QLDeThi frm = new GV_QLDeThi();
            frm.ShowDialog();
        }

        private void btnQLKyThi_Click(object sender, EventArgs e)
        {
            GV_QLKyThi frm = new GV_QLKyThi();
            frm.Show();
        }

        private void btnQLHocSinh_Click(object sender, EventArgs e)
        {
            GV_QLHocSinh frm = new GV_QLHocSinh();
            frm.ShowDialog();
        }

        private void btnQLKyThiThu_Click(object sender, EventArgs e)
        {
            GV_QLKyThiThu frm = new GV_QLKyThiThu();
            frm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
