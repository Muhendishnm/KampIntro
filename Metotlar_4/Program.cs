using System;

namespace Metotlar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma" , "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            // Böylece urun arrayi oluşturabiliriz. Array : Bir veri tipinde istenilen kadar datayı tutan yapıdır.
            // Array (Diziler) çoğul isimlendirilir. Birden fazla data içerdiği için.
            // Burada array urunler olarak isimlendirildi ve içerisinde 2 data var.

            foreach (Urun urun in urunler)
            { // 'urun' aslında takma isimdir x desen de olur. Foreach urunu 2 kere döndürür.Çünkü 2 urun datası var.
              // 'Urun' burada veri tipidir. C# veri güvenlidir.Veri tipi belirtilmelidir.
              // type-safe -- tip güvenli
              // 'Urun' yerine 'var' yazsak da olur. 'var' C# a sonradan girmiş bir keyworddur.

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".............");
                // Tırnak yapmıyoruz dikkat et!!
                // Tırnak içinde yazarsan urun.Adi olarak yazar tırnaksız elma 15 gibi verilerini yazar.

            }
            Console.WriteLine("....Metotlar.....");
            //instance - örnek
            //encapsulation-kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //sepetManager bana aynı şeyi tekrar tekrar kullanabilme olanağı verir.5 farklı sayfada sepete ekle yazdırdık.
            //Projede bir farklılık olduğu durumda ör;"Tebrikler.Sepete eklendi." diye değiştirmek istendiğinde SepetManager.cs den ekleme yapabilinir.

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,1);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,1);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,1);

        }
    }
}

//Dont repeat yourself - DRY (kendini tekrar etme) -Clean Code (temiz kod yazma) - Best Practice 
