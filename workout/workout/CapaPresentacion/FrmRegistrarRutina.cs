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
    public partial class FrmRegistrarRutina : Form
    {
        public FrmRegistrarRutina()
        {
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
    }
}
