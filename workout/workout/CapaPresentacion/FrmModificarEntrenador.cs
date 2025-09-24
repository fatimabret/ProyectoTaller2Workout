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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace workout.CapaPresentacion
{
    public partial class FrmModificarEntrenador : Form
    {
        private string nombre;
        private string apellido;
        CN_Entrenador logicaEntrenador = new CN_Entrenador();
        public FrmModificarEntrenador(string p_nombre, string p_apellido)
        {
            InitializeComponent();
            nombre = p_nombre;
            apellido = p_apellido;
            // Configuración inicial
            hsCupo.Minimum = 0;
            hsCupo.Maximum = 15;
            hsCupo.SmallChange = 1;
            hsCupo.LargeChange = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id_entrenador = logicaEntrenador.buscarEntrenador(nombre, apellido);
            if (id_entrenador <= 0)
            {
                MessageBox.Show("No se encontró el entrenador seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cupo = int.Parse(lblCupoVal.Text);
            string horario_disp = cmbHorario_disp.SelectedItem?.ToString();
            string dias_disp = cmbDias_disp.SelectedItem?.ToString();
            string detalles = cmbDetalles.SelectedItem.ToString();
            logicaEntrenador.modificarEntrenador(id_entrenador,cupo, horario_disp, dias_disp, detalles);
            FrmListEntrenador listaEntrenadores = new FrmListEntrenador();
            this.Hide();
            listaEntrenadores.ShowDialog();
            this.Close();
        }

        private void hsCupo_Scroll(object sender, ScrollEventArgs e)
        {
            lblCupoVal.Text = "" + hsCupo.Value;
        }

        private void FrmModificarEntrenador_Load(object sender, EventArgs e)
        {
            // Configurar los ComboBox para que no permitan edición manual
            cmbHorario_disp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDias_disp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDetalles.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cargar opciones de Horario
            cmbHorario_disp.Items.AddRange(new string[]
            {
                "Mañana (08:00 - 12:00)",
                "Tarde (14:00 - 18:00)",
                "Noche (18:00 - 22:00)"
            });

            // Cargar opciones de Días
            cmbDias_disp.Items.AddRange(new string[]
            {
                "Lunes a Viernes",
                "Lunes, Miércoles y Viernes",
                "Martes y Jueves",
                "Sábados"
            });

            // Cargar opciones de Especialización
            cmbDetalles.Items.AddRange(new string[]
            {
                "Musculación",
                "Crossfit",
                "Pilates",
                "Cardio Funcional"
            });

            // Seleccionar la primera opción por defecto (índice 0)
            cmbHorario_disp.SelectedIndex = 0;
            cmbDias_disp.SelectedIndex = 0;
            cmbDetalles.SelectedIndex = 0;
        }
    }
}
