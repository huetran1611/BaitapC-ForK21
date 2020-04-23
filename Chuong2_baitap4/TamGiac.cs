using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong2_baitap4
{
    class TamGiac
    {
        int a, b, c;
        public bool IsTamGiac()
        {
            bool ketqua = false;

            if ((a + b) > c && (b + c) > a && (a + c) > b)
                ketqua = true;
            return ketqua;
        }
        public double ChuVi()
        {
            if (IsTamGiac())
            {
                return (a + b + c);
            }
            else
                Console.WriteLine("Đây không phải 1 tam giá");
            return -1;
        }
        public double DienTich()
        {
            if (IsTamGiac())
            {
                double p = 0.5 *(a + b + c) ;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                return (-1);
        }
        public void nhap()
        {
            Console.WriteLine("Hay nhập vào cạnh a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhập vào cạnh b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhập vào cạnh c");
            c = Convert.ToInt32(Console.ReadLine());
        }

        public TamGiac()
        {
            a = b = c = 1;
        }

        public TamGiac(int chieudaicanh)
        {
            a = b = c = chieudaicanh;
        }

        public TamGiac (int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public TamGiac (TamGiac tg)
        {
            this.a = tg.a;
            this.b = tg.b;
            this.c = tg.c;
        }



    }
}
