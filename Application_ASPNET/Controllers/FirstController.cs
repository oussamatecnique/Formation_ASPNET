using System.Dynamic;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace Application_ASPNET.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        //retourner un contenu text
        public ContentResult Action1()
        {
            return Content("<h1>C'est pas une balise</h1>", "text/plain", Encoding.UTF8);
        }
        public ContentResult Action2()
        {
            string xml = "<action> Action2 </action> ";
            return Content(xml, "text/xml", Encoding.UTF8);
        }
        //retourne une reponse json
        public JsonResult Action3()
        {
            dynamic personne = new ExpandoObject();
            personne.nom = "someone";
            personne.age = 20;
            return Json(personne, JsonRequestBehavior.AllowGet);
        }
        //type string equivalent a content(text/html)
        public string Action4()
        {
            return "<h3>Contrôleur=First, Action=Action4</h3>";

        }
        public EmptyResult Action5()
        {
            return new EmptyResult();
        }
        // redirect to url
        public RedirectResult Action6()
        {
            return new RedirectResult("/First/Action1");
        }
        public RedirectResult Action7()
        {
            return new RedirectResult("/First/Action1", true);
        }
        // route to default with specifying controller and action
        public RedirectToRouteResult Action8()
        {
            return new RedirectToRouteResult("Default", new RouteValueDictionary(new { controller = "First", action = "Action5" }));
        }
        // response created by itself
        public void Action9()
        {
            // if parameter null return inconnu
            string nom = Request.QueryString["nom"] ?? "inconnu";
            Response.AddHeader("Content-Type", "text/plain");
            Response.Write(string.Format("<h3>Action09</h3>nom={0}", nom));
        }
    }
}