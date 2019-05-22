namespace Punto_De_Venta
{
    partial class ReportesDeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesDeVenta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btmAceptar = new System.Windows.Forms.Button();
            this.btmReporteVenta = new System.Windows.Forms.Button();
            this.btmReporteProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelEspecial = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btmAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 41);
            this.panel2.TabIndex = 2;
            // 
            // btmAceptar
            // 
            this.btmAceptar.Location = new System.Drawing.Point(360, 3);
            this.btmAceptar.Name = "btmAceptar";
            this.btmAceptar.Size = new System.Drawing.Size(118, 27);
            this.btmAceptar.TabIndex = 0;
            this.btmAceptar.Text = "Aceptar";
            this.btmAceptar.UseVisualStyleBackColor = true;
            this.btmAceptar.Click += new System.EventHandler(this.btmAceptar_Click);
            // 
            // btmReporteVenta
            // 
            this.btmReporteVenta.FlatAppearance.BorderSize = 0;
            this.btmReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmReporteVenta.Location = new System.Drawing.Point(3, 3);
            this.btmReporteVenta.Name = "btmReporteVenta";
            this.btmReporteVenta.Size = new System.Drawing.Size(108, 29);
            this.btmReporteVenta.TabIndex = 0;
            this.btmReporteVenta.Text = "Reporte de venta";
            this.btmReporteVenta.UseVisualStyleBackColor = true;
            this.btmReporteVenta.Click += new System.EventHandler(this.btmReporteVenta_Click);
            // 
            // btmReporteProducto
            // 
            this.btmReporteProducto.FlatAppearance.BorderSize = 0;
            this.btmReporteProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmReporteProducto.Location = new System.Drawing.Point(117, 3);
            this.btmReporteProducto.Name = "btmReporteProducto";
            this.btmReporteProducto.Size = new System.Drawing.Size(130, 29);
            this.btmReporteProducto.TabIndex = 1;
            this.btmReporteProducto.Text = "Reporte de producto";
            this.btmReporteProducto.UseVisualStyleBackColor = true;
            this.btmReporteProducto.Click += new System.EventHandler(this.btmReporteProducto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btmReporteProducto);
            this.panel1.Controls.Add(this.btmReporteVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 35);
            this.panel1.TabIndex = 4;
            // 
            // PanelEspecial
            // 
            this.PanelEspecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEspecial.Location = new System.Drawing.Point(0, 35);
            this.PanelEspecial.Name = "PanelEspecial";
            this.PanelEspecial.Size = new System.Drawing.Size(523, 271);
            this.PanelEspecial.TabIndex = 5;
            // 
            // ReportesDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 347);
            this.ControlBox = false;
            this.Controls.Add(this.PanelEspecial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportesDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesDeVenta";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btmAceptar;
        private System.Windows.Forms.Button btmReporteVenta;
        private System.Windows.Forms.Button btmReporteProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelEspecial;
    }
}