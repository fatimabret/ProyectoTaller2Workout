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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbHorarioDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void txtApeEntrenador_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtDniEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {

            //Variable de la logica de negocios
            CN_Entrenador logicaEntrenador = new CN_Entrenador();

            //Obtiene los datos de los campos de la vista
            int dni = int.Parse(txtDniEntrenador.Text);
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
                int id_entrenador = logicaEntrenador.registrarEntrenador(nombre, apellido, dni, correo, contrasena, horario_disp, dias_disp, detalles);

                if (id_entrenador >= 0)
                    MessageBox.Show("Entrenador registrado con éxito");
                else
                    MessageBox.Show("El entrenador ya esta registrado");
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

        private void cmbEspecializacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDniEntrenador_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDniEntrenador.Text.Trim();

            // Si está vacío
            if (string.IsNullOrEmpty(dni))
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI es obligatorio");
                e.Cancel = true;
                return;
            }

            // Si no son números
            if (!dni.All(char.IsDigit))
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI solo puede contener números");
                e.Cancel = true;
                return;
            }

            // Si la longitud no es válida
            if (dni.Length < 7 || dni.Length > 8)
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI debe tener entre 7 y 8 dígitos");
                e.Cancel = true;
                return;
            }

            // Si es correcto
            errorProvider1.SetError(txtDniEntrenador, "");
        }

        private void txtNomEntrenador_Validating(object sender, CancelEventArgs e)
        {
            //Validar que el nombre solo contenga letras
            string nombre = txtNomEntrenador.Text.Trim();

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
            //Validar que el apellido solo contenga letras
            string apellido = txtApeEntrenador.Text.Trim();

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
    }
}
