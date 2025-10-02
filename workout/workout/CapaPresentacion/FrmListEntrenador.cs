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
    public partial class FrmListEntrenador : Form
    {
        public FrmListEntrenador()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmListEntrenador_Load);
        }
        CN_Entrenador logicaEntrenador = new CN_Entrenador();
        private void FrmListEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable entrenadores = logicaEntrenador.listarEntrenadores();
                listEntrenadores.DataSource = entrenadores;

                if (entrenadores.Rows.Count > 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listEntrenadores.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar entrenadores: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listEntrenadores.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listEntrenadores.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listEntrenadores.Rows[rowIndex].Cells[0].Value?.ToString();
                var apellido = listEntrenadores.Rows[rowIndex].Cells[1].Value?.ToString();
               
                
                //Pasa los datos a la logica de negocio
                logicaEntrenador.eliminarEntrenador(nombre, apellido);

                MessageBox.Show("Entrenador eliminado correctamente.");
                this.FrmListEntrenador_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void listEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                DataTable entrenador = logicaEntrenador.buscarEntrenadorDni(dni);
                listEntrenadores.DataSource = entrenador;
                if (entrenador.Rows.Count >= 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listEntrenadores.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro un entrenador registrado: " + ex.Message);
            }
        }


        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listEntrenadores.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listEntrenadores.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listEntrenadores.Rows[rowIndex].Cells[0].Value?.ToString();
                var apellido = listEntrenadores.Rows[rowIndex].Cells[1].Value?.ToString();
                //Pasa los datos al formulario de modificar alumno
                this.Hide();
                FrmModificarEntrenador modificarUsuario = new FrmModificarEntrenador(nombre, apellido);
                modificarUsuario.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listEntrenadores.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listEntrenadores.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listEntrenadores.Rows[rowIndex].Cells[0].Value?.ToString();
                var apellido = listEntrenadores.Rows[rowIndex].Cells[1].Value?.ToString();


                //Pasa los datos a la logica de negocio
                logicaEntrenador.activarEntrenador(nombre, apellido);

                MessageBox.Show("Entrenador activado correctamente.");
                this.FrmListEntrenador_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.FrmListEntrenador_Load(sender, e); // Recarga la lista de entrenadores
        }
    }
}
