using sigsar.view.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sigsar.view.mozo
{
    public partial class FormPrincipalMoza : Form
    {
        public FormPrincipalMoza()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormPedidos pedidos = new FormPedidos();
            pedidos.ShowDialog();
        }

        private void FormPrincipalMoza_Load(object sender, EventArgs e)
        {

        }
    }
}
