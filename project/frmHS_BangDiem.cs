using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using
using System.Data.Linq;
using System.Linq.Expressions;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
namespace project
{
    public partial class frmHS_BangDiem : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string Username;
        public frmHS_BangDiem(string username)
        {
            InitializeComponent();
            Username = username;
        }
        public SqlConnection getconnect()
        {
            string DataSource = "DESKTOP-8GO2DH8";
            string Database = "QLThiTracNghiem";
            string UserName = "sa";
            string Pass = "ttth";
            string connString = @"Data Source=" + DataSource + ";Initial Catalog=" + Database + ";User ID=" + UserName + ";Password=" + Pass;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        private void frmHS_BangDiem_Load(object sender, EventArgs e)
        {
            var hs = (from h in db.HocSinhs
                      join t in db.TaiKhoans on h.MaHS equals t.ID_User
                      where t.ID_Account == Username
                      select h.MaHS).SingleOrDefault();
            SqlConnection cn = getconnect();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_BD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.Add(new SqlParameter("@MaHS",hs));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập báo cáo
            rptView.ProcessingMode = ProcessingMode.Local;
            rptView.LocalReport.ReportPath = @"C:\Users\Focus\Desktop\project_LTUDQL1_2019\project\rptBangDiem.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            //Gán lên mẫu báo cáo
            rptView.LocalReport.DataSources.Clear();
            rptView.LocalReport.DataSources.Add(rds);
            rptView.RefreshReport();
        }
    }
}
