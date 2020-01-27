using ServicioApiCoches.Data;
using ServicioApiCoches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioApiCoches.Repositories
{
    public class RepositoryCoches
    {
        CochesContext context;
        public RepositoryCoches()
        {
            this.context = new CochesContext();
        }

        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }

        public Coche BuscarCoche(int idCoche)
        {
            return this.context.Coches.SingleOrDefault(z => z.IdCoche == idCoche);
        }
    }
}