using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarEntrenador : Form
    {
        public FrmRegistrarEntrenador()
        {
            InitializeComponent();
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

        private void txtDniEntrenador_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDniEntrenador.Text.Trim();

            // Si está vacío
            if (string.IsNullOrEmpty(dni))
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI es obligatorio");
                return;
            }

            // Si no son números
            if (!dni.All(char.IsDigit))
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI solo puede contener números");
                return;
            }

            // Si la longitud no es válida
            if (dni.Length < 7 || dni.Length > 8)
            {
                errorProvider1.SetError(txtDniEntrenador, "El DNI debe tener entre 7 y 8 dígitos");
                return;
            }

            // Si es correcto
            errorProvider1.SetError(txtDniEntrenador, "");
        }

        private void txtApeEntrenador_TextChanged(object sender, EventArgs e)
        {
            //Validar que el apellido solo contenga letras
            string apellido = txtApeEntrenador.Text.Trim();

            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtApeEntrenador, "El apellido es obligatorio");
                return;
            }

            if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(txtApeEntrenador, "Solo puede contener letras y espacios");
                return;
            }

            errorProvider1.SetError(txtApeEntrenador, "");
        }

        private void txtNomEntrenador_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            string nombre = txtNomEntrenador.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtNomEntrenador, "El nombre es obligatorio");
                return;
            }

            if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider1.SetError(txtNomEntrenador, "Solo puede contener letras y espacios");
                return;
            }

            errorProvider1.SetError(txtNomEntrenador, "");
        }

        private void txtDniEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
