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
    public partial class GV_SuaCauHoi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public GV_SuaCauHoi()
        {
            InitializeComponent();
        }

        private void GV_SuaCauHoi_Load(object sender, EventArgs e)
        {
            cbKhoi.DataSource = (from k in db.KhoiLops select k.MaKhoi);

        }

    }
}
