using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class GV_InDSTS : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_InDSTS()
        {
            InitializeComponent();
        }
        private void GV_InDSTS_Load(object sender, EventArgs e)
        {
            var result = from i in db.KyThis
                         select i.ID;
            cbMaKyThi.DataSource = result;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            cryportDanhSachTS rp = new cryportDanhSachTS();
            rp.SetParameterValue("ID", cbMaKyThi.Text);
            crystalReportViewer.ReportSource = rp;
        }
    }
}
