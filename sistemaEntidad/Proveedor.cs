using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEntidad
{
    public class Proveedor
    {
        public int IdPersona { get; set; }
        public string Tipo_Persona { get; set; }
        public string Nombre { get; set; }
        public string Tipo_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
