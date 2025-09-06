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
    public partial class FrmDetalleAlumo : Form
    {
        public FrmDetalleAlumo()
        {
            InitializeComponent();
        }

        private void btnVerMembresia_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            FrmMembresia frm = new FrmMembresia();

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
