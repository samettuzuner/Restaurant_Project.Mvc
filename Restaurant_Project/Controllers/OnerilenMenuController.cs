using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class OnerilenMenuController : Controller
    {
        // GET: OnerilenMenu
        
        OnerilerRepo repo=new OnerilerRepo();
        public ActionResult Index()
        {
            var oneriler = repo.List();
            return View(oneriler);
        }
        [HttpGet]
        public ActionResult OneriGuncelle(int id)
        {
            var oneriguncelle = repo.Find(x => x.ID == id);
            return View();
        }
        [HttpPost]
        public ActionResult OneriGuncelle(Tbl_Onerilerimiz p)
        {
            var t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama1 = p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            t.Resim_Adres = p.Resim_Adres;

            repo.TUpdate(t);
            return RedirectToAction("Index");
        }


    }
}