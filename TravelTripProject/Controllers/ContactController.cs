using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context _db = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact c)
        {
            _db.Contacts.Add(c);
            _db.SaveChanges();
            return View();
        }
    }
}