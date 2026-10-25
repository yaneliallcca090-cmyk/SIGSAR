using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using sigsar.Config;
using sigsar.view.admin;
using sigsar.view.cocinero;
using sigsar.view.mozo;
using System.Security.Principal;

namespace sigsar
{
    public partial class FormPrincipalSigsar : Form
    {
        public FormPrincipalSigsar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            string user = txtusuario.Text.Trim();
            string clave = txtclave.Text.Trim();

            // Obtener la opción seleccionada del ComboBox cbxrol
            string rol = cbxrol.SelectedItem?.ToString()!;

            // Validar Administrador
            if (rol == "Administrador" && user == "123" && clave == "1234")
            {
                this.Hide();
                FormPrincipalAdmin principal = new FormPrincipalAdmin();
                principal.ShowDialog();
                this.Close();
            }
            // Validar Cajero
            else if (rol == "Cajero" && user == "1234" && clave == "12345")
            {
                this.Hide();

                // FormVentas ventas = new FormVentas();
                // ventas.ShowDialog();
                this.Close();
            }
            // Validar Mozo
            else if (rol == "Mozo" && user == "12345" && clave == "123456")
            {
                this.Hide();
                FormPrincipalMoza Principal = new FormPrincipalMoza();
                Principal.ShowDialog();
                this.Close();
                // FormGestionMesas mesas = new FormGestionMesas();
                // mesas.ShowDialog();
                this.Close();
            }
            //Validar Cosinero
            else if (rol == "cosinero" && user == "123456" && clave == "1234567")
            {
                this.Hide();
                FormPrincipalCosinero Principal = new FormPrincipalCosinero();
                Principal.ShowDialog();
                this.Close();
                // FormGestionMesas mesas = new FormGestionMesas();
                // mesas.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Credenciales o rol incorrectos", "Mensaje");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       

        private void FormPrincipalSigsar_Load(object sender, EventArgs e)
        {
            cbxrol.Items.Clear();
            cbxrol.Items.Add("Administrador");
            cbxrol.Items.Add("Cajero");
            cbxrol.Items.Add("Mozo");
            cbxrol.Items.Add("Cosinero");
            cbxrol.SelectedIndex = 0; // Selecciona Administrador por defecto


            using (NpgsqlConnection conexion = Conexion.ObtenerConexion())
            {

                conexion.Open();

                try
                {
                    lblEstado.Text = "Conexion correcta!";
                    lblEstado.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    lblEstado.Text = "No se ha podido conectar";
                    lblEstado.ForeColor = Color.Red;
                }

            }
        }

    }
}
