using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TcNo = 123;
            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriSoyAdi = "BAK";
            musteri1.KayitYili = 2010;
            musteri1.MusteriYili = 13;

            Musteri musteri2 = new Musteri();
            musteri2.TcNo = 456;
            musteri2.MusteriAdi = "Veli";
            musteri2.MusteriSoyAdi = "KAÇ";
            musteri2.KayitYili = 2020;
            musteri2.MusteriYili = 3;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Tc No : " + musteri.TcNo);
                Console.WriteLine("Müşteri Adı : " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı :" + musteri.MusteriSoyAdi);
                Console.WriteLine("Müşteri Kayıt Yılı :" + musteri.KayitYili);
                Console.WriteLine("Müşteri Yılı :"+ musteri.MusteriYili);

            }
            Console.WriteLine("----------Metotlar-----------------------------------");
            Console.WriteLine("------------------EKLEME---------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            

            Console.WriteLine("------------------SİLME---------------");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("-----------------LİSTELEME----------------");
            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);

            Console.ReadLine();

        }
    }
}
