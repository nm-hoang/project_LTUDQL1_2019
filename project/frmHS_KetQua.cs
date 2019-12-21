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
    public partial class frmHS_KetQua : Form
    {
        public string username;
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public frmHS_KetQua(string UserName)
        {
            InitializeComponent();
            username = UserName;
        }
        //Lấy mã học sinh
        public void ThongTinThiThat()
        {

            var hs = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == username
                      select h).SingleOrDefault();
            var result = from kq in db.KetQuaThis
                         where kq.MaHS == hs.MaHS
                         select new { kq.ID, kq.MaHS, kq.SoCauDung, kq.SoCauSai, kq.DiemThi, kq.NgayThi, kq.KyThi,kq.TenMH };
            dgvThiThat.DataSource = result;

        }
        public void ThongTinThu()
        {

            var hs = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == username
                      select h).SingleOrDefault();
            var result = from kq in db.KetQuaThiThus
                         where kq.MaHS == hs.MaHS
                         select new { kq.ID, kq.MaHS, kq.SoCauDung, kq.SoCauSai, kq.DiemThi, kq.NgayThi, kq.KyThi,kq.TenMH };
            dgvThiThu.DataSource = result;

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHS_KetQua_Load(object sender, EventArgs e)
        {
            ThongTinThiThat();
            ThongTinThu();
        }

        private void dgvThiThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThiThat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
