using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_De_Atencion.Models;

namespace Ticket_De_Atencion.Controllers
{
    public class GuardaController : Controller
    {
        // GET: Guarda
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guardar()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guardar(string cod, string nom)
        {
            ticketContext db = new ticketContext();
            db.GuardarClienteCola(cod, nom);            
            return Redirect("~/Views/Ticket/Index");

        }
    }
}