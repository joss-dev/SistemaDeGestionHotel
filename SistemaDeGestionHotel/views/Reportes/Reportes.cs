using SistemaDeGestionHotel.views.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.Reportes
{
    public partial class Reportes : Form
    {

        private Form formularioAbierto = null;

        public Reportes()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)
        {
            if (formularioAbierto == null || formularioAbierto.IsDisposed)
            {
                // El formulario no está abierto o está cerrado, abre el formulario especificado
                formularioAbierto = formulario;
                formularioAbierto.Owner = this; // Establecer el formulario principal como propietario
                formularioAbierto.FormClosed += Formulario_FormClosed; // Manejar el evento FormClosed
                formularioAbierto.ShowDialog();
            }
            else
            {
                // El formulario ya está abierto, trae el formulario existente al frente
                formularioAbierto.BringToFront();
            }
        }
        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cuando se cierra el formulario, establece la variable formularioAbierto como nula
            formularioAbierto = null;
        }


        private void BTNSsAdicionales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ReporteSsAdicionales());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BTNIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ReporteIngresos());
        }

        private void BTNSituacionHabit_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ReporteHabitaciones());
        }
    }
}
