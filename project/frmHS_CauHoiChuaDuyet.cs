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
    public partial class frmHS_CauHoiChuaDuyet : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string UserName;
        public frmHS_CauHoiChuaDuyet(string username)
        {
            UserName = username;
            InitializeComponent();
        }

        private void frmHS_CauHoiChuaDuyet_Load(object sender, EventArgs e)
        {
            //Lấy Mã học sinh
            var MaHS = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == UserName
                      select h.MaHS).SingleOrDefault();

            var result = from ch in db.CauHoiDongGops
                            where ch.IDHS.CompareTo(MaHS) == 0
                            select new { ch.IDHS, ch.CauHoi, ch.DapAn_A, ch.DapAn_B,ch.DapAn_C,ch.DapAn_D,ch.KetQua,ch.DoKho,ch.MaMH};
            dgv.DataSource = result;

        }
    }
}
