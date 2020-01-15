using Autofac;
using InyeccionProductos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionProductos.Dpendencies
{
    public class IOModules : Module 
    {
        //Método LOAD donde realizaremos las inversiones
        //de control
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            //Registramos las clases de inyección
            //ESTO ES EL CONTAINER
            //builder.Register(z => new RepositoryProductos()).InstancePerRequest(); //No estamos especificando
            //El tipo de clase que es respositoryProductos
            //Por cada petición hará un new repo, cuantas veces quieres que cree
            //el objeto a lo largo de la app

            //Debemos registrar un tipo (RepositoryProductos)
            builder.RegisterType<RepositoryProductosNEW>()
                .As<IRepositoryProductos>().InstancePerRequest();
        }
    }
}