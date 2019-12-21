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
    public partial class GV_TaoKyThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_TaoKyThi()
        {
            InitializeComponent();
        }

        private void GV_TaoKyThi_Load(object sender, EventArgs e)
        {
            HideInsert();
            cbMaDe.DataSource = (from d in db.DeThis select d.ID);
        }
        private void HideInsert()
        {
            btnAdd.Hide();
            dgvHocSinh.Hide();
            dgvKyThi.Hide();
            lblDS.Hide();
            btnDelete.Hide();
            btnSave.Hide();
        }

        private void ShowInsertStudent()
        {
            dgvHocSinh.Show();
            dgvKyThi.Show();
            lblDS.Show();
            btnAdd.Show();
            btnDelete.Show();
            btnSave.Show();
            dgvHocSinh.DataSource = (from hs in db.HocSinhs
                                     select new
                                     {
                                         hs.MaHS,
                                         hs.HoTen,
                                         hs.MaLop,
                                         hs.MaKhoi
                                     });

        }
        private void DisableInfo()
        {
            txtID.Enabled = false;
            dtpDate.Enabled = false;
            cbMaDe.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            var check = (from kt in db.KyThis
                         where kt.ID == id
                         select kt).SingleOrDefault();
            if (check == null)
            {
                KyThi kt = new KyThi();
                kt.ID = id;
                kt.NgayThi = dtpDate.Text.ToString();
                kt.MaDe = int.Parse(cbMaDe.SelectedValue.ToString());
                kt.SuDung = false;

                db.KyThis.InsertOnSubmit(kt);

                try
                {
                    db.SubmitChanges();
                    ShowInsertStudent();
                    MessageBox.Show("Thêm kỳ thi thành công");
                    DisableInfo();
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm kỳ thi vào database");
                }

            }
            else
            {
                MessageBox.Show("Đã tồn tại id kỳ thi trong database");
            }
        }

        private void cbMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbMaDe.SelectedValue.ToString();
            lblName.Text = (from md in db.DeThis
                            where md.ID == int.Parse(id)
                            select md.TenDeThi).SingleOrDefault();
            db.SubmitChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maHS = dgvHocSinh.CurrentRow.Cells["MaHS"].Value.ToString();
            string maKythi = txtID.Text;
            var check = (from hs in db.DSHocSinhs
                         where hs.MaHS == maHS && hs.MaKiThi == maKythi
                         select hs).SingleOrDefault();
            if (check == null)
            {
                DSHocSinh hs = new DSHocSinh();
                hs.MaHS = maHS;
                hs.MaKiThi = txtID.Text;

                db.DSHocSinhs.InsertOnSubmit(hs);
                try
                {
                    db.SubmitChanges();
                    ReloadKyThi();
                }

                catch
                {
                    MessageBox.Show("Thêm học sinh thất bại");
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại thí sinh trong kỳ thi");
            }
        }
        private void ReloadKyThi()
        {
            dgvKyThi.DataSource = (from ds in db.DSHocSinhs
                                   where ds.MaKiThi == txtID.Text
                                   select new
                                   {
                                       ds.MaKiThi,
                                       ds.MaHS
                                   });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string maKT = txtID.Text;

            DSHocSinh hs = (from h in db.DSHocSinhs
                            where h.MaKiThi == dgvKyThi.CurrentRow.Cells["MaKiThi"].Value.ToString()
                                && h.MaHS == dgvKyThi.CurrentRow.Cells["MaHS2"].Value.ToString()
                            select h).SingleOrDefault();
            db.DSHocSinhs.DeleteOnSubmit(hs);
            try
            {
                db.SubmitChanges();
                ReloadKyThi();

            }
            catch
            {
                MessageBox.Show("Lỗi xóa thí sinh");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Lưu thành công");
        }

    }
}
