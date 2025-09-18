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
using workout.CapaEntidad;

namespace workout.CapaPresentacion
{
    public partial class FrmListAlumnos : Form
    {
        public FrmListAlumnos()
        {
            InitializeComponent();
        }
        CN_Alumno logicaAlumno = new CN_Alumno();
        CN_Entrenador logicaEntrenador = new CN_Entrenador();
        private void FrmListAlumnos_Load(object sender, EventArgs e)
        {
            List<Alumno> listaAlumnos = logicaAlumno.listarAlumnos();
            List<Entrenador> listaEntrenadores = logicaEntrenador.ListarEntrenadores();
        }
    }
}
