using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class RezervasyonController : Controller
    {
        // GET: Rezervasyon
        RezervasyonRepo repo= new RezervasyonRepo();
        public ActionResult Index()
        {
            var rezervasyon = repo.List();
            return View(rezervasyon);
        }
    }
}