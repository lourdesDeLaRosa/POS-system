using sistemaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaNegocios
{
    public class NRol
    {

      
        //listar roles
        public static DataTable Listar()
        {
            DRol datos = new DRol();
            return datos.Listar();
        }
    }
}
