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
    public partial class GV_QLHocSinh : Form
    {
        public GV_QLHocSinh()
        {
            InitializeComponent();
        }

        private void btnKyThi_Click(object sender, EventArgs e)
        {
            GV_ThongKeKyThi frm = new GV_ThongKeKyThi();
            frm.Show();
        }

        private void GV_QLHocSinh_Load(object sender, EventArgs e)
        {

        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            GV_ThongKeKQHocSinh frm = new GV_ThongKeKQHocSinh();
            frm.ShowDialog();
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            GV_ThongKeCauHoi frm = new GV_ThongKeCauHoi();
            frm.ShowDialog();
        }
    }
}
