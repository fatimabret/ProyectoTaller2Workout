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

        }
    }
}
