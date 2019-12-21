using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project
{
    public partial class AD_FormGV : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public AD_FormGV()
        {
            InitializeComponent();
            cbMaGV.DataSource = (from gv in db.GiaoViens select gv.MaGV);
            cbMaGV.SelectedIndexChanged += new EventHandler(cbMaGV_SelectedIndexChanged);
        }

        private void AD_FormGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
           
        }
        private void LoadDSGV()
        {
            db.DeferredLoadingEnabled = false;
            dataGV.DataSource = from gv in db.GiaoViens select new { gv.MaGV, gv.HoTen, gv.NgaySinh, gv.DienThoai };
            db.SubmitChanges();
        }

        private void cbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaGV = cbMaGV.SelectedItem.ToString();
            TimKiem(MaGV);
        }
        private void TimKiem(string MaGV)
        {
            dataGV.Rows.Clear();
            dataGV.DataSource = from gv in db.GiaoViens where gv.MaGV == cbMaGV.SelectedValue.ToString() select new { gv.MaGV, gv.HoTen, gv.NgaySinh, gv.DienThoai };
            db.SubmitChanges();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            LoadDSGV();
        }
        public int NhapGiaoVien(string MaGV, string HoTen, string NgaySinh, string DienThoai)
        {
            int i = 0;
            var gv = new GiaoVien();
            gv.MaGV = MaGV;
            gv.HoTen = HoTen;
            gv.NgaySinh = NgaySinh;
            gv.DienThoai = DienThoai;
            db.GiaoViens.InsertOnSubmit(gv);
            try
            {
                db.SubmitChanges();
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            // openfile
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "EXCEL FILE|*.xls;*.xlsx;*.xlsm";
            fopen.ShowDialog();
            // xu li
            if (fopen.FileName != "")
            {
                string path = fopen.FileName;
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Open(fopen.FileName);
                try
                {
                    //open sheet
                    Excel._Worksheet sheet = wb.Sheets[1];
                    Excel.Range range = sheet.UsedRange;
                    ///read
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;
                    //read head
                    // readdata
                    int CountGV = 0;
                    for (int i = 2; i <= rows; i++)
                    {
                        string MaGV = range.Cells[i, 1].Value.ToString();
                        string HoTen = range.Cells[i, 2].Value.ToString();
                        var DateNgaySinh = range.Cells[i, 3].Value.Date;
                        string NgaySinh = DateNgaySinh.ToString("dd/MM/yyyy");
                        string DienThoai = range.Cells[i, 4].Value.ToString();
                        if (NhapGiaoVien(MaGV, HoTen, NgaySinh, DienThoai) == 1)
                        {
                            CountGV++;
                        }
                    }
                    // end thread plz wait
                    //

                    MessageBox.Show("Import thành công " + CountGV.ToString() + " Giáo Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSGV();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                wb.Save();
                wb.Close(true);
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "EXCEL FILE|*.xls;*.xlsx;*.xlsm";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                string path = fsave.FileName;
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel._Worksheet sheet = null;
                try
                {
                    sheet = wb.ActiveSheet;
                    sheet.Name = "DSGV";
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dataGV.Columns.Count]].Merge();
                    sheet.Cells[1, 1].Value = "Danh Sách Giáo Viên";
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[1, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;

                    //create head
                    for (int i = 1; i <= dataGV.Columns.Count; i++)
                    {
                        sheet.Cells[2, i] = dataGV.Columns[i - 1].HeaderText;
                        sheet.Cells[2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[2, i].Font.Bold = true;
                        sheet.Cells[2, i].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }
                    // create data
                    int CountGV = dataGV.Rows.Count;
                    for (int i = 1; i <= dataGV.Rows.Count ; i++)
                    {
                        sheet.Cells[i + 2, 1] = dataGV.Rows[i - 1].Cells[0].Value.ToString();
                        sheet.Cells[i + 2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        for (int j = 2; j <= dataGV.Columns.Count; j++)
                        {
                            try
                            {
                                sheet.Cells[i + 2, j] = "'" + dataGV.Rows[i - 1].Cells[j - 1].Value.ToString();
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
                    wb.Close();
                    MessageBox.Show("Export thành công " + CountGV.ToString() + " Giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    wb = null;
                    app.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                }
            }
        }
    }
}
