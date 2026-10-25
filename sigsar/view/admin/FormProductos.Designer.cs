namespace sigsar.view.admin
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            txtDescripcion = new TextBox();
            nudPrecio = new NumericUpDown();
            cmbCategoria = new ComboBox();
            txtNombre = new TextBox();
            dgvProductos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            panlProduc = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panlProduc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(207, 18);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE DEL PRODUCTO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 87);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 2;
            label3.Text = "PRECIO :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 21);
            label4.Name = "label4";
            label4.Size = new Size(102, 18);
            label4.TabIndex = 3;
            label4.Text = "CATEGORIA :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 108);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 4;
            label5.Text = "DESCRIPCION :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(nudPrecio);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(112, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 244);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Sienna;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnRegistrar);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(318, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 53);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Coral;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(235, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(121, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 45);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.ForestGreen;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = SystemColors.InactiveCaptionText;
            btnRegistrar.Location = new Point(11, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(99, 45);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(14, 131);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(282, 85);
            txtDescripcion.TabIndex = 12;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(341, 120);
            nudPrecio.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(146, 24);
            nudPrecio.TabIndex = 11;
            nudPrecio.ValueChanged += nudPrecio_ValueChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Bebidas" });
            cmbCategoria.Location = new Point(341, 53);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(249, 26);
            cmbCategoria.TabIndex = 9;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 24);
            txtNombre.TabIndex = 7;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.MistyRose;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCategoria, colDescripcion, colPrecio });
            dgvProductos.Location = new Point(35, 21);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(617, 205);
            dgvProductos.TabIndex = 7;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // panlProduc
            // 
            panlProduc.BackColor = Color.FromArgb(128, 64, 64);
            panlProduc.Controls.Add(dgvProductos);
            panlProduc.Location = new Point(112, 243);
            panlProduc.Name = "panlProduc";
            panlProduc.Size = new Size(685, 248);
            panlProduc.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 491);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 489);
            Controls.Add(pictureBox1);
            Controls.Add(panlProduc);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProductos";
            Text = "GESTION DE PRODUCTOS Y PRECIOS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panlProduc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nudPrecio;
        private Panel panel2;
        private Button btnEliminar;
        private Button btnRegistrar;
        private DataGridView dgvProductos;
        private Panel panlProduc;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecio;
        private ComboBox cmbCategoria;
        private PictureBox pictureBox1;
        private Button btnEditar;
    }
}