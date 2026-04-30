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
    public class DCategoria
    {
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
                SqlCommand Comando = new SqlCommand("categoria_listar", sqlConnection);
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

        //buscar una o varias categorias
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
                SqlCommand Comando = new SqlCommand("categoria_buscar", sqlConnection);
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


        //insertar una categoria
        public string Insertar(Categoria obj)
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
                SqlCommand Comando = new SqlCommand("categoria_insertar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
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


        //actualizar categoria
        public string  Actualizar(Categoria obj)
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
                SqlCommand Comando = new SqlCommand("categoria_actualizar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;
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


        //activar una categoria
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
                SqlCommand Comando = new SqlCommand("categoria_activar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;  
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


        //Desactivar una categoria
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
                SqlCommand Comando = new SqlCommand("categoria_desactivar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
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
                SqlCommand Comando = new SqlCommand("categoria_eliminar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
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
    }

}
