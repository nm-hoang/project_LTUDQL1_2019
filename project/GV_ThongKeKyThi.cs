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
    public partial class GV_ThongKeKyThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_ThongKeKyThi()
        {
            InitializeComponent();
        }

      

        private void GV_ThongKeKyThi_Load(object sender, EventArgs e)
        {
            List<string> temp = new List<string> { "Kỳ thi", "Kỳ thi thử/ Ôn tập"};
            cbKyThi.DataSource = temp;


        }

        private void cbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKyThi.Text == "Kỳ thi thử/ Ôn tập")
            {
                dgvKyThi.DataSource = (from k in db.KyThiThus select new { k.ID, k.NgayThi, k.MaDe });
                //  choose = 0;
           //     string KyThi = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();
            //    DiemThi = (from k in db.KetQuaThiThus where k.KyThi == KyThi select k.DiemThi).ToList();
            }
            if (cbKyThi.Text == "Kỳ thi")
            {
                dgvKyThi.DataSource = (from k in db.KyThis select new { k.ID, k.NgayThi, k.MaDe });
                //  choose = 1;

         ///       string KyThi = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();
                //  List<string> DiemThi = new List<string>();
            //    DiemThi = (from k in db.KetQuaThis where k.KyThi == KyThi select k.DiemThi).ToList();
            }
          
        }

        private void dgvKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int XuatSac = 0, Gioi = 0, Kha = 0, TB = 0, Yeu = 0, Kem = 0;
            List<string> DiemThi = new List<string>();
           string KyThi = dgvKyThi.CurrentRow.Cells["ID"].Value.ToString();
            if (cbKyThi.Text == "Kỳ thi thử/ Ôn tập")
            {
                DiemThi = (from k in db.KetQuaThiThus where k.KyThi == KyThi select k.DiemThi).ToList();
            }
            if (cbKyThi.Text == "Kỳ thi")
            {
                DiemThi = (from k in db.KetQuaThis where k.KyThi == KyThi select k.DiemThi).ToList();
            }
            foreach (string diem in DiemThi)
            {
                float a = float.Parse(diem);

                if (a >= 9)
                {
                    XuatSac++;
                }
                else if (a >= 8)
                {
                    Gioi++;
                }
                else if (a >= 6.5)
                {
                    Kha++;
                }
                else if (a >= 5)
                {
                    TB++;
                }
                else if (a >= 3)
                {
                    Yeu++;
                }
                else if (a < 3)
                {
                    Kem++;
                }

            }
                txtXuatSac.Text = XuatSac.ToString();
                txtGioi.Text = Gioi.ToString();
                txtKha.Text = Kha.ToString();
                txtTB.Text = TB.ToString();
                txtYeu.Text = Yeu.ToString();
                txtKem.Text = Kem.ToString();

        }
    }
}
