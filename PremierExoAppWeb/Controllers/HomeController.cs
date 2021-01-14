using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremierExoAppWeb.Controllers
{
    public class HomeController : Controller
    {
        //quand ouvre lien de routeConfig:
        //https://i3.be/home/index
        // plutot cas ici : http://localhost:54042/Home/Index
        // le moteur MVC: =>le lien va renvoyé au homecontroller

        // HomeController ctl = new HomeController()
        //return ctrl.index();

        // return => renvois vers le navigateur (httpResponse)
        public ActionResult Index()
        {
           // return "<h1> hello </h1>";
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

        public ActionResult Hobbies()
        {
            ViewBag.Message = "Your hobbies page.";

            return View();
        }
    }
}