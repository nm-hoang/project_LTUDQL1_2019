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
    public partial class GV_ThongKeKQHocSinh : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_ThongKeKQHocSinh()
        {
            InitializeComponent();
        }

        private void GV_ThongKeKQHocSinh_Load(object sender, EventArgs e)
        {
            var kithi = from kt in db.KyThis
                        select kt.ID;
            cbMaKyThi.DataSource = kithi;
        }

        private void cbMaKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = from kq in db.KetQuaThis
                         join hs in db.HocSinhs on kq.MaHS equals hs.MaHS
                         where kq.KyThi == cbMaKyThi.Text
                         select new {hs.MaHS,hs.HoTen,hs.MaLop,hs.MaKhoi,hs.NgaySinh,kq.DiemThi};

            dgv.DataSource = result;
            var tendethi = (from i in db.DeThis
                             join j in db.KyThis on i.ID equals j.MaDe
                             where cbMaKyThi.Text == j.ID
                             select i.TenDeThi).SingleOrDefault();
            lblTenDeThi.Text = tendethi.ToString();
            var kithi = (from i in db.KyThis
                         where i.ID == cbMaKyThi.Text
                         select i).SingleOrDefault();
            var tenmonhoc = (from i in db.DeThis
                             join j in db.MonHocs on i.MaMH equals j.MaMH
                             where kithi.MaDe == i.ID
                             select j.TenMH).SingleOrDefault();
            lblMonHoc.Text = tenmonhoc.ToString();
        }

        private void lblMonHoc_Click(object sender, EventArgs e)
        {

        }
    }
}
