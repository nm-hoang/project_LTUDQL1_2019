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
    public partial class GV_QLCauHoi : Form
    {
         QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public GV_QLCauHoi()
        {
            InitializeComponent();
        }

        private void GV_QLCauHoi_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        public void LoadQuestions()
        {
            dgvCauHoi.Rows.Clear();
            dgvCauHoi.DataSource = (from ch in db.CauHois select ch);
        }
    }
}
