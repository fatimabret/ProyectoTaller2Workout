using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace workout.CapaPresentacion
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '●';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validar correo
            if (string.IsNullOrWhiteSpace(txtCorreoInicioSes.Text))
            {
                errorProvider1.SetError(txtCorreoInicioSes, "Debe ingresar un correo electrónico");
                return;
            }
            else if (!EsCorreoValido(txtCorreoInicioSes.Text))
            {
                errorProvider1.SetError(txtCorreoInicioSes, "Formato de correo inválido");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreoInicioSes, "");
            }

            // Validar contraseña
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errorProvider1.SetError(txtContraseña, "Debe ingresar la contraseña");
                return;
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "");
            }

            //Verifica que el correo y la contraseña sean correctos
            if ((txtCorreoInicioSes.Text == "arielgonzalez@gmail.com") && (txtContraseña.Text == "12345"))
            {
                //Llama al formulario de administrador
                FrmInicioAdm frmAdmin = new FrmInicioAdm();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmAdmin.ShowDialog();
                //cierra el formulario anterior
                this.Close();
                
            }else if ((txtCorreoInicioSes.Text == "fatimabret@gmail.com") && (txtContraseña.Text == "12345"))
            {
                //Llama al formulario de recepcionista
                FrmInicioRec frmRecep = new FrmInicioRec();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmRecep.ShowDialog();
                //cierra el formulario anterior
                this.Close();

            }else if ((txtCorreoInicioSes.Text == "bongio@gmail.com") && (txtContraseña.Text == "12345"))
            {
                FrmInicioEntr frmEntr = new FrmInicioEntr();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmEntr.ShowDialog();
                //cierra el formulario anterior
                this.Close();
            }
            else
            {
                lblCredenciales.Text = "CREDENCIALES INVALIDAS!!!!";
            }
        }

        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void txtCorreoInicioSes_TextChanged(object sender, EventArgs e)
        {
            // Validar correo
            if (string.IsNullOrWhiteSpace(txtCorreoInicioSes.Text))
            {
                errorProvider1.SetError(txtCorreoInicioSes, "Debe ingresar un correo electrónico");
                return;
            }
            else if (!EsCorreoValido(txtCorreoInicioSes.Text))
            {
                errorProvider1.SetError(txtCorreoInicioSes, "Formato de correo inválido");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreoInicioSes, "");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errorProvider1.SetError(txtContraseña, "Debe ingresar la contraseña");
                return;
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "");
            }
        }

        private void lblInicioSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
