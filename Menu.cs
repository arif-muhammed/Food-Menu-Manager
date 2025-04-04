using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Menu
    {
        private List<Yiyecek> liste = new List<Yiyecek>();

        public void Ekle(Yiyecek y)
        {
            liste.Add(y);
        }

        public void Sil(int index)
        {
            if (index >= 0 && index < liste.Count)
                liste.RemoveAt(index);
        }

        public List<Yiyecek> MenuYazdir()
        {
            return liste;
        }

        public string TumMenuyuYazdir()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in liste)
            {
                sb.AppendLine(item.Yazdir());
            }
            return sb.ToString();
        }
    }

}
