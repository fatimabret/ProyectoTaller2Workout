using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workout.CapaDatos;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarMembresia : Form
    {
        private int dniAlumno;
        private double montoMembresia = 20000;
        public FrmRegistrarMembresia(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
            this.Load += new System.EventHandler(this.FrmRegistrarMembresia_Load);
        }

        private void FrmRegistrarMembresia_Load(object sender, EventArgs e)
        {
            try
            {
                txtMonto.Text = montoMembresia.ToString("C"); // Formato moneda

                // Cargar métodos de pago
                CN_Metodo_Pago logicaMetodoPago = new CN_Metodo_Pago();
                List<Metodo_Pago> metodoPago = logicaMetodoPago.ListarMetodosPago();

                cbMetodoPago.DataSource = metodoPago;
                cbMetodoPago.DisplayMember = "tipo";
                cbMetodoPago.ValueMember = "id_metodo_pago";
                cbMetodoPago.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnRegistrarMembresia_Click(object sender, EventArgs e)
        {
            }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMetodoPago.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un método de pago.");
                    return;
                }

                Membresia nuevaMembresia = new Membresia
                {
                    dni_alumno = dniAlumno,
                    id_metodo_pago = Convert.ToInt32(cbMetodoPago.SelectedValue),
                    monto = montoMembresia
                };

                CN_Membresia cnMembresia = new CN_Membresia();
                int resultado = cnMembresia.RegistrarMembresia(nuevaMembresia);

                if (resultado == -1)
                {
                    MessageBox.Show("El alumno con ese DNI no existe.");
                }
                else
                {
                    MessageBox.Show("Membresía registrada con éxito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar membresía: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
