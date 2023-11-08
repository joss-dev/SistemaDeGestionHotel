using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.Reportes
{
    public partial class ReporteIngresos : Form
    {
        PagoController pago_controller = new PagoController();
        public ReporteIngresos()
        {
            InitializeComponent();
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
        }

        private void CambiarChartIngresos(object sender, EventArgs e)
        {
            List<Pago> pagos = pago_controller.GetPagos();

            // Obtén el mes seleccionado en el ComboBox
            string mesSeleccionado = comboBoxMeses.SelectedItem.ToString();

            // Convierte el nombre del mes a su número correspondiente
            int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", CultureInfo.CurrentCulture).Month;

            // Filtra los pagos por el mes seleccionado
            List<Pago> pagosFiltrados = pagos.Where(p => p.FechaHoraPago.Month == numeroMes).ToList();

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

        }
    }
}
