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
                        where ds.ID_Account == MaHS orderby kt.MaDe
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
        private void btnLamBai_Click(object sender, EventArgs e)
        {
            if (cbMaKiThi.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa được giáo viên cho thi thử", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
