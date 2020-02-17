using Action_Model.Infrastructure;
using Action_Model.Models;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Liason_Model_View
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // intialisation application
            Application["infoAppli1"] = ConfigurationManager.AppSettings["infoAppli1"];
            // intialisation application - cas 2
            ApplicationModel data = new ApplicationModel();
            data.InfoAppli1 = ConfigurationManager.AppSettings["infoAppli1"];
            Application["data"] = data;
            // model binders
            ModelBinders.Binders.Add(typeof(ApplicationModel), new ApplicationModelBinder());
            ModelBinders.Binders.Add(typeof(SessionModel), new SessionModelBinder());

        }
        protected void Session_Start()
        {
            // initialisation compteur
            Session["compteur"] = 0;// initialisation compteur - cas 2
            Session["data"] = new SessionModel();
        }
    }
}
