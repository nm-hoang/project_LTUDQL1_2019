using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace project
{
    public partial class AD_FormND_Them : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public AD_FormND_Them()
        {
            InitializeComponent();
            List<String> type = new List<string>
            {
                "HocSinh", "GiaoVien", "Admin"
            };
            cbType.DataSource = type;     
        }
        public bool CheckAccount(string ID_User)
        {
            bool i = true;
            var IDAccount = (from tk in db.TaiKhoans where tk.ID_User == ID_User select tk.ID_Account).SingleOrDefault();
            if (IDAccount != null)
            {
                i = false;
            }
            db.SubmitChanges();
            return i;
        }

        public int ThemNguoiDung()
        {
            int i = 0;
            var tk = new TaiKhoan();
            tk.ID_Account = txtAccount.Text;
            tk.PassWord = txtPassWord.Text;
            try
            {
                tk.Type = cbType.SelectedItem.ToString();
                tk.ID_User = cbIDUser.SelectedItem.ToString();
                db.TaiKhoans.InsertOnSubmit(tk);
                try
                {
                    db.SubmitChanges();
                    i = 1;
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    i = 0;
                    MessageBox.Show("Thêm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loại người dùng hoặc ID người dùng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            return i;
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(txtAccount.Text) || !regexItem.IsMatch(txtPassWord.Text)) // check ki tu dac biet
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu có chứa kí tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAccount.Text.Any(Char.IsWhiteSpace) || txtPassWord.Text.Any(Char.IsWhiteSpace))  // check khoang trang
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu có chứa khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAccount.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CheckAccount(cbIDUser.Text) == false)
            {
                MessageBox.Show("Người dùng này đã có tài khoản rồi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                if (ThemNguoiDung() == 1)
                {
                    this.Close();
                }
        }
        public string TenNguoiDung(string ID_User)
        {
            string name = "";
            if (cbType.Text == "HocSinh")
            {
               
                name = (from hs in db.HocSinhs where hs.MaHS == ID_User select hs.HoTen).SingleOrDefault();
                db.SubmitChanges();
               
            }
            else if (cbType.Text == "GiaoVien")
            {
               
                name = (from gv in db.GiaoViens where gv.MaGV == ID_User select gv.HoTen).SingleOrDefault();
                db.SubmitChanges();
               
            }
            else if (cbType.Text == "Admin")
            {
               
                name = (from ad in db.Admins where ad.ID == ID_User select ad.HoTen).SingleOrDefault();
                db.SubmitChanges();
               
            }
            return name;
        }

        private void cbIDUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDUser.Text != "")
            {
                lbName.Text = TenNguoiDung(cbIDUser.Text);
            }
            string ID_User = cbIDUser.SelectedItem.ToString();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbType.Text == "HocSinh")
                {
                    cbIDUser.DataSource = (from hs in db.HocSinhs select hs.MaHS);
                    lbName.Text = (from u in db.HocSinhs where u.MaHS == cbIDUser.SelectedValue.ToString() select u.HoTen).SingleOrDefault();
                    db.SubmitChanges();
                }
                else if (cbType.Text == "GiaoVien")
                {
                    cbIDUser.DataSource = (from gv in db.GiaoViens select gv.MaGV);
                    lbName.Text = (from u in db.GiaoViens where u.MaGV == cbIDUser.SelectedValue.ToString() select u.HoTen).SingleOrDefault();
                    db.SubmitChanges();
                }
                else if (cbType.Text == "Admin")
                {
                    cbIDUser.DataSource = (from ad in db.Admins select ad.ID);
                    lbName.Text = (from u in db.Admins where u.ID == cbIDUser.SelectedValue.ToString() select u.HoTen).SingleOrDefault();
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa có mã người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }

    
}
