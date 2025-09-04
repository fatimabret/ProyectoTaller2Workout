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
    public partial class FrmInicioAdm : Form
    {
        public FrmInicioAdm()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmRegistrarAlumno frm = new FrmRegistrarAlumno();
            frm.ShowDialog();
        }

        private void btnEntrenadores_Click(object sender, EventArgs e)
        {
            FrmRegistrarEntrenador frm = new FrmRegistrarEntrenador();
            frm.ShowDialog();
        }

        private void btnListaAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnosList frm = new FrmAlumnosList();
            frm.ShowDialog();
        }
    }
}
