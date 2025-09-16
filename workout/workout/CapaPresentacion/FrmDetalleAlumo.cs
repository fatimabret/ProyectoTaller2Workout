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
    public partial class FrmDetalleAlumo : Form
    {
        public FrmDetalleAlumo()
        {
            InitializeComponent();
        }

        private void btnVerMembresia_Click(object sender, EventArgs e)
        {
            CN_Alumno logicaAlumno = new CN_Alumno();
            //Obtiene el nombre del alumno
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            //Busca el alumno por nombre y apellido
            logicaAlumno.buscarAlumno(nombre, apellido);
            //Llama al formulario de membresía
            FrmMembresia frm = new FrmMembresia();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CN_Alumno logicaAlumno = new CN_Alumno();

            // Trae todos los alumnos
            //DataTable dt = logicaAlumno.listarAlumnos();

            // Usamos BindingSource para manejar los registros
            BindingSource binding = new BindingSource();
            //binding.DataSource = dt;

            // Enlazamos los TextBox con las columnas de la tabla
            txtNombre.DataBindings.Add("Text", binding, "nombre");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
