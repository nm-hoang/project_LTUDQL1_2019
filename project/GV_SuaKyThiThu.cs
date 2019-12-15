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
    public partial class GV_SuaKyThiThu : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_SuaKyThiThu()
        {
            InitializeComponent();
        }

        private void GV_SuaKyThiThu_Load(object sender, EventArgs e)
        {
            cbMaDe.DataSource = (from md in db.DeThis select md.ID);
            cbMaDe.Text = (from md in db.KyThiThus
                           where md.ID == txtID.Text
                           select md.MaDe).SingleOrDefault().ToString();

            LoadThiSinh();
            ReloadKyThi();
            txtID.Enabled = false;
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

        private void LoadThiSinh()
        {
            dgvHocSinh.DataSource = (from hs in db.HocSinhs
                                     select new
                                     {
                                         hs.MaHS,
                                         hs.HoTen,
                                         hs.MaLop,
                                         hs.MaKhoi
                                     });
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            KyThiThu kt = (from k in db.KyThiThus
                        where k.ID == txtID.Text
                        select k).SingleOrDefault();

            kt.MaDe = int.Parse(cbMaDe.SelectedValue.ToString());
            kt.NgayThi = dtpDate.Text;

            try
            {
                db.SubmitChanges();
                this.Close();
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }
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

        private void cbMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbMaDe.SelectedValue.ToString();
            lblName.Text = (from md in db.DeThis
                            where md.ID == int.Parse(id)
                            select md.TenDeThi).SingleOrDefault();
            db.SubmitChanges();
        }
    }
}
