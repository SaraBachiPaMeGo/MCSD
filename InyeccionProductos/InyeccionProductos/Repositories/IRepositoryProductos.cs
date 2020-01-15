using InyeccionProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionProductos.Repositories
{
    public interface IRepositoryProductos
    {
        List<Productos> GetProductos();
    }
}
