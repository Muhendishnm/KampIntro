using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik_4_örn
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) //Toplama yapabilmek için en az 2 sayı vermen gerek demektir.
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
