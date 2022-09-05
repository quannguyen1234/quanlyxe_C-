using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxe
{
    class quanlyxe
    {
        Dictionary<string, Xe> LIST = new Dictionary<string, Xe>();

        public void nhap()
        {
            Console.WriteLine("H/D");
            char c = Console.ReadLine().ToUpper()[0];
            Xe xe;
            if (c == 'H')
            {
                xe = new xechohang();
            }
            else
            {
                xe = new xedulich();

            }
            xe.nhap();

            this.LIST.Add(xe.get_tenxe(), xe);
        }
        public void xuat()
        {
            foreach (KeyValuePair<string, Xe> item in this.LIST)
            {
                item.Value.xuat();
            }
        }
        public void nhap_nguoi()
        {
            nhanvien nv = new nhanvien();
            nv.nhap1();
        }
        public static void Main(string[] args)
        {
            //quanlyxe qlx = new quanlyxe();
            //while( true){
            //    qlx.nhap();
            //    Console.WriteLine("t/d");
            //    if(Console.ReadLine()[0] == 'd')
            //    {
            //        break;
            //    }
            //}
            Xe xdl = new xedulich();
            xdl.nhap();
            xdl.xuat();

            //x.nhap();
            //x.xuat();
            //x.nhap_nguoi();
            Console.ReadLine();
        }
    }
}
