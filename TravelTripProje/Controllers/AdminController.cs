using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context E = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = E.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet] /*==> sayfa yüklenince action alma sayfayı boş döndür.*/
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost] /*==> Sayfada Post işlemi yapınca buradaki action kullan.*/
        public ActionResult YeniBlog(Blog B)
        {
            E.Blogs.Add(B);
            E.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var B = E.Blogs.Find(id);
            E.Blogs.Remove(B);
            E.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult BlogGetir(int id)
        {
            var B = E.Blogs.Find(id);
            return View("BlogGetir", B);
        }
        public ActionResult BlogGuncelle(Blog G)
        {
            var BL = E.Blogs.Find(G.Id);
            BL.Acıklama = G.Acıklama;
            BL.Baslık = G.Baslık;
            BL.BlogImage = G.BlogImage;
            BL.Tarih = G.Tarih;
            E.SaveChanges();
            return RedirectToAction("Index");   
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = E.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var B = E.Yorumlars.Find(id);
            E.Yorumlars.Remove(B);
            E.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

        public ActionResult YorumGetir(int id)
        {
            var B = E.Yorumlars.Find(id);
            return View("YorumGetir", B);
        }

        public ActionResult YorumGuncelle(Yorumlar G)
        {
            var BL = E.Yorumlars.Find(G.Id);
            BL.KullanıcıAdı= G.KullanıcıAdı;
            BL.Mail = G.Mail;
            BL.Yorum = G.Yorum;
            E.SaveChanges();
            return RedirectToAction("YorumListesi");
        }




    }
}


