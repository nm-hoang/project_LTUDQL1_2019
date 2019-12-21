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
    public partial class GV_QLDeThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_QLDeThi()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GV_TaoDeThi frm = new GV_TaoDeThi();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GV_SuaDeThi frm = new GV_SuaDeThi();
            frm.lblID.Text = dgvDeThi.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtTen.Text = dgvDeThi.CurrentRow.Cells["TenDethi"].Value.ToString();
            this.Close();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Message = "Bạn có chắc muốn xóa đề thi";
            string Title = "Xóa đề thi";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(Message, Title, buttons);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dgvDeThi.CurrentRow.Cells["ID"].Value.ToString());
                DeThi dt = (from d in db.DeThis
                            where d.ID == id
                            select d).SingleOrDefault();
                db.DeThis.DeleteOnSubmit(dt);
                db.SubmitChanges();

                MessageBox.Show("Xóa thành công");
            }
            else
            {
                //
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ReLoad()
        {

            dgvDeThi.Rows.Clear();
            dgvDeThi.DataSource = (from dt in db.DeThis select new { dt.ID, dt.TenDeThi, dt.MaMH, dt.MaKhoi });
        }
        private void GV_QLDeThi_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
