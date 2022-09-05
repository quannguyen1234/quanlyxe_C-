using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxe
{
    class xechohang : Xe
    {
        double sotan;
        public override void nhap()
        {
            //Xe xe = new Xe();
            base.nhap();
            Console.WriteLine("nhap so so tan");
            this.sotan = double.Parse(Console.ReadLine());

        }
        public override void xuat()
        {

        }
        public void aaa()
        {

        }
    }

    
    
}
