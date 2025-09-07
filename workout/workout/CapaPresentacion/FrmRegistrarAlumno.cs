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
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtApeAlumno.Text,out int apellido)){
                ePApeAlumno.SetError(txtApeAlumno, "Solo puede contener letras de A-Z");
            }
            
        }

        private void txtNombAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtNombAlumno.Text, out int nombre))
            {
                ePNomAlumno.SetError(txtNombAlumno, "Solo puede contener letras de A-Z");
            }
        }

        private void txtNombAlumno_TextChanged_1(object sender, EventArgs e)
        {
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtNombAlumno.Text, out int nombre))
            {
                ePNomAlumno.SetError(txtNombAlumno, "Solo puede contener letras de A-Z");
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

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            CN_Alumno logicaAlumno = new CN_Alumno();
            try
            {
                int dni = int.Parse(txtDniAlumno.Text);
                string nombre = txtNombAlumno.Text;
                string apellido = txtApeAlumno.Text;
                string detalles = txtDetallesAlum.Text;
                int idAlumno = logicaAlumno.registrar(dni, nombre, apellido, correo, genero, detalles);
                if (idAlumno > 0)
                {
                    MessageBox.Show("Alumno registrado correctamente. ID: " + idAlumno);
                    // Limpiar los campos después del registro exitoso
                    txtDniAlumno.Clear();
                    txtNombAlumno.Clear();
                    txtApeAlumno.Clear();
                    txtCorreoAlum.Clear();
                    cmbGeneroAlum.SelectedIndex = -1;
                    txtDetallesAlum.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar el alumno.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
    }
}
