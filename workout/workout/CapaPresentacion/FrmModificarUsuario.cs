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
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*Usuario usuario = new Usuario
            {
                id_usuario = Convert.ToInt32(txtDni.Text),
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                correo = txtCorreo.Text,
                dni = Convert.ToInt32(txtDni.Text),
                id_estado = (rbActivo.Checked) ? 1 : 0,
                detalles = cmbDetalles.SelectedValue.ToString(),
                dias_disp = cmbDias_disp.SelectedValue.ToString(),
                horario_disp = cmbHorario_disp.SelectedValue.ToString(),
                id_entrenador = Convert.ToInt32(cmbDetalles.SelectedValue)
            };

            CN_Usuario logicaUsuario = new CN_Usuario();
            int resultado = logicaUsuario.modificar(usuario);

            if (resultado == 1)
                MessageBox.Show("Usuario actualizado con éxito.");
            else
                MessageBox.Show("Error: el usuario no existe.");
        }
            */
    }
    }
}
