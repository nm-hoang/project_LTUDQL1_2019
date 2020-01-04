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
        }
    }
}
