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
    public partial class GV_TaoDeThi : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public List<int> dsCauHoi = new List<int>();
        public int Made;
        public GV_TaoDeThi()
        {
            InitializeComponent();

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void GV_TaoDeThi_Load(object sender, EventArgs e)
        {
            cbMaKhoi.DataSource = (from k in db.KhoiLops select k.MaKhoi);
            cbMaMH.DataSource = (from mh in db.MonHocs select mh.MaMH);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListQuestions.CurrentRow.Cells["ID"].Value.ToString());

            var check = (from c in db.DanhSachCauHois
                         where c.MaDe == Made && c.ID_Cauhoi == id
                         select c).SingleOrDefault();
            
            if(check == null)
            {
            DanhSachCauHoi ch = new DanhSachCauHoi();
            ch.ID_Cauhoi = id;
            ch.MaDe = Made;
            db.DanhSachCauHois.InsertOnSubmit(ch);
            db.SubmitChanges();
            LoadExam();
            }
            else
            {
                MessageBox.Show("Đã tồn tại câu hỏi trong đề thi");
            }
            
        }

        //Load danh sách các câu hỏi trong đề thi
        private void LoadExam()
        {
            
            dgvExam.DataSource = (from ds in db.DanhSachCauHois
                                  from ch in db.CauHois
                                  where ds.MaDe == Made && ds.ID_Cauhoi == ch.ID
                                  select new { ds.ID_Cauhoi, ch.CauHoi1,ch.DoKho });

        }

        //Load danh sách các câu hỏi
        private void LoadListQuestions()
        {
            dgvListQuestions.DataSource = (from qs in db.CauHois
                                           select new { qs.ID, qs.CauHoi1, qs.DoKho });

        }

        private void DisableBtn()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnCreate.Enabled = false;
            txtID.Enabled = false;
            txtTen.Enabled = false;
            cbMaKhoi.Enabled = false;
            cbMaMH.Enabled = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");

            }
            else
            {

                var exists = (from d in db.DeThis
                              where d.ID == int.Parse(txtID.Text)
                              select d).SingleOrDefault();
                if (exists == null)
                {
                    DeThi dt = new DeThi();
                    dt.ID = Made = int.Parse(txtID.Text);
                    dt.TenDeThi = txtTen.Text;
                    dt.MaKhoi = int.Parse(cbMaKhoi.SelectedValue.ToString());
                    dt.MaMH = cbMaMH.SelectedValue.ToString();

                    try
                    {
                        db.DeThis.InsertOnSubmit(dt);
                        db.SubmitChanges();

                        //Disable button sau khi tạo thành công đề thi
                        DisableBtn();
                        LoadExam();
                        LoadListQuestions();
                        MessageBox.Show("Thêm đề thi thành công");
                    }
                    catch
                    {
                        MessageBox.Show("lỗi thêm đề thi");
                    }
                }

                else
                {
                    MessageBox.Show("Đã tồn tại mã đề thi");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Lưu thành công");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvExam.CurrentRow.Cells["IDch"].Value.ToString());
            DanhSachCauHoi ch = (from c in db.DanhSachCauHois
                                 where c.ID_Cauhoi == id && c.MaDe == Made
                                 select c).SingleOrDefault();
            db.DanhSachCauHois.DeleteOnSubmit(ch);
            db.SubmitChanges();
            LoadExam();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            int temp;

            bool checkIsNumber = int.TryParse(txtID.Text,out temp);
            if(checkIsNumber == false  )
            {
                MessageBox.Show("Vui lòng nhập kiểu số");
                this.txtID.Focus();
            }
           
        }
    }
}
