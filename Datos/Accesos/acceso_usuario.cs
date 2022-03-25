using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;

namespace Datos.Accesos
{
    public class acceso_usuario
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=gerson11;";

        MySqlConnection conn;
        MySqlCommand cmd;


        public usuario login(string codigo, string clave)
        {
            usuario user = null;
            try
            {
                string sql = "SELECT * FROM usuario WHERE codigo = @Codigo_Usuario AND clave = @Clave_Usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo_Usuario", codigo);
                cmd.Parameters.AddWithValue("@Clave_Usuario", clave);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new usuario();
                    user.Codigo_Usuario = reader[0].ToString();
                    user.Nombre_Usuario = reader[1].ToString();
                    user.Clave_Usuario = reader[3].ToString();

                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

                throw;
            }
            return user;

        }



    }
}
