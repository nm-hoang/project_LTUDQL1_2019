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
    public partial class GV_SuaDeThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public GV_SuaDeThi()
        {
            InitializeComponent();
        }

        private void GV_SuaDeThi_Load(object sender, EventArgs e)
        {
            int id = int.Parse(lblID.Text);

            cbMaMH.DataSource = (from m in db.DeThis select m.MaMH).Distinct();
            cbMaKhoi.DataSource = (from m in db.DeThis select m.MaKhoi).Distinct();

            cbMaMH.Text = (from m in db.DeThis
                           where m.ID == id
                           select m.MaMH).SingleOrDefault();
            var currentMaKhoi = (from m in db.DeThis
                                 where m.ID == id
                                 select m.MaKhoi).SingleOrDefault();
            cbMaKhoi.Text = currentMaKhoi.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DeThi dt = (from d in db.DeThis
                        where d.ID == int.Parse(lblID.Text)
                        select d).SingleOrDefault();
            dt.TenDeThi = txtTen.Text;
            dt.MaMH = cbMaMH.SelectedValue.ToString();
            dt.MaKhoi = int.Parse(cbMaKhoi.SelectedValue.ToString());

            try
            {
                db.SubmitChanges();
                //MessageBoxButtons(")
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            GV_QLDeThi frm = new GV_QLDeThi();
            frm.Show();
        }
    }
}
