using Autofac;
using Autofac.Integration.Mvc;
using ExamenMVCSaraBachiller.Data;
using ExamenMVCSaraBachiller.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ExamenMVCSaraBachiller.App_Start
{
    public class IoCConfiguration
    {
        public static void RegistrarDependencias()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<ContextoLibros>().As<IContexto>().InstancePerRequest();
            builder.RegisterType<RepositoryLibros>().As<IRepository>().InstancePerRequest();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}