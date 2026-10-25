namespace sigsar
{
    partial class FormPrincipalSigsar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalSigsar));
            label1 = new Label();
            cbxrol = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtusuario = new TextBox();
            txtclave = new TextBox();
            btningresar = new Button();
            pictureBox1 = new PictureBox();
            btnregresar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(485, 175);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "ROL:";
            label1.Click += label1_Click;
            // 
            // cbxrol
            // 
            cbxrol.FormattingEnabled = true;
            cbxrol.Items.AddRange(new object[] { "ADMINISTRADOR", "CAJERO", "MOZA", "COSINERO" });
            cbxrol.Location = new Point(485, 199);
            cbxrol.Margin = new Padding(3, 4, 3, 4);
            cbxrol.Name = "cbxrol";
            cbxrol.Size = new Size(214, 28);
            cbxrol.TabIndex = 1;
            cbxrol.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(485, 245);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "USUARIO(DNI:)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(485, 319);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "CLAVE:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(485, 269);
            txtusuario.Margin = new Padding(3, 4, 3, 4);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(214, 27);
            txtusuario.TabIndex = 4;
            txtusuario.TextChanged += textBox1_TextChanged;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(485, 357);
            txtclave.Margin = new Padding(3, 4, 3, 4);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(214, 27);
            txtclave.TabIndex = 5;
            txtclave.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.LightBlue;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Location = new Point(610, 427);
            btningresar.Margin = new Padding(3, 4, 3, 4);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(135, 35);
            btningresar.TabIndex = 6;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += txtIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, 51);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.LightBlue;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.Location = new Point(447, 427);
            btnregresar.Margin = new Padding(3, 4, 3, 4);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(137, 35);
            btnregresar.TabIndex = 8;
            btnregresar.Text = "REGRESAR";
            btnregresar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(389, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(413, 531);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-9, -29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(401, 557);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(128, 64, 64);
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(201, 152);
            label4.Name = "label4";
            label4.Size = new Size(127, 41);
            label4.TabIndex = 12;
            label4.Text = "SIGSAR";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.FromArgb(255, 224, 192);
            lblEstado.Location = new Point(399, 488);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(18, 20);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "...";
            // 
            // FormPrincipalSigsar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 520);
            Controls.Add(lblEstado);
            Controls.Add(label4);
            Controls.Add(btnregresar);
            Controls.Add(label1);
            Controls.Add(cbxrol);
            Controls.Add(pictureBox1);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(txtclave);
            Controls.Add(btningresar);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipalSigsar";
            Text = "login - sigsar";
            Load += FormPrincipalSigsar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxrol;
        private Label label2;
        private Label label3;
        private TextBox txtusuario;
        private TextBox txtclave;
        private Button btningresar;
        private PictureBox pictureBox1;
        private Button btnregresar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label lblEstado;
    }
}
