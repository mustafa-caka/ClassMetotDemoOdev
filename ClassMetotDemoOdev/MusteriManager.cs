using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoOdev
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("Müşteri Tc No : " + musteri.TcNo);
            Console.WriteLine("Müşteri Adı : " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadı :" + musteri.MusteriSoyAdi);
            Console.WriteLine("Müşteri Kayıt Yılı :" + musteri.KayitYili);
            Console.WriteLine("Müşteri Yılı :" + musteri.MusteriYili);
           
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!!");
            Console.WriteLine("Müşteri Tc No : " + musteri.TcNo);
            Console.WriteLine("Müşteri Adı : " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadı :" + musteri.MusteriSoyAdi);
            Console.WriteLine("Müşteri Kayıt Yılı :" + musteri.KayitYili);
            Console.WriteLine("Müşteri Yılı :" + musteri.MusteriYili);
           

        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi!");
            Console.WriteLine("Müşteri Tc No : " + musteri.TcNo);
            Console.WriteLine("Müşteri Adı : " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadı :" + musteri.MusteriSoyAdi);
            Console.WriteLine("Müşteri Kayıt Yılı :" + musteri.KayitYili);
            Console.WriteLine("Müşteri Yılı :" + musteri.MusteriYili);
        }
    }
}
