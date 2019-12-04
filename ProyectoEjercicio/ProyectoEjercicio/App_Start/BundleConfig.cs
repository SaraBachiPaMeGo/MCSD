using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEjercicio.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bootstrap").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/estilos").Include("~/Content/jumbotron.css", "~/Content/bootstrap.min.css", "~/Content/prueba.css"));
        }
    }
}