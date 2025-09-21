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
    public partial class FrmAlumnosList : Form
    {
        private int idEntrenador;

        public FrmAlumnosList(int idEntrenador)
        {
            InitializeComponent();
            this.idEntrenador = idEntrenador;
            this.Load += new System.EventHandler(this.FrmAlumnosList_Load);
        }

        private void FrmAlumnosList_Load(object sender, EventArgs e)
        {
            try
            {
                CN_Alumno logicaAlumno = new CN_Alumno();
                DataTable alumnos = logicaAlumno.listarAlumnosPorEntrenador(idEntrenador);
                dataGridView1.DataSource = alumnos;
                if (alumnos.Rows.Count > 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
