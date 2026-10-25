namespace sigsar.view.admin
{
    partial class FormRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoles));
            txtDescripcionRol = new TextBox();
            btnAgregar = new Button();
            dgvTablaRoles = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombreRol = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTablaRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Location = new Point(12, 131);
            txtDescripcionRol.Multiline = true;
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(235, 51);
            txtDescripcionRol.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(298, 144);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 38);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvTablaRoles
            // 
            dgvTablaRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaRoles.BackgroundColor = Color.Linen;
            dgvTablaRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaRoles.Location = new Point(12, 199);
            dgvTablaRoles.Name = "dgvTablaRoles";
            dgvTablaRoles.ReadOnly = true;
            dgvTablaRoles.RowHeadersWidth = 51;
            dgvTablaRoles.Size = new Size(431, 138);
            dgvTablaRoles.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 5;
            label2.Text = "Descripción:";
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(12, 65);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(235, 27);
            txtNombreRol.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 0, 0);
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(23, 9);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 8;
            label3.Text = "GESTIÓN DE ROLES:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(449, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 353);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FormRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(529, 349);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreRol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTablaRoles);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcionRol);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRoles";
            Text = "GESTION DE ROLES";
            Load += FormRoles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcionRol;
        private Button btnAgregar;
        private DataGridView dgvTablaRoles;
        private Label label1;
        private Label label2;
        private TextBox txtNombreRol;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
    }
}