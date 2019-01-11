using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JuniorInterviewTask.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Prepare your opening times here using the provided HelperServiceRepository class.
         * Think about what else you may wish to do - HINT:  think of the HelperService being a call
         * to a database / remote server 
         */
        public ActionResult Index()
        {

            return View();
        }
    }
}