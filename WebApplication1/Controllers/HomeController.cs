using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using NHibernate;
using NHibernate.Linq;
using WebApplication1.Migrations;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {// GET: Home
        public ActionResult Index()
        {
            var session = Database.Session;

            //var a = session.Query<Contect>().FirstOrDefault();

            //var img = System.Drawing.Image.FromFile(@"C:\Users\boogi\Desktop\Школа\sushi.jpg");
            //byte[] arr;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr = ms.ToArray();
            //}

            //var img1 = System.Drawing.Image.FromFile(@"C:\Users\boogi\Desktop\Школа\set.jpg");
            //byte[] arr1;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    img1.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr1 = ms.ToArray();
            //}

            //var menu = new Product
            //{
            //    Id = 1,
            //    Name = "Огуречный",
            //    Text = "Самый фкусный!!",
            //    Imeg = arr,
            //    Type_id = 1,
            //    Value =  100.50m
            //};

            //var menu1 = new Product
            //{
            //    Id = 2,
            //    Name = "Огуречный1",
            //    Text = "Самый фкусный!!",
            //    Imeg = arr1,
            //    Type_id = 1,
            //    Value = 100.50m
            //};


            //using (var trans = session.BeginTransaction())
            //{
            //    session.Save(menu);
            //    trans.Commit();
            //}
            //using (var trans = session.BeginTransaction())
            //{
            //    session.Save(menu1);
            //    trans.Commit();
            //}

            var items = session.Query<Menu>().ToList();

            return View(items);
        }

        public ActionResult List(int id)
        {
            var session = Database.Session;
            var items = session.Query<Product>().Where(x=>x.Type_id == id).ToList();

            return View(items);
        }

        public ActionResult Cart()
        {
            return View();
        }
    }
}