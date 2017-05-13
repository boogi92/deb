using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Database.Conf();
        }

        protected void Application_BeginRequest()
        {
            Database.OpenSession();
        }

        protected void Application_EndRequest()
        {
            Database.CloseSession();
        }

     //   protected void Session_Start(Object sender, EventArgs e)
     //   {
     //       SessionStateSection sessionState =
     //(SessionStateSection)ConfigurationManager.GetSection("system.web/sessionState");
     //       string sidCookieName = sessionState.CookieName;

     //       if (Request.Cookies[sidCookieName] != null)
     //       {
     //           HttpCookie sidCookie = Response.Cookies[sidCookieName];
     //           sidCookie.Value = Session.SessionID;
     //           sidCookie.HttpOnly = true;
     //           sidCookie.Secure = true;
     //           sidCookie.Path = "/";
     //       }
     //   }
    }
}
