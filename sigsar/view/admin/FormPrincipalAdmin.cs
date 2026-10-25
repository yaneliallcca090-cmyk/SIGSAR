using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sigsar.view.admin
{
    public partial class FormPrincipalAdmin : Form
    {
        public FormPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void FormPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos Productos = new FormProductos();
            Productos.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario Usuarios = new FormUsuario();
            Usuarios.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FormRoles Roles = new FormRoles();
            Roles.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas Ventas = new FormVentas();
            Ventas.ShowDialog();
        }

        private void btnCategorias_Clik(object sender, EventArgs e)
        {
            FormCategorias categorias = new FormCategorias();
            categorias.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes Reportes = new FormReportes();
            Reportes.ShowDialog();
        }

        private void btnGestionMesa_Click(object sender, EventArgs e)
        {
            FormMesa gestionMesa = new FormMesa();
            gestionMesa.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
