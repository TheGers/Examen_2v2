using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
             Pedidos pedidos = new Pedidos();   
            pedidos.MdiParent = this;   
            pedidos.Show(); 
        }
    }
}
