using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KisiselBilgilerim()
        {
            return View();
        }
        public ActionResult EgitimBilgilerim()
        {
            return View();
        }
        public ActionResult IsBilgilerim()
        {
            return View();
        }
        public ActionResult iletisimBilgilerim()
        {
            return View();
            
        }
        public ActionResult DenemeSayfasi()
        {
            return View();

        }

    }
}