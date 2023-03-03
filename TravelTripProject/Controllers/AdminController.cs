﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context _db = new Context();
        public ActionResult Index()
        {
            var listele = _db.Blogs.ToList();
            return View(listele);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
            //Sayfa yüklenince sayfanın boş halini bana döndür
        }
        [HttpPost]
        public ActionResult NewBlog(Blog b)
        {
            _db.Blogs.Add(b);
            _db.SaveChanges();
            // Kaydettikten sonra Index Sayfasına Git
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteBlog(int id)
        {
            var bul = _db.Blogs.Find(id);
            _db.Blogs.Remove(bul);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateBlog(int id)
        {
            var bul= _db.Blogs.Find(id);
            return View("UpdateBlog",bul);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog b)
        {
            var bul = _db.Blogs.Find(b.Id);
            bul.Explanation = b.Explanation;
            bul.Title = b.Title;
            bul.Date = b.Date;
            bul.BlogImage = b.BlogImage;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}