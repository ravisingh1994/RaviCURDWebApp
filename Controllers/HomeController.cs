using RaviCURDWebApp.DB_Connect_RP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaviCURDWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            prakashEntities obj = new prakashEntities();
            
            var res=obj.stud_info.ToList();

            return View(res);
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