using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout.CapaPresentacion
{
    public partial class FrmInicioRec : Form
    {
        public FrmInicioRec()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            //Llama al formulario de registrar alumno
            FrmRegistrarAlumno frm = new FrmRegistrarAlumno();

            frm.ShowDialog();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Llama al formulario de inicio de sesión
            FrmPrincipal frm = new FrmPrincipal();
            this.Hide();
            //Setea el nuevo formulario como el actual
            frm.ShowDialog();
            //Cierra el formulario anterior
            this.Close();
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

        private void btnConsultarMembresia_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            FrmMembresia frm = new FrmMembresia();

            frm.ShowDialog();
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            //Llama al formulario de registrar entrenador
            FrmRegistrarEntrenador frm = new FrmRegistrarEntrenador();

            frm.ShowDialog();
        }

        private void btnListarAlumnos_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            FrmListAlumnos frm = new FrmListAlumnos();

            frm.ShowDialog();
        }

        private void btnListarEntrenadores_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            FrmListEntrenador frm = new FrmListEntrenador();

            frm.ShowDialog();
        }
    }
}
