using Autofac;
using Autofac.Integration.Mvc;
using InyeccionHospitales.Data;
using InyeccionHospitales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace InyeccionHospitales.App_Start
{
    public class IoCConfiguration
    {
        public static void RegisterDependencies()
        {
            //Constructor de contenedores
            ContainerBuilder builder = new ContainerBuilder();

            //Registramos los controladores
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Creamos la clase context
            builder.Register(z => new ContextoHospital()).InstancePerRequest();

            //Establecemos el tipo de IRepo para la clase repo
            builder.RegisterType<RepositoryHospitalSQL>().As<IRepositoryHospital>().InstancePerRequest();

            //Creamos el container y el constructor que nos lo crea
            IContainer container = builder.Build();

            //Indicamos al entorno MVC qué contenedor IoC va a utilizar
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}