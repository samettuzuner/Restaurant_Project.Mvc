using Restaurant_Project.Models.Entity;
using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        GenericRepo<Tbl_Hakkimda> repo=new GenericRepo<Tbl_Hakkimda>();
       

        [HttpGet]
        public ActionResult Hakkimizda(int id)
        {
            Tbl_Hakkimda t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult Hakkimizda(Tbl_Hakkimda p)
        {
            Tbl_Hakkimda t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama = p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index","Default");
        }
    }
}
