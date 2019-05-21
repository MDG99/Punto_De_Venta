using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Punto_De_Venta;


namespace SQLiteDb
{
    public partial class SQLiteConn
    {

        public List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM productos"))
            {
                while (rs.NextRecord())
                {
                    productos.Add(new Producto(rs.GetInt32("id"),
                        rs.GetString("nombre"),
                        rs.GetString("descripcion"),
                        rs.GetDouble("precio"),
                        rs.GetInt32("cantidad"),
                        rs.GetInt32("categoria_id")));
                }
            }

            return productos;
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using(SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM usuarios"))
            {
                while (rs.NextRecord())
                {
                    usuarios.Add(new Usuario(rs.GetInt32("id"),
                        rs.GetString("nombre"),
                        rs.GetString("apellido"),
                        rs.GetInt32("edad"),
                        rs.GetInt32("administracion"),
                        rs.GetInt32("estado")));
                }
            }
            return usuarios;
        }

        public void AddProducto(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            using (SQLiteRecordSet rs = ExecuteQuery($"INSERT INTO productos (id, nombre, descripcion, precio, cantidad)" +
                $" VALUES ({id}, '{nombre}','{descripcion}',{precio},{cantidad})")) { }
        }
    }

}
