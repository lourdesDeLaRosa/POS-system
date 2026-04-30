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
    public class NCliente
    {
        //Listar categorias
        public static DataTable Listar()
        {
            //instanciar la capa de datos
            DCliente datos = new DCliente();
            return datos.Listar();
        }//fin de metodo listar


        //buscar categorias
        public static DataTable Buscar(string valor)
        {
            //instanciar la capa de datos
            DCliente datos = new DCliente();
            return datos.Buscar(valor);
        }


        //metodo Insertar
        public static string Insertar(int idpersona, string tipo_persona, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            //instanciar la capa de datos
            DCliente datos = new DCliente();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Cliente cliente = new Cliente();

            cliente.IdPersona = idpersona;
            cliente.Tipo_Persona = tipo_persona;
            cliente.Nombre = nombre;
            cliente.Tipo_Documento = tipo_documento;
            cliente.Num_Documento = num_documento;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Email = email;

            return datos.Insertar(cliente);
        }//fin metodo insertar


        //metodo actualizar
        public static string Actualizar(int idpersona, string tipo_persona, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            //instanciar la capa de datos
            DCliente datos = new DCliente();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
            Cliente cliente = new Cliente();

            cliente.IdPersona = idpersona;
            cliente.Tipo_Persona = tipo_persona;
            cliente.Nombre = nombre;
            cliente.Tipo_Documento = tipo_documento;
            cliente.Num_Documento = num_documento;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Email = email;

            return datos.Actualizar(cliente);
        }//fin metodo actualizar

        //metodo eliminar
        public static string Eliminar(int id)
        {
            //instanciar el objeto aja
            DCliente datos = new DCliente();
            return datos.Eliminar(id);
        }//fin metodo eliminar



       
    }
}
