using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        acceso_Producto frm = new acceso_Producto();



        private void guardar_button_Click(object sender, EventArgs e)
        {
            try
            {
                productos producto = new productos();
                producto.codigo_producto = code_textBox.Text;
                producto.Descripcion_Producto = descrip_textBox.Text;
                producto.Precio_Producto =Convert.ToDecimal(price_textBox.Text);
                producto.Existencia_Producto = Convert.ToInt32(existen_textBox.Text);

              frm.ingreso_producto(producto);
                limpiar();
            }
            catch (Exception ex)
            {

                throw;
            }

        }




        public void limpiar()
        {
            code_textBox.Clear();
            descrip_textBox.Clear();
            price_textBox.Clear();
            existen_textBox.Clear();

        }

        public void mostrar_lista()
        {
            lista_dataGridView.DataSource = frm.mostrar_productos();


        }

        private void Producto_Load(object sender, EventArgs e)
        {
            mostrar_lista();
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
