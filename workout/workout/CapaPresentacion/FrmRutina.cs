using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout.CapaPresentacion
{
    public partial class FrmRutina : Form
    {
        private int dniAlumno;
        public FrmRutina(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void lblEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRutina_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Rutina de Usuario: " + dniAlumno;
        }
    }
}
