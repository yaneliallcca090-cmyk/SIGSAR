namespace sigsar.view.admin
{
    partial class FormMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMesa));
            panel1 = new Panel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudNumero = new NumericUpDown();
            nudPiso = new NumericUpDown();
            nudCapacidad = new NumericUpDown();
            panel2 = new Panel();
            dgvTablaMesas = new DataGridView();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaMesas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Location = new Point(21, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 48);
            panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(172, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 33);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(12, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 33);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Registrar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Número :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 42);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Piso :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 42);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Capacidad :";
            // 
            // nudNumero
            // 
            nudNumero.Location = new Point(21, 60);
            nudNumero.Name = "nudNumero";
            nudNumero.Size = new Size(89, 27);
            nudNumero.TabIndex = 4;
            // 
            // nudPiso
            // 
            nudPiso.Location = new Point(147, 60);
            nudPiso.Name = "nudPiso";
            nudPiso.Size = new Size(81, 27);
            nudPiso.TabIndex = 5;
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(260, 60);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(81, 27);
            nudCapacidad.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Controls.Add(dgvTablaMesas);
            panel2.Location = new Point(0, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 224);
            panel2.TabIndex = 7;
            // 
            // dgvTablaMesas
            // 
            dgvTablaMesas.AllowUserToAddRows = false;
            dgvTablaMesas.AllowUserToDeleteRows = false;
            dgvTablaMesas.AllowUserToResizeColumns = false;
            dgvTablaMesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaMesas.BackgroundColor = Color.MistyRose;
            dgvTablaMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaMesas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTablaMesas.Location = new Point(12, 3);
            dgvTablaMesas.Name = "dgvTablaMesas";
            dgvTablaMesas.ReadOnly = true;
            dgvTablaMesas.RowHeadersWidth = 51;
            dgvTablaMesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaMesas.Size = new Size(647, 213);
            dgvTablaMesas.TabIndex = 0;
            dgvTablaMesas.CellDoubleClick += dgvTablaMesas_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 9);
            label4.Name = "label4";
            label4.Size = new Size(195, 25);
            label4.TabIndex = 8;
            label4.Text = "GESTIÓN DE MESAS ";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 365);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(673, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // FormMesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(671, 437);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(nudCapacidad);
            Controls.Add(nudPiso);
            Controls.Add(nudNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMesa";
            Text = "GESTIÓN DE MESAS";
            Load += FormMesa_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaMesas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudNumero;
        private NumericUpDown nudPiso;
        private NumericUpDown nudCapacidad;
        private Button btnActualizar;
        private Button btnEliminar;
        private Panel panel2;
        private DataGridView dgvTablaMesas;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}