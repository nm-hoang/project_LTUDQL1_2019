using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace project
{
    public partial class frmHS_LamBaiThiThat : Form
    { 
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();
        string NgayThi = DateTime.Now.ToString("dd-MM-yyyy");
        string MaDe,MaKiThi,UserName,TenMH;
        ArrayList arrCauHoi = new ArrayList();
        ArrayList arrCauA = new ArrayList();
        ArrayList arrCauB = new ArrayList();
        ArrayList arrCauC = new ArrayList();
        ArrayList arrCauD = new ArrayList();
        ArrayList arrDapAnDung = new ArrayList();
        ArrayList arrChonDapAn = new ArrayList();
        Button[] arrBtn = new Button[100];
        int Phut = 0, Giay = 0, chon = 0, socauhoanthanh = 0, socaudung = 0;
        double Diem;
        public frmHS_LamBaiThiThat(string username,string made,string makithi,string tenmh)
        {
            InitializeComponent();
            MaDe = made;
            MaKiThi = makithi;
            UserName = username;
            TenMH = tenmh;
        }
        private int SoLuongCauHoi()
        {
            int result = db.DanhSachCauHois.Where(ds => ds.MaDe.ToString() == MaDe).Count();
            return result;
        }
        private void ThoiGianThi()
        {
            lblThoiGian.Text = Phut + ":" + Giay;
            proThoiGian.Maximum = SoLuongCauHoi() * 90; 
        }
        private void frmHS_LamBaiThiThat_Load(object sender, EventArgs e)
        {
            lblMonHoc.Text = TenMH.ToLower();
            SoLuongCauHoi();
            HienThiCauHoi(sender, e);
            NapDapAnGia();
            TaoButtonCauHoi();
            ThoiGianThi();
            lblTraLoi.Text = socauhoanthanh + "/" + SoLuongCauHoi();
        }
        private void TaoButtonCauHoi()
        {
            int x = SoLuongCauHoi();
            Phut = (x * 90) / 60;
            Giay = (x * 90) % 60;
            int cot = 4;
            int dong = 1;
            if ((x / 4.0) % 2 == 0 && x > 4)
            {
                dong = x / 4;
            }
            if ((x / 4.0) % 2 != 0 && x > 4)
            {
                dong = (int)(x / 4.0) + 1;
            }
            int Top = 0;
            int t = 1;
            int m = 0;
            {

                for (int i = 0; i < dong; i++)
                {
                    int Left = 0;
                    for (int j = 0; j < cot; j++)
                    {
                        arrBtn[m] = new Button();
                        if (m < x)
                        {
                            arrBtn[m].Size = new Size(35, 35);
                            arrBtn[m].Text = string.Format("{0}", t);
                            arrBtn[m].Tag = string.Format("{0}, {1}", i, j);
                            arrBtn[m].Top = Top;
                            arrBtn[m].Left = Left += 35;
                            arrBtn[m].Click += new EventHandler(Btn_Click);
                            panel1.Controls.Add(arrBtn[m]);
                            t++;
                        }
                        m++;
                    }
                    Top += 35;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Int32.TryParse(((Button)sender).Text.ToString(), out chon);
            chon = chon - 1;
            HienThiCauHoi(sender, e);
            Danh_DapAn(sender, e);
        }
        private void NapCauHoi()
        {
            var cauhoi = (from u in db.CauHois
                       join t in db.DanhSachCauHois on u.ID equals t.ID_Cauhoi
                       where t.MaDe == int.Parse(MaDe)
                       select u.CauHoi1).ToList();
            arrCauHoi.AddRange(cauhoi);
            var cauA = (from u in db.CauHois
                      join t in db.DanhSachCauHois on u.ID equals t.ID_Cauhoi
                      where t.MaDe == int.Parse(MaDe)
                      select u.DapAn_A).ToList();
            arrCauA.AddRange(cauA);
            var cauB = (from u in db.CauHois
                       join t in db.DanhSachCauHois on u.ID equals t.ID_Cauhoi
                       where t.MaDe == int.Parse(MaDe)
                       select u.DapAn_B).ToList();
            arrCauB.AddRange(cauB);
            var CauC = (from u in db.CauHois
                           join t in db.DanhSachCauHois on u.ID equals t.ID_Cauhoi
                           where t.MaDe == int.Parse(MaDe)
                           select u.DapAn_C).ToList();
            arrCauC.AddRange(CauC);
            var CauD = (from u in db.CauHois
                       join t in db.DanhSachCauHois on u.ID equals t.ID_Cauhoi
                       where t.MaDe == int.Parse(MaDe)
                       select u.DapAn_D).ToList();
            arrCauD.AddRange(CauD);
            var DapAn = (from u in db.CauHois
                       join t in db.DanhSachCauHois on u.ID equals t.ID_Cauhoi
                       where t.MaDe == int.Parse(MaDe)
                       select u.DapAnDung).ToList();
            arrDapAnDung.AddRange(DapAn);
              
        }
        private void HienThiCauHoi(object sender, EventArgs e)
        {
            if (SoLuongCauHoi() > 0)
            {
                lblCauSo.Text = "Câu hỏi " + (chon + 1);
                NapCauHoi();
                lblCauHoi.Text = arrCauHoi[chon].ToString();
                lblCauA.Text = arrCauA[chon].ToString();
                lblCauB.Text = arrCauB[chon].ToString();
                lblCauC.Text = arrCauC[chon].ToString();
                lblCauD.Text = arrCauD[chon].ToString();
            }
        }
        private void Danh_DapAn(object sender, EventArgs e)
        {
            if (arrChonDapAn[chon].ToString() == "")
            {
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;
            }
            else
            {
                if (arrChonDapAn[chon].ToString() == "A")
                    radioA.Checked = true;
                if (arrChonDapAn[chon].ToString() == "B")
                    radioB.Checked = true;
                if (arrChonDapAn[chon].ToString() == "C")
                    radioC.Checked = true;
                if (arrChonDapAn[chon].ToString() == "D")
                    radioD.Checked = true;
            }
        }
        private void CapNhat_DapAn(object sender, EventArgs e)
        {
            if (radioA.Checked == true)
                arrChonDapAn[chon] = "A";
            if (radioB.Checked == true)
                arrChonDapAn[chon] = "B";
            if (radioC.Checked == true)
                arrChonDapAn[chon] = "C";
            if (radioD.Checked == true)
                arrChonDapAn[chon] = "D";
            socauhoanthanh = 0;
            for (int i = 0; i < SoLuongCauHoi(); i++)
            {
                if (arrChonDapAn[i] == "A" || arrChonDapAn[i] == "B" || arrChonDapAn[i] == "C" || arrChonDapAn[i] == "D")
                {
                    socauhoanthanh++;
                }
            }
            lblTraLoi.Text = socauhoanthanh + "/" + SoLuongCauHoi();
        }
        private void NapDapAnGia()
        {
            for (int i = 0; i < proThoiGian.Maximum; i++)
            {
                arrChonDapAn.Add("");
            }
        }
        private void NopBai(object sender, EventArgs e)
        {
            try
            {
                timeThiThat.Stop();
                for (int i = 0; i < SoLuongCauHoi(); i++)
                {
                    if (arrChonDapAn[i].ToString() == arrDapAnDung[i].ToString())
                    {
                        socaudung++;
                    }
                }
                double DiemNhan = 10 / (SoLuongCauHoi() * 1.0);
                Diem = socaudung * DiemNhan;
                Diem = Math.Round(Diem, 2);
                MessageBox.Show("* Bạn được : " + Diem.ToString() + " điểm" +
                                "\n* Số câu đúng : " + socaudung + "\n* Số câu sai : " + (SoLuongCauHoi() - socaudung));
            }
            catch (Exception)
            {

            }
        }
   
        private void ToMauButton()
        {
            for (int i = 0; i < SoLuongCauHoi(); i++)
            {
                if (arrChonDapAn[i] != "")
                {
                    arrBtn[i].BackColor = Color.Green;
                }
            }
        }
        public void LuuKetQua()
        {
                string SoCauDung = socaudung.ToString();
                string MaHS = UserName;
                string SoCauSai = (SoLuongCauHoi() - socaudung).ToString();
                double DiemThi = Diem;
                string Ngaythi = NgayThi;
                string KiThi = MaKiThi;
                KetQuaThi insert = new KetQuaThi();
                insert.SoCauDung = SoCauDung;
                insert.MaHS = MaHS;
                insert.SoCauSai = SoCauSai;
                insert.DiemThi = DiemThi;
                insert.NgayThi = NgayThi;
                insert.ID_Account = MaHS;
                insert.KyThi = KiThi;
                insert.TenMH = lblMonHoc.Text;
                db.KetQuaThis.InsertOnSubmit(insert);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {

                }
        }
        private void btnNopBai_Click_1(object sender, EventArgs e)
        {
            if (proThoiGian.Value != proThoiGian.Maximum)
            {

                if (MessageBox.Show("Bạn đã hoàn thành " + socauhoanthanh + "/" + SoLuongCauHoi(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    btnKetThuc.Enabled = true;
                    btnNopBai.Enabled = false;
                    NopBai(sender, e);
                    btnKetThuc_Click_1(sender, e);
                }
            }
            else
            {
                NopBai(sender, e);
                btnKetThuc_Click_1(sender, e);
            }
        }

        private void btnKetThuc_Click_1(object sender, EventArgs e)
        {
            LuuKetQua();
        }

        private void btnLui_Click_1(object sender, EventArgs e)
        {
            if (chon > 0)
            {
                chon = chon - 1;
                HienThiCauHoi(sender, e);
                Danh_DapAn(sender, e);
            }
        }

        private void btnTien_Click_1(object sender, EventArgs e)
        {
            if (chon < SoLuongCauHoi() - 1)
            {
                chon = chon + 1;
                HienThiCauHoi(sender, e);
                Danh_DapAn(sender, e);
            }
        }

        private void timeThiThat_Tick_1(object sender, EventArgs e)
        {
            if (SoLuongCauHoi() > 0)
            {
                ThoiGianThi();
                proThoiGian.Value++;
                if (Giay == 0)
                {
                    Phut--;
                    Giay = 59;
                }
                Giay--;
                if (proThoiGian.Value == proThoiGian.Maximum)
                {
                    ThoiGianThi();
                    timeThiThat.Stop();
                    btnNopBai_Click_1(sender, e);
                }
            }
        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            if (SoLuongCauHoi() > 0)
            {
                CapNhat_DapAn(sender, e);
                ToMauButton();
            }
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            if (SoLuongCauHoi() > 0)
            {
                CapNhat_DapAn(sender, e);
                ToMauButton();
            }
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            if (SoLuongCauHoi() > 0)
            {
                CapNhat_DapAn(sender, e);
                ToMauButton();
            }
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            if (SoLuongCauHoi() > 0)
            {
                CapNhat_DapAn(sender, e);
                ToMauButton();
            }
        }
    }
}
