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
    public partial class GV_QLKyThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_QLKyThi()
        {
            InitializeComponent();
        }

        private void GV_QLKyThi_Load(object sender, EventArgs e)
        {
            LoadKyThi();
        }
        private void LoadKyThi()
        {
            List<string> kqThi = new List<string>();
            kqThi = (from k in db.KetQuaThis select k.KyThi).ToList();
            foreach (string idKQ in kqThi)
            {
                KyThi kt = (from k in db.KyThis
                            where k.ID == idKQ
                            select k).SingleOrDefault();
                try
                {
                    if (kt.SuDung == false)
                    {
                        kt.SuDung = true;
                        db.SubmitChanges();
                    }
                }
                catch
                {

                }
                
            }
            dgvKyThi.DataSource = (from kt in db.KyThis
                                   select new { kt.ID, kt.NgayThi, kt.MaDe, kt.SuDung });


        }

        private void dgvKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();

            dgvThiSinh.DataSource = (from ts in db.DSHocSinhs
                                     where ts.MaKiThi == id
                                     select new { ts.MaKiThi, ts.MaHS, ts.ID_Account });
            db.SubmitChanges();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            GV_TaoKyThi frm = new GV_TaoKyThi();
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKyThi();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GV_SuaKyThi frm = new GV_SuaKyThi();
            frm.txtID.Text = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();
            frm.dtpDate.Text = dgvKyThi.CurrentRow.Cells["NgayThi"].Value.ToString();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();

            KyThi kt = (from k in db.KyThis
                        where k.ID == id
                        select k).SingleOrDefault();

            db.KyThis.DeleteOnSubmit(kt);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Xóa kỳ thi thành công");
                LoadKyThi();
                dgvThiSinh.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa kỳ thi ");
            }
        }

        private void btnDSTS_Click(object sender, EventArgs e)
        {
            GV_InDSTS frm = new GV_InDSTS();
            frm.ShowDialog();
        }
    }
}
