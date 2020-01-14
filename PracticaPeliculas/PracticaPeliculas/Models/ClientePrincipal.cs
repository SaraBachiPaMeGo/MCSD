using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace PracticaPeliculas.Models
{
    [NotMapped]
    public class ClientePrincipal : Cliente, IPrincipal
    {
        String Role;

        public ClientePrincipal(IIdentity identidad, String role) {
            this.Identity = identidad;
            this.Role = role;
        }
        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            return Role.Contains(role);
        }
    }
}