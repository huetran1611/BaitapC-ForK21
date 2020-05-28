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
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtSoHoaDon.Text = DAO.CreateKey("HDB");
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            // fill dữ liệu vào câc cobobox mã nv, khách hàng, mã hàng

            string sql = "select manhanvien, tennhanvien from tblnhanvien";
            DAO.OpenConnection();
            DAO.FillDataToCombo(sql, cmbNhanVien, "manhanvien", "tennhanvien");

            sql = "select makhach, tenkhach from tblKhach";
            DAO.FillDataToCombo(sql, cmbKhachHang, "makhach", "makhach");

            sql = "select mahang, tenhang from tblHang";
            DAO.FillDataToCombo(sql, cmbHang, "mahang", "mahang");


        }
    }
}
