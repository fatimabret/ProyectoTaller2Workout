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
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '●';
        }
        CN_Usuario logicaUsuario = new CN_Usuario();

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var resultado = logicaUsuario.iniciarSesion(txtCorreoInicioSes.Text, txtContraseña.Text);
            int idUsuario = resultado.idUsuario;
            int idRol = resultado.idRol;

            if (idRol == 1)
            {
                //Llama al formulario de administrador
                FrmInicioAdm frmAdmin = new FrmInicioAdm();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmAdmin.ShowDialog();
                //cierra el formulario anterior
                this.Close();
            }
            else if (idRol == 2)
            {
                //Llama al formulario de recepcionista
                FrmInicioRec frmRecep = new FrmInicioRec();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmRecep.ShowDialog();
                //cierra el formulario anterior
                this.Close();
            }
            else if (idRol == 3)
            {
                // Antes de abrir el inicio del entrenador, buscamos su id_entrenador
                CN_Entrenador logicaEntrenador = new CN_Entrenador();
                int idEntrenador = logicaEntrenador.ObtenerIdEntrenadorPorUsuario(idUsuario);

                FrmInicioEntr frmEntr = new FrmInicioEntr(idEntrenador);
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


        private void lblInicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoInicioSes_Validating(object sender, CancelEventArgs e)
        {
            // Validar correo
            if (string.IsNullOrWhiteSpace(txtCorreoInicioSes.Text))
            {
                errorProvider1.SetError(txtCorreoInicioSes, "Debe ingresar un correo electrónico");
                e.Cancel = true;
                return;
            }
            else if (!EsCorreoValido(txtCorreoInicioSes.Text))
            {
                errorProvider1.SetError(txtCorreoInicioSes, "Formato de correo inválido");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreoInicioSes, "");
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            // Validar contraseña
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errorProvider1.SetError(txtContraseña, "Debe ingresar la contraseña");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "");
            }
        }

        private void txtCorreoInicioSes_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
