using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using NHibernate.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var con = Database.Session.QueryOver<Contect>();

            var a = Database.Session.Query<Contect>().FirstOrDefault();
            return View();
        }
    }
}