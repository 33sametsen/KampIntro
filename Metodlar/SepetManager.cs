using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stok)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
