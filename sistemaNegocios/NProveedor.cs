using sistemaDatos;
using sistemaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNegocios
{
    public class NProveedor
    {
        //Listar categorias
        public static DataTable Listar()
        {
            //instanciar la capa de datos
            DProveedor datos = new DProveedor();
            return datos.Listar();
        }//fin de metodo listar


        //buscar categorias
        public static DataTable Buscar(string valor)
        {
            //instanciar la capa de datos
            DProveedor datos = new DProveedor();
            return datos.Buscar(valor);
        }


        //metodo Insertar
        public static string Insertar(int idpersona, string tipo_persona, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            //instanciar la capa de datos
            DProveedor datos = new DProveedor();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Proveedor proveedor = new Proveedor();

            proveedor.IdPersona = idpersona;
            proveedor.Tipo_Persona = tipo_persona;
            proveedor.Nombre = nombre;
            proveedor.Tipo_Documento = tipo_documento;
            proveedor.Num_Documento = num_documento;
            proveedor.Direccion = direccion;
            proveedor.Telefono = telefono;
            proveedor.Email = email;

            return datos.Insertar(proveedor);
        }//fin metodo insertar


        //metodo actualizar
        public static string Actualizar(int idpersona, string tipo_persona, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            //instanciar la capa de datos
            DProveedor datos = new DProveedor();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Proveedor proveedor = new Proveedor();

            proveedor.IdPersona = idpersona;
            proveedor.Tipo_Persona = tipo_persona;
            proveedor.Nombre = nombre;
            proveedor.Tipo_Documento = tipo_documento;
            proveedor.Num_Documento = num_documento;
            proveedor.Direccion = direccion;
            proveedor.Telefono = telefono;
            proveedor.Email = email;

            return datos.Actualizar(proveedor);
        }//fin metodo actualizar

        //metodo eliminar
        public static string Eliminar(int id)
        {
            //instanciar el objeto aja
            DProveedor datos = new DProveedor();
            return datos.Eliminar(id);
        }//fin metodo eliminar

    }
}
