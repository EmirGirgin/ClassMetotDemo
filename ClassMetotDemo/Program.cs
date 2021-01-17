using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Emir";
            musteri1.Soyad = "Girgin";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Nilay";
            musteri2.Soyad = "Demircan";
            musteri2.Id = 2;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusterSil(musteri1);

            Musteri[] musteri = new Musteri[]
            {
                musteri1,musteri2
            };

            musteriManager.MusteriListele(musteri);
            
        }
    }
}
