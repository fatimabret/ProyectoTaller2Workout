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
    public partial class FrmEjercicio : Form
    {
        private int dniAlumno;

        public FrmEjercicio(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void picMascota_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEjercicio_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Rutina de Usuario: " + dniAlumno;
        }

        private void lblEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }
    }
}
