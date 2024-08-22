using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItems;
            listBox2.Items.Add(item);

        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            // Duyệt danh sách các mặt hàng đã mua nằm trong ListBox2
            // Cộng Dồn số tiền cần thanh toán

            foreach (string hang in listBox2.Items)
            {
                switch (hang) 
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn Phím":
                        soTien += 200000;
                        break;
                    case "Máy in":
                        soTien += 300000;
                        break;
                    case "USB KingMax":
                        soTien += 400000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = soTien.ToString();
            }    

        }
    }
}
