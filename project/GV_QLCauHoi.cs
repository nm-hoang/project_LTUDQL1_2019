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
            dgvCauHoi.DataSource = (from ch in db.CauHois select new {ch.ID,ch.CauHoi1, ch.DapAn_A, ch.DapAn_B, ch.DapAn_C,ch.DapAn_D,
                                        ch.DapAnDung,ch.Khoi,ch.DoKho,ch.MaMH} );
        }

        private void btnSuaCH_Click(object sender, EventArgs e)
        {
            GV_SuaCauHoi frm = new GV_SuaCauHoi();
            frm.lbIDCauHoi.Text = dgvCauHoi.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtCauHoi.Text = dgvCauHoi.CurrentRow.Cells["CauHoi1"].Value.ToString();
            frm.txtA.Text = dgvCauHoi.CurrentRow.Cells["DapAn_A"].Value.ToString();
            frm.txtB.Text = dgvCauHoi.CurrentRow.Cells["DapAn_B"].Value.ToString();
            frm.txtC.Text = dgvCauHoi.CurrentRow.Cells["DapAn_C"].Value.ToString();
            frm.txtD.Text = dgvCauHoi.CurrentRow.Cells["DapAn_D"].Value.ToString();
            this.Hide();
            frm.ShowDialog();
        }

        private void dgvCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int tempID = int.Parse(dgvCauHoi.CurrentRow.Cells["ID"].Value.ToString());

            var qs = (from c in db.CauHois where c.ID == tempID select c).FirstOrDefault();
            db.CauHois.DeleteOnSubmit(qs);
            db.SubmitChanges();
            LoadQuestions();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            string id = dgvCauHoi.CurrentRow.Cells["ID"].Value.ToString();
            GV_ChiTietCauHoi frm = new GV_ChiTietCauHoi(id);
            frm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
