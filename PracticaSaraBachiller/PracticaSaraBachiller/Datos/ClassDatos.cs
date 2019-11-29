using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticaSaraBachiller.Datos
{
    #region
    //    SELECT* FROM Productos

    //--•	Creación de Productos y modificación de productos.
    //INSERT INTO Productos values(11,'MAC', 1500, 4);

    //    UPDATE Productos set Nombre = 'ZapatillaS' WHERE IdProducto = 1;

    //--•	Eliminar y realizar pedidos para un cliente

    //DELETE FROM Clientes WHERE CodigoCliente = 1;

    //--•	Cada vez que realizamos un pedido, debemos restar del Stock del producto.

    //CREATE PROCEDURE RealizarPedidoS
    //(@IDPedido INT, @IDCliente INT, @fecha datetime, @IDProd INT, @Unid INT)
    //AS
    //    UPDATE PEDIDOs SET FechaPedido = @fecha, IdProducto = @IDProd, Unidades = @Unid
    //    where CodigoPedido = @IDPedido AND CodigoCliente = @IDCliente

    //    UPDATE Productos SET Stock = Stock - 1
    //GO

    //aLTER PROCEDURE RealizarPedido
    //(@IDPedido INT, @IDCliente INT, @fecha datetime, @IDProd INT, @Unid INT)
    //AS

    //    DECLARE @STOCK INT


    //    INSERT INTO PEDIDOS values(@IDPedido, @IDCliente , @fecha, @IDProd, @Unid)


    //    SELECT @STOCK = STOCK FROM Productos

    //    WHERE IdProducto = @IDProd

    //	if(@STOCK <= 0)
    //	BEGIN
    //        PRINT 'NO HAY STOCK DISPONIBLE'
    //	END
    //    ELSE

    //    BEGIN
    //        UPDATE Productos SET Stock = Stock - 1
    //	where IdProducto = @IDProd

    //    END
    //GO

    //exec RealizarPedido 000,1,'19/11/2019', 1, 1

    //--•	Visualizar los pedidos de cada cliente con datos detallados, es decir, el precio total de un pedido, 
    //--junto al nombre de los productos que ha comprado y su cantidad, también mostrando el precio individual
    //-- de producto por su cantidad.Crear una Vista que nos devuelva los datos y realizaremos un formulario
    //--con movimiento por los pedidos(Siguiente, Anterior)

    //SELECT* FROM Pedidos



    //   Alter VIEW PedidoDetallado AS

    //   SELECT PEDIDOS.CodigoCliente, Productos.nombre AS NombreProducto, Productos.precio, Productos.precio* Pedidos.Unidades as PrecioTotal,
    //   Pedidos.Unidades as Cantidad, Pedidos.FechaPedido
    //   FROM Productos
    //   INNER JOIN PEDIDOS

    //   ON PRODUCTOS.IDPRODUCTO = PEDIDOS.IDPRODUCTO



    //   Go

    //CREATE PROCEDURE NUEVO3
    //(@IDCLI NVARCHAR(10))
    //AS

    //    SELECT* FROM PedidoDetallado
    //   WHERE CodigoCliente = @IDCLI
    //GO

    //SELECT* FROM PedidoDetallado
    //   WHERE CodigoCliente = 'MAS'


    //select* from PedidoDetallado
    //select* from Pedidos

    //--•	Modificar datos de los clientes, excepto su PK

    //ALTER PROCEDURE ModificarCli
    //(@cod nvarchar(10), @empresa nvarchar(10), @cont nvarchar(10),@carg nvarchar(10),@city nvarchar(10),@tlf int)
    //as
    //declare @codigo nvarchar(10)


    //    SELECT @codigo = COUNT(CODIGOCLIENTE) FROM Clientes

    //		if(@cod is null)
    //		begin
    //            PRINT 'CODIGO PK INCORRECTO: NO EXISTE'
    //		end
    //		else
    //		begin
    //            update Clientes set Empresa= @empresa, Contacto=@cont,Cargo=@carg, Ciudad=@city
    //            where CodigoCliente = @cod
    //        end


    //go

    //EXEC ModificarCli 'xxx', 'PRUEBA', 'PRUEBA','PRUEBA','PRUEBA', 00000000

    //SELECT* FROM Clientes
    #endregion
    public class ClassDatos
    {
        String cadena;
        SqlDataAdapter ad;
        DataTable tabla; 
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public ClassDatos() {
            this.cadena = "Data Source = localhost; Initial Catalog = Tienda; User ID = SA; Password = MCSD2019";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            ad = new SqlDataAdapter();
            ad.SelectCommand = new SqlCommand();
            ad.SelectCommand.Connection = cn;
            this.cn.InfoMessage += Cn_InfoMessage;
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
           // e.Message;
        }
        // Crear y modificar 

        public List<Producto> GetProductos() {
            String sql = "SELECT * FROM PRODUCTOS";

            tabla = new DataTable();

            this.ad.SelectCommand.CommandType = CommandType.Text;
            this.ad.SelectCommand.CommandText = sql;

            ad.Fill(tabla);

            List<Producto> listaprod = new List<Producto>();

            foreach (DataRow row in tabla.Rows) {
                Producto prod = new Producto();

                prod.idProducto = int.Parse(row["IdProducto"].ToString());
                prod.nombreProducto = row["Nombre"].ToString();
                prod.precioProducto = int.Parse(row["Precio"].ToString());
                prod.StockProducto = int.Parse(row["Stock"].ToString());
                listaprod.Add(prod);
            }
            return listaprod;
        }

        public List<Pedido> GetPedidos()
        {
            String sql = "SELECT * FROM Pedidos";

            tabla = new DataTable();

            this.ad.SelectCommand.CommandType = CommandType.Text;
            this.ad.SelectCommand.CommandText = sql;

            ad.Fill(tabla);

            List<Pedido> listapedi = new List<Pedido>();

            foreach (DataRow row in tabla.Rows)
            {
                Pedido ped = new Pedido();

                ped.codigoPedido =row["CodigoPedido"].ToString();
                ped.codigoCliente = row["CodigoCliente"].ToString();
                ped.fechaPedido = Convert.ToDateTime(row["FechaPedido"].ToString());
                ped.codigoProducto = int.Parse(row["IdProducto"].ToString());
                ped.unidades = int.Parse(row["Unidades"].ToString());
                listapedi.Add(ped);
            }
            return listapedi;
        }

        public List<Cliente> GetClientes()
        {
            String sql = "SELECT * FROM Clientes";

            tabla = new DataTable();

            this.ad.SelectCommand.CommandType = CommandType.Text;
            this.ad.SelectCommand.CommandText = sql;

            ad.Fill(tabla);

            List<Cliente> listaCli = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                Cliente cli = new Cliente();

                cli.codigoCliente = row["CodigoCliente"].ToString();
                cli.empresa = row["Empresa"].ToString();
                cli.contacto = row["Contacto"].ToString();
                cli.cargo = row["Cargo"].ToString();
                cli.ciudad = row["Ciudad"].ToString();
                cli.tlf = int.Parse(row["Telefono"].ToString());
                listaCli.Add(cli);
            }

            return listaCli;
        }

        public ClientePedido GetDetalles() {
            String sql = "SELECT * FROM PedidoDetallado";
            tabla = new DataTable();

            this.ad.SelectCommand.CommandType = CommandType.Text;
            this.ad.SelectCommand.CommandText = sql;

            ad.Fill(tabla);

            ClientePedido cliPedi = new ClientePedido();

            foreach (DataRow row in tabla.Rows)
            {
                cliPedi.nombreProducto = row["NombreProducto"].ToString();
                cliPedi.precio = int.Parse(row["Precio"].ToString());
                cliPedi.precioTotal = int.Parse(row["PrecioTotal"].ToString());
                cliPedi.cantidad = int.Parse(row["Cantidad"].ToString());
                cliPedi.fechaPedido = Convert.ToDateTime(row["FechaPedido"].ToString());

            }

            return cliPedi;
        
        }

        public void VerDetalles(string idCliente)
        {
            String sql = "NUEVO3";

            this.com.Parameters.AddWithValue("@IDCLI", idCliente);

            tabla = new DataTable();

            this.ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            this.ad.SelectCommand.CommandText = sql;

            ad.Fill(tabla);

            ClientePedido cliPedi= new ClientePedido();

            foreach (DataRow row in tabla.Rows)
            {
                cliPedi.nombreProducto = row["NombreProducto"].ToString();
                cliPedi.precio = int.Parse(row["Precio"].ToString());
                cliPedi.precioTotal = int.Parse(row["PrecioTotal"].ToString());
                cliPedi.cantidad = int.Parse(row["Cantidad"].ToString());
                cliPedi.fechaPedido =Convert.ToDateTime( row["FechaPedido"].ToString());

            }

            this.com.Parameters.Clear();
            //return cliPedi;          
            GetDetalles();
        }



        public void InsertPedidos(String idPedido, String idCliente, DateTime fechaPedido, int idProducto, int unidades)
        {
            String sql = "RealizarPedido";

            this.com.Parameters.AddWithValue("@IDPedido", idPedido);
            this.com.Parameters.AddWithValue("@IDCliente", idCliente);
            this.com.Parameters.AddWithValue("@fecha", fechaPedido);
            this.com.Parameters.AddWithValue("@IDProd", idProducto);
            this.com.Parameters.AddWithValue("@Unid", unidades);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetPedidos();
        }

        public void DeletePedidos(String idPedido, String idCliente, DateTime fechaPedido, int idProducto, int unidades)
        {
            String sql = "DELETE Pedidos WHERE CodigoPedido =@idPedido and CodigoCliente =@idCliente";

            this.com.Parameters.AddWithValue("@idPedido", idPedido);
            this.com.Parameters.AddWithValue("@idCliente", idCliente);
            this.com.Parameters.AddWithValue("@fechaPedido", fechaPedido);
            this.com.Parameters.AddWithValue("@idProducto", idProducto);
            this.com.Parameters.AddWithValue("@unidades", unidades);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetPedidos();
        }

        public void InsertProductos(int id, String nombre, int precio, int stock)
        {
            String sql = "INSERT INTO Productos VALUES (@ID,@NOMBRE,@PRECIO,@STOCK)";

            this.com.Parameters.AddWithValue("@ID", id);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@PRECIO", precio);
            this.com.Parameters.AddWithValue("@STOCK", stock);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetProductos();
        }

        public void UpdateProductos(int id, String nombre, int precio, int stock)
        {
            String sql = "UPDATE PRODUCTOS SET Nombre = @NOMBRE," +
                "Precio = @PRECIO, Stock =@STOCK WHERE IdProducto =@ID";

            this.com.Parameters.AddWithValue("@ID", id);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@PRECIO", precio);
            this.com.Parameters.AddWithValue("@STOCK", stock);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetProductos();
        }

        public void UpdateCliente( String id, String Empresa, String Cont, String cargo, String city, int tlf)
        {
            String sql = "UPDATE CLIENTES SET Empresa = @Empresa," +
                "Contacto = @Cont, Cargo =@cargo, Ciudad = @city, Telefono = @tlf WHERE CodigoCliente =@ID";

            this.com.Parameters.AddWithValue("@ID", id);
            this.com.Parameters.AddWithValue("@Empresa", Empresa);
            this.com.Parameters.AddWithValue("@Cont", Cont);
            this.com.Parameters.AddWithValue("@cargo", cargo);
            this.com.Parameters.AddWithValue("@city", city);
            this.com.Parameters.AddWithValue("@tlf", tlf);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();

            this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            GetClientes();
        }

    }
}
