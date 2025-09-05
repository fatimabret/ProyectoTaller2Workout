using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout.CapaPresentacion
{
    public partial class FrmMembresia : Form
    {
        public FrmMembresia()
        {
            InitializeComponent();
        }
        private void frmMembresia_Load(object sender, EventArgs e)
        {
            lblPagado.Text = "Pagado el " + DateTime.Now.ToString("dd/MM/yyyy");
            lblVence.Text = "Vence el " + DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");
            lblPrecio.Text = "Precio de la cuota a Pagar: $5000";
        }
    }
}
