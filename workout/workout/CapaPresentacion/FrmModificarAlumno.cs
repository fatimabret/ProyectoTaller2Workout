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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace workout.CapaPresentacion
{
    public partial class FrmModificarAlumno : Form
    {
        private string nombre;
        private string apellido;
        public FrmModificarAlumno(string p_nombre,string p_apellido)
        {
            InitializeComponent();
            nombre = p_nombre;
            apellido = p_apellido;
            CargarEntrenadores();
        }

        CN_Alumno logicaAlumno = new CN_Alumno();
        CN_Entrenador logicaEntrenador = new CN_Entrenador();

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            int id_alumno = logicaAlumno.buscarAlumno(nombre,apellido);
            if (id_alumno <= 0)
            {
                MessageBox.Show("No se encontró el alumno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string detalles = txtDetalles.Text;
            if (string.IsNullOrWhiteSpace(txtDetalles.Text))
            {
                MessageBox.Show("El campo 'Detalles' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDetalles.Focus();
                return;
            }

            string genero = rbHombre.Checked ? "Hombre" : rbMujer.Checked ? "Mujer" : "Otro";
            if (string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int estado = rbActivo.Checked ? 1 : rbInactivo.Checked ? 0 : 2;
            if (estado == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el texto seleccionado
            string entrenador = cmbEntrenador.Text; 

            // Separar la parte del nombre/apellido
            string[] partes = entrenador.Split(new string[] { " - " }, StringSplitOptions.None);
            string nombreApellido = partes[0].Trim(); // "Bongiovanni Iara"

            // Separar apellido y nombre
            string[] palabras = nombreApellido.Split(' ');
            if (palabras.Length > 1)
            {
                apellido = palabras[0]; // "Bongiovanni"
                nombre = palabras[1];   // "Iara"
            }
            
            int idEntrenador = logicaEntrenador.buscarEntrenador(nombre,apellido);
            logicaAlumno.modificarAlumno(id_alumno,detalles,genero,estado,idEntrenador);
            
            //Llama al formulario de administrador
            FrmListAlumnos frmListaAlumnos = new FrmListAlumnos();
            //oculta el formulario actual
            this.Hide();
            //setea el nuevo formulario como el actual
            frmListaAlumnos.ShowDialog();
            //cierra el formulario anterior
            this.Close();
        }
        private void CargarEntrenadores()
        {
            CN_Entrenador logicaEntrenador = new CN_Entrenador();
            DataTable listaEntrenadores = logicaEntrenador.ListarEntrenadoresConInfoCompleta();

            if (listaEntrenadores.Rows.Count > 0)
            {
                cmbEntrenador.DataSource = listaEntrenadores;
                cmbEntrenador.DisplayMember = "InfoCompleta";
                cmbEntrenador.ValueMember = "id_entrenador";
            }
            else
            {
                MessageBox.Show("No hay entrenadores registrados. Registre uno para continuar.", "Aviso");
            }
        }

        private void txtDniAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDniAlumno.Text, out int dni))
            {
                errorProvider1.SetError(txtDniAlumno, "Solo puede contener numeros");
            }
        }

        private void txtNombAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtNombAlumno.Text, out int nombre))
            {
                errorProvider1.SetError(txtNombAlumno, "Solo puede contener letras de A-Z");
            }
        }

        private void txtApeAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtApeAlumno.Text, out int nombre))
            {
                errorProvider1.SetError(txtApeAlumno, "Solo puede contener letras de A-Z");
            }
        }

        private void txtCorreoAlum_TextChanged(object sender, EventArgs e)
        {
            // Validar Correo
            if (string.IsNullOrWhiteSpace(txtCorreoAlum.Text))
            {
                errorProvider1.SetError(txtCorreoAlum, "Debe ingresar un correo electrónico");
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

        private void FrmModificarAlumno_Load(object sender, EventArgs e)
        {
            DataRow alumno = logicaAlumno.obtenerAlumno(nombre, apellido);

            if (alumno != null)
            {
                txtNombAlumno.Text = alumno["nombre"].ToString();
                txtApeAlumno.Text = alumno["apellido"].ToString();
                txtDniAlumno.Text = alumno["dni"].ToString();
                txtCorreoAlum.Text = alumno["correo"].ToString();
                txtDetalles.Text = alumno["detalles"].ToString();
                fechaNacAlumno.Value = Convert.ToDateTime(alumno["fecha_nac"]);

                // Genero
                string genero = alumno["genero"].ToString();
                if (genero == "Hombre") rbHombre.Checked = true;
                else if (genero == "Mujer") rbMujer.Checked = true;
                else rbOtro.Checked = true;

                // Estado
                int estado = Convert.ToInt32(alumno["id_estado"]);
                if (estado == 1) rbActivo.Checked = true;
                else rbInactivo.Checked = true;

                // Entrenador → setear SelectedValue
                cmbEntrenador.SelectedValue = Convert.ToInt32(alumno["id_entrenador"]);
            }
            else
            {
                MessageBox.Show("No se encontró el alumno en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

            if (string.IsNullOrWhiteSpace(txtApeAlumno.Text))
            {
                MessageBox.Show("El campo APELLIDO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApeAlumno.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoAlum.Text))
            {
                MessageBox.Show("El campo CORREO no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreoAlum.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDetalles.Text))
            {
                MessageBox.Show("El campo DETALLES no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDetalles.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombAlumno.Text))
            {
                MessageBox.Show("El campo NOMBRE no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombAlumno.Focus();
                return false;
            }

            if (cmbEntrenador.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un entrenador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEntrenador.Focus();
                return false;
            }

            return true;
        }

        private void txtDniAlumno_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDniAlumno.Text.Trim();
            if (string.IsNullOrEmpty(dni))// está vacío
            {
                errorProvider1.SetError(txtDniAlumno, "El DNI es obligatorio");
                e.Cancel = true;
                return;
            }
            if (!dni.All(char.IsDigit))// no son números
            {
                errorProvider1.SetError(txtDniAlumno, "El DNI solo puede contener números");
                e.Cancel = true;
                return;
            }
            if (dni.Length < 7 || dni.Length > 8)// la longitud no es válida
            {
                errorProvider1.SetError(txtDniAlumno, "El DNI debe tener entre 7 y 8 dígitos");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(txtDniAlumno, "");
        }
    }
}
