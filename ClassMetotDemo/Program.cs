using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Melis";
            musteri1.musteriSoyadi = "Turk";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAdi = "Ayberk";
            musteri2.musteriSoyadi = "Akin";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele(musteriler);
        
        }
    }
}
