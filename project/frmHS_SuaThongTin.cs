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
using System.Globalization; //datetime picker
namespace project
{
    public partial class frmHS_SuaThongTin : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string username;
        string Lop;
        string Khoi;
        public frmHS_SuaThongTin(string UserName,string MaLop,string MaKhoi)
        {
            InitializeComponent();
            username = UserName;
            Lop = MaLop;
            Khoi = MaKhoi;
        }
        //Hiển thị thông tin
        private void ThongTin()
        {
            var hs = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == username
                      select h).SingleOrDefault();
            txtHoTen.Text = hs.HoTen;
            dtNgaySinh.Value = DateTime.ParseExact(hs.NgaySinh, "dd/M/yyyy", CultureInfo.InvariantCulture);
            txtSDT.Text = hs.DienThoai;
        }
        //Sửa thông tin
        private void SuaThongTin()
        {
            HocSinh hs = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == username
                      select h).SingleOrDefault();
            hs.HoTen = txtHoTen.Text;
            hs.NgaySinh = dtNgaySinh.Text;
            hs.DienThoai = txtSDT.Text;
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thông tin thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmHS_SuaThongTin_Load(object sender, EventArgs e)
        {
            ThongTin();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTin();
            Visible = false;
            frmHS_ThongTinSinhVien frm = new frmHS_ThongTinSinhVien(username);
           // frm.Activate();
            frm.ShowDialog();
        }
    }
}
