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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void validarDni(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(sender as TextBox, errorProviderNumero);
        }
    }
}
