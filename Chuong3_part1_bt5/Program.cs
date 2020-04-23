using System;

namespace Chuong3_part1_bt5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Nhanvien nv = new Nhanvien();
            nv.Nhap();
            nv.Tinhluong();
            nv.InThongTinNV();
            Console.ReadLine();
        }
    }
}
