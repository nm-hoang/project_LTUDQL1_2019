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
    public partial class frmLogin : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        //Mã hóa pass
        public int Hashlen = 20; 
        static List<char> arrHex = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', };
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        public string LayPhanQuyen(string UserName) //Lấy phân quyền dựa vào IDUser
        {
            string result = (from user in db.TaiKhoans
                          where user.ID_Account == UserName 
                          select user.Type).SingleOrDefault();
            db.SubmitChanges();
            return result;
        }
        public bool KiemTraTaiKhoan(string UserName) //Kiểm tra tài khoản có trong hệ thống hay chưa
        {
            bool check = true;
            var result = (from user in db.TaiKhoans
                          where user.ID_Account == UserName
                          select user).SingleOrDefault();
            db.SubmitChanges();
            if (result == null)
            {
                check = false; //Chưa có tài khoản
            }
            return check;//Đã có tài khoản
        }
        public string LayPass(string UserName) //Lấy pass trong db
        {
            string result = (from user in db.TaiKhoans
                                 where user.ID_Account == UserName
                                 select user.PassWord).SingleOrDefault();
            db.SubmitChanges();
            return result;
        }
        public string MaHoaPass(string txtPass,string txtUserName) //Mã hóa pass vừa nhập
        {
            var strPassHash ="";
            if(txtUserName != null)
            {
                var strPass = txtPass;
                var sha1 = new SHA1CryptoServiceProvider();
                var arrByte = ASCIIEncoding.ASCII.GetBytes(strPass);
                var arrchar = txtUserName.ToCharArray();
                var arrbyte = new byte[txtUserName.Length / 2 - Hashlen];
                for (int i = Hashlen * 2, j = 0; i < arrchar.Length; i += 2)
                {
                    arrbyte[j++] = (byte)(arrHex.IndexOf(arrchar[i]) * 16 + arrHex.IndexOf(arrchar[i + 1]));
                }
                var arrPassSalt = new byte[arrByte.Length + arrbyte.Length];
                Array.Copy(arrByte, arrPassSalt, arrByte.Length);
                Array.Copy(arrbyte, 0, arrPassSalt, arrByte.Length, arrbyte.Length);

                var arrPassHash = sha1.ComputeHash(arrPassSalt);
                var arrPassSaltHash = new byte[arrPassHash.Length + arrbyte.Length];
                Array.Copy(arrPassHash, arrPassSaltHash, arrPassHash.Length);
                Array.Copy(arrbyte, 0, arrPassSaltHash, arrPassHash.Length, arrbyte.Length);
                strPassHash = BitConverter.ToString(arrPassSaltHash).Replace("-", "");
                return strPassHash;
            }
            return strPassHash;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            if(LayPhanQuyen(txtUserName.Text) == "HocSinh")
            {
                string Pass = MaHoaPass(txtPass.Text, LayPass(UserName));
                if (Pass != LayPass(UserName))
                {
                    MessageBox.Show("Mật khau bị sai");
                }
                else
                {
                        MessageBox.Show("Hoc sinh đăng nhập");
                }
            }
            else if (KiemTraTaiKhoan(UserName) == false)
            {
                MessageBox.Show("Chưa dang ki");
            }
            else if (LayPhanQuyen(UserName) == "GiaoVien")
            {
                if(LayPass(UserName) != txtPass.Text)
                {
                    MessageBox.Show("Mat khau bị sai");
                }
                else
                {
                    MessageBox.Show("GiaoVien dang nhap");
                }
            }
            else if(LayPhanQuyen(UserName)=="Admin")
            {
                if (LayPass(UserName) != txtPass.Text)
                {
                    MessageBox.Show("Mat khau bị sai");
                }
                else
                {
                    FormAdmin frm = new FormAdmin(UserName);
                    frm.FormClosed += new FormClosedEventHandler(form_FormClosed);
                    frm.ShowDialog(); 
                    //MessageBox.Show("Admin dang nhap");
                }
            }
           
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
