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
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dd/MM/yyyy";
            dtpDesde.Width = 100; // lo hace más angosto

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd/MM/yyyy";
            dtpHasta.Width = 100;

            // Configurar los ComboBox para que no permitan edición manual
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cargar opciones de Especialización
            cmbEstado.Items.AddRange(new string[]
            {
                "Activo",
                "Inactivo"
            });

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
            string dniTexto = txtBuscador.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Debe ingresar un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscador.Focus();
                return;
            }

            if (!dniTexto.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscador.Focus();
                return;
            }

            if (dniTexto.Length < 7 || dniTexto.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscador.Focus();
                return;
            }

            int dni = int.Parse(dniTexto);

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

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.FrmListPago_Load(sender, e); // Recarga la lista de pagos
        }

    }
}
