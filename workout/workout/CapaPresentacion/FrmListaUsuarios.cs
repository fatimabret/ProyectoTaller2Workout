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
    public partial class FrmListaUsuarios : Form
    {
        CN_Usuario logicaUsuario = new CN_Usuario();
        int id_Usuario;
        public FrmListaUsuarios(int p_id_Usuario)
        {
            InitializeComponent();
            id_Usuario = p_id_Usuario;
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
                DataTable usuario = logicaUsuario.buscarUsuarioDni(dni);
                listUsuarios.DataSource = usuario;
                if (usuario.Rows.Count >= 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listUsuarios.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro un usuario registrado: " + ex.Message);
            }
        }

        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable usuarios = logicaUsuario.listarUsuarios(id_Usuario);
                listUsuarios.DataSource = usuarios;
                if (usuarios.Rows.Count > 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listUsuarios.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listUsuarios.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listUsuarios.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listUsuarios.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listUsuarios.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaUsuario.eliminarUsuario(nombre, apellido);

                MessageBox.Show("Usuario dado de baja correctamente.");
                this.FrmListaUsuarios_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            if (listUsuarios.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listUsuarios.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listUsuarios.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listUsuarios.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaUsuario.activarUsuario(nombre, apellido);

                MessageBox.Show("Usuario activado correctamente.");
                this.FrmListaUsuarios_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea caracteres no numéricos
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.FrmListaUsuarios_Load(sender, e); // Recarga la lista de usuarios
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listUsuarios.CurrentRow != null)
            {
                int rowIndex = listUsuarios.CurrentCell.RowIndex;
                string nombre = listUsuarios.Rows[rowIndex].Cells["nombre"].Value?.ToString();
                string apellido = listUsuarios.Rows[rowIndex].Cells["apellido"].Value?.ToString();
                string rol = listUsuarios.Rows[rowIndex].Cells["Rol"].Value?.ToString();

                this.Hide();

                if (rol == "Entrenador")
                {
                    FrmModificarEntrenador frm = new FrmModificarEntrenador(nombre, apellido);
                    frm.ShowDialog();
                }
                else // Administrador o Recepcionista
                {
                    FrmModificarUsuario frm = new FrmModificarUsuario(nombre, apellido);
                    frm.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

    }
}
