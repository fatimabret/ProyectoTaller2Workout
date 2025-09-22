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

namespace workout.CapaPresentacion
{
    public partial class FrmModificarAlumno : Form
    {
        public FrmModificarAlumno()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                id_alumno = Convert.ToInt32(txtDni.Text),
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                correo = txtCorreo.Text,
                detalles = txtDetalles.Text,
                genero = rbHombre.Checked ? "Hombre" : rbMujer.Checked ? "Mujer" : "Otro",
                fecha_nac = dtpFechaNac.Value,
                dni = Convert.ToInt32(txtDni.Text),
                id_estado = (rbActivo.Checked) ? 1 : 0,
                id_entrenador = Convert.ToInt32(cmbEntrenador.SelectedValue)
            };

            CN_Alumno logicaAlumno = new CN_Alumno();
            int resultado = logicaAlumno.ModificarAlumno(alumno);

            if (resultado == 1)
                MessageBox.Show("Alumno actualizado con éxito.");
            else
                MessageBox.Show("Error: el alumno no existe.");
        }
    }
}
