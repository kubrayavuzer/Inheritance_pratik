
using Inheritance_pratik;

class Program
{
    static void Main(string[] args)
    {
        //Öğrenci nesnesi oluşturma, değer atama

        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Ad = "xx";
        ogrenci1.Soyad = "yy";
        ogrenci1.OgrenciNumarasi = 123;

        // Öğrenci bilgilerini yazdırma

        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci1.OgrenciBilgileriniYazdir();
        Console.WriteLine(); 

        //Öğretmen nesnesi oluşturma, değer atama

        Ogretmen ogretmen1 = new Ogretmen();
        ogretmen1.Ad = "aa";
        ogretmen1.Soyad = "bb";
        ogretmen1.Maas = 77;

        //çğretmen bilgilerini yazdırma

        Console.WriteLine("Öğretmen Bilgileri:");
        ogretmen1.OgretmenBilgileriniYazdir();
    }
}