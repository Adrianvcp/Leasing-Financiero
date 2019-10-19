using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanzasTrabajoFinal.Models;
using FinanzasTrabajoFinal.Models.DAO;

namespace FinanzasTrabajoFinal.Controllers
{

    public class LeasingController : Controller
    {
        bdFinanzasEntities8 ds = new bdFinanzasEntities8();
        DAO dao = new DAO();

        // GET: Leasing
        public ActionResult Index()
        {
            var items = ds.nameBancoes.ToList();
            if (items != null) ViewBag.data = items;
            var itemCarros = ds.vwCarroes.ToList();
            if (itemCarros != null) ViewBag.carros = itemCarros; 
            ViewBag.Frecuencia = ds.Frecuencias.ToList();
            ViewBag.plazoGracia = ds.PlazoGracias.ToList();
            return View();
        }

        // GET: Leasing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Leasing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leasing/Create
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

        // GET: Leasing/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Leasing/Edit/5
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

        // GET: Leasing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Leasing/Delete/5
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


        // GET: Login/Simulador/5
        public ActionResult Simulador(int id)
        {
            return View();
        }

        // POST: Login/Simulador/5
        [HttpPost]
        public ActionResult Simulador(String NombreBando,String carro,String fr,String pl,String CantCu, String anios)
        {
            try
            {
                // TODO: Add delete logic here
                leasing ls = new leasing();
                ls.idBanco = Int32.Parse(NombreBando);
                ls.Banco = dao.datosBancoXID(Int32.Parse(NombreBando));
                var numero = dao.carroEntid(carro).Precio;
                ls.NprevioVenta = (float)numero;
                
                ls.idFrecuencia = dao.frecuenciaDD(fr).idFrecuencia;
                ls.idCarro = dao.carroEntid(carro).idCarro;
                ls.NAnios = Int32.Parse(anios);
                ls.Frecuencia = dao.frecuenciaDD(fr);

                Session["plazoGracia"] = Int32.Parse(CantCu);
                Session["tipoGracia"] = (String)pl;

                Session["datosPlanPago"] = ls;
                //var prestamo = float.Parse(pv) - (int.Parse(ci) * 0.01 * int.Parse(pv));

                return RedirectToAction("Index", "PlanDePagos");
            }
            catch
            {
                return View();
            }
        }

        //nuevo metodo
        public ActionResult bancoRetorno()
        {
            var items = ds.nameBancoes.ToList();
            if (items != null) ViewBag.data = items;
            return View();
        }

    }
}
