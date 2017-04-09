using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log.Controllers
{
    public class CommonController : Controller
    {
        //
        // GET: /Common/

        public ActionResult LeftMenu()
        {
            return PartialView("_LeftMenuTreePartial");
        }

        public ActionResult TopNavigation()
        {
            return PartialView("_TopNavigationPartial");
        }

        public ActionResult Footer()
        {
            return PartialView("_FooterPartial");
        }

    }
}
