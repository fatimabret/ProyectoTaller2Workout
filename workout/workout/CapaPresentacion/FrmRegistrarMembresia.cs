using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using workout.CapaDatos;
using workout.CapaEntidad;
using workout.CapaNegocio;

namespace workout.CapaPresentacion
{
    public partial class FrmRegistrarMembresia : Form
    {
        private int dniAlumno;
        private double montoMembresia = 20000;
        CN_Alumno logicaAlumno = new CN_Alumno();
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
                    var result = MessageBox.Show("Membresía registrada con éxito.\n\n¿Desea generar el comprobante?",
                        "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //Alumno alumno = logicaAlumno.buscarAlumnoDni(dniAlumno);
                    if (result == DialogResult.Yes)
                    {
                        // Cargar plantilla HTML
                        string Texto_Html = Properties.Resources.plantilla.ToString();

                        // Reemplazar datos
                        Texto_Html = Texto_Html.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                        //Texto_Html = Texto_Html.Replace("@NOMBRE", textNombre.Text);
                        //Texto_Html = Texto_Html.Replace("@APELLIDO", textApellido.Text);
                        Texto_Html = Texto_Html.Replace("@DNI", dniAlumno.ToString());
                        //Texto_Html = Texto_Html.Replace("@CORREO", textCorreo.Text);
                        Texto_Html = Texto_Html.Replace("@MEMBRESIA", resultado.ToString());
                        //Texto_Html = Texto_Html.Replace("@CATEGORIA", cbCategoria.Text);
                        Texto_Html = Texto_Html.Replace("@METODO", cbMetodoPago.Text);
                        Texto_Html = Texto_Html.Replace("@IMPORTE", montoMembresia.ToString("N2"));
                        Texto_Html = Texto_Html.Replace("@MONTO", montoMembresia.ToString("N2"));

                        SaveFileDialog guardar = new SaveFileDialog();
                        guardar.FileName = string.Format("Comprobante_{0}.pdf", resultado);
                        guardar.Filter = "PDF Files | *.pdf";

                        if (guardar.ShowDialog() == DialogResult.OK)
                        {
                            // Crear PDF
                            PdfDocument pdf = new PdfDocument();
                            //PdfGenerator.AddPdfPages(pdf, Texto_Html, PdfSharp.PageSize.A4);

                            // Guardar PDF
                            pdf.Save(guardar.FileName);

                            MessageBox.Show("PDF generado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Membresía registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
