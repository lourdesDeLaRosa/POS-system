using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaEntidad;
using System.Drawing;

namespace sistemaDatos
{
    public class DUsuario
    {
        //metodo para seleccionar o cargar las categorias activas
        public DataTable CargarRol()
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
                SqlCommand Comando = new SqlCommand("usuario_seleccionar", sqlConnection);
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
        }

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
                SqlCommand Comando = new SqlCommand("usuario_activar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
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
                SqlCommand Comando = new SqlCommand("usuario_desactivar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
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
                SqlCommand Comando = new SqlCommand("usuario_eliminar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
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

        public string Insertar(Usuario obj)
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
                SqlCommand Comando = new SqlCommand("usuario_insertar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.IdRol;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = obj.Tipo_Documento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = obj.Num_Documento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Clave;
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = obj.Estado;

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


        public string Actualizar(Usuario obj)
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
                SqlCommand Comando = new SqlCommand("usuario_actualizar", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //se debe configurar los parametros que el procedimiento alamcenado requiere 
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.IdUsuario;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.IdRol;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = obj.Tipo_Documento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = obj.Num_Documento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Clave;

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
                SqlCommand Comando = new SqlCommand("usuario_buscar", sqlConnection);
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
                SqlCommand Comando = new SqlCommand("usuario_listar", sqlConnection);
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

        //traer la informacion de un usuario que hizo login
        public DataTable Login(string email, string clave)
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
                SqlCommand Comando = new SqlCommand("usuario_login", sqlConnection);
                //le debo indicar a comando que va a ejecutar un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value= clave;
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



        
    }
}

