using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RepositoryList() 
        {
            return View("~/Views/Home/RepositoryList.cshtml");
        }

        public ActionResult SearchResult()
        {
            return View("~/Views/Home/SearchResult.cshtml");
        }

    }
}
