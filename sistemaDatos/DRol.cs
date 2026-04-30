using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDatos
{
    public class DRol
    {
        //listar roles
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
                SqlCommand Comando = new SqlCommand("rol_listar", sqlConnection);
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
