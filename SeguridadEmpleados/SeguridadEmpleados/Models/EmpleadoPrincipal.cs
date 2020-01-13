using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SeguridadEmpleados.Models
{
    //No dejaba poner la herendia de Empleado porque está mapeando la clse
    // y busca coincidencias entre los métodos, por eso tenemos que especificar que 
    //no mapee
    [NotMapped]
    public class EmpleadoPrincipal : Empleados, IPrincipal
    //Quiero que contenga todo lo que tenga empleado
    //E implementar la interface iprinppal
    
    {
        //Un ppal esta compuesto por grupos, una identidad y el name
        List<String> Roles;
        public EmpleadoPrincipal(IIdentity identidad, List<String> roles) //O recibo un grupo o una coleccion 
        //que contenga la información o por si tiene más de un Role
        {
            this.Identity = identidad;
            this.Roles = roles;
        }
        public IIdentity Identity { get; set; }//Modificamos para que sea una propiedad

        public bool IsInRole(string role)//Método que sirve para verificar 
            //en qué role está el usuario
        {
            return this.Roles.Contains(role);
        }
    }
}