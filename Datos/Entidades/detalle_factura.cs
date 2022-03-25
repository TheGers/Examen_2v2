using System;

namespace Datos.Entidades
{
    public class detalle_factura
    {
        public int ID_Detalle_Factura { get; set; }
        public int id_factura { get; set; }
        public String descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal total { get; set; }
        public String codigo_producto { get; set; }

        public detalle_factura(int iD_Detalle_Factura, int id_factura, string descripcion, int cantidad, decimal precio, decimal total, string codigo_producto)
        {
            ID_Detalle_Factura = iD_Detalle_Factura;
            this.id_factura = id_factura;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.total = total;
            this.codigo_producto = codigo_producto;
        }


        public detalle_factura()
        {
            //constructor vacio
        }


    }
}
