using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //ekleme
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni eklenen müşterinin ismi: " + musteri.Ad + " " + musteri.Soyad);
        }

        //silme
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşterinin ismi: " + musteri.Ad + " " + musteri.Soyad);
        }

        //listeleme
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşterilerimiz: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
