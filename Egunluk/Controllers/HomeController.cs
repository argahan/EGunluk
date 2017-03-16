using Egunluk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Egunluk.Controllers
{
    public class HomeController : Controller
    {
        private DB _db = new DB();
        
        public ActionResult Index()
        {
            var model = _db.Users.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}