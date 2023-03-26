using HelloMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HelloMvcApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Ogrenci> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }


        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddStudent(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                var sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    TempData["sonuc"] = true;
                }
               
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteStudent(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(id);
                ctx.Ogrenciler.Remove(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult UpdateStudent(int id)
        {
            Ogrenci ogr;
            using (var ctx = new OkulDbContext())
            {
                ogr = ctx.Ogrenciler.Find(id);
            }
            return View(ogr);
        }

        [HttpPost]
        public IActionResult UpdateStudent(Ogrenci ogr)
        {           
            using (var ctx = new OkulDbContext())
            {
                ctx.Entry(ogr).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
