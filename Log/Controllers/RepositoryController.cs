using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log.Controllers
{
    public class RepositoryController : Controller
    {
        //
        // GET: /Repository/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyRepositories()
        {
            return View();
        }

        /// <summary>
        /// Displays customer list, and select one go to the next page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Customer()
        {
            return View();
        }
    }
}
