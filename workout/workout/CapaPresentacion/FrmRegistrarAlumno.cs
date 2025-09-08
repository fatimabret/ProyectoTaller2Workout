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

        private void txtNombAlumno_TextChanged_1(object sender, EventArgs e)
        {
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtNombAlumno.Text, out int nombre))
            {
                ePNomAlumno.SetError(txtNombAlumno, "Solo puede contener letras de A-Z");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            //Oculta el formulario actual
            this.Hide();
            //Setea el nuevo formulario como el actual
            frm.ShowDialog();
            //Cierra el formulario anterior
            this.Close();
        }

        private void txtDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDetallesAlum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            //Variable de la logica de negocios
            CN_Alumno logicaAlumno = new CN_Alumno();
            //Obtiene los datos de los campos de la vista
            int dni = int.Parse(txtDniAlumno.Text);
            string nombre = txtNombAlumno.Text;
            string apellido = txtApeAlumno.Text;
            DateTime fechaNac = fechaNacAlumno.Value;
            string detalles = txtDetallesAlum.Text;
            string correo = txtCorreoAlum.Text;
            string genero;
            
            //Evalua si es hombre o mujer
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            else
            {
                genero = "Otro";
            }
            //Le pasa los datos a la logica de negocio
            int idAlumno = logicaAlumno.registrar(dni, nombre, apellido, fechaNac, correo, genero, detalles);
        }
            
    }
}
