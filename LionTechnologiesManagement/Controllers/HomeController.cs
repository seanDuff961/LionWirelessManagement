using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LionTechnologiesManagement.Controllers
{
    //checks to make sure user is authorized, if they are, allows the following controllers
    [Authorize]
    public class HomeController : Controller
    {   //everyone has to be authorized except allowanonymous
        //[AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        /*public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/

        public ActionResult Add()
        {
            return View();
        }        
        
        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult Accounts()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }
    }
}