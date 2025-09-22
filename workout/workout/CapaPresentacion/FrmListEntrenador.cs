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

        private void FrmListEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                CN_Entrenador logicaEntrenador = new CN_Entrenador();
                DataTable entrenadores = logicaEntrenador.ListarEntrenadores();
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

                CN_Entrenador logicaEntrenador = new CN_Entrenador();
                //Pasa los datos a la logica de negocio
                logicaEntrenador.eliminarEntrenador(nombre, apellido);

                // Elimina la fila del DataGridView
                listEntrenadores.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Entrenador eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void listEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
