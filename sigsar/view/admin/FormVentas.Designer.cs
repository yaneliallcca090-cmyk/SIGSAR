namespace sigsar.view.admin
{
    partial class FormVentas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            cmbTipoComprobante = new ComboBox();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            btnBuscar = new Button();
            panel2 = new Panel();
            btnEsportar = new Button();
            btnLimpiar = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            ColNventa = new DataGridViewTextBoxColumn();
            ColfechaH = new DataGridViewTextBoxColumn();
            ColComprob = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 14);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 14);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Comprobante:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(cmbTipoComprobante);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 74);
            panel1.TabIndex = 3;
            // 
            // cmbTipoComprobante
            // 
            cmbTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoComprobante.FormattingEnabled = true;
            cmbTipoComprobante.Items.AddRange(new object[] { "Boleta", "Factura" });
            cmbTipoComprobante.Location = new Point(262, 40);
            cmbTipoComprobante.Margin = new Padding(3, 2, 3, 2);
            cmbTipoComprobante.Name = "cmbTipoComprobante";
            cmbTipoComprobante.Size = new Size(223, 23);
            cmbTipoComprobante.TabIndex = 5;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(135, 38);
            dtpFechaFin.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(111, 23);
            dtpFechaFin.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(22, 38);
            dtpFechaInicio.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(108, 23);
            dtpFechaInicio.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.GradientActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(46, 4);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 30);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(btnEsportar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnBuscar);
            panel2.Location = new Point(10, 84);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 38);
            panel2.TabIndex = 7;
            // 
            // btnEsportar
            // 
            btnEsportar.BackColor = SystemColors.GradientActiveCaption;
            btnEsportar.FlatStyle = FlatStyle.Flat;
            btnEsportar.Location = new Point(375, 4);
            btnEsportar.Margin = new Padding(3, 2, 3, 2);
            btnEsportar.Name = "btnEsportar";
            btnEsportar.Size = new Size(84, 30);
            btnEsportar.TabIndex = 8;
            btnEsportar.Text = "Exportar Excel";
            btnEsportar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.GradientActiveCaption;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(218, 4);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 30);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(10, 127);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 202);
            panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNventa, ColfechaH, ColComprob, ColTotal, ColEstado });
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(505, 173);
            dataGridView1.TabIndex = 0;
            // 
            // ColNventa
            // 
            ColNventa.HeaderText = "N°Venta";
            ColNventa.MinimumWidth = 6;
            ColNventa.Name = "ColNventa";
            ColNventa.ReadOnly = true;
            ColNventa.Width = 125;
            // 
            // ColfechaH
            // 
            ColfechaH.HeaderText = "Fecha/Hora";
            ColfechaH.MinimumWidth = 6;
            ColfechaH.Name = "ColfechaH";
            ColfechaH.ReadOnly = true;
            ColfechaH.Width = 125;
            // 
            // ColComprob
            // 
            ColComprob.HeaderText = "Comprobante";
            ColComprob.MinimumWidth = 6;
            ColComprob.Name = "ColComprob";
            ColComprob.ReadOnly = true;
            ColComprob.Width = 125;
            // 
            // ColTotal
            // 
            ColTotal.HeaderText = "Total S/";
            ColTotal.MinimumWidth = 6;
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            ColTotal.Width = 125;
            // 
            // ColEstado
            // 
            ColEstado.HeaderText = "Estado";
            ColEstado.MinimumWidth = 6;
            ColEstado.Name = "ColEstado";
            ColEstado.ReadOnly = true;
            ColEstado.Width = 125;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 338);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVentas";
            Text = "CONSULTA DE VENTAS REALIZADAS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private ComboBox cmbTipoComprobante;
        private Button btnBuscar;
        private Panel panel2;
        private Button btnLimpiar;
        private Button btnEsportar;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNventa;
        private DataGridViewTextBoxColumn ColfechaH;
        private DataGridViewTextBoxColumn ColComprob;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewTextBoxColumn ColEstado;
    }
}