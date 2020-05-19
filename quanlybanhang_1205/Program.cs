using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace quanlybanhang_1205
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Data Source = DESKTOP - RM3H1RB\SQLEXPRESS; Initial Catalog = QuanLyBanHang; Integrated Security = True

            Application.Run(new frmMain());
        }
    }
}
