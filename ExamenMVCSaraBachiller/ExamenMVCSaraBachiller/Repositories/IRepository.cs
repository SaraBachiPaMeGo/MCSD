using ExamenMVCSaraBachiller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMVCSaraBachiller.Repositories
{
    public interface IRepository
    {
        List<Pedido> GetPedidos();

        List<VistaPedidos> GetVistaPedidos();
        List<Usuario> GetUsuarios();

        List<Libro> GetLibrosGenero(int IdGenero);
        List<Libro> GetLibros();
        List<Genero> GetGeneros();
        Libro BuscarLibro(int idLibro);
        Usuario BuscarUsuario(String usuario, String pass);
        Usuario BuscarUsuarioId(int id);

        void InsertarPedidos(List<Libro> libros, int IdUsuario, List<int> cantidades);
       
    }
}
