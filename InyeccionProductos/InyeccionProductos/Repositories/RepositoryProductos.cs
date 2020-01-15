using InyeccionProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionProductos.Repositories
{
    public class RepositoryProductos : IRepositoryProductos
    {
        List<Productos> productos;
        public RepositoryProductos() 
        {
            productos = new List<Productos>();
            this.CrearProductos();            
        }
        public void CrearProductos() {
            Productos p = new Productos();

            p.Nombre = "CHAMPÚ";
            p.Descripcion = "OLOR A ROSAS";
            p.Foto = "https://www.garnier.es/~/media/garnier%20local/es-es/prd-haircare/haircare_brands_fructis_strengthandshine/ch_fyb_l2019.png?c=1&h=488";
            p.Precio = 2;

            this.productos.Add(p);

            p = new Productos();
            p.Nombre = "ZAPATILLAS";
            p.Descripcion = "ADIDAS ROSA";
            p.Foto = "https://www.forumsport.com/medias/medias-1000456534-00-P-X-20181120201411.jpg?context=bWFzdGVyfGltYWdlc3wxNjQzOTR8aW1hZ2UvanBlZ3xpbWFnZXMvaDBhL2gwYi84OTUxNjM5MDQ4MjIyLmpwZ3w0MTg5YjM5NGI5ZmU2ZjBkMzA0ZmEwNDFhNWIwNDlhOTc4ZjkzMWI5ZDk5MzRhNWZiMWZhYTI3N2Y2ZTU4Njlj";
            p.Precio = 85;

            this.productos.Add(p);

            p = new Productos();
            p.Nombre = "GAFAS";
            p.Descripcion = "REDONDAS";
            p.Foto = "https://www.bally.eu/dw/image/v2/AAWE_PRD/on/demandware.static/-/Sites-bly-master-product-catalog/default/dweb81fdb5/images/original/Sunglasses_BY0001_D_003F.jpg";
            p.Precio = 75;

            this.productos.Add(p);
        }

        public List<Productos> GetProductos()
        {
            return this.productos;
        }
    }
}