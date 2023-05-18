using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant_Project.Models.Entity;

namespace Restaurant_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Restaurant_DbEntities1 db = new Restaurant_DbEntities1();
        public ActionResult Index()
        {
            var degerler= db.Tbl_Giris.ToList();
            return View(degerler);
        }
        public PartialViewResult Hakkimda()
        {
            var hakkimda=db.Tbl_Hakkimda.ToList();
            return PartialView(hakkimda);
        }
        public PartialViewResult NedenBiz()
        {
            var neden=db.Tbl_NedenSecmelisiniz.ToList();
            return PartialView(neden);
        }
        public PartialViewResult Menu()
        {
            var menu=db.Tbl_Menu_Yemekler.ToList();
            return PartialView(menu);
        }
        public PartialViewResult Oneriler()
        {
            var oneri=db.Tbl_Onerilerimiz.ToList();
            return PartialView(oneri);
        }
        public PartialViewResult Resimler()
        {
            var resim = db.Tbl_Resimler.ToList();
            return PartialView(resim);
        }
        [HttpGet]
        public PartialViewResult Rezervasyon()
        {
    
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Rezervasyon(Tbl_Rezervasyon t)
        {
            db.Tbl_Rezervasyon.Add(t);
            db.SaveChanges();
            return PartialView();
        }
       
    }
}