using ServicioApiPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioApiPersonas.Controllers
{
    public class PersonasController : ApiController
    {
        List<Persona> personas;

        public PersonasController()
        {
            personas = new List<Persona>();

            Persona per = new Persona();
            per.IdPersona = 1;
            per.Nombre = "Lola";
            per.Email = "lolita@gmail.com";
            per.Edad = 15;

            personas.Add(per);

            per = new Persona();
            per.IdPersona = 2;
            per.Nombre = "Alfredo";
            per.Email = "Alfredo@gmail.com";
            per.Edad = 46;

            personas.Add(per);

            per = new Persona();
            per.IdPersona = 3;
            per.Nombre = "Pepe";
            per.Email = "Pepe@gmail.com";
            per.Edad = 75;

            personas.Add(per);

        }

        //Get : api/Personas
        public List<Persona> GetPersonas()
        {
            return this.personas;
        }

        //Get: api/Personas/id
        public Persona GetUnaPersona(int id)
        {
            return this.personas.SingleOrDefault(z=> z.IdPersona == id);
        }


    }
}
