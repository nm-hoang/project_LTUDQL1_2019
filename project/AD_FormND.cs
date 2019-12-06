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
        public AD_FormND()
        {
            InitializeComponent();
            cbLoaiND.Items.Add("HocSinh");
            cbLoaiND.Items.Add("GiaoVien");
            cbLoaiND.Items.Add("Admin");
        }

        private void cbLoaiND_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoaiND = cbLoaiND.SelectedItem.ToString();
            LoadDS(LoaiND);
        }

        public void LoadDS(string LoaiND)
        {
            using (QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext())
            {
                dataGV.DataSource = from tk in db.TaiKhoans where tk.Type == LoaiND select tk;
                db.SubmitChanges();
            }
        }


        private void AD_FormND_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
        public void LoadDS()
        {
            using (QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext())
            {
                dataGV.DataSource = from tk in db.TaiKhoans select tk;
                db.SubmitChanges();
            }
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
            int i = dataGV.CurrentCell.RowIndex;

            int ID = int.Parse(dataGV.Rows[i].Cells[0].Value.ToString());
            string ID_Account = dataGV.Rows[i].Cells[1].Value.ToString();
            string PassWord = dataGV.Rows[i].Cells[2].Value.ToString();
            string Type= dataGV.Rows[i].Cells[3].Value.ToString();
            string ID_User = dataGV.Rows[i].Cells[4].Value.ToString();

            AD_FormND_CapNhat frm = new AD_FormND_CapNhat(ID, ID_Account, PassWord, Type, ID_User);
            frm.FormClosed += new FormClosedEventHandler(frmClosed);
            frm.Show();
        }

        
    
    }
}
