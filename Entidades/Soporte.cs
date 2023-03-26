using System;

namespace Entidades
{
    public class Soporte
    {
        public DateTime Fecha { get; set; }
        public string IdentidadCliente { get; set; }
        public string CodigoUsuario { get; set; }
        public string DesSolicitud { get; set; }
        public string DesRespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Soporte(DateTime fecha, string identidadCliente, string codigoUsuario, string desSolicitud, string desRespuesta, decimal precio, decimal impuesto, decimal descuento, decimal total)
        {
            Fecha = fecha;
            IdentidadCliente = identidadCliente;
            CodigoUsuario = codigoUsuario;
            DesSolicitud = desSolicitud;
            DesRespuesta = desRespuesta;
            Precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            Total = total;
        }

        public Soporte()
        {
        }
    }
}
