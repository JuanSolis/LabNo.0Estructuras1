using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlDeClientes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClientsControl()
        {
            ViewBag.Message = "Welcome to Client Control Stage";

            return View();
        }

        public ActionResult ClientsFilter()
        {
            ViewBag.Message = "Welcome to Clients Filter Stage";

            return View();
        }
    }
}