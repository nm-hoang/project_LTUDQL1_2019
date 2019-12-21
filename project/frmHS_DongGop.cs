using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Using 
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace project
{
    public partial class frmHS_DongGop : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string UserName;
        public frmHS_DongGop(string username)
        {
            InitializeComponent();
            UserName = username;
        }
        private string LayTenMH(string MaMH)
        {
            return ( from mh in db.MonHocs 
                     where mh.MaMH==cbTenMonHoc.Text
                     select mh.TenMH).SingleOrDefault();
        }
        private void LayMaMH()
        {
            var result = from mh in db.MonHocs select mh.MaMH;
            cbTenMonHoc.DataSource = result;
        }
        private string LayMaLop()
        {
            string hs = (from h in db.HocSinhs
                         join t in db.TaiKhoans on h.MaHS equals t.ID_User
                         where t.ID_Account == UserName
                         select h.MaLop).SingleOrDefault();
            return hs;

        }
        private string LayMaHS()
        {
            string hs = (from h in db.HocSinhs
                         join t in db.TaiKhoans on h.MaHS equals t.ID_User
                         where t.ID_Account == UserName
                         select h.MaHS).SingleOrDefault();
            return hs;
        }
        private string LayKhoiHS()
        {
            string hs = (from h in db.HocSinhs
                         join t in db.TaiKhoans on h.MaHS equals t.ID_User
                         where t.ID_Account == UserName
                         select h.MaKhoi).SingleOrDefault().ToString();
            return hs;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHS_DongGop_Load(object sender, EventArgs e)
        {
            LayMaMH();
        }
        //Lấy cấp độ và đáp án đúng
        private string radioBTN(String result, Panel pn)
        {
            string x=null;
            RadioButton check = null;
            foreach (RadioButton item in pn.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        check = item;
                    }
                }
            }
            if (check != null)
            {
                x = check.Text;
            }             
          return x;
        }
        string DapAnDung,DoKho;
        private void btnDongGop_Click(object sender, EventArgs e)
        {
           
            if(KT())
            {
                    CauHoiDongGop donggop = new CauHoiDongGop();
                    donggop.IDHS = LayMaHS();
                    donggop.CauHoi = txtCauHoi.Text;
                    donggop.DapAn_A = txtCauA.Text;
                    donggop.DapAn_B = txtCauB.Text;
                    donggop.DapAn_C = txtCauC.Text;
                    donggop.DapAn_D = txtCauD.Text;
                    donggop.KetQua = radioBTN(DapAnDung, panelDapAnDung);
                    donggop.Khoi = int.Parse(LayKhoiHS());
                    donggop.Duyet = bool.Parse("false");
                    donggop.DoKho = radioBTN(DoKho, panelCapDo);
                    donggop.MaMH = cbTenMonHoc.Text;
                    db.CauHoiDongGops.InsertOnSubmit(donggop);
                    db.SubmitChanges();
                    MessageBox.Show("Đóng góp thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtCauHoi.Clear();
                    txtCauA.Clear();
                    txtCauB.Clear();
                    txtCauC.Clear();
                    txtCauD.Clear();

            }
        }
        public bool KT()
        {
           
            if(string.IsNullOrWhiteSpace(txtCauHoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập câu hỏi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCauHoi.Focus();
                return false;

            }
            if(string.IsNullOrWhiteSpace(txtCauA.Text))
            {
                MessageBox.Show("Bạn chưa nhập câu A", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCauA.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCauB.Text))
            {
                MessageBox.Show("Bạn chưa nhập câu B", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCauB.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCauC.Text))
            {
                MessageBox.Show("Bạn chưa nhập câu C", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCauC.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCauD.Text))
            {
                MessageBox.Show("Bạn chưa nhập câu D", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCauD.Focus();
                return false;
            }
            if (radioBTN(DapAnDung, panelDapAnDung) == null || radioBTN(DoKho, panelCapDo) == null)
            {
                MessageBox.Show("Bạn chưa chọn đáp án đúng hoặc cấp độ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void cbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenMH.Text = LayTenMH(cbTenMonHoc.Text);
        }

        private void btnXemDuyet_Click(object sender, EventArgs e)
        {
            frmHS_CauHoiDaDuyet frm = new frmHS_CauHoiDaDuyet(UserName);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnChuaDuyet_Click(object sender, EventArgs e)
        {
            frmHS_CauHoiChuaDuyet frm = new frmHS_CauHoiChuaDuyet(UserName);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            frm.ShowDialog();
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
