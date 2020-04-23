using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part1_bt5
{
    class Nhanvien
    {

        //        Các thành phần dữ liệu
        //Họ tên, Năm sinh, Địa chỉ, Lương cơ bản, Hệ số, Phụ cấp, Tổng tiền
        //Các phương thức
        //Hàm tạo không tham số
        //Nhập nhân viên
        //Tính lương: Tổng tiền = Lương cơ bản x Hệ số + Phụ cấp
        //In nhân viên ra màn hình
        private string HoTen;
        private int NamSinh;
        private string DiaChi;
        private double LuongCoBan;
        private double HeSo;
        private double PhuCap;
        private double TongTien;

        public Nhanvien()
        {
            HoTen = "";
            NamSinh = 1900;
            DiaChi = "";
            LuongCoBan = HeSo = PhuCap = TongTien = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Hay nhập họ tên nhân viên:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hãy nhập năm sinh của nhân viên");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhập địa chỉ của nhận viên: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Hay nhập hệ số lương của nhân viên");
            HeSo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hãy nhập vào lương cơ bản của nhân viên");
            LuongCoBan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hãy nhập vào phụ cấp của nhân viên");
            PhuCap = Convert.ToDouble(Console.ReadLine());
        }
        public void Tinhluong()
        {
            TongTien = LuongCoBan * HeSo + PhuCap;
        }

        public void InThongTinNV()
        {
            Console.WriteLine("Thông tin của nhân viên: \n Tên : {0} \t Năm sinh : {1}" +
                "\t Đia chỉ: {2} \n tổng lương : {3}", HoTen, NamSinh, DiaChi, TongTien);
        }


    }
}
