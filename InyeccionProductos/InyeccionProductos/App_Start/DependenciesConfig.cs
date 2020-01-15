using Autofac;
using Autofac.Integration.Mvc;
using InyeccionProductos.Dpendencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyeccionProductos.App_Start
{
    public class DependenciesConfig
    {
        //Registrar dependencias
        public static void RegisterDependencies()
        {
            //Creamos un constructor de contenedores de la app
            //El que se encarga de crear objetod
            ContainerBuilder builder = new ContainerBuilder();

            //Los controllers tienen inyección de dependencias 
            //por lo que debemos de registrarlos dentro de container
            //para que pueda resolver las dependencias (Que realice un 
            // new lo que sea)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //Coge la app donde trabajamos y registra todos los controladores que 
            //haya para que, en el caso de que haya inyecciones las haga automáti
            //camente

            //Si tuviéramos filtros, tendriamos que registrarlos
            builder.RegisterFilterProvider();

            //Debemos registrar las vistas
            builder.RegisterSource(new ViewRegistrationSource());

            //La clase Module tendrá los new objects
            //Debemos registrar el Módulo para las dependencias
            builder.RegisterModule(new IOModules());

            //Necesitamos el contenedor
            IContainer container = builder.Build();

            //Registramos en nuestra app el contenedor para que sea
            //el encargado de resolver todas las dependencias
            //Indicará el contenedoor encargado de hacer las dependencias
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}