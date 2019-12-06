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
    public partial class frmHocSinh : Form
    {
        public string username;
        public frmHocSinh(string UserName)
        {
            InitializeComponent();
            username = UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        //button thông tin sinh viên
        private void btnTTSV_Click(object sender, EventArgs e)
        {
            frmHS_ThongTinSinhVien frmThongTin = new frmHS_ThongTinSinhVien(username);
            frmThongTin.FormClosed += new FormClosedEventHandler(frmThongTin_FormClosed);
            frmThongTin.ShowDialog();
        }
        private void frmThongTin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
