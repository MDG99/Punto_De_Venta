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
    public partial class ModificacionUsuario : Form
    {
        SQLiteConn conexion = new SQLiteConn("Terminal de punto de venta.db", true);

        public ModificacionUsuario()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "nombre" + "  " + "apellido";
            comboBox1.DataSource = conexion.GetUsuarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = (comboBox1.SelectedItem as Usuario).Nombre;
            txtApellido.Text = (comboBox1.SelectedItem as Usuario).Apellido;
            txtEdad.Text = $"{(comboBox1.SelectedItem as Usuario).Edad}";

            if ((comboBox1.SelectedItem as Usuario).Administracion == 1)
            {
                comboBox1.SelectedItem = "Administrador";
            }
            else
            {
                comboBox1.SelectedItem = "Usuario normal";
            }

            if ((comboBox1.SelectedItem as Usuario).Estado == 1)
            {
                comboBox1.SelectedItem = "Habilitado";
            }
            else
            {
                comboBox1.SelectedItem = "Inhabilitado";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtEdad.ResetText();
            cmbEstatus.ResetText();
            cmbPrivilegios.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int administracion, estatus;

            if (cmbPrivilegios.Text == "Administrador")
            {
                administracion = 1;
            }
            else
            {
                administracion = 0;
            }

            if (cmbEstatus.Text == "Habilitado")
            {
                estatus = 1;
            }
            else
            {
                estatus = 0;
            }

            conexion.UpdateUsuario((comboBox1.SelectedItem as Usuario).Id, administracion, estatus);
        }
    }
}
