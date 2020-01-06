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
    public partial class GV_InThongKeKyThi : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string ID;
        string Type;
        public GV_InThongKeKyThi(string id,string type)
        {
            InitializeComponent();
            ID = id;
            Type = type;
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
        private void GV_InThongKeKyThi_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            this.reportViewer1.RefreshReport();
            
        }
        public void LoadThongKe()
        {
            SqlConnection cn = getconnect();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_InThongKeKyThi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.Parameters.Add(new SqlParameter("@type", Type));
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //Thiết lập báo cáo

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Focus\Desktop\project_LTUDQL1_2019\project\rptThongKeKyThi.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            //Gán lên mẫu báo cáo
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
