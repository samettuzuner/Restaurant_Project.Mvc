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
        GenericRepo<Tbl_NedenSecmelisiniz> repo = new GenericRepo<Tbl_NedenSecmelisiniz>();
        public ActionResult Index()
        {
            var neden = repo.List();
            return View(neden);
        }

        [HttpGet]
        public ActionResult nedenBiz(int id)
        {
            Tbl_NedenSecmelisiniz t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult nedenBiz(Tbl_NedenSecmelisiniz p)
        {
            Tbl_NedenSecmelisiniz t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public ActionResult nedenBizDuzenle(int id)
        {
            Tbl_NedenSecmelisiniz t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult nedenBizDuzenle(Tbl_NedenSecmelisiniz p)
        {
            Tbl_NedenSecmelisiniz t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult nedenBizSil(int id)
        {
            Tbl_NedenSecmelisiniz t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
    }
}