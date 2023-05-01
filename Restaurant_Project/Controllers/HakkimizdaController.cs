﻿using Restaurant_Project.Models.Entity;
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
        HakkimdaRepo repo = new HakkimdaRepo();


        [HttpGet]
        public ActionResult HakkimizdaDuzenle(int id)
        {
            Tbl_Hakkimda t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult HakkimizdaDuzenle(Tbl_Hakkimda p)
        {
            Tbl_Hakkimda t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Aciklama = p.Aciklama;
            p.Resim_Link = p.Resim_Link;
            p.Madde = p.Madde;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}