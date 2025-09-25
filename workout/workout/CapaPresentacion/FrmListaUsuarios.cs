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
        public FrmListaUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtBuscador.Text);
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
                DataTable usuarios = logicaUsuario.listarUsuarios();
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
                MessageBox.Show("Error al cargar alumnos: " + ex.Message);
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

                MessageBox.Show("Alumno dado de baja correctamente.");
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

                MessageBox.Show("Alumno activado correctamente.");
                this.FrmListaUsuarios_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }
    }
}
