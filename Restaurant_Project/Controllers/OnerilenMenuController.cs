using Restaurant_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Project.Controllers
{
    public class OnerilenMenuController : Controller
    {
        // GET: OnerilenMenu
        
        OnerilerRepo repo=new OnerilerRepo();
        public ActionResult Index()
        {
            var oneriler = repo.List();
            return View(oneriler);
        }
    }
}