using clientweb.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clientweb.Controllers
{
    public class CustomersController : Controller
    {
        private DataEntity db = new DataEntity();
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Container()
        {
            if(Session["uname"] == null)
            {
                return RedirectToAction("eport", "customers");
            }
            else
            {
                int userid = Convert.ToInt32(Session["userid"]);
                var user = db.Users.Find(userid);

                var model = db.Containers.Where(q => q.Booking.CustID == user.UsersIsCustomer.CustID);

                return View(model);
            }     
        }
        public ActionResult Invoice()
        {
            if (Session["uname"] == null)
            {
                return RedirectToAction("eport", "customers");
            }
            else
            {
                return View();
            }            
        }

        public ActionResult EPort()
        {
            return View();
        }

        public PartialViewResult GetInvoiceContainer(int? containerid)
        {
            var model = db.ContainerInvoices.Find(containerid);

            return PartialView("_bill", model);
        }
    }
}