using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FinanzasTrabajoFinal.Models;

namespace FinanzasTrabajoFinal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        leasing ls = new leasing();


        double[] arrayCS;
            
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        protected void Session_Start()
        {
            Session["estado"] = 0;
            Session["userName"] = "";
            Session["idUser"] = 0; 
            Session["datosPlanPago"] = ls;
            Session["plazoGracia"] = 0;

            Session["DatosPlanPago"] = arrayCS;
            Session["DatosFlujoNeto"] = arrayCS;
            Session["frecuencia"] = 0;
            Session["frDias"] = 0;
        }


    }
}
    