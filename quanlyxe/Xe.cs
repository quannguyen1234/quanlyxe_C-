using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxe
{
    class Xe
    {
        string tenxe;
        DateTime ngaydangkiem;
        
        public virtual void nhap()
        {
            Console.WriteLine("tenxe");
            this.tenxe = Console.ReadLine();
            Console.WriteLine("ngaydangkiem");
            Console.WriteLine("dd/mm/yyyy");
            int[] date = new int[3];
            int count = 0;
            foreach(var c in Console.ReadLine().Split('/'))
            {
                date[count++] = int.Parse(c);
            }
            this.ngaydangkiem = new DateTime(date[2], date[1], date[0]);

        }
        public virtual void xuat()
        {
            Console.WriteLine("tenxe :{0}", this.tenxe);
            Console.WriteLine("ngaydangkiem :{0}", this.ngaydangkiem);
        }
        public string get_tenxe()
        {
            return this.tenxe;
        }
    }
    
}
