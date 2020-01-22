using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoMvcEneroAjax.Controllers
{
    public class RutasController : Controller
    {
        // GET: Rutas
        public ActionResult Index()
        {
            RouteValueDictionary rutas = RouteData.Values;

            //KEY-VALUE
            String html = "";
            foreach(String key in rutas.Keys)
            {
                html += "<h2>" + key + ":" + rutas[key] + "</h2>";
            }
            //Tenemos una clase para almacenar el código interpretado en ViewBag
            MvcHtmlString conversor = new MvcHtmlString(html);
            ViewBag.Rutas = conversor;
            //Html.Raw(ViewBag...)

            return View();
        }

        public ActionResult Buscar()
        {
            //RECUPERAMOS LOS VALORES TIPOACCION Y IDDATO 

            String tipoaccion = RouteData.Values["tipoaccion"].ToString();

            String iddato = RouteData.Values["iddato"].ToString();

            String resultado = String.Empty;

            switch (tipoaccion.ToLower())
            {
                case "peliculas":
                    {
                        switch (iddato.ToLower())

                        {

                            case "regreso al futuro":

                                {

                                    resultado = "Disponibles 5";

                                    break;

                                }

                            case "avatar":

                                {

                                    resultado = "Disponible 7";

                                    break;

                                }

                            default:

                                {

                                    resultado = "La película " + iddato + " no existe en stock";

                                    break;

                                }

                        }
                        break;
                    }

                case "comics":
                    {
                        switch (iddato.ToLower())

                        {

                            case "batman":

                                {

                                    resultado = "Disponibles 4 unidades.";

                                    break;

                                }

                            case "lobezno":

                                {

                                    resultado = "Disponibles 12 unidades.";

                                    break;

                                }

                            default:

                                {

                                    resultado = String.Format("El comic " + iddato + " no existe en stock");

                                    break;

                                }

                        }
                        break;
                    }
                default:
                    break;
            }

            //DEVOLVEMOS UN CONTENIDO HTML PARA VISUALIZAR LOS  

            //RESULTADOS DE LA PETICION 

            return Content("<h2 style='color:blueviolet'>" + resultado + "</h2>");
        }
    }
}