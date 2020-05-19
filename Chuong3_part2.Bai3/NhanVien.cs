using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part2.Bai3
{
    class NhanVien 
    {
        //Dữ liệu: Họ tên, Địa chỉ, ngày sinh
        // Phương thức: Nhập, Xuất, Tính lương
        protected string hoTen;
        protected string diaChi;
        protected DateTime ngaySinh;

        protected virtual void Nhap()
        {
            Console.WriteLine("Hay nhap ho ten cua nhan vien");
            hoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap Dia chi cua nhan vien");
            diaChi = Console.ReadLine();

            Console.WriteLine("Hay nhap ngay sinh cua nhan vien:");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
        }

    }
}
