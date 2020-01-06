using clientweb.ModelData;
using System.Web.Mvc;
using System.Linq;
using System;

namespace clientweb.Controllers
{
    public class HomeController : Controller
    {
        private DataEntity db = new DataEntity();
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

        public JsonResult  Login(string uname, string pword)
        {
            string flag = "OK";

            pword = Models.Helper.GetMD5Hash(pword);


            var x = db.Users.FirstOrDefault(q => q.UserName == uname && q.HashPass == pword);

            if(x == null)
            {
                flag = "NOTFOUND";
            }
            else
            {
                if(x.Active == false)
                {
                    flag = "ACCDISABLED";
                }
                else if(x.UsersIsCustomer == null)
                {
                    flag = "NOTCUSTOMER";
                }
                else
                {
                    flag = "DONE";
                    Session["uname"] = x.UserName;
                    Session["userid"] = x.UserID;
                }
            }

            return Json(flag, JsonRequestBehavior.AllowGet);
        }

        public ActionResult LogOff()
        {
            Session["uname"] = null;
            Session.Abandon();
            return RedirectToAction("eport", "customers");
        }

        public ActionResult Document()
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

        public ActionResult Account()
        {
            if (Session["uname"] == null)
            {
                return RedirectToAction("eport", "customers");
            }
            else
            {
                int userid = Convert.ToInt32(Session["userid"]);
                var model = db.Users.Find(userid).UsersIsCustomer.Customer;
                return View(model);
            }            
        }

        public ActionResult GetPassword()
        {
            if (Session["uname"] == null)
            {
                return View();                
            }
            else
            {
                return RedirectToAction("eport", "customers");
            }
            
        }

        public JsonResult ChangePassword(string oldpass, string newpass)
        {
            string flag = "";

            if(Session["uname"] == null)
            {
                flag = "NULL";
            }
            else
            {
                int userid = Convert.ToInt32(Session["userid"]);
                var user = db.Users.Find(userid);

                var hash = Models.Helper.GetMD5Hash(oldpass);

                if (hash != user.HashPass)
                {
                    flag = "WRONGOLD";
                }
                else 
                {
                    hash = Models.Helper.GetMD5Hash(newpass);

                    user.HashPass = hash;

                    flag = "DONE";

                    db.SaveChanges();
                }
            }



            return Json(flag, JsonRequestBehavior.AllowGet);
        }





    }
}