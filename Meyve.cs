using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Meyve : Yiyecek
    {
        public double kalori; 

        public Meyve(string a, string c, double f, double kdv, double k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string Yazdir()
        {
            return $"{base.Yazdir()} {kalori,5}";
        }
    }


}
