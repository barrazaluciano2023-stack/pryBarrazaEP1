namespace pryBarrazaAppSorteo
{
    partial class login
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtusuario = new TextBox();
            txtContraseña = new TextBox();
            lstModulo = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(430, 148);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 32);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnAceptar.Location = new Point(430, 96);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 32);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(102, 96);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 19);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            lblContraseña.Location = new Point(102, 149);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(95, 19);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            lblModulo.Location = new Point(102, 201);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(69, 19);
            lblModulo.TabIndex = 4;
            lblModulo.Text = "Modulo";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 12F);
            txtusuario.ForeColor = SystemColors.Highlight;
            txtusuario.Location = new Point(202, 96);
            txtusuario.MaxLength = 10;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(159, 29);
            txtusuario.TabIndex = 5;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.ForeColor = SystemColors.MenuHighlight;
            txtContraseña.Location = new Point(202, 149);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(159, 29);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // lstModulo
            // 
            lstModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstModulo.Enabled = false;
            lstModulo.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "ADM ", "SIST", "COM", "VTA" });
            lstModulo.Location = new Point(202, 203);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(159, 24);
            lstModulo.TabIndex = 7;
            lstModulo.SelectedIndexChanged += cmbModulo_SelectedIndexChanged;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtusuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "login";
            Text = "Login";
            Load += principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtusuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
    }
}