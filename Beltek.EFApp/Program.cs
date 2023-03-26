using System;
using System.Collections.Generic;
using System.Linq;

namespace Beltek.EFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = new Ogrenci();
            //    ogr.Ad = "Ahmet";
            //    ogr.Soyad = "Mehmet";
            //    ogr.Numara = 456;

            //    ctx.Ogrenciler.Add(ogr);
            //    int sonuc = ctx.SaveChanges();
            //    if (sonuc > 0)
            //        Console.WriteLine("Kayıt Başarıyla Eklendi!");
            //}

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = ctx.Ogrenciler.Find(2);
            //    ogr.Numara = 789;
            //    if (ctx.SaveChanges() > 0)
            //    {
            //        Console.WriteLine("Kayıt Başarıyla Güncellendi!");
            //    }
            //}

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = ctx.Ogrenciler.Find(2);
            //    ctx.Ogrenciler.Remove(ogr);
            //    ctx.SaveChanges();  
            //}

            //using (var ctx = new OkulDbContext())
            //{
            //    List<Ogrenci> lst = ctx.Ogrenciler.ToList();

            //    foreach (var ogrenci in lst)
            //    {
            //        Console.WriteLine($"Ad:{ogrenci.Ad} Soyad:{ogrenci.Soyad} Numara:{ogrenci.Numara}");
            //    }
            //}
        }
    }
}

//Entity Framework Veritabanı oluşturma yöntemleri
//Code First: Önce kod sonra veritabanı
//DB First: Önce veritabanı sonra kod
