using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace quanlybanhang_1205
{
    public partial class DMHang : Form
    {
        public DMHang()
        {
            InitializeComponent();
        }

        private void DMHang_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGridView();
            fillDataToCombo();
            DAO.CloseConnetion();

        }
        private void LoadDataToGridView()
        {
            string sql = "Select * from tblHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridViewDMhang.DataSource = table;
        }
        public void fillDataToCombo()
        {
            string sql = "Select * from tblChatLieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbChatLieu.DataSource = table;
            cmbChatLieu.ValueMember = "MaChatLieu";
            cmbChatLieu.DisplayMember = "TenChatLieu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = "";
            txtMaHang.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtSoLuong.Text = "";
            cmbChatLieu.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // kiểm tra dữ liệu 
            //- Các trường ko được trống
            if(txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã hàng");
                txtMaHang.Focus();
                return;
            }
            if(txtTenHang.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên hàng");
                txtTenHang.Focus();
                return;
            }
            if(cmbChatLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn chất liệu");
                return;
            }
            // tương tự check them cho những texbox còn lại
            // - Mã hàng ko được trùng
            string sql = "select * from tblHang where Mahang = '" +
            txtMaHang.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("mã hàng đã tồn tại");
                txtMaHang.Focus();
                DAO.CloseConnetion();
                return;
            }
            else
            {
                sql = "insert into  tblHang (mahang, tenhang, dongianhap,dongiaban, " +
                    "soluong, machatlieu, anh, ghichu)" +
                    " values ('" + txtMaHang.Text.Trim() + "',N'"
                    + txtTenHang.Text.Trim() + "', " + txtGiaNhap.Text + "," +
                    txtGiaBan.Text.Trim() + "," + txtSoLuong.Text.Trim() + 
                    ",'"+ cmbChatLieu.SelectedValue.ToString() + "', null, null)";
                                SqlCommand cmd = new SqlCommand(sql, DAO.conn);

                MessageBox.Show(sql);

                cmd.ExecuteNonQuery();
                LoadDataToGridView();
                fillDataToCombo();
                DAO.CloseConnetion();                               

            }
        }
    }
}
