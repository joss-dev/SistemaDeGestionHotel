using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaDeGestionHotel.views.Reportes
{
    public partial class ReporteHabitaciones : Form
    {

        HabitacionController habController = new HabitacionController();
        RegistroController registroController = new RegistroController();
        int totalHabitaciones = 0;



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public ReporteHabitaciones()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }

        private void CambiarPyramidHabitaciones(object sender, EventArgs e)
        {
            List<Habitacion> habitacion = habController.GetHabitaciones();
            List<Registro> registro = new RegistroController().GetRegistros();

            // Obtén la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dateTimeHasta.Value.Date;

            totalHabitaciones = habController.GetHabitaciones()
            .Where(h => h.IdEstado != 5)
            .Count();

            // Consulta para contar todas las habitaciones
            var resultadoConsulta = from h in habitacion
                                    join r in registro on h.IdHabitacion equals r.NroHabitacion
                                    where DateTime.Today >= r.FechaIngreso.Date && DateTime.Today <= r.FechaSalida.Date
                                    select h;

            // Asegúrate de tener una referencia a la serie "Estado de Habitaciones" en tu gráfico
            var serieEstadoHabitaciones = ChartTotalHab.Series["Estado de Habitaciones"];

            // Establece el tipo de gráfico a Pyramid
            serieEstadoHabitaciones.ChartType = SeriesChartType.Pyramid;

            // Realiza la consulta para contar las habitaciones en cada estado
            var habitacionesPorEstado = resultadoConsulta
                .GroupBy(r => r.IdEstado)  // Agrupa por el estado de la habitación
                .Select(g => new { Estado = g.Key, Cantidad = g.Count() });  // Cuenta la cantidad de habitaciones en cada estado

            // Limpia las series existentes en el gráfico
            serieEstadoHabitaciones.Points.Clear();

            // Agrega una nueva serie al gráfico
            foreach (var estado in habitacionesPorEstado)
            {
                // Asegúrate de ajustar la obtención de datos según la estructura real de tu objeto
                //string nombreEstado = estado.Estado;  // Reemplaza "Estado" con la propiedad correcta
                int cantidad = estado.Cantidad;  // Reemplaza "Cantidad" con la propiedad correcta

                // Agrega un punto al gráfico con el nombre del estado y la cantidad
                serieEstadoHabitaciones.Points.AddXY(cantidad);
            }

            ChartTotalHab.Update();

        }
    }
}

