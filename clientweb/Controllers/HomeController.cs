using clientweb.ModelData;
using System.Web.Mvc;
using System.Linq;

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

        public ActionResult EPort()
        {
            return View();
        }

        public JsonResult  Login(string username, string password)
        {
            string flag = "OK";

            //password = GetMD5Hash(password);


            var x = db.Users.FirstOrDefault(q => q.UserName == username && q.HashPass == password);

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
                }
            }

            return Json(flag, JsonRequestBehavior.AllowGet);
        }

        

    }
}