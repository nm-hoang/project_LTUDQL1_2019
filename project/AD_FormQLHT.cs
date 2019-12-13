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

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            AD_FormTL frm = new AD_FormTL();
            frm.TopLevel = false;
            pnBody.Controls.Clear();
            pnBody.Controls.Add(frm);
            frm.Show();
            //AD_FormTL frm = new AD_FormTL();
            //frm.ShowDialog();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            AD_FormSL frm = new AD_FormSL();
            frm.TopLevel = false;
            pnBody.Controls.Clear();
            pnBody.Controls.Add(frm);
            frm.Show();
            //AD_FormSL frm = new AD_FormSL();
            //frm.ShowDialog();
        }
    }
}
