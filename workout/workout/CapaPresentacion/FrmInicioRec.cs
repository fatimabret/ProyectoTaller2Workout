using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmInicioRec : Form
    {
        public FrmInicioRec(int id_Usuario)
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
            // Si la longitud no es válida
            if (dni.Length < 7 || dni.Length > 8)
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos");
                return false;
            }
            return true;
        }
        private void btnConsultarMembresia_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            if (!DniValido()) return;

            //Llama al formulario de membresía
            int dni = int.Parse(txtDni.Text);
            FrmMembresia frm = new FrmMembresia(dni);
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

        private void btnRenovarMembresia_Click(object sender, EventArgs e)
        {
            if (!DniValido()) return;

            int dni = int.Parse(txtDni.Text.Trim());
            CN_Membresia cnMembresia = new CN_Membresia();
            int estadoMembresia = cnMembresia.BuscarMembresiaPorDni(dni);

            if (estadoMembresia == -3)
            {
                MessageBox.Show("No existe un alumno con ese DNI.");
            }
            else if (estadoMembresia == -2)
            {
                MessageBox.Show("El alumno ya tiene una membresía vigente.");
            }
            else if (estadoMembresia == -1)
            {
                FrmRegistrarMembresia frm = new FrmRegistrarMembresia(dni);
                frm.ShowDialog();
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            int id_rol = 2;
            FrmRegistrarUsuario registrarUsuario = new FrmRegistrarUsuario(id_rol);
            registrarUsuario.ShowDialog();
        }

        private void FrmInicioRec_Load(object sender, EventArgs e)
        {
            try
            {
                CN_Alumno logicaAlumno = new CN_Alumno();
                DataTable dt = logicaAlumno.ListarAlumnosConCuotaVencida();

                if (dt.Rows.Count > 0)
                {
                    string mensaje = "⚠️ Alumnos con cuota vencida:\n\n";
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row["nombre"].ToString();
                        string apellido = row["apellido"].ToString();
                        string fechaVenc = row["ultima_fecha_venc"] == DBNull.Value
                            ? "sin membresía"
                            : Convert.ToDateTime(row["ultima_fecha_venc"]).ToShortDateString();

                        mensaje += $"{apellido}, {nombre} - Venció: {fechaVenc}\n";
                    }

                    MessageBox.Show(mensaje, "Aviso de cuotas vencidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No hay alumnos con cuotas vencidas 👌", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
