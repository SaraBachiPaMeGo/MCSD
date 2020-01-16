using Autofac;
using Autofac.Integration.Mvc;
using InyeccionDepartamentos.Data;
using InyeccionDepartamentos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace InyeccionDepartamentos.App_Start
{
    public class IoCConfiguration
    {
        public static void RegistrarDependencias()
        {
            //Constructor de contenedores
            ContainerBuilder builder = new ContainerBuilder();

            //Creamos los controladores
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //creamos (new) Las interfaces 
            builder.RegisterType<ContextoHospital>().As<IContextoHospital>().InstancePerRequest();
            builder.RegisterType<RepositoryHospital>().InstancePerRequest();

            //Construimos el container con la interfaz IContainer
            IContainer container = builder.Build();

            //Indicamos en el entorno en donde estamos trabajando
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
                    
        }
    }
}