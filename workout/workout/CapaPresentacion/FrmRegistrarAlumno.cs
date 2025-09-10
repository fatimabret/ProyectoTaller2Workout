using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaNegocio;
using System.Text.RegularExpressions;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarAlumno : Form
    {
        public FrmRegistrarAlumno()
        {
            InitializeComponent();
        }

        private void txtDniAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDniAlumno.Text,out int dni))
            {
                ePDniAlumno.SetError(txtDniAlumno, "Solo puede contener numeros");
            }
        }

        private void txtApeAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtApeAlumno.Text, out int nombre))
            {
                ePNomAlumno.SetError(txtApeAlumno, "Solo puede contener letras de A-Z");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void txtDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDetallesAlum_TextChanged(object sender, EventArgs e)
        {

        }

        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {

            //Variable de la logica de negocios
            CN_Alumno logicaAlumno = new CN_Alumno();

            //Obtiene los datos de los campos de la vista
            int dni = int.Parse(txtDniAlumno.Text);
            string nombre = txtApeAlumno.Text.Trim();
            string apellido = txtNombAlumno.Text.Trim();
            DateTime fechaNac = fechaNacAlumno.Value;
            string detalles = txtDetallesAlum.Text.Trim();
            string correo = txtCorreoAlum.Text.Trim();

            //Evalua si es hombre o mujer
            string genero = rbHombre.Checked ? "Hombre" : rbMujer.Checked ? "Mujer" : "Otro";

            try
            {
                //Le pasa los datos a la logica de negocio
                int idAlumno = logicaAlumno.registrar(dni, nombre, apellido, fechaNac, correo, genero, detalles);

                if (idAlumno >= 0)
                    MessageBox.Show("Alumno registrado con éxito");
                else
                    MessageBox.Show("Error al registrar el alumno");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void txtCorreoAlum_TextChanged(object sender, EventArgs e)
        {
            // Validar Correo
            if (string.IsNullOrWhiteSpace(txtCorreoAlum.Text))
            {
                errorProvider1.SetError(txtCorreoAlum, "Debe ingresar un correo");
                return;
            }
            else if (!EsCorreoValido(txtCorreoAlum.Text.Trim()))
            {
                errorProvider1.SetError(txtCorreoAlum, "Formato de correo inválido");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreoAlum, "");
            }
        }
    }
}
