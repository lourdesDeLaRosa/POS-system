using sistemaDatos;
using sistemaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace sistemaNegocios
{
    public class NUsuario
    {
        //metodo para cargar las categorias que estan activas
        public static DataTable CargarRol()
        {
            DUsuario datos = new DUsuario();
            return datos.CargarRol();
        }

   


        //Listar categorias
        public static DataTable Listar()
        {
            //instanciar la capa de datos
            DUsuario datos = new DUsuario();
            return datos.Listar();
        }//fin de metodo listar

        //buscar categorias
        public static DataTable Buscar(string valor)
        {
            //instanciar la capa de datos
            DUsuario datos = new DUsuario();
            return datos.Buscar(valor);
        }


        //metodo Insertar
        public static string Insertar(int idrol, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email, string clave)
        {
            //instanciar la capa de datos
            DUsuario datos = new DUsuario();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Usuario usuario = new Usuario();

            usuario.IdRol = idrol;
            usuario.Nombre = nombre;
            usuario.Tipo_Documento = tipo_documento;
            usuario.Num_Documento = num_documento;
            usuario.Direccion = direccion;
            usuario.Telefono = telefono;
            usuario.Email = email;
            usuario.Clave = clave;

            return datos.Insertar(usuario);
        }//fin metodo insertar

        //metodo actualizar
        public static string Actualizar(int idusuario, int idrol, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email, string clave)
        {
            //instanciar la capa de datos
            DUsuario datos = new DUsuario();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Usuario usuario = new Usuario();

            usuario.IdUsuario = idusuario;
            usuario.IdRol = idrol;
            usuario.Nombre = nombre;
            usuario.Tipo_Documento = tipo_documento;
            usuario.Num_Documento = num_documento;
            usuario.Direccion = direccion;
            usuario.Telefono = telefono;
            usuario.Email = email;
            usuario.Clave = clave;

            return datos.Actualizar(usuario);
        }//fin metodo actualizar

        //metodo eliminar
        public static string Eliminar(int id)
        {
            //instanciar el objeto aja
            DUsuario datos = new DUsuario();
            return datos.Eliminar(id);
        }//fin metodo eliminar



        //metodo activar
        public static string Activar(int id)
        {
            //instanciar el objeto aja
            DUsuario datos = new DUsuario();
            return datos.Activar(id);
        }//fin metodo Activar


        //metodo desactivar
        public static string Desactivar(int id)
        {
            //instanciar el objeto aja
            DUsuario datos = new DUsuario();
            return datos.Desactivar(id);
        }//fin metodo Desactivar


        public static DataTable Login(string email, string clave)
        {
            DUsuario datos = new DUsuario();
            return datos.Login(email, clave);

        }
    }
}
