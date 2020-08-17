using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAcademica_Toti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sbre Nós";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "O nosso contato";

            return View();
        }
    }
}