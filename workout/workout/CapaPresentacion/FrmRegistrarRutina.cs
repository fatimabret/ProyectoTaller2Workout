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
        public FrmRegistrarRutina()
        {
            //CargarEjercicio();
            InitializeComponent();
        }

        private void FrmRegistrarRutina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llama al formulario de registrar rutina
            FrmRegistrarEjercicio frm = new FrmRegistrarEjercicio();
            frm.ShowDialog();
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {

        }
        /*
        private void CargarEjercicio()
        {
            CN_Ejercicio logicaEjercicio = new CN_Ejercicio();
            List<Ejercicio> logicaEjercicio = logicaEjercicio.ListarEjercicios();

            if (listaEjercicios.Count > 0)
            {
                AsigEjercicio.DataSource = ListarEjercicios;
                //AsigEjercicio.DisplayMember = "InfoCompleta"; descripcion,serie,repeticiones,descanso
                AsigEjercicio.ValueMember = "id_ejercicio";
            }
            else
            {
                MessageBox.Show("No hay ejercicios registrados. Registre uno para continuar.", "Aviso");
            }
        }
        */
    }
}
