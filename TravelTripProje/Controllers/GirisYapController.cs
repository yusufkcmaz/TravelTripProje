﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Sınıflar;
namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        Context c = new Context();
        // GET: GirisYap
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admın ad )
        {
            var bilgiler = c.Admıns.FirstOrDefault(x => x.Kulanıcı == ad.Kulanıcı && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kulanıcı, false);
                Session["Kulanıcı"]=bilgiler.Kulanıcı.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
            
            //***CHATGPT ARAŞTIRMA YAPILCAK

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}