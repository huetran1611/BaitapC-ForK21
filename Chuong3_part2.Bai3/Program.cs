using System;

namespace Chuong3_part2.Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            INguoi Sinhvien1 = new SinhVien();
            INguoi Nhanvien = new NhanVienCN();
            try
            {

                Sinhvien1.nhap();
                Sinhvien1.xuat();

                Nhanvien.nhap();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
           

            Console.ReadLine();


        }
    }
}
