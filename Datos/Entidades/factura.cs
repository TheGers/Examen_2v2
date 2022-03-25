using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class factura
    {
        public int Codigo_factura { get; set; }
        public String codigo_cliente { get; set; }
        public String cliente { get; set; }

        public factura(int codigo_factura, string codigo_cliente, string cliente)
        {
            Codigo_factura = codigo_factura;
            this.codigo_cliente = codigo_cliente;
            this.cliente = cliente;
        }


        public factura()
        {
            //constructor vacio
        }

    }
}
