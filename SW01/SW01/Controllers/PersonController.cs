using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW01.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult PersonDetails()
        {
            return View();
        }
    }
}