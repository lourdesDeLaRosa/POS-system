using sistemaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDatos
{
    public class DArticulo
    {
        //metodo para seleccionar o cargar las categorias activas
        public DataTable CargarCategorias()
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlDataReader Resultado; //me permite leer una tabla de SQL Server
            DataTable Tabla = new DataTable(); //esta es la tabla que vamos a manipular en c#
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("categoria_seleccionar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //nosotros no podemos manipular un sqlDataReader en c#, hay que convertirlo a
                //un tipo manipulable
                Tabla.Load(Resultado);
                //retornamos la tabla, que es lo que vamos a manioular en la programacion 
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }//fin metodo activar

        //desactivar un articulo
        public string Activar(int id)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos
            String Respuesta = ""; //se usa esta variable para almacenar si se insertó o no

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_activar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el Registro";

            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            //retornar la respuesta
            return Respuesta;


        }//fin del metodo activar

        public string Desactivar(int id)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos
            String Respuesta = ""; //se usa esta variable para almacenar si se insertó o no

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_desactivar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el Registro";

            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            //retornar la respuesta
            return Respuesta;


        }//fin del metodo desactivar

        //actualizar categoria


        //Eliminar una categoria
        public string Eliminar(int id)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos
            String Respuesta = ""; //se usa esta variable para almacenar si se insertó o no

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_eliminar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el Registro";

            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            //retornar la respuesta
            return Respuesta;


        }//fin del metodo eliminar


        //insertar un articulo
        public string Insertar(Articulo obj)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos
            String Respuesta = ""; //se usa esta variable para almacenar si se insertó o no

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_insertar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = obj.Precio_Venta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = obj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.Imagen;

                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el Registro";

            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            //retornar la respuesta
            return Respuesta;


        }//fin del metodo insertar


        //actualizar articulo
        public string Actualizar(Articulo obj)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos
            String Respuesta = ""; //se usa esta variable para almacenar si se insertó o no

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_actualizar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("idarticulo", SqlDbType.Int).Value = obj.IdArticulo;
                Comando.Parameters.Add("idcategoria", SqlDbType.Int).Value = obj.IdCategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = obj.Precio_Venta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = obj.Stock;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.Imagen;

                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el Registro";

            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            //retornar la respuesta
            return Respuesta;


        }//fin del metodo actualizar


        //buscar una o varios articulos
        public DataTable BuscarCodigo(string Valor)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlDataReader Resultado; //me permite leer una tabla de SQL Server
            DataTable Tabla = new DataTable(); //esta es la tabla que vamos a manipular en c#
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar el parametro que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //nosotros no podemos manipular un sqlDataReader en c#, hay que convertirlo a
                //un tipo manipulable
                Tabla.Load(Resultado);
                //retornamos la tabla, que es lo que vamos a manioular en la programacion 
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public DataTable Buscar(string Valor)
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlDataReader Resultado; //me permite leer una tabla de SQL Server
            DataTable Tabla = new DataTable(); //esta es la tabla que vamos a manipular en c#
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_buscar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar el parametro que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //nosotros no podemos manipular un sqlDataReader en c#, hay que convertirlo a
                //un tipo manipulable
                Tabla.Load(Resultado);
                //retornamos la tabla, que es lo que vamos a manioular en la programacion 
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }


        //public DataTable buscarCodigo(string valor)
        //{
        //    //paso 1 - crear los objetos para almacenar los datos desde la tabla sql
        //    SqlDataReader Resultado;// me permite leer una tabla de sql server
        //    DataTable Tabla = new DataTable(); // esta es la tabla que vamos a manipular en c#
        //    SqlConnection sqlConnection = new SqlConnection();// con este nos conectamos a la base de datos

        //    //paso 2 - tratar de conectarnos y ejecutar un comando sql

        //    try
        //    {
        //        //obtenemos la cadena de conexion
        //        sqlConnection = Conexion.GetInstancia().crearConexion();
        //        //configurar el comando sql que queremos ejecutar
        //        SqlCommand Comando = new SqlCommand("articulo_buscar_codigo", sqlConnection);
        //        // le debo indicar a comando que va a ejecutar un procedimiento almacenado
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        //debemos configurar el parametro que el stored procedure requiere
        //        Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
        //        //abrir la conexion para ejecutar
        //        sqlConnection.Open();
        //        //ejecutar comando
        //        Resultado = Comando.ExecuteReader();
        //        //nosostros no podemos anipular un sqldatareader en c# hay que convertirlo en un tipo manipulable
        //        Tabla.Load(Resultado);
        //        //retornamos la tabla, que es lo que vamos a manipular en la programacion
        //        return Tabla;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;// dime si hubo un error
        //    }
        //    finally
        //    {
        //        if (sqlConnection.State == ConnectionState.Open)
        //        {
        //            sqlConnection.Close();
        //        }
        //    }
        //}// fin buscar


        //Listar las categorias

        public DataTable Listar()
        {
            //Paso 1. crear los objetos para almacenar los datos desde la tabla SQL
            SqlDataReader Resultado; //me permite leer una tabla de SQL Server
            DataTable Tabla = new DataTable(); //esta es la tabla que vamos a manipular en c#
            SqlConnection sqlConnection = new SqlConnection();//con este nos vamos a conectar a la base de datos

            //Paso 2. tratar de econectarnos y ejecutar un comando sql
            try
            {
                //obtenempos cadena de conexion
                sqlConnection = Conexion.GetInstancia().crearConexion();
                //Configurar el comando SQL que queremos manejar
                SqlCommand Comando = new SqlCommand("articulo_listar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //abrimos la conexion para ejecutar
                sqlConnection.Open();
                //ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //nosotros no podemos manipular un sqlDataReader en c#, hay que convertirlo a
                //un tipo manipulable
                Tabla.Load(Resultado);
                //retornamos la tabla, que es lo que vamos a manioular en la programacion 
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex; //dime si hubo un error
            }
            finally
            {
                //siempre debemos cerrar la conexion a la base de datos
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }//fin metodo listar


    }

}
