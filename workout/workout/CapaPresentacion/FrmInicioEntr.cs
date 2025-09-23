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
    public partial class FrmInicioEntr : Form
    {
        private int idEntrenador;

        public FrmInicioEntr(int idEntrenador)
        {
            InitializeComponent();
            this.idEntrenador = idEntrenador;
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
        private bool DniValido()
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Debe ingresar un DNI.");
                return false;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números.");
                return false;
            }

            return true;
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
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ConslRutina_Click(object sender, EventArgs e)
        {
            if (!DniValido()) return;

            //Llama al formulario de rutina
            int dni = int.Parse(txtDni.Text);
            FrmRutina frm = new FrmRutina(dni);
            frm.ShowDialog();
        }

        private void AlumnosList_Click(object sender, EventArgs e)
        {
            //Llama al formulario de lista de alumnos
            FrmAlumnosList frm = new FrmAlumnosList(this.idEntrenador);
            frm.ShowDialog();
        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            if (!DniValido()) return;


            int dni = int.Parse(txtDni.Text);
            //Llama al formulario de registrar rutina
            FrmRegistrarRutina frm = new FrmRegistrarRutina(dni,idEntrenador);
            //Oculta el formulario actual
            this.Hide();
            //Setea el nuevo formulario como el actual
            frm.ShowDialog();
            this.Show();

        }

        private void FrmInicioEntr_Load(object sender, EventArgs e)
        {

        }
    }
}
