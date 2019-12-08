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
        private void LayTenMH()
        {
            var result = from mh in db.MonHocs select mh.TenMH;
            cbTenMonHoc.DataSource = result;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHS_DongGop_Load(object sender, EventArgs e)
        {
            LayTenMH();
        }
    }
}
