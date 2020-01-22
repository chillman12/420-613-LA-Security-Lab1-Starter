using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecurityLab1_Starter.Models;

namespace SecurityLab1_Starter.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult ServerError()
        {
            ViewBag.CurrentURL = Request.Url.ToString();
            return View();
        }

    }
}