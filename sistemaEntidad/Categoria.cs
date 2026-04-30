using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEntidad
{
    public class Categoria
    {
        //Esto se utiliza para modlear la tabla de categoria como un objeto de C#
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }


    }

}



