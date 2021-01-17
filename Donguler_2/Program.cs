using System;

namespace Donguler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);





            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs", "Java" };

            for (int i = 0; i<kurslar.Length; i++) //Length(uzunluk) sayısı bilinmeyenler için kullanılır. 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("sayfa sonu - footer ");
        }
    }
}
