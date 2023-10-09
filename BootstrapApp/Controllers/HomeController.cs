using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        
        public ActionResult Forms()
        {
            ViewBag.Message = "Your form page.";

            return View();
        } 
        public ActionResult FormsInline()
        {
            ViewBag.Message = "Your form page.";

            return View();
        } 
        public ActionResult Tables()
        {
            ViewBag.Message = "Your form page.";

            return View();
        } 
        
    }
}