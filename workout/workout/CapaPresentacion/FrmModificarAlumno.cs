using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        
    }
}
