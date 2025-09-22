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
    public partial class FrmMembresia : Form
    {
        private int dniAlumno;
        public FrmMembresia(int dni)
        {
            InitializeComponent();
            dniAlumno = dni;
        }
        private void frmMembresia_Load(object sender, EventArgs e)
        {
            CN_Membresia logicaMembresia = new CN_Membresia();
            Membresia datosMembresia = logicaMembresia.ObtenerMembresiaPorDni(dniAlumno);

            if (datosMembresia != null)
            {
                lblPagado.Text = "Pagado el " + datosMembresia.fecha_pago.ToString("dd/MM/yyyy");
                lblVence.Text = "Vence el " + datosMembresia.fecha_venc.ToString("dd/MM/yyyy");
                lblPrecio.Text = "Monto abonado: $" + datosMembresia.monto.ToString("N2");
                lblEstado.Text = "¡Estado " + (datosMembresia.id_estado == 1 ? "VIGENTE!" : "VENCIDA!");
                lblDni.Text = "DNI Alumno: " + dniAlumno;
            }
            else
            {
                lblDni.Text = "";
                lblPagado.Text = "No tiene membresía registrada";
                lblVence.Text = "";
                lblPrecio.Text = "";
                lblEstado.Text = "¡Estado: Sin membresía!";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
