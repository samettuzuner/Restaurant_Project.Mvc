using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class NedenBizController : Controller
    {
        // GET: NedenBiz

        NedenBizRepo repo = new NedenBizRepo();
        public ActionResult Index()
        {
            var neden = repo.List();
            return View(neden);
        }
        [HttpGet]
        public ActionResult NedenGuncelle(int id)
        {
            var nedenGuncelle = repo.Find(x => x.ID == id);
            return View();
        }
        [HttpPost]
        public ActionResult NedenGuncelle(Tbl_NedenSecmelisiniz p)
        {
            var t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}