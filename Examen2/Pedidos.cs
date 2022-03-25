using System.Collections.Generic;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Examen2
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }
        
        acceso_Producto acceso_Porducto = new acceso_Producto();
        factura factura = new factura();
        acceso_factura acceso_Factura = new acceso_factura();
        productos productos;

        List<detalle_factura> detalleFacturaLista = new List<detalle_factura>();

        decimal total = decimal.Zero;

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, System.EventArgs e)
        {
            lista_pedidosdataGridView.DataSource = detalleFacturaLista;
        }

        private void codigo_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                productos = new productos();
                productos = acceso_Porducto.GetProducto_Codigo(codigo_textBox.Text);
                descrip_textBox.Text = productos.Descripcion_Producto;
                cant_textBox.Focus();
              
            }
            else
            {
                productos = null;
                descrip_textBox.Clear();
                cant_textBox.Clear();
            }
        }

        private void cant_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(cant_textBox.Text))
            {
                detalle_factura detalleFactura = new detalle_factura();
                detalleFactura.codigo_producto = productos.codigo_producto;
                detalleFactura.descripcion = productos.Descripcion_Producto;
                detalleFactura.cantidad = System.Convert.ToInt32(cant_textBox.Text);
                detalleFactura.precio = productos.Precio_Producto;
                detalleFactura.total = productos.Precio_Producto * System.Convert.ToInt32(cant_textBox.Text);

                total += detalleFactura.total;

                total_textBox.Text = total.ToString();


                detalleFacturaLista.Add(detalleFactura);
                lista_pedidosdataGridView.DataSource = null;
                lista_pedidosdataGridView.DataSource = detalleFacturaLista;


            }
        }
    }
}
