using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
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
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            if (open.FileName != "")
            {

                string path = open.FileName;
                Microsoft.Office.Interop.Excel.Application ap = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = ap.Workbooks.Open(open.FileName);

                //
                List<int> errorQuestion = new List<int>();
                int countQS = 0;
                try
                {
                    Microsoft.Office.Interop.Excel.Worksheet sheet = wb.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;

                    int row, col;
                    row = range.Rows.Count;
                    col = range.Rows.Count;
                    for (int i = 1; i <= row; i++)
                    {
                        CauHoi ch = new CauHoi();
                        ch.CauHoi1 = range.Cells[i, 1].Value.ToString();
                        ch.DapAn_A = range.Cells[i, 2].Value.ToString();
                        ch.DapAn_B = range.Cells[i, 3].Value.ToString();
                        ch.DapAn_C = range.Cells[i, 4].Value.ToString();
                        ch.DapAn_D = range.Cells[i, 5].Value.ToString();
                        ch.DapAnDung = char.Parse(range.Cells[i, 6].Value.ToString());
                        ch.Khoi = int.Parse(range.Cells[i, 7].Value.ToString());
                        ch.DoKho = range.Cells[i, 8].Value.ToString();
                        ch.MaMH = range.Cells[i, 9].Value.ToString();
                        db.CauHois.InsertOnSubmit(ch);

                        try
                        {
                            db.SubmitChanges();
                            countQS++;
                        }
                        catch
                        {
                            //Lưu lại thứ tự câu hỏi bị lỗi
                            errorQuestion.Add(i);
                        }
                    }

                }
                catch
                {

                }
                    MessageBox.Show("Thêm thành công : " + countQS + " câu");
                    if (errorQuestion.Count() > 0)
                    {
                        StringBuilder build = new StringBuilder();
                        foreach (int i in errorQuestion)
                        {
                            build.Append(i.ToString()).AppendLine();
                        }

                        MessageBox.Show("Lỗi thêm câu hỏi ở câu " + build.ToString());

                    }
            }
            else
            {
                MessageBox.Show("Lỗi chọn tập tin", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
