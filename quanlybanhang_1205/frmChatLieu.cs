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
    public partial class frmChatLieu : Form
    {
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            LoadDataToGrivew();
        }

        private void LoadDataToGrivew()
        {
            //mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblchatlieu";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblChatLieu = new DataTable();
                myAdapter.Fill(tblChatLieu);
                gridviewChatLieu.DataSource = tblChatLieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnetion();
            }
            
        }

        private void gridviewChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMachatLieu.Text = gridviewChatLieu.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            txtTenChatLieu.Text = gridviewChatLieu.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            txtMachatLieu.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "Update tblChatLieu set TenChatLieu = N'" + txtTenChatLieu.Text.Trim() +
                      "' where MaChatLieu = '" + txtMachatLieu.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
            LoadDataToGrivew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblchatlieu where machatlieu = '" + txtMachatLieu.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
            LoadDataToGrivew();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMachatLieu.Enabled = true;
            txtTenChatLieu.Enabled = true;
            // xoa du lieu trong textbox
            txtMachatLieu.Text = "";
            txtTenChatLieu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // kiem tra dieu kien
            if(txtMachatLieu.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã chất liệu ");
                txtMachatLieu.Focus();
                return;
            }
            if(txtTenChatLieu.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên chất liệu");
                txtTenChatLieu.Focus();
                return;
            }
            string sqlCheckKey = "SElect * from tblChatLieu Where machatlieu = '"
                                + txtMachatLieu.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyExit(sqlCheckKey))
            {
                MessageBox.Show("Mã chất liệu đã tồn tại");
                DAO.CloseConnetion();
                txtMachatLieu.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblChatLieu values ('" +
                            txtMachatLieu.Text.Trim() + "' , N'" +
                            txtTenChatLieu.Text.Trim() + "')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnetion();
                LoadDataToGrivew();
            }

            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
