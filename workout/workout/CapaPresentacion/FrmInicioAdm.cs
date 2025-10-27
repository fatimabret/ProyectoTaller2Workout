using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmInicioAdm : Form
    {
        int id_Usuario;
        public FrmInicioAdm(int p_id_Usuario)
        {
            InitializeComponent();
            id_Usuario = p_id_Usuario;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmRegistrarAlumno frm = new FrmRegistrarAlumno();
            frm.ShowDialog();
        }

        private void btnListaAlumnos_Click(object sender, EventArgs e)
        {
            FrmListAlumnos frm = new FrmListAlumnos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            //Oculta el formulario actual
            this.Hide();
            //Setea el nuevo formulario como el actual
            frm.ShowDialog();
            //Cierra el formulario anterior
            this.Close();
        }


        private void btnListaEntrenadores_Click(object sender, EventArgs e)
        {
            //Llama al formulario de membresía
            FrmListEntrenador frm = new FrmListEntrenador();

            frm.ShowDialog();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            // Si está vacío
            if (string.IsNullOrEmpty(dni))
            {
                errorProvider1.SetError(txtDni, "El DNI es obligatorio");
                return;
            }

            // Si la longitud no es válida
            if (dni.Length < 7 || dni.Length > 8)
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos");
                return;
            }

            // Si es correcto
            errorProvider1.SetError(txtDni, "");
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el caracter
            }
        }
        private bool DniValido()
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Debe ingresar un DNI.");
                return false;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números.");
                return false;
            }
            // Si la longitud no es válida
            if (dni.Length < 7 || dni.Length > 8)
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos");
                return false;
            }
            return true;
        }
        private void btnConsultarPago_Click(object sender, EventArgs e)
        {
            if (!DniValido()) return;

            //Llama al formulario de pago
            int dni = int.Parse(txtDni.Text);
            FrmPago frm = new FrmPago(dni);
            frm.ShowDialog();
        }

        private void btnListaPagos_Click(object sender, EventArgs e)
        {
            FrmListPago listaPagos = new FrmListPago();
            this.Hide();
            listaPagos.ShowDialog();
            this.Show();
        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            FrmListaUsuarios listaUsuarios = new FrmListaUsuarios(id_Usuario);
            this.Hide();
            listaUsuarios.ShowDialog();
            this.Show();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            int id_rol = 1;
            FrmRegistrarUsuario registrarUsuario = new FrmRegistrarUsuario(id_rol);
            registrarUsuario.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // fecha y hora (ej: workout_backup_2025-10-06_21-45-32.bak)
            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss");
            string nombreArchivo = $"workout_backup_{fechaHora}.bak";

            SaveFileDialog seleccionabk = new SaveFileDialog();
            seleccionabk.Filter = "Archivo de respaldo (*.bak)|*.bak";
            seleccionabk.InitialDirectory = @"C:\Taller\workout\workout\ScriptBD\backup";
            seleccionabk.Title = "Selecciona dónde guardar el respaldo";
            seleccionabk.FileName = nombreArchivo;

            if (seleccionabk.ShowDialog() == DialogResult.OK)
            {
                string ruta = seleccionabk.FileName;

                // Conexión al servidor SQL Server
                string cadena = "Data Source=DESKTOP-80HNL37;Initial Catalog=master;Integrated Security=True;";

                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        conexion.Open();

                        string sqlBackup = $@"
                            BACKUP DATABASE workout
                            TO DISK = '{ruta}'
                            WITH INIT, STATS = 10;
                        ";

                        using (SqlCommand cmd = new SqlCommand(sqlBackup, conexion))
                        {
                            cmd.CommandTimeout = 600; // por si la BD es grande
                            cmd.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Backup realizado con éxito.\nArchivo: {nombreArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccionaRestore = new OpenFileDialog();
            seleccionaRestore.Filter = "Archivo de respaldo (*.bak)|*.bak";
            seleccionaRestore.InitialDirectory = @"C:\backups";
            seleccionaRestore.Title = "Selecciona el archivo de respaldo";

            if (seleccionaRestore.ShowDialog() == DialogResult.OK)
            {
                string ruta = seleccionaRestore.FileName;
                string cadena = "Data Source=DESKTOP-80HNL37;Initial Catalog=master;Integrated Security=True;";

                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        conexion.Open();

                        // 1Poner la base en modo usuario unico para liberar conexiones
                        string setSingleUser = "ALTER DATABASE workout SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                        new SqlCommand(setSingleUser, conexion).ExecuteNonQuery();

                        // Restaurar la base desde el archivo .bak
                        string restoreSql = $@"
                            RESTORE DATABASE workout
                            FROM DISK = '{ruta}'
                            WITH REPLACE, STATS = 10;
                        ";
                        new SqlCommand(restoreSql, conexion).ExecuteNonQuery();

                        //vuelve a multi usuario
                        string setMultiUser = "ALTER DATABASE workout SET MULTI_USER;";
                        new SqlCommand(setMultiUser, conexion).ExecuteNonQuery();

                        MessageBox.Show("Base de datos restaurada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restaurar el backup: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmInicioAdm_Load(object sender, EventArgs e)
        {
            try
            {
                CN_Alumno logicaAlumno = new CN_Alumno();
                DataTable dt = logicaAlumno.ListarAlumnosConCuotaVencida();

                if (dt.Rows.Count > 0)
                {
                    string mensaje = "⚠️ Alumnos con cuota vencida:\n\n";
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row["nombre"].ToString();
                        string apellido = row["apellido"].ToString();
                        string fechaVenc = row["ultima_fecha_venc"] == DBNull.Value
                            ? "sin membresía"
                            : Convert.ToDateTime(row["ultima_fecha_venc"]).ToShortDateString();

                        mensaje += $"{apellido}, {nombre} - Venció: {fechaVenc}\n";
                    }

                    MessageBox.Show(mensaje, "Aviso de cuotas vencidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No hay alumnos con cuotas vencidas 👌", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReportEstadist_Click(object sender, EventArgs e)
        {
            FrmReporteEstadistica reporteEstadistica = new FrmReporteEstadistica();
            this.Hide();
            reporteEstadistica.ShowDialog();
            this.Show();
        }
    }
}
