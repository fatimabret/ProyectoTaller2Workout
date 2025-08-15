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
    public partial class FrmRegistrarAlumno : Form
    {
        public FrmRegistrarAlumno()
        {
            InitializeComponent();
        }

        private void txtDniAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDniAlumno.Text,out int dni))
            {
                ePDniAlumno.SetError(txtDniAlumno, "Solo puede contener numeros");
            }
        }

        private void txtApeAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtApeAlumno.Text,out int apellido)){
                ePApeAlumno.SetError(txtApeAlumno, "Solo puede contener letras de A-Z");
            }
            
        }

        private void txtNombAlumno_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtNombAlumno.Text, out int nombre))
            {
                ePNomAlumno.SetError(txtNombAlumno, "Solo puede contener letras de A-Z");
            }
        }
    }
}
