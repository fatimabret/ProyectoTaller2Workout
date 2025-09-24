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
    public partial class FrmListPago : Form
    {
        public FrmListPago()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmListPago_Load);
        }
        CN_Pago logicaPago = new CN_Pago();
        private void FrmListPago_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable pagos = logicaPago.listarPagos();
                listPagos.DataSource = pagos;

                if (pagos.Rows.Count >= 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listPagos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message);
            }
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtBuscador.Text);

            try
            {
                DataTable pagos = logicaPago.buscarPagosDni(dni);
                listPagos.DataSource = pagos;
                if (pagos.Rows.Count >= 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listPagos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro un pago registrado: " + ex.Message);
            }
        }
    }
}
