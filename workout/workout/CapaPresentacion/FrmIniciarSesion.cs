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
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Verifica que el correo y la contraseña sean correctos
            if ((txtCorreoInicioSes.Text == "arielgonzalezr9@gmail.com") && (txtContraseña.Text == "12345"))
            {
                //Llama al formulario de administrador
                FrmInicioAdm frmAdmin = new FrmInicioAdm();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmAdmin.ShowDialog();
                //cierra el formulario anterior
                this.Close();
                
            }else if ((txtCorreoInicioSes.Text == "fatimabret@gmail.com") && (txtContraseña.Text == "12345"))
            {
                //Llama al formulario de recepcionista
                FrmInicioRec frmRecep = new FrmInicioRec();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmRecep.ShowDialog();
                //cierra el formulario anterior
                this.Close();

            }else if ((txtCorreoInicioSes.Text == "bongio22@gmail.com") && (txtContraseña.Text == "12345"))
            {
                FrmInicioEntr frmEntr = new FrmInicioEntr();
                //oculta el formulario actual
                this.Hide();
                //setea el nuevo formulario como el actual
                frmEntr.ShowDialog();
                //cierra el formulario anterior
                this.Close();
            }
            else
            {
                lblCredenciales.Text = "CREDENCIALES INVALIDAS!!!!";
            }
        }
    }
}
