﻿using System;
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
    public partial class frmGiaoVien : Form
    {
        public string username;
        public frmGiaoVien(string Username)
        {
            InitializeComponent();
            username = Username;
        }


        private void frmGiaoVien_Load(object sender, EventArgs e)
        {

        }

        private void btnQLCauHoi_Click(object sender, EventArgs e)
        {
            GV_QLCauHoi frm = new GV_QLCauHoi();
            frm.Show();
        }
    }
}
