using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        MenuRepo repo= new MenuRepo();
        public ActionResult Index()
        {
            var deger=repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult MenuEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MenuEkle(Tbl_Menu_Yemekler p) 
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult MenuSil(int id)
        {
            var menusil=repo.Find(x=>x.ID==id);
            repo.TDelete(menusil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult MenuGuncelle(int id)
        {
            var menuguncelle = repo.Find(x => x.ID == id);
            return View();
        }
        [HttpPost]
        public ActionResult MenuGuncelle(Tbl_Menu_Yemekler p) 
        { 
            var t=repo.Find(x=>x.ID==p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama=p.Aciklama;
            t.Fiyat = p.Fiyat;
            t.ResimLink=p.ResimLink;

            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}