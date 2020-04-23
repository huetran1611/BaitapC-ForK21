
using System;

namespace Chuong2_Vidu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = "hello";
            string s2 = "world";

            Console.WriteLine("2 bien ma ban vua tao ra co thong tin nhu sau:");
            Console.WriteLine("s1: {0}, s2: {1}", s1, s2);

            Console.ReadLine();

            Console.WriteLine("Bắt đầu chương trình tính tổng của hai số");
            Console.WriteLine("Hãy nhập số nguyên thứ 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hay nhap vao số nguyên thứ 2");
            int b = Int32.Parse(Console.ReadLine());

            int tong = a + b;

            Console.WriteLine("Tong của {0} và {1} là {2}", a, b, tong);
            Console.Read();

        }
    }
}
