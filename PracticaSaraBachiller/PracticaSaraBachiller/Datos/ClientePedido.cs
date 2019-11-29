using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSaraBachiller.Datos
{
    public class ClientePedido
    {
        public int cantidad { get; set; }
        public DateTime fechaPedido { get; set; }
        public String nombreProducto { get; set; }

        public int precio { get; set; }

        public int precioTotal { get; set; }
    }
}
