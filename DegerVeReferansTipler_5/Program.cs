using System;

namespace DegerVeReferansTipler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int,decimal,fload,double,bool(0,1) = değer tip
            //array,class,interface = referans tipler
            //bellekte 2 alan var; stack(değer tip gerçekleşir) ve heap(new int[]) 

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi2 değerini sayi1 e eşitle sayi1=30 sayi2=30 oldu.
            //sonra Sayi2= 65 verdik. Sayi1 i soruyor.Sayi1 = 30 
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 }; //new heap adresinde yeni bir yer oluştur demektir.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar1 in referans numarasını sayilar2nin ref.no suna eşitle.
            sayilar2[0] = 999;
            //sayilar1[0] 999 

            //Artık new int[] { 10, 20, 30 }; değerini tutan olmadığı için bellekten kendiliğinden silinecektir.
        }
    }
}
