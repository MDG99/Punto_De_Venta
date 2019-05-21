using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_De_Venta
{
    public class Producto
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
        public double Precio { get; }
        public int Cantidad { get; }
        public int Categoria_Id { get; }

        public Producto(int id, string nombre, string descripcion, double precio, int cantidad, int categoria_Id)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            Categoria_Id = categoria_Id;
        }
    }

    public class Usuario
    {
       public int Id {get;}
       public string Nombre { get; }
       public string Apellido { get; }
       public int Edad { get; }
       public string Administracion { get; }
       public string Estado { get; }

        public Usuario(int id, string nombre, string apellido, int edad, string administracion, string estado)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Administracion = administracion;
            Estado = estado;
        }
    }
}
