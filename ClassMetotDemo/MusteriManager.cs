using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Siteye Giriş Yaptı");
        }
        
        public void MusterSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Kaydınız Silinmiştir");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi");
            foreach(var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "Id : " + musteri.Id);
            }
        }
    }
}
