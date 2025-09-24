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
    }
}
