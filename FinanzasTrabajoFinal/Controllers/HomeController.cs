using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanzasTrabajoFinal.Models;


namespace FinanzasTrabajoFinal.Controllers
{
    public class HomeController : Controller
    {
        bdFinanzasEntities8 ds = new bdFinanzasEntities8();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CerrarSesion()
        {

            Session["estado"] = 0;
            Session["userName"] = "";
            Session["idUser"] = 0;
            Session["plazoGracia"] = 0;
            Session["frecuencia"] = 0;
            Session["frDias"] = 0;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}