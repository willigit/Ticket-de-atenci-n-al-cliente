using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_De_Atencion.Models;
using Ticket_De_Atencion.Models.ViewModels;

namespace Ticket_De_Atencion.Controllers
{
    public class clienteController : Controller
    {
        // GET: cliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cliente/Create
        [HttpPost]
        public ActionResult Create(TablaViewModels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ticketContext db = new ticketContext())
                    {
                        var obj = new cliente();
                        obj.cli_nombre = model.cli_nombre;
                        obj.cli_codigo = model.cli_codigo;
                        db.cliente.Add(obj);
                        db.SaveChanges(); 
                        //if (db.SaveChanges() > 0)
                        //{

                        //}else
                        //{
                            
                        //}
                    }
                    return Redirect("../Ticket/Index"); 
                }
                return View();
                
            }
            catch
            {
                return View();
            }
        }

        // GET: cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
