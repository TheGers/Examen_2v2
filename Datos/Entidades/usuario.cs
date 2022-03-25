using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class usuario
    {
        public String Codigo_Usuario { get; set; }
        public String Nombre_Usuario { get; set; }
        public String Clave_Usuario { get; set; }

        public usuario(string codigo_Usuario, string nombre_Usuario, string clave_Usuario)
        {
            Codigo_Usuario = codigo_Usuario;
            Nombre_Usuario = nombre_Usuario;
            Clave_Usuario = clave_Usuario;
        }


        public usuario()
        {


        }
    }
}

