using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using 
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace project
{
    public partial class frmHS_ThongTinSinhVien : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public string username;
        public frmHS_ThongTinSinhVien(string UserName)
        {
            InitializeComponent();
            username = UserName;
        }
        private void ThongTin()
        {
            var hs = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == username
                      select h).SingleOrDefault();
            lblMaHS.Text = hs.MaHS;
            lblHoTen.Text = hs.HoTen;
            lblSdt.Text = hs.DienThoai;
            lblKhoi.Text = hs.MaKhoi.ToString();
            lblLop.Text = hs.MaLop;
            lblNgaySinh.Text = hs.NgaySinh;
        }

        private void frmHS_ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            ThongTin();
        }
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            string MaLop, MaKhoi;
            MaLop = lblLop.Text;
            MaKhoi = lblKhoi.Text;

            frmHS_SuaThongTin frm = new frmHS_SuaThongTin(username, MaLop, MaKhoi);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            frm.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {

            frmHS_KetQua frm = new frmHS_KetQua(username);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            frmHS_LichThi frm = new frmHS_LichThi(username);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            frm.ShowDialog();
        }

        private void gbThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void btnInBangDiem_Click(object sender, EventArgs e)
        {
            frmHS_BangDiem frm = new frmHS_BangDiem(username);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            frm.ShowDialog();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
