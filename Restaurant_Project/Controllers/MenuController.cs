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
    }
}