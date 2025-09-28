using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            // Configurar los ComboBox para que no permitan edición manual
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            

            // Cargar opciones de Rol
            cmbRol.Items.AddRange(new string[]
            {
                "Administrador",
                "Entrenador",
                "Recepcionista"
            });

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNom.Text.Trim();
            string apellido = txtApe.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            int id_rol;
            
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato numérico válido.",
                "Error de formato",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }

            if (cmbRol.SelectedItem?.ToString() == "Recepcionista")
            {
                id_rol = 2; // Rol de recepcionista
            }else if (cmbRol.SelectedItem?.ToString() == "Administrador")
            {
                id_rol = 1; // Rol de administrador
            }
            else
            {
                id_rol = 3; // Rol de entrenador
                FrmRegistrarEntrenador frmRegistrarEntrenador = new FrmRegistrarEntrenador(dni,nombre,apellido,contrasena,correo,id_rol);
                frmRegistrarEntrenador.ShowDialog();
            }

            if (id_rol != 3)
            {
                try
                {
                    // Crear objeto usuario
                    Usuario nuevoUsuario = new Usuario(nombre, apellido, dni, correo, contrasena, id_rol);

                    //Le pasa los datos a la logica de negocio
                    CN_Usuario logicaUsuario = new CN_Usuario();
                    int id_usuario = logicaUsuario.registrarUsuario(nuevoUsuario);

                    if (id_usuario > 0)
                        MessageBox.Show("Usuario registrado con éxito");
                    else
                        MessageBox.Show("El Usuario fue registrado previamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }
        
    }
}
