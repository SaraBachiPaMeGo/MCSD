using MvcProject.Models;
using MvcProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class SesionesController : Controller
    {
        RepositoryEmpleados repo;

        public SesionesController()
        {
            this.repo = new RepositoryEmpleados();
        }

        //GET: AlmacenarSalarios
        public ActionResult AlmacenarSalarios(int? salario)
        {
            if (salario != null)
            {
                //QUEREMOS REALIZAR UNA SUMA CON
                //TODOS LOS SALARIOS PREVIOS
                //QUE ESTARAN EN LA SESION
                int suma;
                //PREGUNTAMOS SI EXISTE LA SESION
                if (Session["SUMASALARIAL"] != null)
                {
                    //EXISTE, RECUPERAMOS LA SUMA
                    //PREVIA
                    suma = (int)Session["SUMASALARIAL"];
                }
                else
                {
                    //NO EXISTE, LA SUMA LA INICIALIZAMOS
                    suma = 0;
                }
                //SUMAMOS EL SALARIO A LA VARIABLE
                suma += salario.GetValueOrDefault();
                //ALMACENAMOS EN LA SESION EL NUEVO
                //SALARIO PARA ACCIONES SIGUIENTES
                Session["SUMASALARIAL"] = suma;
                ViewBag.Mensaje = "Salario "
                    + salario.GetValueOrDefault()
                    + " almacenado correctamente";
            }
            List<Empleado> empleados = repo.GetEmpleados();
            return View(empleados);
        }

        //GET: SumaSalarial
        public ActionResult SumaSalarial()
        {
            return View();
        }

        // GET: Sesiones
        public ActionResult Index()
        {
            return View();
        }

        //GET: AlmacenarEmpleados
        public ActionResult AlmacenarEmpleados(int? empno)
        {
            if (empno != null)
            {
                List<int> seleccionados;
                if (Session["EMPLEADOS"] != null)
                {
                    seleccionados =
                        Session["EMPLEADOS"] as List<int>;
                }
                else
                {
                    seleccionados = new List<int>();
                }
                seleccionados.Add(empno.GetValueOrDefault());
                Session["EMPLEADOS"] = seleccionados;
                ViewBag.Mensaje = "Empleados almacenados: "
                    + seleccionados.Count;
            }
            List<Empleado> empleados = repo.GetEmpleados();
            return View(empleados);
        }

        //Get: EmpleadosSeleccionados
        public ActionResult EmpleadosSeleccionados(int? eliminar)
        {
            if (eliminar != null) 
            {
                //Recupero lo que hay dentro de la sesión
                List<int> lista = (List<int>)Session["EMPLEADOS"];
                //ELIMINAMOS DE LA LISTA EL ID QUE HAYAN PULSADO
                lista.Remove(eliminar.GetValueOrDefault());
                //Si la lista es igual a cero, le diremos que la sesión empleados es null
                if (lista.Count == 0)
                {
                    Session["EMPLEADOS"] = null;
                }
                else
                { 
                    //Actualizamos la sesión con la lista sin el empleado
                    Session["EMPLEADOS"] = lista;
                }                
            }

            if (Session["EMPLEADOS"] != null)
            {
                List<int> seleccionados = (List<int>)
                    Session["EMPLEADOS"];
                List<Empleado> empleados =
                    repo.GetEmpleadosSeleccionados(seleccionados);
                return View(empleados);
            }
            return View();
        }
    }
}