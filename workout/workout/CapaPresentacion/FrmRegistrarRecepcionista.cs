using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarRecepcionista : Form
    {
        public FrmRegistrarRecepcionista()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '●';
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNom.Text.Trim();//Validar que el nombre solo contenga letras
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtNom, "El nombre es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(txtNom, "Solo puede contener letras y espacios");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtNom, "");
        }

        private void txtApe_Validating(object sender, CancelEventArgs e)
        {
            string apellido = txtApe.Text.Trim();//Validar que el apellido solo contenga letras
            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtApe, "El apellido es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(txtApe, "Solo puede contener letras y espacios");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtApe, "");
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                errorProvider1.SetError(txtDni, "Solo puede contener numeros");
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtNom.Text, out int nombre))
            {
                errorProvider1.SetError(txtNom, "Solo puede contener letras de A-Z");
            }
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtApe.Text, out int nombre))
            {
                errorProvider1.SetError(txtApe, "Solo puede contener letras de A-Z");
            }
        }
        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDni.Text.Trim();
            if (string.IsNullOrEmpty(dni))// está vacío
            {
                errorProvider1.SetError(txtDni, "El DNI es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!dni.All(char.IsDigit))// no son números
            {
                errorProvider1.SetError(txtDni, "El DNI solo puede contener números");
                e.Cancel = true;
                return;
            }
            if (dni.Length < 7 || dni.Length > 8)// la longitud no es válida
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtDni, "");// es correcto
        }
        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            // Validar correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar un correo electrónico");
                e.Cancel = true;
                return;
            }
            else if (!EsCorreoValido(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Formato de correo inválido");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
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
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("El campo NOMBRE no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApe.Text))
            {
                MessageBox.Show("El campo APELLIDO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("El campo CONTRASEÑA no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El campo CORREO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApe.Clear();
            txtDni.Clear();
            txtNom.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            //Obtiene los datos de los campos de la vista
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato numérico válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }
            string nombre = txtNom.Text.Trim();
            string apellido = txtApe.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            int id_rol = 2; // Rol de recepcionista

            try
            {
                // Crear objeto usuario
                Usuario nuevoUsuario = new Usuario(nombre, apellido, dni, correo, contrasena, id_rol);

                //Le pasa los datos a la logica de negocio
                CN_Usuario logicaUsuario = new CN_Usuario();
                int id_usuario = logicaUsuario.registrarUsuario(nuevoUsuario);

                if (id_usuario > 0)
                    MessageBox.Show("Usuario registrado con éxito");
                else
                    MessageBox.Show("El Usuario fue registrado previamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            //Oculta el formulario actual
            this.Hide();
            //Setea el nuevo formulario como el actual
            frm.ShowDialog();
            //Cierra el formulario anterior
            this.Close();
        }
        private void FrmRegistrarRecepcionista_Load(object sender, EventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea caracteres no numéricos
            }
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea caracteres no numéricos
            }
        }
    }
}
