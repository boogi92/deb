
namespace WebApplication1.Controllers
{ 
    using System.Linq;
    using System.Web.Mvc;
    using NHibernate.Linq;
    using Models;

    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var session = Database.Session;
            var orders = session.Query<Order>().ToList();
            return View(orders);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var session = Database.Session;
            var orders = session.Query<Order>().FirstOrDefault(x=>x.Id == id);
            return Json(orders, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(Order order)
        {
            var session = Database.Session;
            using (var trans = session.BeginTransaction())
            {
                session.Update(order);
                trans.Commit();
            }
            return Json(order);
        }
    }
}