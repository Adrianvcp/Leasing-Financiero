using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanzasTrabajoFinal.Models.DAO;
using FinanzasTrabajoFinal.Models;

namespace FinanzasTrabajoFinal.Controllers
{
    public class PlanDePagosController : Controller
    {
        leasing ls = null;
        // GET: PlanDePagos
        DAO dao = new DAO();

        public ActionResult Index()
        {
            ls = (leasing)Session["datosPlanPago"];
            ls.Banco = dao.datosBancoXID(ls.idBanco);
           
            return View();
        }

        // GET: PlanDePagos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanDePagos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanDePagos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanDePagos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanDePagos/Edit/5
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

        // GET: PlanDePagos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanDePagos/Delete/5
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
