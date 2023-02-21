using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skill_Code_First_Entity.Models.Siniflar;
namespace Skill_Code_First_Entity.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();

        // GET: Default
        public ActionResult Index()
        {
           
            var degerler = c.Yeteneklers.ToList();
            return View(degerler);
        }



    }
}