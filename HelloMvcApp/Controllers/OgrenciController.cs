using HelloMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelloMvcApp.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult OgrenciBilgi(int id)
        {
            var ogr = new Ogrenci();
            if (id == 1)
            {
                ogr.Ad = "Ali";
                ogr.Soyad = "Veli";
                ogr.Numara = 123;
            }
            else if (id == 2)
            {
                ogr.Ad = "Ahmet";
                ogr.Soyad = "Mehmet";
                ogr.Numara = 456;
            }
            else
            {
                ogr = null;
            }

            //ViewData["ogrenci"] = ogr;
            //ViewBag.Student = ogr;

            var ogretmen = new Ogretmen();
            ogretmen.Ad = "Ahmet";
            ogretmen.Soyad = "Mehmet";
            ogretmen.Tckimlik = "12345678910";

            // ViewBag.Ogretmen = ogretmen;
            var info = new InfoDTO(ogr, ogretmen);

            return View(info);
        }

        public ViewResult Test()
        {
            var ogr = new Ogrenci();
            ogr.Ad = "Ahmet";
            ogr.Soyad = "Mehmet";
            ogr.Numara = 456;
            ViewData["Student"] = ogr;
            ViewBag.Ogrenci = ogr;

            var ogretmen = new Ogretmen { Ad = "Ali", Soyad = "Veli", Tckimlik = "123" };
            var info = new InfoDTO(ogr, ogretmen);
            return View(info);
        }

        public ViewResult OgrenciListe()
        {
            var ogr = new Ogrenci();
            ogr.Ad = "Ali";
            ogr.Soyad = "Veli";
            ogr.Numara = 123;

            var ogr2 = new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Numara = 456 };

            Ogrenci[] ogrenciler = new Ogrenci[2];
            ogrenciler[0] = ogr;
            ogrenciler[1] = ogr2;

            return View(ogrenciler);
        }
    }
}
//ViewData: Collection- Key Value Pair
//Keyler tekil olmalıdır.
//Object tipinde değer taşırlar.

//ViewBag arka planda ViewData Koleksiyonunu kullanır. ViewData'da kullanılan bir key değeri, ViewBag'de kullanılmamalıdır.
//ViewBag object tipinde veri taşır ancak kendisi dynamic'tir.Dynamic yapıların içindeki verilerin tipi, runtime sırasında tespit edilir.
