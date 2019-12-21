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
    public partial class frmHS_LichThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string UserName;
        public frmHS_LichThi(string username)
        {
            InitializeComponent();
            UserName = username;
        }
        private void XemLichThiThu()
        {
            var hs = (from h in db.TaiKhoans 
                      where h.ID_Account == UserName
                      select h.ID_User).SingleOrDefault();

            var result = from k in db.KyThiThus
                         join dshs in db.DSHocSinhs on k.ID equals dshs.MaKiThi
                         where dshs.MaHS == hs
                         select new { k.ID, k.NgayThi };
            dgvThiThu.DataSource = result;
        }
        private void ThiThat()
        {
            var hs = (from h in db.TaiKhoans
                      where h.ID_Account == UserName
                      select h.ID_User).SingleOrDefault();

            var result = from k in db.KyThis
                         join dshs in db.DSHocSinhs on k.ID equals dshs.MaKiThi
                         where dshs.MaHS == hs
                         select new { k.ID, k.NgayThi };
            dgvThiThat.DataSource = result;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHS_LichThi_Load(object sender, EventArgs e)
        {
            ThiThat();
            XemLichThiThu();
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
           
        }
    }
}
