using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******MÜŞTERİ BİLGİLERİ*****");
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Büşra";
            musteri1.Soyad = "Çoğul";
            musteri1.Tc = "00000000000";
            musteri1.TelefonNo = "05256565656";
            musteri1.Yas = "19";
            musteri1.HesapHareketleri = "Son 1 hafta içinde hesapta bir hareketlilik yok";


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Sena";
            musteri2.Soyad = "Ecer";
            musteri2.Tc = "11111111111";
            musteri2.TelefonNo = "05423698574";
            musteri2.Yas = "20";
            musteri2.HesapHareketleri = "Az önce 200 tl çekildi";


            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Yazar";
            musteri3.Tc = "33333333333";
            musteri3.TelefonNo = "05968741232";
            musteri3.Yas = "21";
            musteri3.HesapHareketleri = "3 gün önce 50 tl para yatırma işlemi gerçekleştirildi";

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Özlem";
            musteri4.Soyad = "Hatun";
            musteri4.Tc = "44444444444";
            musteri4.TelefonNo = "03265875436";
            musteri4.Yas = "22";
            musteri4.HesapHareketleri = "Hareketlilik yok";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (var musteri in musteriler)
            {

                Console.WriteLine("İsim: " + musteri.Ad);
                Console.WriteLine("Soyisim: " + musteri.Soyad);
                Console.WriteLine("TC No: " + musteri.Tc);
                Console.WriteLine("Telefon numarası: " + musteri.TelefonNo);
                Console.WriteLine("Yaş: " + musteri.Yas);
                Console.WriteLine("Hesap Hareketliliği: " + musteri.HesapHareketleri);

                Console.WriteLine("------------------");
            }

            Console.WriteLine("********MÜŞTERİLERİMİZLE İLGİLİ GERÇEKLEŞEN BİRTAKIM İŞLEMLER*********");
           
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);

            foreach (var musteri in musteriler)
            {
                musteriManager.Listeleme(musteri);
            }


        }
    }
}
