using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            if (cmbDetalles.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una especialización.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            // Configuración de combos (ya lo tenías)
            cmbHorario_disp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDias_disp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDetalles.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbHorario_disp.Items.AddRange(new string[]
            {
                "Mañana (08:00 - 12:00)",
                "Tarde (14:00 - 18:00)",
                "Noche (18:00 - 22:00)"
            });

            cmbDias_disp.Items.AddRange(new string[]
            {
                "Lunes a Viernes",
                "Lunes, Miércoles y Viernes",
                "Martes y Jueves",
                "Sábados"
            });

            cmbDetalles.Items.AddRange(new string[]
            {
                "Musculación",
                "Crossfit",
                "Pilates",
                "Cardio Funcional"
            });

            // 1. Buscar ID entrenador
            int id_entrenador = logicaEntrenador.buscarEntrenador(nombre, apellido);
            if (id_entrenador <= 0) return;

            // 2. Obtener datos del entrenador
            DataRow datos = logicaEntrenador.obtenerEntrenadorPorId(id_entrenador);

            if (datos != null)
            {
                txtNom.Text = datos["nombre"].ToString();
                txtApe.Text = datos["apellido"].ToString();
                txtDni.Text = datos["dni"].ToString();
                txtCorreo.Text = datos["correo"].ToString();

                hsCupo.Value = Convert.ToInt32(datos["cupo"]);
                lblCupoVal.Text = datos["cupo"].ToString();

                cmbHorario_disp.SelectedItem = datos["horario_disp"].ToString();
                cmbDias_disp.SelectedItem = datos["dias_disp"].ToString();
                cmbDetalles.SelectedItem = datos["detalles"].ToString();
            }

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //Validar que el nombre solo contenga letras
            if (int.TryParse(txtNom.Text, out int nombre))
            {
                errorProvider1.SetError(txtNom, "Solo puede contener letras de A-Z");
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                errorProvider1.SetError(txtDni, "Solo puede contener numeros");
            }
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            //Validar que el apellido solo contenga letras
            if (int.TryParse(txtApe.Text, out int nombre))
            {
                errorProvider1.SetError(txtApe, "Solo puede contener letras de A-Z");
            }
        }
        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            // Validar Correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar un correo electrónico");
                return;
            }
            else if (!EsCorreoValido(txtCorreo.Text.Trim()))
            {
                errorProvider1.SetError(txtCorreo, "Formato de correo inválido");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }
    }
}
