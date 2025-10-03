using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarUsuario : Form
    {
        int id_rol;
        public FrmRegistrarUsuario(int p_id_rol)
        {
            InitializeComponent();
            id_rol = p_id_rol;
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            // Configurar los ComboBox para que no permitan edición manual
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;

            if (id_rol != 2)
            {
                // Cargar opciones de Rol
                cmbRol.Items.AddRange(new string[]
                {
                "Administrador",
                "Entrenador",
                "Recepcionista"
                });
            }
            else {
                // Cargar opciones de Rol
                cmbRol.Items.AddRange(new string[]
                {
                "Entrenador",
                "Recepcionista"
                });
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNom.Text.Trim();
            string apellido = txtApe.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            int id_rol;
            
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato numérico válido.",
                "Error de formato",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }

            if (cmbRol.SelectedItem?.ToString() == "Recepcionista")
            {
                id_rol = 2; // Rol de recepcionista
            }else if (cmbRol.SelectedItem?.ToString() == "Administrador")
            {
                id_rol = 1; // Rol de administrador
            }
            else
            {
                id_rol = 3; // Rol de entrenador
                FrmRegistrarEntrenador frmRegistrarEntrenador = new FrmRegistrarEntrenador(dni,nombre,apellido,contrasena,correo,id_rol);
                frmRegistrarEntrenador.ShowDialog();
            }

            if (id_rol != 3)
            {
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
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtApe.Text, out int nombre))
            {
                errorProvider1.SetError(txtApe, "Solo puede contener letras de A-Z");
            }
        }
        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            // Validar Correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar un correo electrónico");
                return;
            }
            else if (!EsCorreoValido(txtCorreo.Text.Trim()))
            {
                errorProvider1.SetError(txtCorreo, "Formato de correo inválido");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
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

            if (string.IsNullOrWhiteSpace(txtApe.Text))
            {
                MessageBox.Show("El campo APELLIDO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El campo CORREO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("El campo NOMBRE no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                return false;
            }

            return true;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
