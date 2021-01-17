using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar_4
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - söz dizimi
        //Public olarak tanımlanan öğeye kod bloğunun içinden ve dışından erişebilir, yani her yerden ulaşılabilir denilebilir.
        public void Ekle(Urun urun) //Normal parantez varsa orada bir metot çalışıyordur.(C# ve Java için)
          
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urun.Adi);
            //sepetManager bana aynı şeyi tekrar tekrar kullanabilme olanağı verir.5 farklı sayfada sepete ekle yazdırdık.
            //Projede bir farklılık olduğu durumda ör;"Tebrikler.Sepete eklendi." diye değiştirmek istendiğinde SepetManager.cs den ekleme yapabilinir.
            //SepetManager.cs den kodda değişiklik yapılır.Bu tüm program.cs deki yazdırılacak dizine etki eder.
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //Bir class ın içinde 2 ayrı metod olabilir.
        {//Buraya 'int stokAdedi' eklediğimizde Program.cs de yazılan sepetManager.Ekle2("Armut", "Yeşil armut", 12); bu yerler hata verir ,
            //çünkü biz imzaya uymamış oluruz ve 4. eklenilen stokAdedi yazılmadığı için hata verecektir.
            //gidip tüm alt alta olan verilere tek tek stok adedi eklemek yerine "Urun.cs" de -public string StokAdedi { get; set; }- yazarız!!

        }
    }
}
