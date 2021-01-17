using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar_4
{
    class Urun
    {
        //Property - özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public string StokAdedi { get; set; }
        //public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //Bir class ın içinde 2 ayrı metod olabilir.
        //Buraya 'int stokAdedi' eklediğimizde Program.cs de yazılan sepetManager.Ekle2("Armut", "Yeşil armut", 12); bu yerler hata verir ,
         //çünkü biz imzaya uymamış oluruz ve 4. eklenilen stokAdedi yazılmadığı için hata verecektir.
         //gidip tüm alt alta olan verilere tek tek stok adedi eklemek yerine "Urun.cs" de -public string StokAdedi { get; set; }- yazarız!!
         //bu yüzden class kullanırız..
    }
}
