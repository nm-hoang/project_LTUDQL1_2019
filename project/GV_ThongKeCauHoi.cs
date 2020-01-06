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
    public partial class GV_ThongKeCauHoi : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_ThongKeCauHoi()
        {
            InitializeComponent();
        }

        private void GV_ThongKeCauHoi_Load(object sender, EventArgs e)
        {
            var kithi = from kt in db.KyThis
                        select kt.ID;
            cbMaKyThi.DataSource = kithi;
        }

        private void cbMaKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var laymade = (from i in db.KyThis
                          where i.ID == cbMaKyThi.Text
                          select i).SingleOrDefault();
            var laymadech = (from i in db.DanhSachCauHois
                             where i.MaDe == laymade.MaDe
                             select i.MaDe).Distinct();
            var laycauhoi = from i in db.CauHois
                            join j in db.DanhSachCauHois on i.ID equals j.ID_Cauhoi
                            where j.MaDe == laymade.MaDe
                            select new {  i.ID,i.CauHoi1,i.Khoi,i.DoKho,i.MaMH};

            dgv.DataSource = laycauhoi;
            
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            string makithi = cbMaKyThi.Text;
            GV_INThongKeCauHoi frm = new GV_INThongKeCauHoi(makithi);
            frm.ShowDialog();
        }
    }
}
