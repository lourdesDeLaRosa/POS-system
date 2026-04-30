using sistemaDatos;
using sistemaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNegocios
{
    public class NCategoria
    {
        //Listar categorias
        public static DataTable Listar()
        {
            //instanciar la capa de datos
            DCategoria datos = new DCategoria();
            return datos.Listar();
        }//fin de metodo listar

        //buscar categorias
        public static DataTable Buscar(string valor)
        {
            //instanciar la capa de datos
            DCategoria datos = new DCategoria();
            return datos.Buscar(valor);

        }

        public static string Insertar(string nombre, string descripcion)
        {
            //instanciar la capa de datos
            DCategoria datos= new DCategoria();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
           Categoria categoria = new Categoria();
            categoria.Nombre = nombre;
            categoria.Descripcion = descripcion;
            return datos.Insertar(categoria);
        }//fin metodo insertar

        //metodo actualizar
        public static string Actualizar(int id, string nombre, string descripcion)
        {
            //instanciar la capa de datos
            DCategoria datos = new DCategoria();
            //antes debemos determinar si la categoria ya existe-pendiente

            //se debe crear un objeto Categoria, porque es lo que recibe la capa de datos
          
            Categoria categoria = new Categoria();
            categoria.IdCategoria = id;
            categoria.Nombre = nombre;
            categoria.Descripcion = descripcion;
            return datos.Actualizar(categoria);
        }//fin metodo actualizar

        //metodo eliminar
        public static string Eliminar(int id)
        {
            //instanciar el objeto aja
            DCategoria datos = new DCategoria();
            return datos.Eliminar(id);
        }//fin metodo eliminar


        //metodo acvtivar
        public static string Activar(int id)
        {
            //instanciar el objeto aja
            DCategoria datos = new DCategoria();
            return datos.Activar(id);
        }//fin metodo Activar

        //metodo desactivar
        public static string Desactivar(int id)
        {
            //instanciar el objeto aja
            DCategoria datos = new DCategoria();
            return datos.Desactivar(id);
        }//fin metodo Desactivar
    }
}
