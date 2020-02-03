using AccesoDatosCore.Data;
using AccesoDatosCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesoDatosCore.Repositories
{
    public class RepositoryDept: IRepository
    {
        IHospitalContext context;
        public RepositoryDept(IHospitalContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in context.Departamentos
                           select datos;
            return consulta.ToList();
        }
    }
}
