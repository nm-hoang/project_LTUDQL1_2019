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
    public partial class AD_FormQLND : Form
    {
        public AD_FormQLND()
        {
            InitializeComponent();
        }

        private void btnND_Click(object sender, EventArgs e)
        {
            AD_FormND frmQLND = new AD_FormND();
            frmQLND.ShowDialog();
        }

        private void btnHS_Click(object sender, EventArgs e)
        {
            AD_FormHS frmQLHS = new AD_FormHS();
            frmQLHS.ShowDialog();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            AD_FormGV frmQLGV = new AD_FormGV();
            frmQLGV.ShowDialog();
        }
    }
}
