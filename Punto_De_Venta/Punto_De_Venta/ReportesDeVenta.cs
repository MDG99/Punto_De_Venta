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
    public partial class ReportesDeVenta : Form
    {
        public ReportesDeVenta()
        {
            InitializeComponent();
            Agregarpanel(new Reporte_de_venta());
        }


        private void Agregarpanel(object forma)
        {
            if (PanelEspecial.Controls.Count > 0)
                PanelEspecial.Controls.RemoveAt(0);
            Form fh = forma as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            PanelEspecial.Controls.Add(fh);
            PanelEspecial.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregarpanel( new Reporte_de_venta());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregarpanel( new Reporte_De_Productos());
        }
    }
}
