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
    public partial class GV_QLKyThiThu : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_QLKyThiThu()
        {
            InitializeComponent();
        }

        private void GV_QLKyThiThu_Load(object sender, EventArgs e)
        {

        }
        private void LoadKyThiThu()
        {
            List<string> kqThi = new List<string>();
            kqThi = (from k in db.KetQuaThiThus select k.KyThi).ToList();
            foreach (string idKQ in kqThi)
            {
                KyThiThu kt = (from k in db.KyThiThus
                            where k.ID == idKQ
                            select k).SingleOrDefault();
                if (kt.SuDung == false)
                {
                    kt.SuDung = true;
                    db.SubmitChanges();
                }
            }
            dgvKyThi.DataSource = (from kt in db.KyThiThus
                                   select new { kt.ID, kt.NgayThi, kt.MaDe, kt.SuDung });


        }
    }
}
