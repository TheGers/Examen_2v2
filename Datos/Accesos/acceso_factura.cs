using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class acceso_factura
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=gerson11;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarFactura(factura factura)
        {
            int idFactura = 0;
            try
            {
                string sql = "INSERT INTO factura (Codigo_factura, codigo_cliente, cliente) VALUES (@Codigo_facturae, @codigo_cliente, @cliente); select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Codigo_factura", factura.Codigo_factura);//codigo factura
                cmd.Parameters.AddWithValue("@Codigo_cliente", factura.codigo_cliente);
                cmd.Parameters.AddWithValue("@cliente", factura.cliente);
                


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return idFactura;
        }

        public bool InsertarDetalle(detalle_factura detalle_factura)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO detalle_factura (Id_Detalle_Factura, id_factura, descripcion, cantidad, precio, tota, codigo_productol) VALUES (@Id_Detalle_Factura, @id_factura, @descripcion, @cantidad, @precio, @total, @codigo_producto);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id_Detalle_Factura", detalle_factura.ID_Detalle_Factura);
                cmd.Parameters.AddWithValue("@id_factura", detalle_factura.id_factura);
                cmd.Parameters.AddWithValue("@descripcion", detalle_factura.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", detalle_factura.cantidad);
                cmd.Parameters.AddWithValue("@precio", detalle_factura.precio);
                cmd.Parameters.AddWithValue("@total", detalle_factura.total);
                cmd.Parameters.AddWithValue("@codigo_producto", detalle_factura.codigo_producto);
                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }


    }
}
