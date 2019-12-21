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
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Data.Linq;


namespace project
{
    public partial class AD_FormHS : Form
    {
        public QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        public AD_FormHS()
        {
            InitializeComponent();
            cbKhoi.SelectedIndexChanged += new EventHandler(cbKhoi_SelectedIndexChanged);
            cbLop.SelectedIndexChanged += new EventHandler(cbLop_SelectedIndexChanged);
        }

        private void AD_FormHS_Load(object sender, EventArgs e)
        {
            LoadDSKhoi();
            LoadDSLop();
            LoadDSHS();
        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Khoi = cbKhoi.SelectedItem.ToString();
            LoadKhoi(Khoi);
        }
        private void LoadKhoi(string Khoi)
        {
            dataGV.DataSource = from hs in db.HocSinhs join khoi in db.KhoiLops on hs.MaKhoi equals khoi.MaKhoi where khoi.TenKhoi == Khoi select new { hs.MaHS, hs.HoTen, hs.NgaySinh, hs.MaLop, hs.MaKhoi, hs.DienThoai };
            db.SubmitChanges();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Lop = cbLop.SelectedItem.ToString();
            LoadLop(Lop);
        }
        private void LoadLop(string Lop)
        {
            dataGV.DataSource = from hs in db.HocSinhs join lop in db.LopHocs on hs.MaLop equals lop.MaLop where lop.TenLop == Lop select new { hs.MaHS, hs.HoTen, hs.NgaySinh, hs.MaLop, hs.MaKhoi, hs.DienThoai };
            db.SubmitChanges();
        }

        public void LoadDSKhoi()
        {
            cbKhoi.DataSource = from khoi in db.KhoiLops select khoi.TenKhoi;
            db.SubmitChanges();
        }

        public void LoadDSLop()
        {
            cbLop.DataSource = from lop in db.LopHocs select lop.TenLop;
            db.SubmitChanges();
        }

        public void LoadDSHS()
        {
            db.DeferredLoadingEnabled = false;
            dataGV.DataSource = from hs in db.HocSinhs select new { hs.MaHS, hs.HoTen, hs.NgaySinh, hs.MaLop, hs.MaKhoi, hs.DienThoai };
            db.SubmitChanges();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            LoadDSHS();
        }
        public int NhapHocSinh(string MaHS, string HoTen, string NgaySinh, string MaLop, int MaKhoi, string DienThoai)
        {
            int i = 0;
            var hs = new HocSinh();
            hs.MaHS = MaHS;
            hs.HoTen = HoTen;
            hs.NgaySinh = NgaySinh;
            hs.MaLop = MaLop;
            hs.MaKhoi = MaKhoi;
            hs.DienThoai = DienThoai;
            db.HocSinhs.InsertOnSubmit(hs);
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
                    int Dem = 0;
                    for (int i = 2; i <= rows; i++)
                    {

                        string MaHS = range.Cells[i, 1].Value.ToString();
                        string HoTen = range.Cells[i, 2].Value.ToString();
                        var DateNgaySinh = range.Cells[i, 3].Value.Date;
                        string NgaySinh = DateNgaySinh.ToString("dd/MM/yyyy");
                        string MaLop = range.Cells[i, 4].Value.ToString();
                        int MaKhoi = int.Parse(range.Cells[i, 5].Value.ToString());
                        string DienThoai = range.Cells[i, 6].Value.ToString();
                        if (NhapHocSinh(MaHS, HoTen, NgaySinh, MaLop, MaKhoi, DienThoai) == 1)
                        {
                            Dem++;
                        }
                    }
                    MessageBox.Show("Import thành công " + Dem.ToString() + " Học Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHS();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    wb.Save();
                    wb.Close(true);
                    app.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                }
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
                    sheet.Name = "DSHS";
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dataGV.Columns.Count]].Merge();
                    sheet.Cells[1, 1].Value = "Danh Sách Học Sinh";
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
                    int CountHS = dataGV.Rows.Count;
                    for (int i = 1; i <= dataGV.Rows.Count; i++)
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
                    MessageBox.Show("Export thành công " + CountHS.ToString() + " Học Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHS();

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
