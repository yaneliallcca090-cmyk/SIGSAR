using sigsar.Controller;
using sigsar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sigsar.view.admin
{
    public partial class FormUsuario : Form
    {
        UsuarioController ctrUsuario = new UsuarioController();

        // Variable global para almacenar el ID cuando se edita
        private int idUsuarioSeleccionada = 0;

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            dgvTablaUsuarios.DataSource = null;
            dgvTablaUsuarios.DataSource = ctrUsuario.listarUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (btnActualizar.Text == "Registrar")
            {
                // Validaciones 
                if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtNombres.Text))
                {
                    MessageBox.Show("Debes ingresar al menos el DNI y los Nombres", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtClave.Text != txtRepetirClave.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioModel usu = new UsuarioModel
                {
                    IdRol = Convert.ToInt32(cmbRol.SelectedValue), 
                    Dni = txtDni.Text,
                    Apellidos = txtApellidos.Text,
                    Nombres = txtNombres.Text,
                    Genero = cbxGenero.Text.Length > 0 ? Convert.ToChar(cbxGenero.Text.Substring(0, 1)) : 'M',
                    Celular = txtCelular.Text,
                    Email = txtGmail.Text,
                    Direccion = txtDireccion.Text,
                    ClaveHash = txtClave.Text
                };

                bool registro = ctrUsuario.registrarUsuario(usu);

                if (registro)
                {
                    MessageBox.Show("Se ha registrado correctamente el usuario",
                                   "CORRECTO", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    ListarUsuarios();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el registro", 
                                   "ERROR", MessageBoxButtons.OK, 
                                   MessageBoxIcon.Error);
                }
            }
            else // MODO ACTUALIZAR
            {
                UsuarioModel usu = new UsuarioModel
                {
                    IdUsuario = idUsuarioSeleccionada,
                    IdRol = Convert.ToInt32(cmbRol.SelectedValue),
                    Dni = txtDni.Text,
                    Apellidos = txtApellidos.Text,
                    Nombres = txtNombres.Text,
                    Genero = cbxGenero.Text.Length > 0 ? Convert.ToChar(cbxGenero.Text.Substring(0, 1)) : 'M',
                    Celular = txtCelular.Text,
                    Email = txtGmail.Text,
                    Direccion = txtDireccion.Text,
                    ClaveHash = txtClave.Text
                };

                bool actualizado = ctrUsuario.actualizarUsuario(usu);

                if (actualizado)
                {
                    MessageBox.Show("Se ha actualizado correctamente el usuario", 
                                   "CORRECTO", MessageBoxButtons.OK, 
                                   MessageBoxIcon.Information);
                    ListarUsuarios();
                    LimpiarControles();

                    btnActualizar.Text = "Registrar";
                    idUsuarioSeleccionada = 0;
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar",
                                    "ERROR", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTablaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTablaUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionada = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
                cmbRol.SelectedValue = Convert.ToInt32(fila.Cells["IdRol"].Value);
                txtDni.Text = fila.Cells["Dni"].Value.ToString();
                txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
                txtNombres.Text = fila.Cells["Nombres"].Value.ToString();
                txtCelular.Text = fila.Cells["Celular"].Value.ToString();
                txtGmail.Text = fila.Cells["Email"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtClave.Text = fila.Cells["ClaveHash"].Value.ToString();
                txtRepetirClave.Text = fila.Cells["ClaveHash"].Value.ToString();
                cbxGenero.Text = fila.Cells["Genero"].Value.ToString();

                btnActualizar.Text = "Actualizar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTablaUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvTablaUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                                                          "CONFIRMACIÓN", MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    bool eliminado = ctrUsuario.eliminarUsuario(idUsuario);

                    if (eliminado)
                    {
                        MessageBox.Show("Se ha eliminado correctamente el usuario",
                                         "CORRECTO", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        ListarUsuarios();
                        LimpiarControles();
                        btnActualizar.Text = "Registrar";
                        idUsuarioSeleccionada = 0;
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el usuario",
                                        "ERROR", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un usuario de la tabla para eliminar", 
                                "ATENCIÓN", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            }
        }

        private void LimpiarControles()
        {
            txtDni.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtCelular.Text = "";
            txtGmail.Text = "";
            txtDireccion.Text = "";
            txtClave.Text = "";
            txtRepetirClave.Text = "";
            cmbRol.SelectedIndex = -1;
            cbxGenero.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




    }
}
