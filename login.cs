using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {

                txtContraseña.Enabled = false;

                // para asginar o grabar datos se utiliza =
                // comparar valores ==
                // javascript ===
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                lstModulo.Enabled = true;
            }
        }
        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModulo.Text != "")
            {
                btnAceptar.Enabled = true;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //esto es un comentario: crea una ventana del formulario que le indico
            //crear objeto ventanaXXX de la clase frmXXX

            frmBienvenida ventanaBienvenida = new frmBienvenida();

            //con el objeto ventana, mostralo MODAL en la pantalla
            ventanaBienvenida.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //le digo a la caja de texto en su propiedad texto, que le asigne, NADA 
            txtusuario.Text = "";

            txtContraseña.Text = "";

            //borra los elementos de la lista
            //cmbModulo.Items.Clear();
            // limpio el combo box
            lstModulo.SelectedIndex = -1;
        }

        
    }
}
