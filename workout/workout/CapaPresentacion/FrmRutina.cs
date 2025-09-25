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
    public partial class FrmRutina : Form
    {
        private int dniAlumno;
        public FrmRutina(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void lblEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRutina_Load(object sender, EventArgs e)
        {
            CN_Rutina logicaRutina = new CN_Rutina();
            DataTable datos = logicaRutina.ConsultarRutinaPorDni(dniAlumno);

            lblTitulo.Text = "Rutina de Usuario: " + dniAlumno;

            if (datos.Rows.Count > 0)
            {
                lblDias.Text = "Fecha: " + Convert.ToDateTime(datos.Rows[0]["FechaRutina"]).ToString("dd/MM/yyyy");

                dataGridView1.DataSource = datos;

                // Ocultar columnas que ya mostramos arriba
                if (dataGridView1.Columns.Contains("dni"))
                    dataGridView1.Columns["dni"].Visible = false;
                if (dataGridView1.Columns.Contains("Entrenador"))
                    dataGridView1.Columns["Entrenador"].Visible = false;
                if (dataGridView1.Columns.Contains("Horario"))
                    dataGridView1.Columns["Horario"].Visible = false;
                if (dataGridView1.Columns.Contains("FechaRutina"))
                    dataGridView1.Columns["FechaRutina"].Visible = false;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderText = col.HeaderText.ToUpper();
                }
            }
            else
            {
                lblDias.Text = "";
                lblTitulo.Text = "No tiene una rutina registrada.";
                dataGridView1.DataSource = null;
            }
        }
    }
}
