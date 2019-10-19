using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanzasTrabajoFinal.Models.DAO;
using FinanzasTrabajoFinal.Models;

namespace FinanzasTrabajoFinal.Controllers
{
    public class BancoController : Controller
    {
        DAO dao = new DAO();
        // GET: Banco
        public ActionResult Index()
        {
            return View(dao.listBanco());
        }

        // GET: Banco/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Banco/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Banco/Create
        [HttpPost]
        public ActionResult Create(String idUser,String nB,String tea,String sr, String pRecom, String cN, String cR, String tasa, String cEstu, String cActi, String cPerio, String pRiesgo, String ks,String wacc)
        {
            try
            {
                // TODO: Add insert logic here
                Banco obj = new Banco();
                obj.idUsuario = 3;
                obj.NombreBanco = nB;
                obj.TEA = float.Parse(tea);
                obj.SeguroRiesgo = float.Parse(sr);
                obj.PorRecompa = float.Parse(pRecom);
                obj.costesNotariales = float.Parse(cN);
                obj.costesRegistrales = float.Parse(cR);
                obj.Tasacion = float.Parse(tasa);
                obj.comEstudio = float.Parse(cEstu);
                obj.comActivacion = float.Parse(cActi);
                obj.comPeriodica = float.Parse(cPerio);
                obj.PorsegRiesgo = float.Parse(pRiesgo);
                obj.ks = float.Parse(ks);
                obj.wacc = float.Parse(wacc);

                dao.AddBanco(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int id)
        {
            Banco datos = new Banco();
            datos = dao.entBanco(id);
            return View(datos);
        }

        // POST: Banco/Edit/5
        [HttpPost]
        public ActionResult Edit(Banco ent)
        {
            try
            {
                // TODO: Add update logic here
                dao.editarBanco(ent);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int id)
        {
            dao.EliminarBanco(id);
            return RedirectToAction("Index");
        }

        // POST: Banco/Delete/5
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
