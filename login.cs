using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaAppSorteo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            cmbModulo.Items.Add("ADM");
            cmbModulo.Items.Add("SIST");
            cmbModulo.Items.Add("COM");
            cmbModulo.Items.Add("VTA");

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
        int contFormulario = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (contFormulario >= 2)
            {
                MessageBox.Show("Ha superado el numero de intentos permitidos");
                this.Close();
            }
            if (txtusuario.Text == "adm" && txtContraseña.Text == "@1a")
            {
                if (cmbModulo.Text == "ADM" || cmbModulo.Text == "COM" || cmbModulo.Text == "VTA")
                {
                    Bienvenida ventanaBienvenida = new Bienvenida();
                    ventanaBienvenida.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");

                    contFormulario++;
                }
            }
            if (txtusuario.Text == "jhon" && txtContraseña.Text == "*2b" && cmbModulo.Text == "SIST")
            {
                Bienvenida ventanaBienvenida = new Bienvenida();
                ventanaBienvenida.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");

                contFormulario++;
            }
            if (txtusuario.Text == "ceci" && txtContraseña.Text == "@3c")
            {
                if (cmbModulo.Text == "ADM" || cmbModulo.Text == "VTA")
                {
                    Bienvenida ventanaBienvenida = new Bienvenida();
                    ventanaBienvenida.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");

                    contFormulario++;
                }
            }
            if (txtusuario.Text == "god" && txtContraseña.Text == "@#4d")
            {
                if (cmbModulo.Text == "ADM" || cmbModulo.Text == "COM" || cmbModulo.Text == "VTA" || cmbModulo.Text == "SIST")
                {
                    Bienvenida ventanaBienvenida = new Bienvenida();
                    ventanaBienvenida.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");

                    contFormulario++;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
