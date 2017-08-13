namespace WebApplication1.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using NHibernate.Linq;
    using Models;

    public class HomeController : Controller
    {
// GET: Home

        public ActionResult Index()
        {
            var session = Database.Session;

            //var a = session.Query<Product>().Count();

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
            //    Id = a++,
            //    Name = "Огуречный",
            //    Text = "Самый фкусный!!",
            //    Imeg = arr,
            //    TypeId = 1,
            //    Value = 100
            //};

            //var menu1 = new Product
            //{
            //    Id = a++,
            //    Name = "Огуречный1",
            //    Text = "Самый фкусный!!",
            //    Imeg = arr1,
            //    TypeId = 1,
            //    Value = 100
            //};


            //using (var trans = session.BeginTransaction())
            //{
            //    session.Save(menu);
            //    session.Save(menu1);
            //    trans.Commit();
            //}
            var items = session.Query<Menu>().ToList();

            return View(items);
        }

        public ActionResult List(int id)
        {
            var session = Database.Session;
            var items = session.Query<Product>().Where(x => x.Type.Id == id).ToList();

            return View(items);
        }

        [HttpGet]
        public ActionResult Cart()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cart(List<string> products, Order order)
        {
            var session = Database.Session;
            var items = session.Query<OrderProduct>().Count();
            var items1 = session.Query<Order>().Count();
            
            using (var trans = session.BeginTransaction())
            {
                items1++;
                order.Id = items1;
                session.Save(order);
                var orderProductLis = products.Select(x =>
                {
                    var prox = x.Split('\t');

                    return new OrderProduct
                    {
                        Id = items++,
                        Count = Convert.ToInt16(prox[2]),
                        Price = Convert.ToInt16(prox[3]),
                        TypeId = Convert.ToInt16(prox[0]),
                        //ProductId = Convert.ToInt16(a3[5]),
                        OrderId = order.Id,
                        //Order = order,
                    };

                }).ToList();

                foreach (var item in orderProductLis)
                {
                    session.Save(item);
                }              
                
                trans.Commit();

            }
            return View();
        }
    }
}