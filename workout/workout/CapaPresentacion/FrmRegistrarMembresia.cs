using System.IO;                  // FileStream, StringReader
using iTextSharp.text;             // Document, PageSize
using iTextSharp.text.pdf;         // PdfWriter
using iTextSharp.tool.xml;         // XMLWorkerHelper                                   // Para XMLWorkerHelper
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            
            // Cargar plantilla HTML
            string Texto_Html = Properties.Resources.plantilla.ToString();
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
                    DataTable dt = logicaAlumno.buscarAlumnoDni(dniAlumno);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Reemplazar datos desde el DataTable
                        Texto_Html = Texto_Html.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                        Texto_Html = Texto_Html.Replace("@NOMBRE", row["nombre"].ToString());
                        Texto_Html = Texto_Html.Replace("@APELLIDO", row["apellido"].ToString());
                        Texto_Html = Texto_Html.Replace("@DNI", row["dni"].ToString());

                        // Estos dependen de que el SP los devuelva
                        Texto_Html = Texto_Html.Replace("@CORREO", row.Table.Columns.Contains("correo") ? row["correo"].ToString() : "");
                        Texto_Html = Texto_Html.Replace("@MEMBRESIA", resultado.ToString());
                        Texto_Html = Texto_Html.Replace("@METODO", cbMetodoPago.Text);
                        Texto_Html = Texto_Html.Replace("@IMPORTE", montoMembresia.ToString("N2"));
                        Texto_Html = Texto_Html.Replace("@MONTO", montoMembresia.ToString("N2"));

                        // Extras del SP
                        Texto_Html = Texto_Html.Replace("@FECHAPAGO", row["fecha_pago"].ToString());
                        Texto_Html = Texto_Html.Replace("@FECHAVENC", row["fecha_venc"].ToString());
                        Texto_Html = Texto_Html.Replace("@ENTRENADOR", row["Entrenador"].ToString());
                        Texto_Html = Texto_Html.Replace("@ESTADO", row["Estado"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el alumno con ese DNI.");
                    }

                    if (result == DialogResult.Yes)
                    {
                        using (SaveFileDialog saveFile = new SaveFileDialog())
                        {
                            saveFile.Filter = "PDF (*.pdf)|*.pdf";
                            saveFile.FileName = "Comprobante.pdf";

                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();

                                    using (StringReader sr = new StringReader(Texto_Html))
                                    {
                                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                    }

                                    pdfDoc.Close();
                                }

                                MessageBox.Show("PDF generado correctamente en: " + saveFile.FileName,
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                    this.Close();
                
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
