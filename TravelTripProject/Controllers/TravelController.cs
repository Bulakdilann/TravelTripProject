using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        Context _db = new Context();
        public ActionResult Index()
        {
            var listele = _db.Blogs.Take(4).ToList(); //Slider içine Ana sayfada 4 resim gelsin
            return View(listele);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = _db.Blogs.OrderBy(x => x.Id).Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = _db.Blogs.OrderByDescending(x => x.Id).Take(10).ToList();
            return PartialView(degerler);
        }
    }
}