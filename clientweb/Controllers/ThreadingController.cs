using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clientweb.Controllers
{
    public class ThreadingController : Controller
    {
        // GET: Threading
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Local()
        {
            return View();
        }

        public ActionResult Global()
        {
            return View();
        }
    }
}