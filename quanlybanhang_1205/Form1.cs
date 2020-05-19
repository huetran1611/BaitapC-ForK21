using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace quanlybanhang_1205
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "select * from DMHang";
            SqlDataAdapter adap = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
