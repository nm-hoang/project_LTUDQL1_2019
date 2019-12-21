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


namespace project
{
    public partial class AD_FormND_CapNhat : Form
    {
        public AD_FormND_CapNhat(int ID, string ID_Account, string PassWord, string Type, string ID_User)
        {
            InitializeComponent();
            lbID.Text = ID.ToString();
            lbAccount.Text = ID_Account;
            txtPassWord.Text = PassWord;
            lbType.Text = Type;
            lbIDUser.Text = ID_User;
        }

        private void AD_FormND_CapNhat_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (CapNhatThongTin() == 1)
            {
                this.Close();
            }
        }
        public int CapNhatThongTin()
        {
            int i = 0;
            using (QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext())
            {
                TaiKhoan taikhoan = (from tk in db.TaiKhoans where tk.ID_Account == lbAccount.Text select tk).SingleOrDefault();
                taikhoan.PassWord = txtPassWord.Text;
                try
                {
                    db.SubmitChanges();
                    i = 1;
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    i = 0;
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return i;
        }
    }
}
