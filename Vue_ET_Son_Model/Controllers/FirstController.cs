using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Vue_ET_Son_Model.Models;

namespace Vue_ET_Son_Model.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        // Action01
        public ViewResult Action01()
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}",
            RouteData.Values["controller"], RouteData.Values["action"]);
            return View();
        }
        // Action02
        public ViewResult Action02(ActionModel03 modèle)
        {
            string erreurs = getErrorMessagesFor(ModelState);
            return View(new ViewModel01()
            {
                Email = modèle.Email,
                Jour = modèle.Jour,
                Info1 = modèle.Info1,
                Info2 = modèle.Info2,
                Info3 = modèle.Info3,
                Erreurs = erreurs
            });
        }
        // Action03
        public ViewResult Action03(ActionModel04 modèle)
        {
            modèle.Erreurs = getErrorMessagesFor(ModelState);
            return View(modèle);
        }
        // Action04
        public ViewResult Action04()
        {
            return View(new ViewModel02());
        }
        //alimenter un combo box
        public ViewResult Action05()
        {
            return View(new ViewModel05());
        }
        // Formulaire
        [HttpGet]
        public ViewResult Action06()
        {
            return View("Action06Get", new ViewModel05());
        }
        // Action06-POST
        [HttpPost]
        public ViewResult Action06(ActionModel06 modèle)
        {
            return View("Action06Post", modèle);
        }
        // form a travers annotations display and editor
        [HttpGet]
        public ViewResult Action10Get()
        {
            return View(new ViewModel10());
        }
        // Action10- repondre au form 
        [HttpPost]
        public ContentResult Action10Post(ViewModel10 modèle)
        {
            string erreurs = getErrorMessagesFor(ModelState);
            string texte = string.Format("Contrôleur={0}, Action={1}, valide={2}, erreurs ={3}", RouteData.Values["controller"], RouteData.Values["action"],
       ModelState.IsValid, erreurs);
            return Content(texte, "text/plain", Encoding.UTF8);
        }
        // Action11 get formulaire
        [HttpGet]
        public ViewResult Action11Get()
        {
            return View("Action11Get", new ViewModel11());
        }
        // Action11 validate the form
        [HttpPost]
        public ViewResult Action11Post(ViewModel11 modèle)
        {
            return View("Action11Get", modèle);
        }
        // Action12-GET FORM WITH VALIDATION IS USING JAVASCRIPT
        [HttpGet]
        public ViewResult Action12Get()
        {
            return View("Action12Get", new ViewModel11());
        }
        [HttpPost]
        public ViewResult Action12Post(ViewModel11 model)
        {
            return View("Action12Get", model);
        }
        // Action13-GET
        [HttpGet]
        public ViewResult Action13Get()
        {
            return View("Action13Get", new ViewModel11());
        }
        // Action13-POST
        [HttpPost]
        public ViewResult Action13Post(ViewModel11 modèle)
        {
            return View("Action13Get", modèle);
        }
        [HttpGet]
        public ViewResult Action16Get()
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}",
            RouteData.Values["controller"], RouteData.Values["action"]);
            return View("Action16Get");
        }
        // Action16-POST
        [HttpPost]
        public ViewResult Action16Post(string data)
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}, Data={2}",
            RouteData.Values["controller"], RouteData.Values["action"], data);
            return View("Action16Get");
        }
        // Action17-GET
        [HttpGet]
        public ViewResult Action17Get()
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}",
            RouteData.Values["controller"], RouteData.Values["action"]);
            return View();
        }





























        //i coulndt add those methods to shared
        private string getErrorMessagesFor(ModelStateDictionary état)
        {
            List<String> erreurs = new List<String>();
            string messages = string.Empty;
            if (!état.IsValid)
            {
                foreach (ModelState modelState in état.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        erreurs.Add(getErrorMessageFor(error));
                    }
                }
                foreach (string message in erreurs)
                {
                    messages += string.Format("[{0}]", message);
                }
            }
            return messages;
        }
        private string getErrorMessageFor(ModelError error)
        {
            if (error.ErrorMessage != null && error.ErrorMessage.Trim() != string.Empty)
            {
                return error.ErrorMessage;
            }
            if (error.Exception != null && error.Exception.InnerException == null &&
           error.Exception.Message != string.Empty)
            {
                return error.Exception.Message;
            }
            if (error.Exception != null && error.Exception.InnerException != null &&
           error.Exception.InnerException.Message != string.Empty)
            {
                return error.Exception.InnerException.Message;
            }
            return string.Empty;
        }

    }
}