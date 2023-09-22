using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeGestionHotel;


namespace SistemaDeGestionHotel.views.recep
{
    public partial class agregarReserva : Form
    {
        public agregarReserva()
        {
            InitializeComponent();

            //establece la fecha minima para seleccionar
            dateTimeIngreso.MinDate = DateTime.Today;
            dateTimeSalida.MinDate = DateTime.Today;
        }


        private void agregarReserva_Load(object sender, EventArgs e)
        {

        }

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TNombre, errorProviderNumero);
        }

        private void ValidacionApellido(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TApellido, errorProviderNumero);
        }

        private void ValidacionDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProviderNumero);
        }

        private void ValidacionCantHuesped(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TCantidadHuespedes, errorProviderNumero);
        }

        private void btnServiciosAd_Click(object sender, EventArgs e)
        {
            Form servicios = new registrarServicio();

            servicios.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = servicios.ShowDialog();

            // Verificar si se cerró el formulario secundario
            if (result == DialogResult.OK)
            {
                // Realizar acciones después de cerrar el formulario secundario si es necesario
            }

        }
    }
}
