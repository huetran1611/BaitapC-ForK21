using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace quanlybanhang_1205
{
    class DAO
    {
      public  static SqlConnection conn;
      public  static string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
     public static void OpenConnection() {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            try
                {
                    conn.Open();
              //      MessageBox.Show("mo ket noi thanh cong");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
    public static void CloseConnetion()
        {
            
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                 //   MessageBox.Show("dong ket noi thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }
    public static bool checkKeyExit(string sql)
        {
            bool kq = false;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                kq = true;     
           return kq;
        }
    }
}
