using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Windows.Forms;

namespace Examen2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            acceso_usuario frmusers = new acceso_usuario();   
            usuario usuariov2 = new usuario();


            usuariov2 = frmusers.login(usuario_textBox.Text, contra_textBox.Text);

            if (usuariov2 == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            //me confundi todo ingeniero que nada me salio bien :c


        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
