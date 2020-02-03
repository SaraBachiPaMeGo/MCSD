using AccesoDatosCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesoDatosCore.Repositories
{
    public interface IRepository
    {
        List<Departamento> GetDepartamentos();
    }
}
