using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part2_vd1
{
    class SinhVien:Nguoi
    {
        private double DiemLT, DiemCSDL, DiemTB;

        public SinhVien():base()
        {
            this.DiemLT = this.DiemTB = this.DiemCSDL = 0;
        }
    }
}
