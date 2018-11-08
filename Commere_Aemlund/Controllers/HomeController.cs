using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Commere_Aemlund.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult ProductDetails(string id)
        {
            int num = int.Parse(id);
            return View(num);
        }
    }
}