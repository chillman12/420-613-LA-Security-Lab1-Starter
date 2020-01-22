using SecurityLab1_Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
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

        public ActionResult GenError() {

            throw new DivideByZeroException();

            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            //Log the error!!
            var ex = filterContext.Exception;
            LogUtil lu = new LogUtil();
            lu.LogToEventViewer(System.Diagnostics.EventLogEntryType.Error, ex.Message);

            filterContext.Result = RedirectToAction("Index", "Error");

        }

    }
}