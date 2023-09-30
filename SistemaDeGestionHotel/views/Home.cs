using SistemaDeGestionHotel.views.admin;
using SistemaDeGestionHotel.views.recep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnEstadoHab_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario de gestioMediosPago
            gestionHabitaciones GestionHabitaciones = new gestionHabitaciones();

            // Establecer el formulario principal como el propietario (owner) del GestionMedioPago
            GestionHabitaciones.Owner = this;

            // Mostrar el gestionMediosPago
            GestionHabitaciones.Show();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de gestioMediosPago
            consultaSoporte ConsultaSoporte = new consultaSoporte();

            // Establecer el formulario principal como el propietario (owner) del GestionMedioPago
            ConsultaSoporte.Owner = this;

            // Mostrar el gestionMediosPago
            ConsultaSoporte.Show();
        }
    }
}
