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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusuario = new TextBox();
            txtContraseña = new TextBox();
            cmbModulo = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(524, 148);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 32);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(524, 96);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 32);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(102, 96);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(102, 149);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(102, 201);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 4;
            label3.Text = "Modulo";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 12F);
            txtusuario.ForeColor = SystemColors.Highlight;
            txtusuario.Location = new Point(202, 96);
            txtusuario.MaxLength = 10;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(121, 29);
            txtusuario.TabIndex = 5;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.ForeColor = SystemColors.MenuHighlight;
            txtContraseña.Location = new Point(202, 149);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(121, 29);
            txtContraseña.TabIndex = 6;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Location = new Point(202, 203);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(121, 23);
            cmbModulo.TabIndex = 7;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtusuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusuario;
        private TextBox txtContraseña;
        private ComboBox cmbModulo;
    }
}