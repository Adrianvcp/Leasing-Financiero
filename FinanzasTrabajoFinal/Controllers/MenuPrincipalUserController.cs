using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanzasTrabajoFinal.Controllers
{
    public class MenuPrincipalUserController : Controller
    {
        // GET: MenuPrincipalUser
        public ActionResult Index()
        {
            return View();
        }

        // GET: MenuPrincipalUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuPrincipalUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuPrincipalUser/Create
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

        // GET: MenuPrincipalUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuPrincipalUser/Edit/5
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

        // GET: MenuPrincipalUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuPrincipalUser/Delete/5
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
