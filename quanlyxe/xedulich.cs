using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxe
{
    class xedulich : Xe
    {
        int sochongoi;
        public override void nhap()
        {
            Xe xe = new Xe();
            xe.nhap();
            Console.WriteLine("nhap so cho ngoi");
            this.sochongoi=int.Parse(Console.ReadLine());
            
        }
        public override void xuat()
        {

        }
    }
}
