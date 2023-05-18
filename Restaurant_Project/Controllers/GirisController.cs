using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        GirisRepo repo = new GirisRepo();

        [HttpGet]
        public ActionResult GirisDuzenle(int id)
        {
            Tbl_Giris t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult GirisDuzenle(Tbl_Giris p)
        {
            Tbl_Giris t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.AltBilgi = p.AltBilgi;
            repo.TUpdate(t);
            return View(t);
        }
    }
}