using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_De_Atencion.Models;

namespace Ticket_De_Atencion.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            ticketContext db = new ticketContext();

            //List<consultaColaCliente_Result> lista = db.consultaColaCliente();

            return View(db.consultaColaCliente2().ToList());
        }
    }
}