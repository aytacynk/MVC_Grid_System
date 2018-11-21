using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Grid_System.Web.Controllers
{
    public class GridController : Controller
    {
        // GET: Grid
        public ActionResult Index()
        {
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