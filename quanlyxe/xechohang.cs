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

        }
        public override void xuat()
        {

        }
        public void aaa()
        {

        }
    }

    class quanlyxe
    {
        Dictionary<string, Xe> LIST =new Dictionary<string, Xe>();

        public void nhap()
        {
            Console.WriteLine("H/D");
            char c= Console.ReadLine().ToUpper()[0];
            Xe xe;
            if(c == 'H')
            {
                xe = new xechohang();
                xechohang xch = new xechohang();
                xe.aaa();
                
            }
            else
            {
                xe = new xedulich();
                
            }
            xe.nhap();
            
            this.LIST.Add("xe1",xe);
        }
        public void xuat()
        {
            foreach(KeyValuePair<string,Xe> item  in this.LIST)
            {
                item.Value.xuat();
            }
        }
        public static void Main(string[] args) 
        {
            quanlyxe x = new quanlyxe();
            x.nhap();
            x.xuat();
            Console.ReadLine();
        }
    }
    
}
