﻿using System;

namespace Chuong3_part1_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien htttak21 = new DanhSachSinhVien();
            htttak21.Nhap();
            htttak21.Xuat();
            htttak21.SapXep();
            htttak21.Xuat();
            Console.ReadLine();

        }
    }
}
