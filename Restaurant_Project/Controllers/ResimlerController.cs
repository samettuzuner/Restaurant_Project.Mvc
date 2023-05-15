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
        // GET: Resimler
        ResimlerRepo repo=new ResimlerRepo();
        public ActionResult Index()
        {
            var resim=repo.List();
            return View(resim);
        }
        public ActionResult ResimSil(int id)
        {
            Tbl_Resimler resimsil = repo.Find(x => x.ID == id);
            repo.TDelete(resimsil);
            return RedirectToAction("Index");
        }
    }
}