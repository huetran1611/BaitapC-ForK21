using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part2.Bai3
{
    class SinhVien : INguoi
    {
        private string hoTen;
        private int namSinh;
        public int Tuoi
        {
            get
            {
                return (System.DateTime.Today.Year - namSinh);
            }
        }

        public void nhap()
        {
            try
            {
                Console.WriteLine("Hay nhap ho ten cua sinh vien");
                hoTen = Console.ReadLine();
                Console.WriteLine("Hay nhap nam sinh cua sinh vien");
                namSinh = Convert.ToInt32(Console.ReadLine());
             } catch( Exception e)
            {
                // Console.WriteLine(e.ToString());

                throw e;
            }
            
        }

        public void xuat()
        {
            Console.WriteLine("Ho ten va nam sinh cua sinh vien la : {0} va {1}", hoTen, namSinh);
            Console.WriteLine("Tuoi cua sinh vien la: " + this.Tuoi);
        }
    }
}
