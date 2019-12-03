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
    public partial class frmRegister : Form
    {
        QLThiTracNghiemDataContext db =  new QLThiTracNghiemDataContext();
        public frmRegister()
        {
            InitializeComponent();
        }
        public string LayTen(string MaHS)
        {
            string name;
            name = (from hs in db.HocSinhs
                    where hs.MaHS == MaHS
                    select hs.HoTen).SingleOrDefault();
            return name;
        }
    }
}
