using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context con = new Context();  //context sayesinde hakkımızda ulaşıyoruz.  
        public ActionResult IndexAbt()
        {
            var degerler=con.Hakkımızdas.ToList();
            return View(degerler);
        }
    }
}