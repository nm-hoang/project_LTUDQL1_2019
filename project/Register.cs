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
    public partial class frmRegister : Form
    {
        public QLThiTracNghiemDataContext db =  new QLThiTracNghiemDataContext();
        public TaiKhoan tk = new TaiKhoan();
        public frmRegister()
        {
            InitializeComponent();
            txtUserName.Validating += txtUserName_Validating;
            txtPass.Validating += txtPass_Validating;
            txtRePass.Validating += txtRePass_Validating;
        }

        void txtRePass_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as Control;
            var StrInput = control.Text;
            var reStr = @"^[a-zA-Z_0-9]{3,}$";
            var re = new Regex(reStr);
            if (!re.IsMatch(StrInput))
            {
                MessageBox.Show("Password a-z, 0-9 và tối thiểu 3 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRePass.Clear();
                txtRePass.Focus();
            }
        }

        void txtPass_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as Control;
            var StrInput = control.Text;
            var reStr = @"^[a-zA-Z_0-9]{3,}$";
            var re = new Regex(reStr);
            if (!re.IsMatch(StrInput))
            {
                MessageBox.Show("Password a-z, 0-9 và tối thiểu 3 kí tự","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtPass.Clear();
                txtPass.Focus();
            }

        }

        void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as Control;
            var StrInput = control.Text;
            var reStr = @"^[a-z_0-9]+$";
            var re = new Regex(reStr);
            if(!re.IsMatch(StrInput))
            {
                MessageBox.Show("Không nhập kí tự hoa, khoảng trắng và kí tự đặc biệt","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtUserName.Focus();
            }
        }
        public string LayTen(string MaHS)
        {
            return (from hs in db.HocSinhs
                    where hs.MaHS == MaHS
                    select hs.HoTen).SingleOrDefault();
        }

        private void cbMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblName.Text = LayTen(cbMaHS.Text);
        }
        public void LoadDSHS()
        {
            var result =  from hs in db.HocSinhs
		                   select hs.MaHS;
            cbMaHS.DataSource = result;
        }
        public bool KiemTraUser(string MaHS)
        {
            bool check = true;
            var result = (from user in db.TaiKhoans
                          where user.ID_User == MaHS
                          select user.ID_User).SingleOrDefault();
            db.SubmitChanges();
            if (result == null)
            {
                check = false; //Chưa có tài khoản
            }
                return check;//Đã có tài khoản
        }
        public int DangKy(string UserName, string Pass, string Type, string IDUser)
        {
            int temp = 0;
            tk = new TaiKhoan();
            tk.ID_Account = UserName;
            tk.PassWord = Pass;
            tk.Type = Type;
            tk.ID_User = IDUser;
            db.TaiKhoans.InsertOnSubmit(tk);
            try
            {
                db.SubmitChanges();
                temp = 1;
            }
            catch
            {
                temp = 0;
            }
            return temp;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadDSHS();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string  MaHS = cbMaHS.SelectedItem.ToString();
            string UserName = txtUserName.Text;
            string Pass = txtPass.Text;
            //Mã hóa Pass
            var sha1 = new SHA1CryptoServiceProvider();
            var arrBytePass = ASCIIEncoding.ASCII.GetBytes(Pass);
            var strTimeNow = DateTime.Now.Millisecond.ToString();
            var arrTimeNow = ASCIIEncoding.ASCII.GetBytes(strTimeNow);
            var arrPassSalt = new byte[arrBytePass.Length + arrTimeNow.Length];
            Array.Copy(arrBytePass, arrPassSalt, arrBytePass.Length);
            Array.Copy(arrTimeNow, 0, arrPassSalt, arrBytePass.Length, arrTimeNow.Length);

            var arrPassHash = sha1.ComputeHash(arrPassSalt);
            var arrPassSaltHash = new byte[arrPassHash.Length + arrTimeNow.Length];
            Array.Copy(arrPassHash, arrPassSaltHash, arrPassHash.Length);
            Array.Copy(arrTimeNow, 0, arrPassSaltHash, arrPassHash.Length, arrTimeNow.Length);
            var strPassHash = BitConverter.ToString(arrPassSaltHash).Replace("-", "");
            //
            string RePass = txtRePass.Text;
            string Type = "HocSinh";
            if(Pass !=  RePass)
            {
                MessageBox.Show("Mật khẩu không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(KiemTraUser(MaHS) == true)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (DangKy(UserName, strPassHash, Type, MaHS) == 1)
                {
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Đăng kí thất bại. Tài khoản đã có người đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
