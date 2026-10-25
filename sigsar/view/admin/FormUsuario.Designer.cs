namespace sigsar.view.admin
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            panel1 = new Panel();
            cbxGenero = new ComboBox();
            label12 = new Label();
            txtCelular = new TextBox();
            txtGmail = new TextBox();
            txtDireccion = new TextBox();
            txtClave = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtApellidos = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            dgvTablaUsuarios = new DataGridView();
            cmbRol = new ComboBox();
            txtRepetirClave = new TextBox();
            txtNombres = new TextBox();
            txtDni = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlBotones = new Panel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaUsuarios).BeginInit();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(cbxGenero);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtCelular);
            panel1.Controls.Add(txtGmail);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgvTablaUsuarios);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(txtRepetirClave);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnlBotones);
            panel1.Location = new Point(2, -1);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 511);
            panel1.TabIndex = 0;
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "F", "M" });
            cbxGenero.Location = new Point(694, 140);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(99, 31);
            cbxGenero.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(694, 109);
            label12.Name = "label12";
            label12.Size = new Size(70, 23);
            label12.TabIndex = 24;
            label12.Text = "Genero:";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(301, 75);
            txtCelular.MaxLength = 9;
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(189, 30);
            txtCelular.TabIndex = 23;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(301, 138);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(189, 30);
            txtGmail.TabIndex = 22;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(301, 201);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(189, 30);
            txtDireccion.TabIndex = 21;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(518, 140);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(161, 30);
            txtClave.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(301, 173);
            label11.Name = "label11";
            label11.Size = new Size(90, 23);
            label11.TabIndex = 19;
            label11.Text = "Dirección :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(301, 110);
            label10.Name = "label10";
            label10.Size = new Size(59, 23);
            label10.TabIndex = 18;
            label10.Text = "Gmai :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(301, 47);
            label9.Name = "label9";
            label9.Size = new Size(115, 23);
            label9.TabIndex = 17;
            label9.Text = "Num Celular :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(56, 173);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 16;
            label8.Text = "Apellidos :";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(56, 201);
            txtApellidos.Margin = new Padding(3, 5, 3, 5);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(218, 30);
            txtApellidos.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(694, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.RosyBrown;
            label7.Location = new Point(48, 11);
            label7.Name = "label7";
            label7.Size = new Size(198, 23);
            label7.TabIndex = 13;
            label7.Text = "GESTIÓN DE USUARIOS ";
            // 
            // dgvTablaUsuarios
            // 
            dgvTablaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTablaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvTablaUsuarios.BackgroundColor = Color.RosyBrown;
            dgvTablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaUsuarios.Location = new Point(10, 293);
            dgvTablaUsuarios.MultiSelect = false;
            dgvTablaUsuarios.Name = "dgvTablaUsuarios";
            dgvTablaUsuarios.ReadOnly = true;
            dgvTablaUsuarios.RowHeadersWidth = 51;
            dgvTablaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaUsuarios.Size = new Size(799, 203);
            dgvTablaUsuarios.TabIndex = 12;
            dgvTablaUsuarios.CellDoubleClick += dgvTablaUsuarios_CellDoubleClick;
            // 
            // cmbRol
            // 
            cmbRol.AutoCompleteCustomSource.AddRange(new string[] { "Cajero/a", "Cosinero/a", "Mozo/a" });
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "ADMINISTRADOR", "CAJERO", "MOZA", "COSINERO" });
            cmbRol.Location = new Point(518, 75);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(162, 31);
            cmbRol.TabIndex = 10;
            // 
            // txtRepetirClave
            // 
            txtRepetirClave.Location = new Point(518, 201);
            txtRepetirClave.Margin = new Padding(3, 5, 3, 5);
            txtRepetirClave.Name = "txtRepetirClave";
            txtRepetirClave.Size = new Size(161, 30);
            txtRepetirClave.TabIndex = 9;
            txtRepetirClave.UseSystemPasswordChar = true;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(55, 138);
            txtNombres.Margin = new Padding(3, 5, 3, 5);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(219, 30);
            txtNombres.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(54, 75);
            txtDni.Margin = new Padding(3, 5, 3, 5);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 30);
            txtDni.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(518, 46);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 5;
            label6.Text = "Asignar rol :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(513, 173);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 4;
            label5.Text = "Repetir Clave :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(518, 109);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 3;
            label4.Text = "Clave :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 110);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 2;
            label3.Text = "Nombres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 47);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(128, 64, 64);
            pnlBotones.BorderStyle = BorderStyle.FixedSingle;
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnActualizar);
            pnlBotones.ForeColor = SystemColors.ActiveCaptionText;
            pnlBotones.Location = new Point(10, 240);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(799, 47);
            pnlBotones.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(449, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(220, 37);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(164, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(216, 37);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Registrar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(823, 507);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsuario";
            Text = "GESTIONAR USUARIOS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaUsuarios).EndInit();
            pnlBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtRepetirClave;
        private TextBox txtNombres;
        private TextBox txtDni;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbRol;
        private Panel pnlBotones;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgvTablaUsuarios;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private TextBox txtApellidos;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtClave;
        private ComboBox cbxGenero;
        private Label label12;
        private TextBox txtCelular;
        private TextBox txtGmail;
        private TextBox txtDireccion;
    }
}