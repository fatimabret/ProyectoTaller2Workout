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
using System.Windows.Forms.DataVisualization.Charting;

namespace workout.CapaPresentacion
{
    public partial class FrmReporteEstadistica : Form
    {
        public FrmReporteEstadistica()
        {
            InitializeComponent();
        }

        private void lblNuevosAlum_Click(object sender, EventArgs e)
        {

        }

        private void FrmReporteEstadistica_Load(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            try
            {
                CN_Reportes logica = new CN_Reportes();
                DataSet ds = logica.GenerarReporte(desde, hasta);

                if (ds.Tables.Count < 2)
                {
                    MessageBox.Show("No se devolvieron datos del reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable grafico = ds.Tables[0];
                DataTable resumen = ds.Tables[1];

                // Cargar gráfico
                chartPagos.Series.Clear();
                chartPagos.Titles.Clear();

                Series serie = new Series("Recaudación Diaria");
                serie.ChartType = SeriesChartType.Column;
                serie.XValueType = ChartValueType.Date;

                foreach (DataRow row in grafico.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(row["Fecha"]);
                    double total = Convert.ToDouble(row["TotalRecaudado"]);
                    serie.Points.AddXY(fecha.ToShortDateString(), total);
                }

                chartPagos.Series.Add(serie);
                chartPagos.ChartAreas[0].AxisX.Title = "Fecha";
                chartPagos.ChartAreas[0].AxisY.Title = "Monto ($)";
                chartPagos.ChartAreas[0].AxisX.Interval = 1;
                chartPagos.Titles.Add($"Recaudación diaria por membresías entre {dtpDesde.Value:dd/MM/yyyy} y {dtpHasta.Value:dd/MM/yyyy}");

                // Mostrar totales
                DataRow r = resumen.Rows[0];
                lblTotalRecaudado.Text = $"Total Recaudado: ${r["TotalRecaudado"]:N2}";
                lblNuevosAlum.Text = $"Nuevos alumnos: {r["NuevosAlumnos"]}";
                lblBajas.Text = $"Bajas: {r["Bajas"]}";
                lblAltas.Text = $"Altas: {r["Altas"]}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblTotalRecaudado_Click(object sender, EventArgs e)
        {

        }

        private void lblAltas_Click(object sender, EventArgs e)
        {

        }

        private void lblBajas_Click(object sender, EventArgs e)
        {

        }

        private void chartPagos_Click(object sender, EventArgs e)
        {

        }
    }
}
