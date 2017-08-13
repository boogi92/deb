using System.ComponentModel.Design;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using WebApplication1.Mapping;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Database
    {
        private static ISessionFactory _sessionFactory;

        public static ISession Session
        {
            get { return (ISession) HttpContext.Current.Items["Database.SessionKey"]; }
        }

        public static void Conf()
        {
            var conf = new Configuration();
            conf.Configure();
            var maper = new ModelMapper();
            maper.AddMapping<ContextMap>();
            maper.AddMapping<MenuMap>();
            maper.AddMapping<ProductMap>();
            maper.AddMapping<OrderMap>();
            maper.AddMapping<OrderProductMap>();

            conf.AddMapping(maper.CompileMappingForAllExplicitlyAddedEntities());

            _sessionFactory = conf.BuildSessionFactory();
        }

        public static void OpenSession()
        {
            HttpContext.Current.Items["Database.SessionKey"] = _sessionFactory.OpenSession();
        }
        public static void CloseSession()
        {
            var session = HttpContext.Current.Items["Database.SessionKey"] as ISession;
            if (session != null) session.Close();

            HttpContext.Current.Items.Remove("Database.SessionKey");
        }
    }
}