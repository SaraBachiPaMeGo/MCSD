using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InyeccionProductos.Models;

namespace InyeccionProductos.Repositories
{
    public class RepositoryProductosNEW : IRepositoryProductos
    {
        public List<Productos> GetProductos()
        {
            List<Productos> listaproductos = new List<Productos>();

            Productos p = new Productos();

            p.Nombre = "MOCHILA";
            p.Descripcion = "GIMNASIO";
            p.Foto = "https://images.boardriders.com/globalGrey/roxy-products/all/default/hi-res/erjbp03967_endlessocean,p_xkks_frt1.jpg";
            p.Precio = 2;

            listaproductos.Add(p);

            p = new Productos();
            p.Nombre = "TOALLA";
            p.Descripcion = "GIMNASIO";
            p.Foto = "https://images.ssstatic.com/toalla-gym-31422101z0-15204067.jpg";
            p.Precio = 85;

            listaproductos.Add(p);

            p = new Productos();
            p.Nombre = "PESAS";
            p.Descripcion = "MANCUERNAS";
            p.Foto = "https://images-na.ssl-images-amazon.com/images/I/41FZ1zz22HL._AC_SY400_ML2_.jpg";
            p.Precio = 75;

            listaproductos.Add(p);

            return listaproductos;
        }
    }
}