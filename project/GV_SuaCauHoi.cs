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
            BindingSource KhoiLop = new BindingSource();
            KhoiLop.DataSource = (from k in db.KhoiLops select k.MaKhoi);
            cbKhoi.DataSource = KhoiLop;
            cbMaMH.DataSource = (from mh in db.MonHocs select mh.MaMH);
            List<String> Dokho = new List<string> {"Dể", "Trung bình", "Khó" };
            List<String> DapAn = new List<string> {"A", "B", "C", "D"};
            cbDADung.DataSource = DapAn;
            cbDoKho.DataSource = Dokho;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //CauHoi qs = new CauHoi
            //{
            //    CauHoi1 = txtCauHoi.Text,
            //    DapAn_A = txtA.Text,
            //    DapAn_B = txtB.Text,
            //    DapAn_C = txtC.Text,
            //    DapAn_D = txtD.Text,
            //    DapAnDung = char.Parse(cbDADung.SelectedValue.ToString()),
            //    Khoi = int.Parse(cbKhoi.SelectedValue.ToString()),
            //    DoKho = cbDoKho.SelectedValue.ToString(),
            //    MaMH = cbMaMH.SelectedValue.ToString()
            //};
            CauHoi question = (from c in db.CauHois where c.ID == int.Parse(lbIDCauHoi.Text)
                                   select c).SingleOrDefault();
            question.CauHoi1 = txtCauHoi.Text;
            question.DapAn_A = txtA.Text;
            question.DapAn_B = txtB.Text;
            question.DapAn_C = txtC.Text;
            question.DapAn_D = txtD.Text;
            question.DapAnDung = char.Parse(cbDADung.SelectedValue.ToString());
            question.Khoi = int.Parse(cbKhoi.SelectedValue.ToString());
            question.DoKho = cbDoKho.SelectedValue.ToString();
            question.MaMH = cbMaMH.SelectedValue.ToString();

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Lưu thành công");
            }

            catch
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            GV_QLCauHoi frm = new GV_QLCauHoi();
            frm.Show();
        }


    }
}
