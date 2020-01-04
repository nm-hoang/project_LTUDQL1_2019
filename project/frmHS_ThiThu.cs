using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace project
{
    public partial class frmHS_ThiThu : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string UserName;
        public frmHS_ThiThu(string username)
        {
            InitializeComponent();
            UserName = username;
        }
        private  string LayMaHS()
        {
                return  (from h in db.HocSinhs
                        join t in db.TaiKhoans on h.MaHS equals t.ID_User
                        where t.ID_Account == UserName
                        select h.MaHS).SingleOrDefault();
        }
        private void LayMaKiThi()
        {
            //Lấy Mã học sinh
            var MaHS = (from h in db.HocSinhs
                        join t in db.TaiKhoans on h.MaHS equals t.ID_User
                        where t.ID_Account == UserName
                        select h.MaHS).SingleOrDefault();
            var MADE = (from kt in db.KyThiThus
                        join ds in db.DSHocSinhs on kt.ID equals ds.MaKiThi
                        where ds.MaHS == MaHS orderby kt.MaDe
                        select ds.MaKiThi).Distinct();
            cbMaKiThi.DataSource = MADE;

        }
        private string LayMaDe()
        {
                return  (from u in db.KyThiThus
                        where u.ID == cbMaKiThi.Text.ToString()
                        select u.MaDe).SingleOrDefault().ToString();
        }
        private void LayTenMonHoc()
        {
                var made = (from u in db.KyThiThus
                            where u.ID == cbMaKiThi.Text.ToString()
                            select u.MaDe).SingleOrDefault().ToString();
                var mh = (from u in db.MonHocs
                          join t in db.DeThis on u.MaMH equals t.MaMH
                          where t.ID.ToString() == made
                          select new { u.TenMH }).SingleOrDefault();
                lblTenMH.Text = mh.TenMH;
        }

        private void cbMaKiThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayTenMonHoc();
        }
        private void frmHS_ThiThu_Load(object sender, EventArgs e)
        {
            LayMaKiThi();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LayMaK()
        {

        }
        private int DemSoLanThi()
        {
            var result = (from i in db.KetQuaThiThus
                          where cbMaKiThi.Text.ToString() == i.KyThi
                          select i.KyThi).Count();
            return result;
        }
        private void btnLamBai_Click(object sender, EventArgs e)
        {
            string NgayThi1 = (from kt in db.KyThiThus
                               where kt.ID == cbMaKiThi.Text
                               select kt.NgayThi).SingleOrDefault().ToString();
            string Ngayhientai1 = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime NgayThi = DateTime.ParseExact(NgayThi1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime NgayHienTai = DateTime.ParseExact(Ngayhientai1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TimeSpan tinhngay = NgayHienTai - NgayThi;
            int resultTinhNgay = tinhngay.Days;
            if (cbMaKiThi.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa có kì thi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Controls.Clear();
                panel2.Visible = true;

            }
            else if (resultTinhNgay > 0)
            {
                MessageBox.Show("Đã qua ngày thi " + NgayThi1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Controls.Clear();
                panel2.Visible = true;
            }
            else if (resultTinhNgay < 0)
            {
                MessageBox.Show("Chưa tới ngày thi " + NgayThi1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Controls.Clear();
                panel2.Visible = true;
            }
            else if (DemSoLanThi() != 0)
            {
                MessageBox.Show("Bạn đã thi kì thi này rồi" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Controls.Clear();
                panel2.Visible = true;
            }
            else
            {
                string mahs,made,makithi, tenmh;
                mahs = LayMaHS();
                made = LayMaDe();
                makithi = cbMaKiThi.Text;
                tenmh = lblTenMH.Text;
                frmHS_LamBaiThiThu frm = new frmHS_LamBaiThiThu(mahs,made,makithi,tenmh);
                //frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                //this.Hide();
                //frm.ShowDialog();
                frm.TopLevel = false;
                panel2.Controls.Clear();
                panel2.Controls.Add(frm);
                frm.Show();
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
