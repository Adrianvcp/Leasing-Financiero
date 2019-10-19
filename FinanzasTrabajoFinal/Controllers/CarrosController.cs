using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanzasTrabajoFinal.Models.DAO;
using FinanzasTrabajoFinal.Models;
namespace FinanzasTrabajoFinal.Controllers
{
    public class CarrosController : Controller
    {
        DAO dao = new DAO();
        // GET: Carros
        public ActionResult Index()
        {
            return View(dao.listCarros());
        }

        // GET: Carros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Carros/Create
        public ActionResult Create()
        {
            ViewBag.listCarro = dao.MarcaCarros();
            return View(dao.MarcaCarros());
        }

        // POST: Carros/Create
        [HttpPost]
        public ActionResult Create(String nEF, String idMarca, String pr)
        {
            try
            {
                // TODO: Add insert logic here
                carro obj = new carro();
                obj.NCarro = nEF;
                obj.idMarca = Int32.Parse(idMarca);
                obj.Precio = decimal.Parse(pr);
                dao.AddCarro(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carros/CreateM
        public ActionResult CreateM()
        {
            return View();
        }

        // POST: Carros/CreateM
        [HttpPost]
        public ActionResult CreateM(String marca)
        {
            try
            {
                // TODO: Add insert logic here
                Marca obj = new Marca();
                obj.nMarca = marca;
                dao.AddMarca(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carros/Edit/5
        public ActionResult Edit(int id)
        {
            carro datos = new carro();
            datos = dao.entCarro(id);
            return View(datos);
        }

        // POST: Carros/Edit/5
        [HttpPost]
        public ActionResult Edit(carro ent)
        {
            try
            {
                // TODO: Add update logic here
                dao.editarCarro(ent);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carros/Delete/5
        public ActionResult Delete(int id)
        {
            dao.EliminarCarro(id);
            return RedirectToAction("Index");
        }

        // POST: Carros/Delete/5
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
