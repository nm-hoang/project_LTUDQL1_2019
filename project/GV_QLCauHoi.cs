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
                List<int> errorQuestion = new List<int>();
                int countQS = 0;
                //
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "EXCEL FILE|*.xls;*.xlsx;*.xlsm";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                string path = fsave.FileName;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet sheet = null;
                try
                {
                    sheet = wb.ActiveSheet;
                    sheet.Name = "DSCH";
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dgvCauHoi.Columns.Count]].Merge();
                    sheet.Cells[1, 1].Value = "Danh Sách Câu Hỏi";
                    sheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[1, 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                    //create head
                    for (int i = 1; i <= dgvCauHoi.Columns.Count; i++)
                    {
                        sheet.Cells[2, i] = dgvCauHoi.Columns[i - 1].HeaderText;
                        sheet.Cells[2, i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[2, i].Font.Bold = true;
                        sheet.Cells[2, i].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                    }
                    // create data
                    int CountHS = dgvCauHoi.Rows.Count;
                    for (int i = 1; i <= dgvCauHoi.Rows.Count; i++)
                    {
                        sheet.Cells[i + 2, 1] = dgvCauHoi.Rows[i - 1].Cells[0].Value.ToString();
                        sheet.Cells[i + 2, 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        for (int j = 2; j <= dgvCauHoi.Columns.Count; j++)
                        {
                            try
                            {
                                sheet.Cells[i + 2, j] = "'" + dgvCauHoi.Rows[i - 1].Cells[j - 1].Value.ToString();
                                sheet.Cells[i + 2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                            }
                            catch (Exception ex)
                            {
                                sheet.Cells[i + 2, j] = "";
                                sheet.Cells[i + 2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                            }
                        }
                    }
                    //save data
                    wb.SaveAs(fsave.FileName);
                    MessageBox.Show("Xuất thành công " + CountHS.ToString() + " câu hỏi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    wb = null;
                    app.Quit();
                }
            }
        }
    }
}
