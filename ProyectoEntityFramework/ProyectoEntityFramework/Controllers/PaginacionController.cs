using ProyectoEntityFramework.Models;
using ProyectoEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoEntityFramework.Controllers
{
    public class PaginacionController : Controller
    {

        RepositoryDepartamento repo;
        RepositoryPlantilla repoPlan;
        RepositoryHospital repoHospi;
        public PaginacionController()
        {            
            repo = new RepositoryDepartamento();
            repoPlan = new RepositoryPlantilla();
            repoHospi = new RepositoryHospital();
        }

        public ActionResult Individual(int? position)
        {
            if (position == null)
            {
                position = 1;
            }
            int anterior, siguiente, ultimo;
            ultimo = repo.GetNumroDepartamentos();
            siguiente = position.GetValueOrDefault() + 1;
            if (siguiente > ultimo)
            {
                siguiente = ultimo;
            }
            anterior = position.GetValueOrDefault() - 1;
            if (anterior < 1)
            {
                anterior = 1;
            }
            ViewBag.Siguiente = siguiente;
            ViewBag.Anterior = anterior;
            ViewBag.Ultimo = ultimo;
            PAGINAR_DEPT_Result department = repo.PaginarDepartamentos(position.Value);
            return View(department);
        }

        public ActionResult Grupo(int? posicion) 
        {
            if(posicion == null) 
            {
                posicion = 1;
            }

            GrupoPlantilla grupo = repoPlan.GetGrupoPlantilla(posicion.Value);
            ViewBag.Registros = "<h1>Registros:" + grupo.NumeroRegistros + "</h1>";

            int numPag = 1;
            String html = "";

            for (int i = 1; i <= grupo.NumeroRegistros; i += 3)
            {
                html += "<a href='Grupo?posicion=" + i + "'>" + numPag + "</a>";
                numPag += 1;
            }

            ViewBag.Link = html;
            return View(grupo.Plantilla);
        }

        public ActionResult PaginacionHospi(int? posicion) { // No siempre vamos a recibir la posición

            if (posicion == null) {
                posicion = 1;
            }

            ModeloHospital hospi = repoHospi.PaginarHospitales(posicion.Value);
            ViewBag.NumeroHospitales = "<h1>Registros: " + hospi.NumeroRegistros + "</h1>";
            ViewBag.Hospital = hospi;

            int siguiente, anterior, ultimo;
            siguiente = posicion.Value + 1;

            if (siguiente > hospi.NumeroRegistros) {
                siguiente = hospi.NumeroRegistros;
            }

            anterior = posicion.Value - 1;

            if (anterior < 1) {
                anterior = 1;
            }

            ultimo = hospi.NumeroRegistros;
            ViewBag.Siguiente = siguiente;
            ViewBag.Anterior = anterior;
            ViewBag.Ultimo = ultimo;
            
            return View(hospi.ListaDoctores);
        }

        // GET: Paginacion
        public ActionResult Index()
        {
            return View();
        }
    }
}