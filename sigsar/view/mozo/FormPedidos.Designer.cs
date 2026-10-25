namespace sigsar.view.mozo
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            btnEnviarComanda = new Button();
            dgvDetallePedido = new DataGridView();
            ColCant = new DataGridViewTextBoxColumn();
            ContPlato = new DataGridViewTextBoxColumn();
            ColMod = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            label12 = new Label();
            panel3 = new Panel();
            lblStockDisponible = new Label();
            nudCantidad = new NumericUpDown();
            cmbPlatos = new ComboBox();
            btnAgregarPedido = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            txtNroMesa = new TextBox();
            rdbParaLlevar = new RadioButton();
            rdbParaMesa = new RadioButton();
            cmbPiso = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarComanda
            // 
            btnEnviarComanda.BackColor = Color.SaddleBrown;
            btnEnviarComanda.Enabled = false;
            btnEnviarComanda.FlatStyle = FlatStyle.Popup;
            btnEnviarComanda.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarComanda.ForeColor = SystemColors.ButtonHighlight;
            btnEnviarComanda.Location = new Point(310, 398);
            btnEnviarComanda.Margin = new Padding(3, 2, 3, 2);
            btnEnviarComanda.Name = "btnEnviarComanda";
            btnEnviarComanda.Size = new Size(215, 27);
            btnEnviarComanda.TabIndex = 16;
            btnEnviarComanda.Text = "ENVIAR COMANDA A COCINA";
            btnEnviarComanda.UseVisualStyleBackColor = false;
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.AllowUserToAddRows = false;
            dgvDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallePedido.BackgroundColor = Color.RosyBrown;
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Columns.AddRange(new DataGridViewColumn[] { ColCant, ContPlato, ColMod, ColEstado });
            dgvDetallePedido.Location = new Point(184, 283);
            dgvDetallePedido.Margin = new Padding(3, 2, 3, 2);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.ReadOnly = true;
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallePedido.Size = new Size(453, 105);
            dgvDetallePedido.TabIndex = 15;
            // 
            // ColCant
            // 
            ColCant.HeaderText = "Cantidad";
            ColCant.MinimumWidth = 6;
            ColCant.Name = "ColCant";
            ColCant.ReadOnly = true;
            // 
            // ContPlato
            // 
            ContPlato.HeaderText = "Plato";
            ContPlato.MinimumWidth = 6;
            ContPlato.Name = "ContPlato";
            ContPlato.ReadOnly = true;
            // 
            // ColMod
            // 
            ColMod.HeaderText = "Modalidad";
            ColMod.MinimumWidth = 6;
            ColMod.Name = "ColMod";
            ColMod.ReadOnly = true;
            // 
            // ColEstado
            // 
            ColEstado.HeaderText = "Estado Stock";
            ColEstado.MinimumWidth = 6;
            ColEstado.Name = "ColEstado";
            ColEstado.ReadOnly = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(138, 259);
            label12.Name = "label12";
            label12.Size = new Size(131, 15);
            label12.TabIndex = 14;
            label12.Text = "DETALLE DEL PEDIDO :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblStockDisponible);
            panel3.Controls.Add(nudCantidad);
            panel3.Controls.Add(cmbPlatos);
            panel3.Controls.Add(btnAgregarPedido);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(138, 166);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 88);
            panel3.TabIndex = 13;
            // 
            // lblStockDisponible
            // 
            lblStockDisponible.AutoSize = true;
            lblStockDisponible.Location = new Point(394, 27);
            lblStockDisponible.Name = "lblStockDisponible";
            lblStockDisponible.Size = new Size(16, 15);
            lblStockDisponible.TabIndex = 8;
            lblStockDisponible.Text = "...";
            // 
            // nudCantidad
            // 
            nudCantidad.ImeMode = ImeMode.On;
            nudCantidad.Location = new Point(88, 51);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(131, 23);
            nudCantidad.TabIndex = 7;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbPlatos
            // 
            cmbPlatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatos.FormattingEnabled = true;
            cmbPlatos.Location = new Point(65, 27);
            cmbPlatos.Margin = new Padding(3, 2, 3, 2);
            cmbPlatos.Name = "cmbPlatos";
            cmbPlatos.Size = new Size(206, 23);
            cmbPlatos.TabIndex = 5;
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.BackColor = SystemColors.GradientActiveCaption;
            btnAgregarPedido.FlatStyle = FlatStyle.Popup;
            btnAgregarPedido.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarPedido.Location = new Point(304, 52);
            btnAgregarPedido.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(165, 22);
            btnAgregarPedido.TabIndex = 4;
            btnAgregarPedido.Text = "AGREGAR AL PEDIDO";
            btnAgregarPedido.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(318, 27);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 3;
            label11.Text = "Stock Disp :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 56);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 2;
            label10.Text = "Cantidad :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 29);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 1;
            label9.Text = "Plato :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 0;
            label8.Text = "AGREGAR PLATOS :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtNroMesa);
            panel2.Controls.Add(rdbParaLlevar);
            panel2.Controls.Add(rdbParaMesa);
            panel2.Controls.Add(cmbPiso);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(138, 64);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 98);
            panel2.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(475, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtNroMesa
            // 
            txtNroMesa.Enabled = false;
            txtNroMesa.Location = new Point(67, 69);
            txtNroMesa.Margin = new Padding(3, 2, 3, 2);
            txtNroMesa.Name = "txtNroMesa";
            txtNroMesa.Size = new Size(110, 23);
            txtNroMesa.TabIndex = 7;
            // 
            // rdbParaLlevar
            // 
            rdbParaLlevar.AutoSize = true;
            rdbParaLlevar.Checked = true;
            rdbParaLlevar.Location = new Point(176, 45);
            rdbParaLlevar.Margin = new Padding(3, 2, 3, 2);
            rdbParaLlevar.Name = "rdbParaLlevar";
            rdbParaLlevar.Size = new Size(82, 19);
            rdbParaLlevar.TabIndex = 6;
            rdbParaLlevar.TabStop = true;
            rdbParaLlevar.Text = "Para Llevar";
            rdbParaLlevar.UseVisualStyleBackColor = true;
            // 
            // rdbParaMesa
            // 
            rdbParaMesa.AutoSize = true;
            rdbParaMesa.Location = new Point(86, 45);
            rdbParaMesa.Margin = new Padding(3, 2, 3, 2);
            rdbParaMesa.Name = "rdbParaMesa";
            rdbParaMesa.Size = new Size(79, 19);
            rdbParaMesa.TabIndex = 5;
            rdbParaMesa.Text = "Para Mesa";
            rdbParaMesa.UseVisualStyleBackColor = true;
            // 
            // cmbPiso
            // 
            cmbPiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPiso.FormattingEnabled = true;
            cmbPiso.Location = new Point(86, 20);
            cmbPiso.Margin = new Padding(3, 2, 3, 2);
            cmbPiso.Name = "cmbPiso";
            cmbPiso.Size = new Size(133, 23);
            cmbPiso.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 74);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 3;
            label7.Text = "N°Mesa :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 49);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 2;
            label6.Text = "Modalidad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 26);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 1;
            label5.Text = "Piso (1 al 5):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 0;
            label4.Text = "REGISTRO DE COMANDA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(138, 25);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 36);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 0;
            label1.Text = "Moza : MZA-001";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(152, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 1;
            label2.Text = "Turno : Activo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(382, 4);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 2;
            label3.Text = "Notificaciones :";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(128, 64, 64);
            flowLayoutPanel1.Location = new Point(106, -2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(594, 452);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 450);
            Controls.Add(pictureBox2);
            Controls.Add(btnEnviarComanda);
            Controls.Add(dgvDetallePedido);
            Controls.Add(label12);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPedidos";
            Text = "GESTION DE PEDIDOS";
            Load += FormPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarComanda;
        private DataGridView dgvDetallePedido;
        private DataGridViewTextBoxColumn ColCant;
        private DataGridViewTextBoxColumn ContPlato;
        private DataGridViewTextBoxColumn ColMod;
        private DataGridViewTextBoxColumn ColEstado;
        private Label label12;
        private Panel panel3;
        private Label lblStockDisponible;
        private NumericUpDown nudCantidad;
        private ComboBox cmbPlatos;
        private Button btnAgregarPedido;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private TextBox txtNroMesa;
        private RadioButton rdbParaLlevar;
        private RadioButton rdbParaMesa;
        private ComboBox cmbPiso;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}