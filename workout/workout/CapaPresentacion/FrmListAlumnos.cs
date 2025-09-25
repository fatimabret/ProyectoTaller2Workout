using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaDatos;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmListAlumnos : Form
    {
        public FrmListAlumnos()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmListAlumnos_Load);
        }
        CN_Alumno logicaAlumno = new CN_Alumno();
        private void FrmListAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable alumnos = logicaAlumno.listarAlumnos();
                listAlumnos.DataSource = alumnos;
                if (alumnos.Rows.Count > 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listAlumnos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message);
            }
        }

        private void listAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaAlumno.eliminarAlumno(nombre, apellido);

                MessageBox.Show("Alumno dado de baja correctamente.");
                this.FrmListAlumnos_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos al formulario de modificar alumno
                this.Hide();
                FrmModificarAlumno modificarAlumno = new FrmModificarAlumno(nombre, apellido);
                modificarAlumno.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            string dniTexto = txtBuscador.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Debe ingresar un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscador.Focus();
                return;
            }

            if (!dniTexto.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscador.Focus();
                return;
            }

            if (dniTexto.Length < 7 || dniTexto.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscador.Focus();
                return;
            }

            int dni = int.Parse(dniTexto);
            try
            {
                DataTable alumno = logicaAlumno.buscarAlumnoDni(dni);
                listAlumnos.DataSource = alumno;
                if (alumno.Rows.Count >= 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listAlumnos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro un alumno registrado: " + ex.Message);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaAlumno.activarAlumno(nombre, apellido);

                MessageBox.Show("Alumno activado correctamente.");
                this.FrmListAlumnos_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picMascota_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
