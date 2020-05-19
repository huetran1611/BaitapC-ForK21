using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part2.Bai3
{
    class NhanVienCN:NhanVien, INguoi
    {
        private int soNgayCong;

        int INguoi.Tuoi => throw new NotImplementedException();

       

        void INguoi.nhap()
        {
            base.Nhap();
            Console.WriteLine("Hay nhap so ngay cong: ");
            soNgayCong = Convert.ToInt32(Console.ReadLine());
        }

        void INguoi.xuat()
        {
            throw new NotImplementedException();
        }
    }
}
