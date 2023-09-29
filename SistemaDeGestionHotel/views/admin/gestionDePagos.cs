using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionDePagos : Form
    {

        public gestionDePagos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de gestioMediosPago
            gestionMediosPago GestionMediosPago = new gestionMediosPago();

            // Establecer el formulario principal como el propietario (owner) del GestionMedioPago
            GestionMediosPago.Owner = this;

            // Mostrar el gestionMediosPago
            GestionMediosPago.Show();
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            // Crear una instancia del primer gestionOfertas
            gestionOfertas GestionOfertas = new gestionOfertas();

            // Establecer el formulario principal como el propietario (owner) del GestionMedioPago
            GestionOfertas.Owner = this;

            // Mostrar el gestionMediosPago
            GestionOfertas.Show();
        }
    }
}
