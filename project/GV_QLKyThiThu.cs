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
    public partial class GV_QLKyThiThu : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_QLKyThiThu()
        {
            InitializeComponent();
        }

        private void GV_QLKyThiThu_Load(object sender, EventArgs e)
        {
            LoadKyThiThu();
        }
        private void LoadKyThiThu()
        {
            List<string> kqThi = new List<string>();
            kqThi = (from k in db.KetQuaThiThus select k.KyThi).ToList();
            foreach (string idKQ in kqThi)
            {
                KyThiThu kt = (from k in db.KyThiThus
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
            dgvKyThi.DataSource = (from kt in db.KyThiThus
                                   select new { kt.ID, kt.NgayThi, kt.MaDe, kt.SuDung });


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GV_TaoKyThiThu frm = new GV_TaoKyThiThu();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GV_SuaKyThiThu frm = new GV_SuaKyThiThu();
            frm.txtID.Text = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();
            frm.dtpDate.Text = dgvKyThi.CurrentRow.Cells["NgayThi"].Value.ToString();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();

            KyThiThu kt = (from k in db.KyThiThus
                           where k.ID == id
                           select k).SingleOrDefault();

            db.KyThiThus.DeleteOnSubmit(kt);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Xóa kỳ thi thành công");
                LoadKyThiThu();
                dgvThiSinh.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa kỳ thi ");
            }
        }

        private void dgvKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();

            dgvThiSinh.DataSource = (from ts in db.DSHocSinhs
                                     where ts.MaKiThi == id
                                     select new { ts.MaKiThi, ts.MaHS, ts.ID_Account });
            db.SubmitChanges();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKyThiThu();
        }
    }
}
