﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nam", "Thông Báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        { 
            if(rdNu.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nữ", "Thông Báo");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor= Color.Green;
        }
    }
}
