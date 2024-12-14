using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;


namespace TravelTripProje.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        Context con = new Context();
        public ActionResult Index()
        {
            
            return View();
        }


        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult SendMessage(İletişim alayı)
        {
            con.İletişims.Add(alayı);
            con.SaveChanges();
            return PartialView();
        }
    }
}