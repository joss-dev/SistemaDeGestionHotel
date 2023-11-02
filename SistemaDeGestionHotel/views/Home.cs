using SistemaDeGestionHotel.NEntidades;
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

        private Form formularioAbierto = null;
        private Usuario usuarioInicioSesion;

        public Home(Usuario usuario)
        {
            InitializeComponent();
            usuarioInicioSesion = usuario;  
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

        private void btnEstadoHab_Click(object sender, EventArgs e)
        {
            // Llama a AbrirFormulario con el formulario gestionMediosPago
            AbrirFormulario(new gestionHabitaciones(usuarioInicioSesion));
        }
    }
}
