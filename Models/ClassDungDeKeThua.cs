using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTB1.Models
{
    public class GiaiPTB1
    {
        //phuong thuc giai phuong trinh bac 1
        //can tra ve gia tri x, kieu double
        //co 2 he so a va b la 2 tham so dau vao cua phuong thuc
        //kieu gia tri tra ve cua phuong thuc la double
        public double GiaiPhuongTrinh(double heSoA, double heSoB)
        {
            double x = -heSoB / heSoA;
            //gia tri tra ve cua phuong thuc (bat buoc)
            return x;
        }
    }
}