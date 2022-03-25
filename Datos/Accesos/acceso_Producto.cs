using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class acceso_Producto
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=gerson11;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable mostrar_productos()
        {
            DataTable lista = new DataTable();



            try
            {
                string sql = "SELECT * FROM productos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();



            }
            catch (Exception ex)
            {

                throw;
            }
            return lista;
        }

        public bool ingreso_producto(productos producto)
        {
            bool insertar = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@codigo_producto, @Descripcion_Producto, @Precio_Producto, @Existencia_Producto);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codigo_producto", producto.codigo_producto);
                cmd.Parameters.AddWithValue("@Descripcion_Producto", producto.Descripcion_Producto);
                cmd.Parameters.AddWithValue("@Precio_Producto", producto.Precio_Producto);
                cmd.Parameters.AddWithValue("@Existencia_Producto", producto.Existencia_Producto);
                
                cmd.ExecuteNonQuery();
                insertar = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return insertar;

        }


        public productos GetProducto_Codigo(string codigo)
        {
            productos producto = new productos();
            try
            {
                string sql = "Select * from producto WHERE codigo_producto = @codigo;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codigo_producto", codigo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto.codigo_producto = reader["codigo_producto"].ToString();
                    producto.Descripcion_Producto = reader["Descripcion_Producto"].ToString();
                    producto.Precio_Producto = (decimal)reader["Precio_Producto"];
                    producto.Existencia_Producto = (int)reader["Existencia_Producto"];
                    
                }

                conn.Close();
            }
            catch (Exception)
            {
            }
            return producto;
        }



    }
}
