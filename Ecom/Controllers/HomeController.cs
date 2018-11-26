using Hitmans;
using Hitmans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom.Controllers
{
    public class HomeController : Controller
    {
        IWaluigiTime service = new WaluigiTime();
        public ActionResult Index()
        {
            
            //List<string> stuff = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    stuff.Add("a"+i);
            //}
            //Hitmany person = new Hitmany()
            //{
            //  Name = "jesus",
            //  Price = 1,
            //  PicLink =""
            //  ,Description =  stuff
            //};
            //service.CreateSome(person);
            return View();
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

        public ActionResult Catalog()
        {
           var hitmen = service.GetSomeMore();
            return View(hitmen);
        }
        public ActionResult ProductDetails(string id)
        {//call get some more and pass through single instance
            int num = int.Parse(id);
            var assassin = service.GetSomeMore().FirstOrDefault(p => p.ID == num);
            return View(assassin);
        }
    }
}