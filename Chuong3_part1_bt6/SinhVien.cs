using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part1_bt6
{
    class SinhVien
    {
        //Mã sinh viên, Họ tên, Năm sinh, Điểm lập trình, Điểm CSDL, Điểm TB(trong đó: Điểm TB = Điểm Lập trình + Điểm CSDL)/2
        public string masv;
        private string HoTen;
        private int NamSinh;
        private double DiemLT, DiemCSDL, DiemTB;

        //Hàm tạo không tham số

        public SinhVien()
        {
            masv = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;
        }

        // Ham khoi tao  chuan 5 tham so

        public SinhVien (string masv, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLT + DiemCSDL) / 2;
        }

        public void Nhap()
        {
            // Hay tu viet
            Console.WriteLine("Ban dang goi ham nhap tt");
            Console.WriteLine("Hay nhap ma cua sinh vien");
            masv = Console.ReadLine();
        }
        public void Xuat()
        {
            //HayTu viet
            Console.WriteLine("Ban dang goi ham xuat tt");
            Console.WriteLine("Ma cua sinh vien la: " + masv);
        }


    }
}
