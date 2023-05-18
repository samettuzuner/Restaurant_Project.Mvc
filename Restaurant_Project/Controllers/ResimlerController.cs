using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class ResimlerController : Controller
    {
        // GET: Resim
        ResimlerRepo repo = new ResimlerRepo();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult ResimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResimEkle(Tbl_Resimler p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult ResimSil(int id)
        {
            var resimSil = repo.Find(x => x.ID == id);
            repo.TDelete(resimSil);
            return RedirectToAction("Index");
        }
      

    }
}