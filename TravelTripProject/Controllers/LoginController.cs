using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context _db = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = _db.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
            if (bilgiler !=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.User, false);
                Session["user"] = bilgiler.User.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
          
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}