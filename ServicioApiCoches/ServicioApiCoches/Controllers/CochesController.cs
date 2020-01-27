using ServicioApiCoches.Models;
using ServicioApiCoches.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioApiCoches.Controllers
{
    public class CochesController : ApiController
    {
        RepositoryCoches repo;
        public CochesController()
        {
            this.repo = new RepositoryCoches();
        }

        //GET: api/Coches
        public List<Coche> GetCoches()
        {
            return this.repo.GetCoches();
        }

        public Coche GetUnCoche(int id)
        {
            return this.repo.BuscarCoche(id);
        }
    }
}
