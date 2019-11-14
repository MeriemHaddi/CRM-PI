using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pi.webb.Areas.administrator.Controllers
{
    public class CrmController : Controller
    {
        // GET: administrator/Crm
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                return Redirect("/chat");
            }
            return View();
        }
        public ActionResult Mobiles()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
    }
}