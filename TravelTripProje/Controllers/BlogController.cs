using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
    
{
    public class BlogController : Controller
    {
        Context con = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index() /*==>Blog index*/
        {
           // var bloglar =con.Blogs.ToList();
           by.Deger1=con.Blogs.ToList();
           by.Deger3=con.Blogs.Take(2).ToList();    
            return View(by);
        }
        
         
        public ActionResult BlogDetay(int id)
        {
            //var blogbul=con.Blogs.Where(b => b.Id == id).ToList();
            by.Deger1= con.Blogs.Where(X=> X.Id==id).ToList();
            by.Deger2 = con.Yorumlars.Where(X=> X.blogid == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();

        }
                
        
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar Y)
        {
            con.Yorumlars.Add(Y);
            con.SaveChanges();
            return PartialView("Index");

        }

    }
}