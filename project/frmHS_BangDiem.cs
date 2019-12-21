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
    public partial class frmHS_BangDiem : Form
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string UserName;
        public frmHS_BangDiem(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void frmHS_BangDiem_Load(object sender, EventArgs e)
        {
            var hs = (from h in db.TaiKhoans
                      where h.ID_Account == UserName
                      select h.ID_User).SingleOrDefault();
            cryportBangDiem rp = new cryportBangDiem();
            rp.SetParameterValue("MaHS", hs);
            crytal_View_BangDiem.ReportSource = rp;
        }
    }
}
