using sistemaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDatos
{
    public class DVentas
    {
        public DataTable Listar()
        {
            //paso 1 - crear los objetos para almacenar los datos desde la tabla sql
            SqlDataReader Resultado;// me permite leer una tabla de sql server
            DataTable Tabla = new DataTable(); // esta es la tabla que vamos a manipular en c#
            SqlConnection sqlConnection = new SqlConnection();// con este nos conectamos a la base de datos

            //paso 2 - tratar de conectarnos y ejecutar un comando sql

            try
            {
                //obtenemos la cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //configurar el comando sql que queremos ejecutar
                SqlCommand Comando = new SqlCommand("venta_listar", sqlConnection);
                // le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //abrir la conexion para ejecutar
                sqlConnection.Open();
                //ejecutar comando
                Resultado = Comando.ExecuteReader();
                //nosostros no podemos anipular un sqldatareader en c# hay que convertirlo en un tipo manipulable
                Tabla.Load(Resultado);
                //retornamos la tabla, que es lo que vamos a manipular en la programacion
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;// dime si hubo un error
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }// fin listar

        public DataTable ListarDetalle(int Id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("venta_listar_detalle", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }



        public DataTable Buscar(string valor)
        {
            //paso 1 - crear los objetos para almacenar los datos desde la tabla sql
            SqlDataReader Resultado;// me permite leer una tabla de sql server
            DataTable Tabla = new DataTable(); // esta es la tabla que vamos a manipular en c#
            SqlConnection sqlConnection = new SqlConnection();// con este nos conectamos a la base de datos

            //paso 2 - tratar de conectarnos y ejecutar un comando sql

            try
            {
                //obtenemos la cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //configurar el comando sql que queremos ejecutar
                SqlCommand Comando = new SqlCommand("venta_buscar", sqlConnection);
                // le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro que el stored procedure requiere
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrir la conexion para ejecutar
                sqlConnection.Open();
                //ejecutar comando
                Resultado = Comando.ExecuteReader();
                //nosostros no podemos anipular un sqldatareader en c# hay que convertirlo en un tipo manipulable
                Tabla.Load(Resultado);
                //retornamos la tabla, que es lo que vamos a manipular en la programacion
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;// dime si hubo un error
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }// fin buscar

        public string Anular(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("venta_anular", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }//fin anular


        public string Insertar(Ventas obj)
        {
            //paso 1 - crear los objetos para almacenar los datos desde la tabla sql
            SqlConnection sqlConnection = new SqlConnection();

            string respuesta = string.Empty;

            try
            {

                sqlConnection = Conexion.GetInstancia().crearConexion();
                //ahora debemos de configurar el comando que ejecutaremos.
                //para eso creamos un objeto de tipo SqlCommand.
                SqlCommand comando = new SqlCommand("venta_insertar", sqlConnection);
                //decirle que va a ejecutar un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado requiere un parametro, debemos enviarlo

                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.IdUsusario;
                comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = obj.IdCliente;
                comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = obj.TipoComprobante;
                comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = obj.SerieComprobante;
                comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = obj.NumComprobante;
                comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = obj.Impuesto;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = obj.Total;
                comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = obj.Detalles;
                //abrimos la conexion
                sqlConnection.Open();
                //ejecutamos el comando
                comando.ExecuteNonQuery();
                respuesta = "OK";



            }
            catch (Exception ex)
            {

                respuesta = ex.Message; // si ocurre una excepcion, dimela
            }
            finally
            {
                //siempre debemos cerrar la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }//retornamos la respuesta
            return respuesta;
        }// fin insertar

        public DataTable Buscar_Codigo_Venta(string valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo_venta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

    }
}

