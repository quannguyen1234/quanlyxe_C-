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
         
            base.nhap();
            Console.WriteLine("nhap so cho ngoi");
            this.sochongoi=int.Parse(Console.ReadLine());
            
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("sochongoi{0}", sochongoi);

        }
    }
}
