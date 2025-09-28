using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaDatos;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarEntrenador : Form
    {
        int dni;
        string nombre;
        string apellido;
        string contrasena;
        string correo;
        int id_rol;
        //Variable de la logica de negocios
        CN_Entrenador logicaEntrenador = new CN_Entrenador();
        public FrmRegistrarEntrenador(int p_dni, string p_nombre,string  p_apellido, string p_contrasena, string p_correo, int p_id_rol)
        {
            InitializeComponent();
            dni = p_dni;
            nombre = p_nombre;
            apellido = p_apellido;
            contrasena = p_contrasena;
            correo = p_correo;
            id_rol = p_id_rol;
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        { }
        private void lblTitulo_Click(object sender, EventArgs e)
        { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { }
        private void cmbHorarioDisponible_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void cmbEspecializacion_SelectedIndexChanged(object sender, EventArgs e)
        { }
   
        private void FrmRegistrarEntrenador_Load(object sender, EventArgs e)
        {
            // Configurar los ComboBox para que no permitan edición manual
            cmbHorarioDisponible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiasDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecializacion.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cargar opciones de Horario
            cmbHorarioDisponible.Items.AddRange(new string[]
            {
                "Mañana (08:00 - 12:00)",
                "Tarde (14:00 - 18:00)",
                "Noche (18:00 - 22:00)"
            });

            // Cargar opciones de Días
            cmbDiasDisponibles.Items.AddRange(new string[]
            {
                "Lunes a Viernes",
                "Lunes, Miércoles y Viernes",
                "Martes y Jueves",
                "Sábados"
            });

            // Cargar opciones de Especialización
            cmbEspecializacion.Items.AddRange(new string[]
            {
                "Musculación",
                "Crossfit",
                "Pilates",
                "Cardio Funcional"
            });

            // Seleccionar la primera opción por defecto (índice 0)
            cmbHorarioDisponible.SelectedIndex = 0;
            cmbDiasDisponibles.SelectedIndex = 0;
            cmbEspecializacion.SelectedIndex = 0;
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            string horario_disp = cmbHorarioDisponible.SelectedItem?.ToString();
            string dias_disp = cmbDiasDisponibles.SelectedItem?.ToString();
            string detalles = cmbEspecializacion.SelectedItem.ToString();

            try
            {
                //Le pasa los datos a la logica de negocio
                int id_entrenador = logicaEntrenador.RegistrarEntrenador(
                    nombre, apellido, dni, correo, contrasena, horario_disp, dias_disp,
                    detalles);

                if (id_entrenador > 0)
                    MessageBox.Show("Entrenador registrado con éxito");
                else
                    MessageBox.Show("El entrenador fue registrado previamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
