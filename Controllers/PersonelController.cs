using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDbMvc.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreDbMvc.Controllers
{
    public class PersonelController : Controller
    {
        // GET: /<controller>/
        private readonly Context db;

        public PersonelController(Context _db)
        {
            db = _db;
        }
        public IActionResult Personel()
        {
            var degerler = db.Personels.ToList();
            return View(degerler);
        }
    }
}   

