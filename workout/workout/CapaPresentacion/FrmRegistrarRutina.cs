using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaDatos;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarRutina : Form
    {
        private int idEntrenador;

        private int dniAlumno;
        public FrmRegistrarRutina(int dni, int idEntrenador)
        {
            InitializeComponent();
            this.idEntrenador = idEntrenador;
            dniAlumno = dni;
        }

        private void FrmRegistrarRutina_Load(object sender, EventArgs e)
        {
            // Configurar columnas del DataGridView
            dgvRutina.AutoGenerateColumns = false;
            dgvRutina.AllowUserToAddRows = true;
            dgvRutina.Columns.Clear();
            cmbDias.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cargar opciones de Días
            cmbDias.Items.AddRange(new string[]
            {
                "Lunes",
                "Martes",
                "Miércoles",
                "Jueves",
                "Viernes",
                "Sábados"
            });

            // Columna ComboBox de ejercicios
            DataGridViewComboBoxColumn colEjercicios = new DataGridViewComboBoxColumn();
            colEjercicios.HeaderText = "Ejercicio";
            colEjercicios.Name = "colEjercicio";
            colEjercicios.DisplayMember = "InfoCompleta";
            colEjercicios.ValueMember = "id_ejercicio";
            dgvRutina.Columns.Add(colEjercicios);

            CargarEjercicio(idEntrenador);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llama al formulario de registrar rutina
            FrmRegistrarEjercicio frm = new FrmRegistrarEjercicio(idEntrenador);
            frm.ShowDialog();
        }

        private void CargarEjercicio(int idEntrenador)
        {
            CN_Ejercicio logicaEjercicio = new CN_Ejercicio();
            List<Ejercicio> listaEjercicios = logicaEjercicio.ListarEjercicios(idEntrenador);

            if (listaEjercicios.Count > 0)
            {
                // Buscar la columna ComboBox en el DataGridView
                var colEjercicios = dgvRutina.Columns["colEjercicio"] as DataGridViewComboBoxColumn;
                if (colEjercicios != null)
                {
                    colEjercicios.DataSource = listaEjercicios;
                    colEjercicios.DisplayMember = "InfoCompleta";
                    colEjercicios.ValueMember = "id_ejercicio";
                }
            }
            else
            {
                MessageBox.Show("No hay ejercicios registrados para este entrenador.", "Aviso");
            }
        }

        private void AsigEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRutina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvRutina.Rows.Clear();

            dgvRutina.ClearSelection();
        }

        private void btnRegistrarRutina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDias.Text))
            {
                MessageBox.Show("Debe seleccionar un día para la rutina.");
                return;
            }

            string diaSeleccionado = cmbDias.Text;
            CN_Rutina logicaRutina = new CN_Rutina();

            int registros = 0;

            foreach (DataGridViewRow row in dgvRutina.Rows)
            {
                if (row.Cells["colEjercicio"].Value != null)
                {
                    int idEjercicio = Convert.ToInt32(row.Cells["colEjercicio"].Value);

                    int resultado = logicaRutina.RegistrarRutina(dniAlumno, idEjercicio, diaSeleccionado);

                    if (resultado > 0) registros++;
                }
            }

            if (registros > 0)
                MessageBox.Show("Rutina registrada con éxito para " + registros + " ejercicios.");
            else
                MessageBox.Show("No se pudo registrar la rutina.");
        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
