using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;


namespace Punto_De_Venta
{
    public partial class AltaProductos : Form
    {
        SQLiteConn conexion = new SQLiteConn("Terminal de punto de venta.db", true);

        public AltaProductos()
        {
            InitializeComponent();
            AltaUsuarios altaUsuarios = new AltaUsuarios();
            altaUsuarios.Show();
            ArriboProductos form2 = new ArriboProductos();
            form2.Show();
            ModificacionUsuario modificacion = new ModificacionUsuario();
            modificacion.Show();
            ReportesDeVenta reportesDeVenta = new ReportesDeVenta();
            reportesDeVenta.Show();
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void ValidarGuardar()
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtCodigo.Text != "" &&
                txtCategoria.Text != "" && txtPrecio.Text != "")
            {
                btmGuardar.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarGuardar();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarGuardar();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidarGuardar();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            ValidarGuardar();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarGuardar();
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            //Falta pasar la categoria, pero hasta que creen la tabla respectiva
            //Hay que crear una excepciones
            if (ComprobarProductos())
            {
                conexion.AddProducto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text,
                Convert.ToDouble(txtPrecio.Text), 0);
                var MensajeExitoso = MessageBox.Show("Operacion exitosa", "Alta de Productos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                var MensajeFallido = MessageBox.Show("Operacion denegada, ya existe el producto", "Alta de Productos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            Reiniciar();
        }

        public bool ComprobarProductos()
        {
            //conexion.GetProductos()
            return true;
        }

        public void Reiniciar()
        {
            btmGuardar.Enabled = false;
            txtNombre.ResetText();
            txtCodigo.ResetText();
            txtDescripcion.ResetText();
            txtCategoria.ResetText();
            txtPrecio.ResetText();
        }
    }
}
