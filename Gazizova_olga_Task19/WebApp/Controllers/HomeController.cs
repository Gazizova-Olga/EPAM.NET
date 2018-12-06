using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Описание приложение";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ваши контакты";

            return View();
        }
    }
}