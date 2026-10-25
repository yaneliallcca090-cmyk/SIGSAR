namespace sigsar.view.admin
{
    partial class FormPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalAdmin));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            btnUsuarios = new ToolStripButton();
            btnRoles = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnProductos = new ToolStripButton();
            btnCategorias = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnVentas = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnReportes = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnGestionMesa = new ToolStripButton();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.GhostWhite;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnUsuarios, btnRoles, toolStripSeparator2, btnProductos, btnCategorias, toolStripSeparator3, btnVentas, toolStripSeparator4, btnReportes, toolStripSeparator5, btnGestionMesa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(794, 42);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // btnUsuarios
            // 
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageTransparentColor = Color.Magenta;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(56, 39);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnRoles
            // 
            btnRoles.Image = (Image)resources.GetObject("btnRoles.Image");
            btnRoles.ImageTransparentColor = Color.Magenta;
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(39, 39);
            btnRoles.Text = "Roles";
            btnRoles.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRoles.Click += btnRoles_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 42);
            // 
            // btnProductos
            // 
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageTransparentColor = Color.Magenta;
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(65, 39);
            btnProductos.Text = "Productos";
            btnProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageTransparentColor = Color.Magenta;
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(67, 39);
            btnCategorias.Text = "Categorias";
            btnCategorias.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCategorias.Click += btnCategorias_Clik;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 42);
            // 
            // btnVentas
            // 
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageTransparentColor = Color.Magenta;
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(45, 39);
            btnVentas.Text = "Ventas";
            btnVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVentas.Click += btnVentas_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 42);
            // 
            // btnReportes
            // 
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageTransparentColor = Color.Magenta;
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(57, 39);
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReportes.Click += btnReportes_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 42);
            // 
            // btnGestionMesa
            // 
            btnGestionMesa.Image = (Image)resources.GetObject("btnGestionMesa.Image");
            btnGestionMesa.ImageTransparentColor = Color.Magenta;
            btnGestionMesa.Name = "btnGestionMesa";
            btnGestionMesa.Size = new Size(82, 39);
            btnGestionMesa.Text = "Gestion Mesa";
            btnGestionMesa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGestionMesa.Click += btnGestionMesa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 124);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(175, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 164);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(45, 76);
            label3.Name = "label3";
            label3.Size = new Size(324, 20);
            label3.TabIndex = 1;
            label3.Text = "Gestion de restaurante para la administracion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(134, 22);
            label2.Name = "label2";
            label2.Size = new Size(136, 54);
            label2.TabIndex = 0;
            label2.Text = "SIGSAR";
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.RosyBrown;
            flowLayoutPanel1.Location = new Point(0, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 408);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // FormPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormPrincipalAdmin";
            Text = "Módulo Administrador";
            Load += FormPrincipalAdmin_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnRoles;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCategorias;
        private ToolStripButton btnVentas;
        private ToolStripButton btnReportes;
        private ToolStripButton btnUsuarios;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnProductos;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnGestionMesa;
        private ToolStripSeparator toolStripSeparator5;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}