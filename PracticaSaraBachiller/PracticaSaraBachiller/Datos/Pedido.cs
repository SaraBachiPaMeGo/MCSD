using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSaraBachiller.Datos
{
    public class Pedido
    {
        public String codigoPedido { get; set; }
        public DateTime fechaPedido { get; set; }
        public String codigoCliente { get; set; }
        public int codigoProducto { get; set; }
        public int unidades { get; set; }
    }
}
