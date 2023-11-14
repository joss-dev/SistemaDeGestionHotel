using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaDeGestionHotel.views.Reportes
{
    public partial class ReporteSsAdicionales : Form
    {
        RegistroController registro_controller = new RegistroController();

        public ReporteSsAdicionales()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            comboBoxMeses.Items.Add("Enero");
            comboBoxMeses.Items.Add("Febrero");
            comboBoxMeses.Items.Add("Marzo");
            comboBoxMeses.Items.Add("Abril");
            comboBoxMeses.Items.Add("Mayo");
            comboBoxMeses.Items.Add("Junio");
            comboBoxMeses.Items.Add("Julio");
            comboBoxMeses.Items.Add("Agosto");
            comboBoxMeses.Items.Add("Septiembre");
            comboBoxMeses.Items.Add("Octubre");
            comboBoxMeses.Items.Add("Noviembre");
            comboBoxMeses.Items.Add("Diciembre");

            for (int año = DateTime.Now.Year; año >= 2009; año--)
            {
                ComboAños.Items.Add(año.ToString());
            }

        }

        private void CargarDatosIngresos(object sender, EventArgs e)
        {
            // Limpia los datos anteriores del gráfico
            chartCantidadServicios.Series["Servicios"].Points.Clear();

            List<Registro> registros = registro_controller.GetRegistros();

            // el mes seleccionado en el ComboBox
            string mesSeleccionado = comboBoxMeses.SelectedItem.ToString();

            // Convierte el nombre del mes a su número correspondiente
            int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", CultureInfo.CurrentCulture).Month;


            int añoSeleccionado = int.Parse(ComboAños.SelectedItem.ToString());

            List<Registro> registroFiltrados = registros.Where(r => r.FechaIngreso.Month == numeroMes && r.FechaIngreso.Year == añoSeleccionado).ToList();

            var serviciosPorRegistro = registroFiltrados.SelectMany(r => r.IdServicioAdics)
                                            .GroupBy(sa => sa.NombServicio)
                                            .Select(g => new { Servicio = g.Key, Cantidad = g.Count() });


            // Limpia los datos anteriores del gráfico
            chartCantidadServicios.Series["Servicios"].Points.Clear();

            // Cambia el tipo de gráfico a Pie
            chartCantidadServicios.Series["Servicios"].ChartType = SeriesChartType.Pie;

            // Añade los nuevos datos al gráfico
            foreach (var servicio in serviciosPorRegistro)
            {
                int punto = chartCantidadServicios.Series["Servicios"].Points.AddXY(servicio.Servicio, servicio.Cantidad);
                chartCantidadServicios.Series["Servicios"].Points[punto].IsValueShownAsLabel = true;
            }

        }
    }
}
