using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Yiyecek
    {
        public string adi;
        public string cins;
        public double fiyat;
        public double kdvOrani;

        public Yiyecek() 
        {
            adi = "";
            cins = "";
            fiyat = 0;
            kdvOrani = 0;
        }

        public Yiyecek(string a, string c, double f, double kdv) 
        {
            adi = a;
            cins = c;
            fiyat = f;
            kdvOrani = kdv;
        }

        public virtual string Yazdir()
        {
            return $"{adi,-10} {cins,-10} {fiyat,10} {kdvOrani,3}";
        }
    }

}
