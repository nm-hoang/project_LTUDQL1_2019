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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnQLHT_Click(object sender, EventArgs e)
        {
            AD_FormQLHT frmQLHT = new AD_FormQLHT();
            frmQLHT.TopLevel = false;
            pnFooter.Controls.Clear();
            pnFooter.Controls.Add(frmQLHT);
            frmQLHT.Show();
        }

        private void btnQLND_Click(object sender, EventArgs e)
        {
            AD_FormQLND frmQLND = new AD_FormQLND();
            frmQLND.TopLevel = false;
            pnFooter.Controls.Clear();
            pnFooter.Controls.Add(frmQLND);
            frmQLND.Show();
        }
    }
}
