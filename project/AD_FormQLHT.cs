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
    public partial class AD_FormQLHT : Form
    {
        public AD_FormQLHT()
        {
            InitializeComponent();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            AD_FormSL frmSL = new AD_FormSL();
            frmSL.TopLevel = false;
            pnBody.Controls.Clear();
            pnBody.Controls.Add(frmSL);
            frmSL.Show();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {

            AD_FormTL frmTL = new AD_FormTL();
            frmTL.TopLevel = false;
            pnBody.Controls.Clear();
            pnBody.Controls.Add(frmTL);
            frmTL.Show();
        }
    }
}
