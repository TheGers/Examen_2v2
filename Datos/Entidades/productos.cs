using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class productos
    {


        public String codigo_producto { get; set; }
        public String Descripcion_Producto { get; set; }
        public decimal Precio_Producto { get; set; }
        public int Existencia_Producto { get; set; }

        public productos(string codigo_producto, string descripcion_Producto, decimal precio_Producto, int existencia_Producto)
        {
            this.codigo_producto = codigo_producto;
            Descripcion_Producto = descripcion_Producto;
            Precio_Producto = precio_Producto;
            Existencia_Producto = existencia_Producto;
        }


        public productos()
        {
            //constructor
        }
    }
}
