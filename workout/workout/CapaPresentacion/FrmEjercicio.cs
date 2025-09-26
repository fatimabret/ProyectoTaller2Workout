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
    public partial class FrmEjercicio : Form
    {
        private int dniAlumno;

        public FrmEjercicio(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void picMascota_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEjercicio_Load(object sender, EventArgs e)
        {
            CN_Rutina logicaRutina = new CN_Rutina();

            try
            {
                DataTable rutina = logicaRutina.ConsultarRutinaPorDni(dniAlumno);
                listaRutina.DataSource = rutina;
                if (rutina.Rows.Count > 0)
                {
                    lblTitulo.Text = "Rutina de Usuario: " + dniAlumno;

                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listaRutina.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
                else
                {
                    lblTitulo.Text = "No tiene una rutina registrada.";
                    listaRutina.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void lblEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }
    }
}
