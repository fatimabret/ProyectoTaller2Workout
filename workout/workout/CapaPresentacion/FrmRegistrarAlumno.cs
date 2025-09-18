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
    public partial class FrmRegistrarAlumno : Form
    {
        public FrmRegistrarAlumno()
        {
            InitializeComponent();
            CargarEntrenadores();
        }
        private void CargarEntrenadores()
        {
            CN_Entrenador logicaEntrenador = new CN_Entrenador();
            List<Entrenador> listaEntrenadores = logicaEntrenador.ListarEntrenadores();

            if (listaEntrenadores.Count > 0)
            {
                AsigEntrenador.DataSource = listaEntrenadores;
                AsigEntrenador.DisplayMember = "InfoCompleta"; // nombre, apellido, horario_disp, dias_disp
                AsigEntrenador.ValueMember = "id_entrenador";
            }
            else
            {
                MessageBox.Show("No hay entrenadores registrados. Registre uno para continuar.", "Aviso");
            }
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
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDniAlumno.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDniAlumno.Focus();
                return false;
            }

            if (!int.TryParse(txtDniAlumno.Text, out _))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDniAlumno.Focus();
                return false;
            }

            // Puedes agregar más validaciones aquí
            if (AsigEntrenador.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un entrenador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AsigEntrenador.Focus();
                return false;
            }

            return true;
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            //Variable de la logica de negocios
            CN_Alumno logicaAlumno = new CN_Alumno();

            //Obtiene los datos de los campos de la vista
            int dni = int.Parse(txtDniAlumno.Text);
            string nombre = txtNombAlumno.Text.Trim();
            string apellido = txtApeAlumno.Text.Trim();
            DateTime fechaNac = fechaNacAlumno.Value;
            string detalles = txtDetallesAlum.Text.Trim();
            string correo = txtCorreoAlum.Text.Trim();

            //Evalua si es hombre o mujer
            string genero = rbHombre.Checked ? "Hombre" : rbMujer.Checked ? "Mujer" : "Otro";

            int idEntrenador = (int)AsigEntrenador.SelectedValue;

            try
            {
                //Le pasa los datos a la logica de negocio
                int id_alumno = logicaAlumno.registrar(
                    nombre, apellido, dni, fechaNac, genero , correo, detalles, idEntrenador);

                if (id_alumno >= 0)
                    MessageBox.Show("Alumno registrado con éxito");
                else
                    MessageBox.Show("El Alumno ya esta registrado");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia todos los campos del formulario
            txtDniAlumno.Clear();
            txtApeAlumno.Clear();
            txtNombAlumno.Clear();
            txtCorreoAlum.Clear();
            txtDetallesAlum.Clear();
        }

        private void AsigEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
