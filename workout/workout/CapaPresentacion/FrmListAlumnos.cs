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
    public partial class FrmListAlumnos : Form
    {
        public FrmListAlumnos()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmListAlumnos_Load);
        }
        CN_Alumno logicaAlumno = new CN_Alumno();
        private void FrmListAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                CN_Alumno logicaAlumno = new CN_Alumno();
                DataTable alumnos = logicaAlumno.listarAlumnos();
                listAlumnos.DataSource = alumnos;
                if (alumnos.Rows.Count > 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listAlumnos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message);
            }
        }

        private void listAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaAlumno.eliminarAlumno(nombre, apellido);

                MessageBox.Show("Alumno dado de baja correctamente.");
                this.FrmListAlumnos_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }
    }
}
