using Ajaxification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ajaxification
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // model binders
         
        }
        protected void Session_Start()
        {
            SessionModel sessionModel = new SessionModel();
            sessionModel.Randomizer = new Random(DateTime.Now.Millisecond);
            Session["data"] = sessionModel;
        }
    }
}