using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array - dizi
            string[] kurslar = new string[] {
                "yazılım geliştirici yetiştirme kampı" ,
                "programlamaya başlangıç için temel kurs",
                "java",
                "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            //foreach dizileri dolaşmak için daha fazla kullanılır.








        }
    }
}
