using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarEjercicio : Form
    {
        private int idEntrenador;
        public FrmRegistrarEjercicio(int idEntrenador)
        {
            InitializeComponent();
            this.idEntrenador = idEntrenador;
        }

        private void FrmRegistrarEjercicio_Load(object sender, EventArgs e)
        {

        }

        private void txtSeries_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRepeticiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMinuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRepeticiones_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMinutos_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEjercicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRepeticiones.Clear();
            txtSeries.Clear();
            txtEjercicio.Clear();
            txtMinutos.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEjercicio.Text) ||
                    string.IsNullOrWhiteSpace(txtSeries.Text) ||
                    string.IsNullOrWhiteSpace(txtRepeticiones.Text) ||
                    string.IsNullOrWhiteSpace(txtMinutos.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir valores numéricos
                int series = int.Parse(txtSeries.Text);
                int repeticiones = int.Parse(txtRepeticiones.Text);
                int descanso = int.Parse(txtMinutos.Text);

                // Crear objeto Ejercicio con el idEntrenador
                Ejercicio nuevoEjercicio = new Ejercicio
                {
                    descripcion = txtEjercicio.Text,
                    serie = series,
                    repeticion = repeticiones,
                    descanso = descanso,
                    id_entrenador = idEntrenador // 🔹 viene del constructor
                };

                CN_Ejercicio logicaEjercicio = new CN_Ejercicio();
                int idEjercicio = logicaEjercicio.RegistrarEjercicio(nuevoEjercicio);

                if (idEjercicio > 0)
                {
                    MessageBox.Show("Ejercicio registrado con éxito. ID: " + idEjercicio, "Éxito");
                    btnLimpiar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error al registrar el ejercicio.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
