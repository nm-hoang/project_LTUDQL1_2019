using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project
{
    public partial class AD_FormND : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public AD_FormND()
        {
            InitializeComponent();
            List<String> type = new List<string>
            {
                "HocSinh", "GiaoVien", "Admin"
            };
            cbLoaiND.DataSource = type;
        }

        private void AD_FormND_Load(object sender, EventArgs e)
        {
            LoadDS();
           
        }

        private void cbLoaiND_SelectedIndexChanged(object sender, EventArgs e)
        {

            string LoaiND = cbLoaiND.SelectedItem.ToString();
            LoadDS(LoaiND);
        }

        public void LoadDS(string LoaiND)
        {
            dataGV.DataSource = from tk in db.TaiKhoans where tk.Type == LoaiND select tk;
            db.SubmitChanges();
            //Databiding
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataGV.DataSource, "ID");
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", dataGV.DataSource, "ID_Account");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataGV.DataSource, "PassWord");
            txtLoaiND.DataBindings.Clear();
            txtLoaiND.DataBindings.Add("Text", dataGV.DataSource, "Type");
            txtIDND.DataBindings.Clear();
            txtIDND.DataBindings.Add("Text", dataGV.DataSource, "ID_User");
        }
        public void LoadDS()
        {
            dataGV.DataSource = from tk in db.TaiKhoans select tk;
            db.SubmitChanges();
            //Databiding
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataGV.DataSource, "ID");
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", dataGV.DataSource, "ID_Account");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataGV.DataSource, "PassWord");
            txtLoaiND.DataBindings.Clear();
            txtLoaiND.DataBindings.Add("Text", dataGV.DataSource, "Type");
            txtIDND.DataBindings.Clear();
            txtIDND.DataBindings.Add("Text", dataGV.DataSource, "ID_User");
        }
        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            LoadDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AD_FormND_Them frm = new AD_FormND_Them();
            frm.FormClosed += new FormClosedEventHandler(frmClosed);
            frm.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

                TaiKhoan taikhoan = (from tk in db.TaiKhoans where tk.ID_Account == txtTaiKhoan.Text select tk).SingleOrDefault();
                taikhoan.PassWord = txtMatKhau.Text;
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            //int i = dataGV.CurrentCell.RowIndex;
            //int ID = int.Parse(dataGV.Rows[i].Cells[0].Value.ToString());
            //string ID_Account = dataGV.Rows[i].Cells[1].Value.ToString();
            //string PassWord = dataGV.Rows[i].Cells[2].Value.ToString();
            //string Type = dataGV.Rows[i].Cells[3].Value.ToString();
            //string ID_User = dataGV.Rows[i].Cells[4].Value.ToString();

            //AD_FormND_CapNhat frm = new AD_FormND_CapNhat(ID, ID_Account, PassWord, Type, ID_User);
            //frm.FormClosed += new FormClosedEventHandler(frmClosed);
            //frm.Show();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNguoiDung();
        }
        public int XoaNguoiDung()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Thông báo", MessageBoxButtons.YesNo);
            int i = 0;
            if (dialogResult == DialogResult.Yes)
            {

                string ID = dataGV.CurrentRow.Cells["ID"].Value.ToString();

                var tk = (from t in db.TaiKhoans where t.ID == int.Parse(ID) select t).FirstOrDefault();
                db.TaiKhoans.DeleteOnSubmit(tk);
                db.SubmitChanges();
                LoadDS();
                try
                {
                    db.SubmitChanges();
                    i = 1;
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    i = 0;
                    MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                // i = 0;
            }
            return i;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
