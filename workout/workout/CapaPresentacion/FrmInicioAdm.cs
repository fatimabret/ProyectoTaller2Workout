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
            FrmListAlumnos frm = new FrmListAlumnos();
            frm.ShowDialog();
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

        private void btnRegistrarRecepcionista_Click(object sender, EventArgs e)
        {

        }

        private void btnListaEntrenadores_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            FrmListEntrenador frm = new FrmListEntrenador();

            frm.ShowDialog();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            // Si está vacío
            if (string.IsNullOrEmpty(dni))
            {
                errorProvider1.SetError(txtDni, "El DNI es obligatorio");
                return;
            }

            // Si la longitud no es válida
            if (dni.Length < 7 || dni.Length > 8)
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos");
                return;
            }

            // Si es correcto
            errorProvider1.SetError(txtDni, "");
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void btnConsultarPago_Click(object sender, EventArgs e)
        {

        }
    }
}
