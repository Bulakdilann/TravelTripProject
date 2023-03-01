using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        Context _db = new Context();
        public ActionResult Index()
        {
            var degerler = _db.AboutUs.ToList();
            return View(degerler);
        }
    }
}