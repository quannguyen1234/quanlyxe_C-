using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxe
{
    abstract class nguoi
    {
        string hoten;

        public abstract void nhap();
        public void nhap1()
        {
            Console.WriteLine("nhap ho ten ");
            this.hoten = Console.ReadLine();
        }
        public abstract void xuat();

    
    }
}
