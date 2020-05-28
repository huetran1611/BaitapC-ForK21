using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quanlybanhang_1205
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dMChatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChatLieu f1 = new frmChatLieu();
            f1.Show();
        }

        private void dMHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMHang f1 = new DMHang();
            f1.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan f1 = new frmHoaDonBan();
            f1.Show();
        }
    }
}
