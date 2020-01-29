using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ExamenMVCSaraBachiller.Models
{
    [NotMapped]
    public class UsuarioPrincipal : Usuario,IPrincipal
    {
        public UsuarioPrincipal(IIdentity identidad, String roles) 
        {
            this.Identity = identidad;
            this.Rol = "";
        }
        public IIdentity Identity { get; set; }
        public String Rol { get; set; }

        public bool IsInRole(string role)
        {
            return true;
        }
    }
}