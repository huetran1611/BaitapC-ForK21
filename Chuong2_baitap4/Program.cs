using System;

namespace Chuong2_baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac tamgiac1 = new TamGiac();
            //tamgiac1.nhap();
            if (tamgiac1.IsTamGiac())
            {
                Console.WriteLine("Dien tích và chu vi cua tam giac ban vua nhap vao lan luot la {0} và {1}", 
                                    tamgiac1.DienTich(), tamgiac1.ChuVi());
            }
                      

            TamGiac TamGiac2 = new TamGiac(2, 4, 3);

            Console.WriteLine("Dien tích và chu vi cua tam giác thứ 2 là:  {0} và {1}",
                                   TamGiac2.DienTich(), TamGiac2.ChuVi());
            Console.ReadLine();

            TamGiac TamGiac3 = new TamGiac(TamGiac2);
                       
            Console.WriteLine("Dien tich và chu vi cua tam giac 3 là: {0} và {1}", TamGiac3.DienTich(), TamGiac3.ChuVi());

            TamGiac3.nhap();

            Console.WriteLine("Dien tich và chu vi của tam giác 3 sau khi vừa thực hiện hàm nhập la: {0} và {1}: "
                                , TamGiac3.DienTich(), TamGiac3.ChuVi());
            Console.WriteLine("Diện tích và chu vi của tam giác 2 sau khi thay đổi thông tin của tam giác 3 sẽ là: {0} và {1}",
                                TamGiac2.DienTich(), TamGiac2.ChuVi());
            Console.Read();

        }
    }
}
