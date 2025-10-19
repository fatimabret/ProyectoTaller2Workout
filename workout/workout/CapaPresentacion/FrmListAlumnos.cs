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
using System.IO;                  // FileStream, StringReader
using iTextSharp.text;             // Document, PageSize
using iTextSharp.text.pdf;         // PdfWriter
using iTextSharp.tool.xml;         // XMLWorkerHelper                                   // Para XMLWorkerHelper

namespace workout.CapaPresentacion
{
    public partial class FrmListAlumnos : Form
    {
        public FrmListAlumnos()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmListAlumnos_Load);
        }
        CN_Alumno logicaAlumno = new CN_Alumno();
        private void FrmListAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable alumnos = logicaAlumno.listarAlumnos();
                listAlumnos.DataSource = alumnos;
                if (alumnos.Rows.Count > 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listAlumnos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message);
            }
        }

        private void listAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaAlumno.eliminarAlumno(nombre, apellido);

                MessageBox.Show("Alumno dado de baja correctamente.");
                this.FrmListAlumnos_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos al formulario de modificar alumno
                this.Hide();
                FrmModificarAlumno modificarAlumno = new FrmModificarAlumno(nombre, apellido);
                modificarAlumno.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
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
                DataTable alumno = logicaAlumno.buscarAlumnoDni(dni);
                listAlumnos.DataSource = alumno;
                if (alumno.Rows.Count >= 0)
                {
                    // Convertir todos los encabezados a mayúsculas
                    foreach (DataGridViewColumn col in listAlumnos.Columns)
                    {
                        col.HeaderText = col.HeaderText.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro un alumno registrado: " + ex.Message);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow != null)
            {
                //Obtiene el indice de la fila seleccionada
                int rowIndex = listAlumnos.CurrentCell.RowIndex;
                //obtiene el nombre y apellido de la fila seleccionada
                var nombre = listAlumnos.Rows[rowIndex].Cells[1].Value?.ToString();
                var apellido = listAlumnos.Rows[rowIndex].Cells[2].Value?.ToString();
                //Pasa los datos a la logica de negocio
                logicaAlumno.activarAlumno(nombre, apellido);

                MessageBox.Show("Alumno activado correctamente.");
                this.FrmListAlumnos_Load(sender, e); // Recarga la lista de entrenadores
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picMascota_Click(object sender, EventArgs e)
        {

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
            this.FrmListAlumnos_Load(sender, e); // Recarga la lista de alumnos

        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (listAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un alumno.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener DNI desde la fila seleccionada
                int dniAlumno = Convert.ToInt32(listAlumnos.CurrentRow.Cells["dni"].Value);

                // Buscar los datos del último pago real del alumno
                CN_Membresia logicaMembresia = new CN_Membresia();
                DataTable dtPago = logicaMembresia.ObtenerUltimoPagoPorDni(dniAlumno);

                if (dtPago == null || dtPago.Rows.Count == 0)
                {
                    MessageBox.Show("El alumno no tiene pagos registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow datosPago = dtPago.Rows[0];

                // Buscar datos personales del alumno
                DataTable dtAlumno = logicaAlumno.buscarAlumnoDni(dniAlumno);
                if (dtAlumno == null || dtAlumno.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos del alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataRow rowAlumno = dtAlumno.Rows[0];

                // Cargar plantilla HTML
                string textoHtml = Properties.Resources.plantilla.ToString();
                string estadoTexto = Convert.ToInt32(datosPago["id_estado"]) == 1 ? "VIGENTE" : "VENCIDA";

                // Reemplazar variables con datos reales
                textoHtml = textoHtml.Replace("@FECHA", Convert.ToDateTime(datosPago["fecha_pago"]).ToString("dd/MM/yyyy"));
                textoHtml = textoHtml.Replace("@NOMBRE", rowAlumno["nombre"].ToString());
                textoHtml = textoHtml.Replace("@APELLIDO", rowAlumno["apellido"].ToString());
                textoHtml = textoHtml.Replace("@DNI", rowAlumno["dni"].ToString());
                textoHtml = textoHtml.Replace("@CORREO", rowAlumno.Table.Columns.Contains("correo") ? rowAlumno["correo"].ToString() : "");
                textoHtml = textoHtml.Replace("@MEMBRESIA", datosPago["id_membresia"].ToString());
                textoHtml = textoHtml.Replace("@METODO", datosPago["modo_pago"].ToString());
                textoHtml = textoHtml.Replace("@IMPORTE", Convert.ToDecimal(datosPago["importe"]).ToString("N2"));
                textoHtml = textoHtml.Replace("@MONTO", Convert.ToDecimal(datosPago["importe"]).ToString("N2"));
                textoHtml = textoHtml.Replace("@ESTADO", estadoTexto);

                // Generar PDF
                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    saveFile.Filter = "PDF (*.pdf)|*.pdf";
                    saveFile.FileName = $"Comprobante_{rowAlumno["apellido"]}_{rowAlumno["nombre"]}.pdf";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            using (StringReader sr = new StringReader(textoHtml))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                        }

                        MessageBox.Show("PDF generado correctamente en:\n" + saveFile.FileName,
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
