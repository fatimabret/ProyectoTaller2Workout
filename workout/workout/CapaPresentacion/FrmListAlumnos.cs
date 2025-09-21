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
    }
}
