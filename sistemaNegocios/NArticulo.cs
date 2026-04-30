using sistemaDatos;
using sistemaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNegocios
{
    public class NArticulo
    {
        //metodo para cargar las categorias que estan activas
        public static DataTable CargarCategorias()
        {
           DArticulo datos = new DArticulo();
            return datos.CargarCategorias();
        }

        //Listar categorias
        public static DataTable Listar()
        {
            //instanciar la capa de datos
            DArticulo datos = new DArticulo();
            return datos.Listar();
        }//fin de metodo listar


        //buscar categorias
        public static DataTable Buscar(string valor)
        {
            //instanciar la capa de datos
            DArticulo datos = new DArticulo();
            return datos.Buscar(valor);
        }

        public static DataTable BuscarCodigo(string valor)
        {
            //instanciar la capa de datos
            DArticulo datos = new DArticulo();
            return datos.BuscarCodigo(valor);
        }


        //metodo Insertar
        public static string Insertar(int idcategoria, string codigo, string nombre, decimal precio_venta, int stock, string descripcion, string imagen)
        {
            //instanciar la capa de datos
            DArticulo datos = new DArticulo();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Articulo articulo = new Articulo();

            articulo.IdCategoria = idcategoria;
            articulo.Codigo = codigo;
            articulo.Nombre = nombre;
            articulo.Precio_Venta = precio_venta;
            articulo.Stock = stock;
            articulo.Descripcion = descripcion;
            articulo.Imagen = imagen;

            return datos.Insertar(articulo);
        }//fin metodo insertar


        //metodo actualizar
        public static string Actualizar(int idarticulo, int idcategoria, string nombre, string descripcion, string codigo, decimal precio_venta, int stock, string imagen)
        {
            //instanciar la capa de datos
            DArticulo datos = new DArticulo();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Articulo articulo = new Articulo();

            articulo.IdArticulo = idarticulo;
            articulo.IdCategoria = idcategoria;
            articulo.Nombre = nombre;
            articulo.Descripcion = descripcion;
            articulo.Codigo = codigo;
            articulo.Stock = stock;
            articulo.Imagen = imagen;

            return datos.Actualizar(articulo);
        }//fin metodo actualizar

        //metodo eliminar
        public static string Eliminar(int id)
        {
            //instanciar el objeto aja
            DArticulo datos = new DArticulo();
            return datos.Eliminar(id);
        }//fin metodo eliminar



        //metodo activar
        public static string Activar(int id)
        {
            //instanciar el objeto aja
            DArticulo datos = new DArticulo();
            return datos.Activar(id);
        }//fin metodo Activar

        public static string ObtenerCodigoBarrasPorId(int id)
        {
            string codigo = "";
            SqlConnection sqlConnection = new SqlConnection();
            SqlDataReader Resultado;

            try
            {
                sqlConnection = Conexion.GetInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("SELECT codigo FROM Articulo WHERE idarticulo = @idarticulo", sqlConnection);
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;

                sqlConnection.Open();
                Resultado = Comando.ExecuteReader();

                if (Resultado.Read())
                {
                    codigo = Resultado["codigo"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return codigo;
        }





        //metodo desactivar
        public static string Desactivar(int id)
        {
            //instanciar el objeto aja
             DArticulo datos = new DArticulo();
            return datos.Desactivar(id);
        }//fin metodo Desactivar

    }
}
