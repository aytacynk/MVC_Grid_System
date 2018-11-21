using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Grid_System.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BussinessLayer.Test test = new BussinessLayer.Test();
            
            return View();
        }

        public ActionResult List()
        {
            BussinessLayer.ActionPersonel actionPer = new BussinessLayer.ActionPersonel();
            var model = actionPer.GetPersonels();

            return View(model);
        }
        
    }
}