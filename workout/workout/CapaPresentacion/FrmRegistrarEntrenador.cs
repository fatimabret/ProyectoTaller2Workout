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
    public partial class FrmRegistrarEntrenador : Form
    {
        public FrmRegistrarEntrenador()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '●';
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        { }
        private void lblTitulo_Click(object sender, EventArgs e)
        { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { }
        private void cmbHorarioDisponible_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void cmbEspecializacion_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void txtNomEntrenador_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNomEntrenador.Text.Trim();//Validar que el nombre solo contenga letras
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtNomEntrenador, "El nombre es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(txtNomEntrenador, "Solo puede contener letras y espacios");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtNomEntrenador, "");
        }
        private void txtApeEntrenador_Validating(object sender, CancelEventArgs e)
        {
            string apellido = txtApeEntrenador.Text.Trim();//Validar que el apellido solo contenga letras
            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtApeEntrenador, "El apellido es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(txtApeEntrenador, "Solo puede contener letras y espacios");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtApeEntrenador, "");
        }
        
        private void txtDniEntrenador_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDniEntrenador.Text.Trim();
            if (string.IsNullOrEmpty(dni))// está vacío
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!dni.All(char.IsDigit))// no son números
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI solo puede contener números");
                e.Cancel = true;
                return;
            }
            if (dni.Length < 7 || dni.Length > 8)// la longitud no es válida
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI debe tener entre 7 y 8 dígitos");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtDniEntrenador, "");// es correcto
        }

        private void txtContrasena_Validating(object sender, CancelEventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtDniEntrenador.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDniEntrenador.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNomEntrenador.Text))
            {
                MessageBox.Show("El campo NOMBRE no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomEntrenador.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApeEntrenador.Text))
            {
                MessageBox.Show("El campo APELLIDO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApeEntrenador.Focus();
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

        private void txtDniEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDniEntrenador_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDniEntrenador.Text, out int dni))
            {
                errorProvider1.SetError(txtDniEntrenador, "Solo puede contener numeros");
            }
        }

        private void txtApeEntrenador_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtApeEntrenador.Text, out int nombre))
            {
                errorProvider1.SetError(txtApeEntrenador, "Solo puede contener letras de A-Z");
            }
        }

        private void txtNomEntrenador_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtNomEntrenador.Text, out int nombre))
            {
                errorProvider1.SetError(txtNomEntrenador, "Solo puede contener letras de A-Z");
            }
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

        private void FrmRegistrarEntrenador_Load(object sender, EventArgs e)
        {
            // Configurar los ComboBox para que no permitan edición manual
            cmbHorarioDisponible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiasDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecializacion.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cargar opciones de Horario
            cmbHorarioDisponible.Items.AddRange(new string[]
            {
                "Mañana (08:00 - 12:00)",
                "Tarde (14:00 - 18:00)",
                "Noche (18:00 - 22:00)"
            });

            // Cargar opciones de Días
            cmbDiasDisponibles.Items.AddRange(new string[]
            {
                "Lunes a Viernes",
                "Lunes, Miércoles y Viernes",
                "Martes y Jueves",
                "Sábados"
            });

            // Cargar opciones de Especialización
            cmbEspecializacion.Items.AddRange(new string[]
            {
                "Musculación",
                "Crossfit",
                "Pilates",
                "Cardio Funcional"
            });

            // Seleccionar la primera opción por defecto (índice 0)
            cmbHorarioDisponible.SelectedIndex = 0;
            cmbDiasDisponibles.SelectedIndex = 0;
            cmbEspecializacion.SelectedIndex = 0;
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            //Variable de la logica de negocios
            CN_Entrenador logicaEntrenador = new CN_Entrenador();

            //Obtiene los datos de los campos de la vista
            if (!int.TryParse(txtDniEntrenador.Text, out int dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato numérico válido.",
                                "Error de formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtDniEntrenador.Focus();
                return;
            }
            string nombre = txtNomEntrenador.Text.Trim();
            string apellido = txtApeEntrenador.Text.Trim();
            string horario_disp = cmbHorarioDisponible.SelectedItem?.ToString();
            string dias_disp = cmbDiasDisponibles.SelectedItem?.ToString();
            string detalles = cmbEspecializacion.SelectedItem.ToString();
            string contrasena = txtContraseña.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            try
            {
                //Le pasa los datos a la logica de negocio
                int id_entrenador = logicaEntrenador.RegistrarEntrenador(
                    nombre, apellido, dni, correo, contrasena, horario_disp, dias_disp,
                    detalles);

                if (id_entrenador > 0)
                    MessageBox.Show("Entrenador registrado con éxito");
                else
                    MessageBox.Show("El entrenador fue registrado previamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApeEntrenador.Clear();
            txtDniEntrenador.Clear();
            txtNomEntrenador.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
        }

        private void txtNomEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea caracteres no numéricos
            }
        }

        private void txtApeEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea caracteres no numéricos
            }
        }
    }
}
