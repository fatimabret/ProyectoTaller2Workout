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
    public partial class FrmPago : Form
    {
        private int dniAlumno;
        public FrmPago(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            CN_Pago logicaPago = new CN_Pago();
            Pago datosPago = logicaPago.obtenerUltimoPagoPorDni(dniAlumno);

            if (datosPago != null)
            {
                lblPagado.Text = "Pagado el " + datosPago.fecha_pago.ToString("dd/MM/yyyy");
                lblVence.Text = "Vence el " + datosPago.fecha_venc.ToString("dd/MM/yyyy");
                lblPrecio.Text = "Monto abonado: $" + datosPago.importe.ToString("N2");
                lblEstado.Text = "¡Estado " + (datosPago.id_estado == 1 ? "VIGENTE!" : "VENCIDA!") + "!";
                lblDni.Text = "DNI Alumno: " + dniAlumno;
                lblModoPago.Text = "Modo de Pago: " + datosPago.modo_pago;
            }
            else
            {
                lblDni.Text = "";
                lblPagado.Text = "No tiene pagos registrados";
                lblVence.Text = "";
                lblPrecio.Text = "";
                lblEstado.Text = "¡Estado: Sin Pagos!";
                lblModoPago.Text = "";
            }
        }
    }
}
