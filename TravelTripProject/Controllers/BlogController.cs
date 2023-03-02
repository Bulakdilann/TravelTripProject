﻿using System;
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
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var bloglar = _db.Blogs.ToList();
            bc.Deger1 = _db.Blogs.ToList();
            bc.Deger3 = _db.Blogs.OrderByDescending(x=>x.Id).Take(3).ToList();
            return View(bc);
        }

       
        public ActionResult BlogDetail(int id)
        {

            // var blogbul = _db.Blogs.Where(x => x.Id == id).ToList();
            bc.Deger1 = _db.Blogs.Where(x => x.Id == id).ToList();
            bc.Deger2 = _db.Comments.Where(x => x.BlogId == id).ToList();
            bc.Deger3 = _db.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(bc);
        }
    }
}