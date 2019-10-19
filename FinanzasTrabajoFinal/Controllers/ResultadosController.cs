using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanzasTrabajoFinal.Models.DAO;
namespace FinanzasTrabajoFinal.Controllers
{
    public class ResultadosController : Controller
    {
        DAO dao = new DAO();

        // GET: Resultados
        public ActionResult Index()
        {
           
            var aux = (double[])Session["DatosPlanPago"];
            var arrFn =(double[])Session["DatosFlujoNeto"];
            arrFn[0] = aux[0];
            var cantCu = (Int32)Session["frecuencia"];
            var tir = dao.tir(aux,cantCu);
            var tirFn = dao.tir(arrFn, cantCu);
            var frDias = (Int32)Session["frDias"];
            var TCEA = (Math.Pow(1 + tir, 360 / frDias) - 1) * 100;
            var TCEAFN = (Math.Pow(1 + tirFn, 360 / frDias) - 1) * 100;

            ViewBag.tir = tir;
            ViewBag.tcea = TCEA;
            ViewBag.tceafn = TCEAFN;
            return View();
        }

        // GET: Resultados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resultados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resultados/Create
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

        // GET: Resultados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resultados/Edit/5
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

        // GET: Resultados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resultados/Delete/5
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
