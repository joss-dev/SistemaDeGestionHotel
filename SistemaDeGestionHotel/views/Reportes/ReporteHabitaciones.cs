using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaDeGestionHotel.views.Reportes
{
    public partial class ReporteHabitaciones : Form
    {

        HabitacionController habController = new HabitacionController();
        RegistroController regController = new RegistroController();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public ReporteHabitaciones()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ActualizarGraficoPyramid(object sender, EventArgs e)
        {
            // Declarar e inicializar la variable habitacion
            List<Habitacion> habitacion = habController.GetHabitaciones();

            // Obtener resultados de la consulta LINQ
            var resultados = habitacion
                .GroupBy(h => h.IdEstadoNavigation.NombEstado)
                .Select(g => new { Estado = g.Key, Total = g.Count() })
                .ToList();

            // Calcular el total de todas las habitaciones
            var totalTodasLasHabitaciones = habitacion.Count();

            // Calcular porcentaje para cada estado
            var resultadosConPorcentaje = resultados.Select(r => new
            {
                Estado = r.Estado,
                Total = r.Total,
                Porcentaje = (double)r.Total / totalTodasLasHabitaciones * 100
            }).ToList();

            var serieEstadoHabitaciones = ChartTotalHab.Series["EstadoHabitaciones"];

            // Borra los puntos existentes en la serie
            serieEstadoHabitaciones.Points.Clear();

            // Agrega nuevos puntos al gráfico
            foreach (var resultado in resultadosConPorcentaje)
            {
                string nombreEstado = resultado.Estado;
                double porcentaje = resultado.Porcentaje;

                // Agrega un punto al gráfico con el nombre del estado y el porcentaje
                serieEstadoHabitaciones.Points.Add(new DataPoint(0, porcentaje) { AxisLabel = $"{nombreEstado} ({porcentaje:F2}%)", Tag = nombreEstado });
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }
    }
}



