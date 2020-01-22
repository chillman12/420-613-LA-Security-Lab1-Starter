using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecurityLab1_Starter.Models;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {

        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
           //Log the error!!
            var ex = Server.GetLastError();
            LogUtil lu = new LogUtil();
            lu.LogToEventViewer(System.Diagnostics.EventLogEntryType.Error, ex.Message);
        }
    }
}