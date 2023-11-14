using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaDeGestionHotel.views.Reportes
{
    public partial class ReporteIngresos : Form
    {
        PagoController pago_controller = new PagoController();
        public ReporteIngresos()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void CargarDatos(object sender, EventArgs e)
        {
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

        private void CambiarChartIngresos(object sender, EventArgs e)
        {
            List<Pago> pagos = pago_controller.GetPagos();

            // Obtén el mes seleccionado en el ComboBox
            string mesSeleccionado = comboBoxMeses.SelectedItem.ToString();

            // Convierte el nombre del mes a su número correspondiente
            int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", CultureInfo.CurrentCulture).Month;

            // Obtén el año seleccionado en el ComboBox
            int añoSeleccionado = int.Parse(ComboAños.SelectedItem.ToString());

            // Filtra los pagos por el mes y el año seleccionados
            List<Pago> pagosFiltrados = pagos.Where(p => p.FechaHoraPago.Month == numeroMes && p.FechaHoraPago.Year == añoSeleccionado).ToList();

            // Agrupa los pagos por día y suma los montos
            var ingresosPorDia = pagosFiltrados.GroupBy(p => p.FechaHoraPago.Day)
                                            .Select(g => new { Dia = g.Key, Ingresos = g.Sum(p => p.MontoPago) });


            // Limpia los datos anteriores del gráfico
            CHIngresoMensual.Series["Series1"].Points.Clear();

            // Añade los nuevos datos al gráfico
            foreach (var ingresos in ingresosPorDia)
            {
                CHIngresoMensual.Series["Series1"].Points.AddXY(ingresos.Dia, ingresos.Ingresos);
            }

            CHIngresoMensual.ChartAreas[0].AxisX.Interval = 1;
            CHIngresoMensual.ChartAreas[0].AxisX.Minimum = 1;
            CHIngresoMensual.ChartAreas[0].AxisX.Maximum = DateTime.DaysInMonth(DateTime.Now.Year, numeroMes);

            // Agrupa los pagos por medio de pago y cuenta la cantidad
            var ventasPorMedioPago = pagosFiltrados.GroupBy(p => p.IdMedioPagoNavigation.Nombre)
                                                .Select(g => new { MedioPago = g.Key, Ventas = g.Count() });

            // Limpia los datos anteriores del gráfico
            chart1.Series["Ingresos"].Points.Clear();

            // Cambia el tipo de gráfico a Pie
            chart1.Series["Ingresos"].ChartType = SeriesChartType.Pie;

            // Añade los nuevos datos al gráfico
            foreach (var ventas in ventasPorMedioPago)
            {
                int punto = chart1.Series["Ingresos"].Points.AddXY(ventas.MedioPago, ventas.Ventas);
                // Muestra el valor como porcentaje
                chart1.Series["Ingresos"].Points[punto].IsValueShownAsLabel = true;
                chart1.Series["Ingresos"].Points[punto].Label = ventas.MedioPago + ":#PERCENT{P0}";

            }


        }
    }
}
