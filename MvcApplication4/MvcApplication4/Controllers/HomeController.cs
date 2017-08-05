using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Information i = new Information();
            return View(i.Accounts);
        }

        public ActionResult Add()

        {
            return View();
        }

        public ActionResult Save(Accounts awd)
        {
            return View();
        }

    }
}
