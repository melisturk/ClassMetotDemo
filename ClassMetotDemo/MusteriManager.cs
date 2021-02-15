using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
        }

        public void Listele(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Musteri Adı : " + item.musteriAdi);
                Console.WriteLine("Musteri Soyadı : " + item.musteriSoyadi);

            }

        }
    }
}
