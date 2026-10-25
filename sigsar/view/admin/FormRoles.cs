using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sigsar.Controllers;

namespace sigsar.view.admin
{
    public partial class FormRoles : Form
    {
        private readonly RolController _controller;
        private int idRolSeleccionado = 0;

        public FormRoles()
        {
            InitializeComponent();
            _controller = new RolController();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvTablaRoles.DataSource = _controller.ObtenerRoles();
                idRolSeleccionado = 0;
                txtDescripcionRol.Clear(); // Asegúrate de que tu TextBox tenga este nombre o ajústalo al que pusiste en el diseño
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionRol.Text))
            {
                MessageBox.Show("Por favor, ingrese la descripción del rol.");
                return;
            }

            try
            {
                if (idRolSeleccionado == 0)
                {
                    _controller.RegistrarRol(txtDescripcionRol.Text.Trim());
                    MessageBox.Show("Rol registrado con éxito.");
                }
                else
                {
                    _controller.ActualizarRol(idRolSeleccionado, txtDescripcionRol.Text.Trim());
                    MessageBox.Show("Rol actualizado con éxito.");
                }

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTablaRoles.Rows[e.RowIndex];
                idRolSeleccionado = Convert.ToInt32(fila.Cells["Id_Rol"].Value);
                txtDescripcionRol.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }
    }
}
