using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDbMvc.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreDbMvc.Controllers
{
    public class DepartController : Controller
    {
        private readonly Context db;

        public DepartController(Context _db)
        {
            db = _db;
        }
       
        public IActionResult Depart()
        {
            var degerler = db.Departmanlars.OrderBy(x=>x.Id).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(Departmanlar d)
        {
            db.Departmanlars.Add(d);
            db.SaveChanges();
            return RedirectToAction("Depart");


        }

        public IActionResult DepartmanSil(int Id)
        {
            var dep = db.Departmanlars.Find(Id);
            db.Departmanlars.Remove(dep);
            db.SaveChanges();
            return RedirectToAction("Depart");
        }

        public IActionResult DepartmanGetir(int Id)
        {
            var depart = db.Departmanlars.Find(Id);
            return View("DepartmanGetir",depart);


        }
        public IActionResult DepartmanGuncelle(Departmanlar d)
        {
            var dep = db.Departmanlars.Find(d.Id);            
             dep.DepartmanAd = d.DepartmanAd;
            db.SaveChanges();
            return RedirectToAction("Depart");
                
        }

    }

}

