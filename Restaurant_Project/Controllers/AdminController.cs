using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepo<Tbl_Admin> repo = new GenericRepo<Tbl_Admin>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(Tbl_Admin p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminGetir(int id)
        {
            Tbl_Admin t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult AdminGetir(Tbl_Admin p)
        {
            Tbl_Admin t = repo.Find(x => x.ID == p.ID);
            t.Sifre = p.Sifre;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}