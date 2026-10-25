using sigsar.Controllers;
using sigsar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sigsar.view.admin
{

    public partial class FormMesa : Form
    {
        public FormMesa()
        {
            InitializeComponent();
        }

        // Instanciamos el controlador de mesas
        MesaController ctrMesa = new MesaController();

        //declaramos una variable global
        private int idMesaSeleccionada = 0;

        // Método para listar las mesas en el DataGridView
        private void ListarMesas()
        {
            dgvTablaMesas.DataSource = null;
            dgvTablaMesas.DataSource = ctrMesa.ListaTablaMesa();
        }

        private void FormMesa_Load(object sender, EventArgs e)
        {
            ListarMesas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (btnActualizar.Text == "Registrar")
            {
                // Validación opcional si deseas verificar que los valores sean mayores a 0
                if (nudNumero.Value <= 0)
                {
                    MessageBox.Show(
                        "Debes ingresar un número de mesa válido",
                        "ATENCIÓN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Instanciamos el modelo de mesa con los valores de los NumericUpDown
                MesaModel mesa = new MesaModel
                {
                    Numero = (int)nudNumero.Value,
                    Piso = (int)nudPiso.Value,
                    Capacidad = (int)nudCapacidad.Value
                };

                // Llamamos al controlador para registrar
                bool registro = ctrMesa.registrarMesa(mesa);

                if (registro)
                {
                    MessageBox.Show(
                        "Se ha registrado correctamente la mesa",
                        "CORRECTO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ListarMesas(); // Refresca el DataGridView de mesas

                    // Limpiamos los controles restableciéndolos a 0
                    nudNumero.Value = 0;
                    nudPiso.Value = 0;
                    nudCapacidad.Value = 0;
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
            else // AQUÍ SE EJECUTA CUANDO EL BOTÓN DICE "Actualizar"
            {
                // Creamos el objeto mesa incluyendo el ID que guardamos al hacer doble clic en la tabla
                MesaModel mesa = new MesaModel
                {
                    IdMesa = idMesaSeleccionada, 
                    Numero = (int)nudNumero.Value,
                    Piso = (int)nudPiso.Value,
                    Capacidad = (int)nudCapacidad.Value
                };

                // Llamamos al método del controlador para actualizar
                bool actualizado = ctrMesa.actualizarMesa(mesa);

                if (actualizado)
                {
                    MessageBox.Show(
                        "Se ha actualizado correctamente la mesa",
                        "CORRECTO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ListarMesas();

                    // Limpiamos los controles
                    nudNumero.Value = 0;
                    nudPiso.Value = 0;
                    nudCapacidad.Value = 0;

                    // Devolvemos el texto del botón a "Registrar" y reseteamos el ID
                    btnActualizar.Text = "Registrar";
                    idMesaSeleccionada = 0;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada en el DataGridView
            if (dgvTablaMesas.SelectedRows.Count > 0)
            {
                // Obtenemos el ID de la mesa desde la fila seleccionada 

                int idMesa = Convert.ToInt32(dgvTablaMesas.SelectedRows[0].Cells["IdMesa"].Value);

                // Mostramos un mensaje de confirmación antes de eliminar
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta mesa?",
                    "CONFIRMACIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Llamamos al controlador para ejecutar la eliminación en la BD
                    bool eliminado = ctrMesa.eliminarMesa(idMesa);

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Se ha eliminado correctamente la mesa",
                            "CORRECTO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Refrescamos la tabla y limpiamos los campos
                        ListarMesas();

                        nudNumero.Value = 0;
                        nudPiso.Value = 0;
                        nudCapacidad.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Hubo un error al eliminar la mesa",
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
                    "Debes seleccionar una mesa de la tabla para eliminar",
                    "ADVERTENCIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgvTablaMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya hecho clic en una fila válida (y no en la cabecera)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTablaMesas.Rows[e.RowIndex];

                // Preguntamos al usuario si desea editar
                DialogResult resultado = MessageBox.Show(
                    "¿Desea editar esta mesa?",
                    "CONFIRMACIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Pasamos los datos de la fila seleccionada a los controles
                    
                    nudNumero.Value = Convert.ToDecimal(fila.Cells["Numero"].Value);
                    nudPiso.Value = Convert.ToDecimal(fila.Cells["Piso"].Value);
                    nudCapacidad.Value = Convert.ToDecimal(fila.Cells["Capacidad"].Value);

                    // Guardamos el ID en la variable global que creamos : idMesaSeleccionada) 
                    // para saber qué registro actualizar en la base de datos.

                    idMesaSeleccionada = Convert.ToInt32(fila.Cells["IdMesa"].Value);

                    // Cambiamos el texto del botón a "Actualizar"
                    btnActualizar.Text = "Actualizar";
                }
            }
        }
    }

}
    

       