using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_Code_First_Entity.Models.Siniflar;

namespace Skill_Code_First_Entity.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = c.Yeteneklers.ToList(); 
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y)
        {
            c.Yeteneklers.Add(y);
            c.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = c.Yeteneklers.Find(id);
            c.Yeteneklers.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {   
            var deger = c.Yeteneklers.Find(id);
            return View("YetenekGuncelle",deger);
        }

        [HttpPost]
        public ActionResult YetenekGuncelle(Yetenekler y)
        {
            var x = c.Yeteneklers.Find(y.ID);
            x.Aciklama = y.Aciklama;
            x.Seviye = y.Seviye;
            c.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}