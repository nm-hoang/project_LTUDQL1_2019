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
    public partial class GV_ChiTietCauHoi : Form
    {
        public int IDCauHoi;
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_ChiTietCauHoi(string idcauhoi)
        {
            InitializeComponent();
            IDCauHoi = int.Parse(idcauhoi);
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GV_ChiTietCauHoi_Load(object sender, EventArgs e)
        {

            var dethi = (from dt in db.DeThis
                         from dsch in db.DanhSachCauHois
                         from ch in db.CauHois
                         from  mh in db.MonHocs
                         from kl in db.KhoiLops
                         where ch.ID == IDCauHoi && ch.ID == dsch.ID_Cauhoi &&  dsch.MaDe == dt.ID && dt.MaMH == mh.MaMH && dt.MaKhoi == kl.MaKhoi 
                         select new{
                             dt.ID,dt.TenDeThi,mh.MaMH, mh.TenMH,kl.MaKhoi, kl.TenKhoi
                         });
            dgvDetails.Rows.Clear();
            dgvDetails.DataSource = dethi;          
        }
    }
}
