using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinglePageApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPercentOfCPULoad()
        {
            System.Diagnostics.PerformanceCounter perfomanceCounter = new System.Diagnostics.PerformanceCounter();
            perfomanceCounter.CategoryName = "Processor";
            perfomanceCounter.CounterName = "% Processor Time";
            perfomanceCounter.InstanceName = "_Total";
            float raw = 0;
            while ((raw == 0 || raw == 100))
            {
                raw = perfomanceCounter.NextValue();
            }
            return Json(raw, JsonRequestBehavior.AllowGet);
        }
    }
}