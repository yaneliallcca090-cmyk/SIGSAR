namespace sigsar.view.admin
{
    partial class FormCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            txtNombreCat = new TextBox();
            panel1 = new Panel();
            txtDescripcionCat = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dgvTablaCategorias = new DataGridView();
            label1 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCat
            // 
            txtNombreCat.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCat.Location = new Point(83, 99);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(365, 29);
            txtNombreCat.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(txtDescripcionCat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(txtNombreCat);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 521);
            panel1.TabIndex = 1;
            // 
            // txtDescripcionCat
            // 
            txtDescripcionCat.Location = new Point(83, 161);
            txtDescripcionCat.Margin = new Padding(3, 4, 3, 4);
            txtDescripcionCat.Multiline = true;
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(365, 61);
            txtDescripcionCat.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(83, 135);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 9;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(83, 73);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvTablaCategorias);
            panel2.Location = new Point(0, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 241);
            panel2.TabIndex = 5;
            // 
            // dgvTablaCategorias
            // 
            dgvTablaCategorias.AllowUserToAddRows = false;
            dgvTablaCategorias.AllowUserToDeleteRows = false;
            dgvTablaCategorias.AllowUserToResizeColumns = false;
            dgvTablaCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaCategorias.BackgroundColor = Color.RosyBrown;
            dgvTablaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTablaCategorias.Location = new Point(15, 15);
            dgvTablaCategorias.Name = "dgvTablaCategorias";
            dgvTablaCategorias.ReadOnly = true;
            dgvTablaCategorias.RowHeadersWidth = 51;
            dgvTablaCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaCategorias.Size = new Size(510, 211);
            dgvTablaCategorias.TabIndex = 4;
            dgvTablaCategorias.CellDoubleClick += dgvTablaCategorias_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(226, 12);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 3;
            label1.Text = "CATEGORIA ";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(297, 237);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 37);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(83, 237);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(165, 37);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Registrar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 521);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormCategorias";
            Text = "GESTION DE CATEGORIAS";
            Load += FormCategorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreCat;
        private Panel panel1;
        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Panel panel2;
        private DataGridView dgvTablaCategorias;
        private PictureBox pictureBox1;
        private TextBox txtDescripcionCat;
        private Label label3;
        private Label label2;
    }
}