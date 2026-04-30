using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEntidad
{
    public class Usuario
    {

        //Esto se utiliza para moldear la tabla de categoria como un objeto de C#
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Tipo_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
    }
}
