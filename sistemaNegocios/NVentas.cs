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
    public class NVentas
    {
        public static DataTable Listar()
        {
            DVentas Datos = new DVentas();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DVentas Datos = new DVentas();
            return Datos.Buscar(Valor);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DVentas Datos = new DVentas();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdCliente, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DVentas Datos = new DVentas();
            Ventas Obj = new Ventas();
            Obj.IdCliente = IdCliente;
            Obj.IdUsusario = IdUsuario;
            Obj.TipoComprobante = TipoComprobante;
            Obj.SerieComprobante = SerieComprobante;
            Obj.NumComprobante = NumComprobante;
            Obj.Impuesto = Impuesto;
            Obj.Total = Total;
            Obj.Detalles = Detalles;
            return Datos.Insertar(Obj);
        }
        public static string Anular(int Id)
        {
            DVentas Datos = new DVentas();
            return Datos.Anular(Id);
        }


        public static DataTable Buscar_Codigo_Venta(string valor)
        {
            DVentas Datos = new DVentas();
            return Datos.Buscar_Codigo_Venta(valor);
        }
    }
}
