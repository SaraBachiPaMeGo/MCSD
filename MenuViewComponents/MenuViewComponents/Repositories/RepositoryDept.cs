using MenuViewComponents.Data;
using MenuViewComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuViewComponents.Repositories
{
    public class RepositoryDept
    {
        ContextoHospi context;

        public RepositoryDept(ContextoHospi context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }
        public Departamento BuscarDept(int deptno)
        {
            return this.context.Departamentos.SingleOrDefault(z=>z.Dept_no == deptno);
        }
    }
}
