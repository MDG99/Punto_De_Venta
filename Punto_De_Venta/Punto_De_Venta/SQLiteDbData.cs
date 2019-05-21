using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public partial class SQLiteConn
    {

        //public List<Producto>

        public void AddProducto(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            using (SQLiteRecordSet rs = ExecuteQuery($"INSERT INTO productos (id, nombre, descripcion, precio, cantidad)" +
                $" VALUES ({id}, '{nombre}','{descripcion}',{precio},{cantidad})")) { }
        }
    }
}
