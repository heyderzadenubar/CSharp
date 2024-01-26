using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpGet.Models;

namespace HttpGet.Controllers
{
    public class HomeController : Controller
    {
        private static List<Kadrlar> _kadrlar = new List<Kadrlar>
        {
           new Kadrlar{Id=1,Ad="İlkin",Soyad="Soltanov",VesiqeNo="11111111",DogumTarixi= new DateTime(1993,1,22) },
           new Kadrlar{Id=2,Ad="Arzu",Soyad="Soltanova",VesiqeNo="11111112",DogumTarixi=new DateTime(1992,1,22) },
           new Kadrlar{Id=3,Ad="Nuray",Soyad="Soltanova",VesiqeNo="11111113",DogumTarixi= new DateTime(1991,1,22)},
           new Kadrlar{Id=4,Ad="İlkin",Soyad="Soltanov",VesiqeNo="11111113",DogumTarixi= new DateTime(1990,1,22)}
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult KadrAxtar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult KadrAxtarNetice(string kadrAdi)
        {
            var kadrlar = _kadrlar.Where(p => p.Ad.Contains(kadrAdi)).ToList();

            return View(kadrlar);
        }

    }
}