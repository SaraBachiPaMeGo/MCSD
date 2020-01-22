using ProyectoMvcEneroAjax.Data;
using ProyectoMvcEneroAjax.Helpers;
using ProyectoMvcEneroAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMvcEneroAjax.Repositories
{
    public class RepositoryUsuario
    {
        ContextoHospital context;

        public RepositoryUsuario()
        {
            this.context = new ContextoHospital();
        }

        public List<Usuario> GetUsuarios()
        {
            var consulta = from datos in context.Usuarios
                           select datos;
            return consulta.ToList();
        }
        
        public void InsertarUser(int idUser, String nombre, String usuario, String pass)
        { 
            Usuario user = new Usuario();

            user.IdUsuario = idUser;
            user.Nombre = nombre;
            user.User = usuario;
            //user.Pass = pass;

            String salt = HelperCifrado.GenerarSalt();
            user.Salt = salt;

            byte[] passw = HelperCifrado.CifrarPass(pass, salt);
            user.Pass = passw;            

            this.context.Usuarios.Add(user);
            this.context.SaveChanges();
        }

        //Comprobar el nombre del usuario y su password

        public Usuario ExisteUser(String usuario, String pass)
        {
            //Buscamos al usuario por su username
            Usuario user = context.Usuarios.SingleOrDefault(z => z.User == usuario);

            if (user != null)
            {
                //Extraemos el salt del usuario
                String salt = user.Salt;

                //Convertimos a bytes el password con el salt
                byte[] cifrado = HelperCifrado.CifrarPass(pass, salt);

                //Comparamos el cifrado con los datos de la BBDD
                bool resultado = HelperCifrado.CompararBytes(cifrado, user.Pass);

                if (resultado == true)
                {
                    return user;
                }
                else 
                {
                    return null;
                }
            }

            return null;
        }
    }
}