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
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmModificarUsuario : Form
    {
        private string nombre;
        private string apellido;
            CN_Usuario logicaUsuario = new CN_Usuario();
        public FrmModificarUsuario(string p_nombre, string p_apellido)
        {
            InitializeComponent();
            nombre = p_nombre;
            apellido = p_apellido;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow datos = logicaUsuario.ObtenerUsuario(nombre, apellido);
            if (datos == null)
            {
                MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id_usuario = Convert.ToInt32(datos["id_usuario"]);
            int dni = int.Parse(txtDni.Text);
            string nuevoNombre = txtNom.Text;
            string nuevoApellido = txtApe.Text;
            string correo = txtCorreo.Text;

            logicaUsuario.ModificarUsuario(id_usuario, nuevoNombre, nuevoApellido, dni, correo);

            MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            DataRow datos = logicaUsuario.ObtenerUsuario(nombre, apellido);
            if (datos == null)
            {
                MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNom.Text = datos["nombre"].ToString();
            txtApe.Text = datos["apellido"].ToString();
            txtDni.Text = datos["dni"].ToString();
            txtCorreo.Text = datos["correo"].ToString();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            //Validar que el DNI solo contenga números
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                errorProvider1.SetError(txtDni, "Solo puede contener numeros");
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
