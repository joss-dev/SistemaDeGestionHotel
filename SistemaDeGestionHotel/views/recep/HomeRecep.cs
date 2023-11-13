﻿using SistemaDeGestionHotel.NEntidades;
using SistemaDeGestionHotel.views.admin;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class HomeRecep : Form
    {

        private Form formularioAbierto = null;
        private Usuario usuarioInicioSesion;


        public HomeRecep(Usuario usuarioInicioSesion)
        {
            InitializeComponent();
            this.usuarioInicioSesion = usuarioInicioSesion;
        }

        private void btnEstadoHab_Click(object sender, EventArgs e)
        {
            // Llama a AbrirFormulario con el formulario gestionMediosPago
            AbrirFormulario(new gestionHabitaciones(usuarioInicioSesion));
        }

        private void AbrirFormulario(Form formulario)
        {
            if (formularioAbierto == null || formularioAbierto.IsDisposed)
            {
                // El formulario no está abierto o está cerrado, abre el formulario especificado
                formularioAbierto = formulario;
                formularioAbierto.Owner = this; // Establecer el formulario principal como propietario
                formularioAbierto.FormClosed += Formulario_FormClosed; // Manejar el evento FormClosed
                formularioAbierto.ShowDialog(); // Muestra Formulario
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
        private void btnContacto_Click(object sender, EventArgs e)
        {
            // Llama a AbrirFormulario con el formulario gestionMediosPago
            AbrirFormulario(new consultaSoporte(usuarioInicioSesion));
        }
    }
}
