using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_part1
{
    public partial class FrmChaoMung : Form
    {
        public FrmChaoMung()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên");
                txtTen.Focus();
                return;
            }
            if(txtLop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lớp");
                txtLop.Focus();
                return;
            }

            MessageBox.Show("Chao mừng bạn " + txtTen.Text + " học lớp " + txtLop.Text);

        }

        private void FrmChaoMung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ban đã bật form frmChaoMung");
        }
    }
}
