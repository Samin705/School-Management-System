using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mid_SchoolManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomeIndex()
        {
            return View();
        }
    }
}