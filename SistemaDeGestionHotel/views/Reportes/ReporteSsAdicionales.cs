using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
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
        }

        private void CargarDatosIngresos(object sender, EventArgs e)
        {

            List<Registro> registros = registro_controller.GetRegistros();

            // el mes seleccionado en el ComboBox
            string mesSeleccionado = comboBoxMeses.SelectedItem.ToString();

            // Convierte el nombre del mes a su número correspondiente
            int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", CultureInfo.CurrentCulture).Month;

            List<Registro> registroFiltrados = registros.Where(r => r.FechaIngreso.Month == numeroMes).ToList();

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
