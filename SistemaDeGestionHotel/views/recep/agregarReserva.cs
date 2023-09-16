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

        private void ValidarApellido(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TApellido, errorProviderNumero);
        }

        private void ValidarNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TNombre, errorProviderNumero);
        }

        private void ValidarDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProviderNumero);
        }

        private void ValidarCantidadHuespedes(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TCantidadHuespedes, errorProviderNumero);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarReserva_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
