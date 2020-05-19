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
    }
}
