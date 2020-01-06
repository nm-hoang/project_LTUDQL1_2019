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
    public partial class GV_INThongKeCauHoi : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string MaKiThi;
        public GV_INThongKeCauHoi(string makithi)
        {
            InitializeComponent();
            MaKiThi = makithi;
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
        public void LoadReport()
        {
            SqlConnection cn = getconnect();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_INThongKeCauHoi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.Add(new SqlParameter("@ID", MaKiThi));

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập báo cáo

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Focus\Desktop\project_LTUDQL1_2019\project\rptThongKeCauHoi.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            //Gán lên mẫu báo cáo
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void GV_INThongKeCauHoi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            LoadReport();
        }
    }
}
