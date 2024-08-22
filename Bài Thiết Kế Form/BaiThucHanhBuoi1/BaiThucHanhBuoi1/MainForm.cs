using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin Chào bạn {tenDaNhap}. Rất vui khi được làm quen với bạn","Thông điệp chào mừng");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtTenSaoChep.Text = txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTenSaoChep.Text = txtTen.Text;
        }
    }
}
