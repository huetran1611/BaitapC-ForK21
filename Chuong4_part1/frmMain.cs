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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void chaoMungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaoMung c1 = new FrmChaoMung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTong c2 = new FrmTinhTong();
            c2.Show();
        }

        private void tínhTổngBt1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTong_bt1 c3 = new TinhTong_bt1();
            c3.Show();
        }
    }
}
