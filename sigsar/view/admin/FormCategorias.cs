using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sigsar.Controllers;
using sigsar.Models;

namespace sigsar.view.admin
{
    public partial class FormCategorias : Form
    {

        public FormCategorias()
        {
            InitializeComponent();

        }

        CategoriaController ctrController = new CategoriaController();

        //  variable global
        private int idCategoriaSeleccionada = 0;

        private void ListarCategoria()
        {
            dgvTablaCategorias.DataSource = null;
            dgvTablaCategorias.DataSource = ctrController.ListaTablaCategoria();

        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (btnActualizar.Text == "Registrar")
            {
                if (txtNombreCat.Text.Length < 4)
                {
                    MessageBox.Show(
                        "Debes ingresar datos en nombre",
                        "ATENCIÓN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return;
                }

                CategoriaModel cat = new CategoriaModel
                {
                    Nombre = txtNombreCat.Text,
                    Descripcion = txtDescripcionCat.Text
                };

                bool registro = ctrController.registrarCategoria(cat);

                if (registro)
                {
                    MessageBox.Show(
                           "Se ha registrado correctamente la categoría",
                            "CORRECTO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                    ListarCategoria();

                    txtNombreCat.Text = "";
                    txtDescripcionCat.Text = "";
                }
                else
                {
                    MessageBox.Show(
                           "Hubo error en el registro",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }

            }
            else //  ESTO SE EJECUTA CUANDO EL BOTÓN DICE "Actualizar"
            {
                CategoriaModel cat = new CategoriaModel
                {
                    IdCategoria = idCategoriaSeleccionada, // Usamos el ID guardado
                    Nombre = txtNombreCat.Text,
                    Descripcion = txtDescripcionCat.Text
                };

                bool actualizado = ctrController.actualizarCategoria(cat);

                if (actualizado)
                {
                    MessageBox.Show(
                        "Se ha actualizado correctamente la categoría",
                        "CORRECTO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ListarCategoria();
                    txtNombreCat.Text = "";
                    txtDescripcionCat.Text = "";

                    // Devolvemos el botón a su estado original
                    btnActualizar.Text = "Registrar";
                    idCategoriaSeleccionada = 0;
                }
                else
                {
                    MessageBox.Show(
                        "Hubo un error al actualizar",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }


            }
        }

        private void dgvTablaCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTablaCategorias.Rows[e.RowIndex];

                DialogResult resultado = MessageBox.Show(
                    "¿Desea editar esta categoría?",
                    "CONFIRMACIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Pasamos los datos de las celdas a las cajas de texto
                    txtNombreCat.Text = fila.Cells["Nombre"].Value.ToString();
                    txtDescripcionCat.Text = fila.Cells["Descripcion"].Value.ToString();

                    // Guardamos el ID seleccionado
                    idCategoriaSeleccionada = Convert.ToInt32(fila.Cells["IdCategoria"].Value);

                    // Cambiamos el texto del botón a "Actualizar"
                    btnActualizar.Text = "Actualizar";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //  Verificamos que haya una fila seleccionada en el DataGridView
            if (dgvTablaCategorias.SelectedRows.Count > 0)
            {
                // Obtenemos el ID de la categoría desde la fila seleccionada
                int idCategoria = Convert.ToInt32(dgvTablaCategorias.SelectedRows[0].Cells["IdCategoria"].Value);

                // Mostramos un mensaje de confirmación antes de eliminar
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta categoría?",
                    "CONFIRMACIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    //Llamamos al controlador para ejecutar la eliminación en la base de datos
                    bool eliminado = ctrController.eliminarCategoria(idCategoria);

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Se ha eliminado correctamente la categoría",
                            "CORRECTO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        //Refrescamos la tabla y limpiamos los campos por si acaso
                        ListarCategoria();
                        txtNombreCat.Text = "";
                        txtDescripcionCat.Text = "";

                        btnActualizar.Text = "Registrar";
                        idCategoriaSeleccionada = 0;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Hubo un error al eliminar la categoría",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Debes seleccionar una categoría de la tabla para eliminar",
                    "ATENCIÓN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }

}

        

