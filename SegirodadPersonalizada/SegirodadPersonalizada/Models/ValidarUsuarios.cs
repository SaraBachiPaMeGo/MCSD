using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegirodadPersonalizada.Models
{
    public class ValidarUsuarios
    {
        public String Role { get; set; }
        public bool ExisteUsuario(String usuario, String password)
        {
            if (usuario.ToUpper() == "ADMIN" && password.ToUpper() == "ADMIN")
            {
                this.Role = "ADMINISTRADOR";
                return true;
            }
            else if(usuario.ToUpper() == "USER" && password.ToUpper() == "USER") 
            {
                this.Role = "USUARIO";
                return true;
            }
            return false;
        }
    }
}