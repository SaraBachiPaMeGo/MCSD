using ProyectoEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoEF.Data
{
    public class ContextoHospital : DbContext
    {
        //En el constructor debemos indicar la cadena
        //de conexion del web config
        //Busca la cadena por su name

        public ContextoHospital() : base("name=conexionhospital") //Recuperamos la cadena que hemos añadido al WEBCONFIG
        { 
            
        }
        //Cada tabla mapeada con una clase es una colección
        //de tipo DbSet
        public DbSet<Hospital> Hospitales { get; set; }
    }
}