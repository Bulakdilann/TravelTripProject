using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context _db = new Context();
        public ActionResult Index()
        {
            var bloglar = _db.Blogs.ToList();
            return View(bloglar);
        }

        public ActionResult BlogDetail(int id)
        {
            var blogbul = _db.Blogs.Where(x => x.Id == id).ToList();
            return View(blogbul);
        }
    }
}