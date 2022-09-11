using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id+" "+ product.Adi+" "+ product.Fiyati+" "+ product.Aciklama);            
            }
            Console.WriteLine("\n ***** Metodlar ******");
            //instant - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 16,5);
        }
    }
}