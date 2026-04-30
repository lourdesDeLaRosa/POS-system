using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDatos
{
    public class Conexion
    {
        //Atributos que se necesitan para configurar 
        //la cadena de conexion

        private string Base; //nombre de la BD a conectar
        private string Servidor; //servidor a conectarse
        private string Usuario; //para hacer el login
        private string Clave; //clave pal login del usuario
        private bool Seguridad; //Si el valor es true nos conectaremos con trusted security
        //de lo contrario, con standard security

        private static Conexion Conn = null; //objeto que permite crear la cadena de conexion


        //crearemos un constructor para inicializar los atributos
        private Conexion()
        {

            this.Base = "db_sistema_ventas_INTEC";
            this.Servidor = "BABYGIRL3\\SQLEXPRESS";
            this.Usuario = "";
            this.Clave = "";
            this.Seguridad = true;

        }

        //Metodo que permite crear la cadena de conexion
        public SqlConnection crearConexion()
        {
            //se crea la variable donde se almacena la cadena de conexion
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server =" + this.Servidor + "; Database =" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
					Cadena.ConnectionString = Cadena.ConnectionString + "User Id =" + this.Usuario + "; Password =" + this.Clave;

				}

			}
            catch (Exception ex)
            {
                //si hubo un error 
                Cadena = null;

                throw ex; //dime el error en una ventana
            }
            return Cadena; //se retorna el string de conexion o null
        }

        //crear metodo para instanciar la clase
        public static Conexion GetInstancia()
        {
            if (Conn == null) //si no hay una conemxion creada a la base de datos
			{

                //enotonces crea una
                Conn = new Conexion();
            }
            return Conn;
        }
            

    }
}
