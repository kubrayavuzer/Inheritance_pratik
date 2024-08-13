using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_pratik
{
    public class BaseKisi
    {
        // Base sınıf özellikleri
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Base sınıf metot
        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    public class 
        Ogrenci : BaseKisi
    {
        //öğrenci sınıfı için ek özellik
        public int 
            OgrenciNumarasi { get; set; }
        //öğrenci sınıfı için ek metot
        public void 
            OgrenciBilgileriniYazdir()
        {
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
            AdSoyadYazdir();  
        }
    }

    public class Ogretmen : BaseKisi
    {
        //öğremen sınıfı için ek özellik
        public decimal 
            Maas { get; set; }

        //öğretmen sınıfı için ek metot

        public void 
            OgretmenBilgileriniYazdir()
        {
            Console.WriteLine($"Maaş: {Maas} TL");
            AdSoyadYazdir();  
        }
    }
}
