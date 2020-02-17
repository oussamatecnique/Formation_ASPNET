using Action_Model.Models;
using pam_web_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pam_web_01.Controllers
{
    public class PamController : Controller
    {
        // GET: Pam
        [HttpGet]
        public ViewResult Index(ApplicationModel application)
        {
            return View(new IndexModel() { Application = application });
        }
        [HttpPost]
        public PartialViewResult FaireSimulation()
        {
            return PartialView("Simulation");
        }
        [HttpPost]
        public PartialViewResult EnregistrerSimulation()
        {
            return PartialView("Simulations");
        }
        [HttpPost]
        public PartialViewResult VoirSimulations()
        {
            return PartialView("Simulations");
        }
        [HttpPost]
        public PartialViewResult Formulaire()
        {
            return PartialView("Formulaire");
        }
        public PartialViewResult TerminerSession()
        {
            return PartialView("Formulaire");
        }
    }
}