﻿using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class ConsultaDni : Form
    {
        private int idHabitacion;

        ClienteController cliente_controller = new ClienteController();
        HabitacionController habitacion_controller = new HabitacionController();
        Usuario usuarioInicioSesion;
        RegistroController registro_controller = new RegistroController();

        public ConsultaDni(int IDHabitacion, Usuario usuario)
        {
            InitializeComponent();
            idHabitacion = IDHabitacion;
            usuarioInicioSesion = usuario;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Cliente clienteBuscado = cliente_controller.GetClienteByDNI(int.Parse(TDni.Text));

                Habitacion habitacion = habitacion_controller.GetHabitacionByID(idHabitacion);

                if (clienteBuscado == null)
                {
                    Form registrarCliente = new RegistrarCliente(usuarioInicioSesion, idHabitacion, int.Parse(TDni.Text));
                    registrarCliente.StartPosition = FormStartPosition.CenterScreen;
                    DialogResult result = registrarCliente.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (registro_controller.ClienteEnEstadiaOReserva(clienteBuscado.IdCliente) == null)
                    {
                        Form agregarHues = new AgregarHuesped(usuarioInicioSesion, clienteBuscado, habitacion, int.Parse(TDni.Text));

                        agregarHues.StartPosition = FormStartPosition.CenterScreen;

                        DialogResult result = agregarHues.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        Registro registroCliente = registro_controller.ClienteEnEstadiaOReserva(clienteBuscado.IdCliente);

                        if (registroCliente.EstadoOcupacion == 0)
                        {
                            string mensaje = $"El cliente se encuetra con una reserva en la habitacion : {registroCliente.NroHabitacionNavigation.NroHabitacion.ToString()}\n";


                            MessageBox.Show(mensaje, "detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string mensaje = $"El cliente se encuentra registrado en la habitacion : {registroCliente.NroHabitacionNavigation.NroHabitacion.ToString()}\n";


                            MessageBox.Show(mensaje, "detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }

                }
            }
        }


        private void ValidarDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProvider1);
        }

        private void CargarDATOS(object sender, EventArgs e)
        {
            Habitacion habitacionInfo = habitacion_controller.GetHabitacionByID(idHabitacion);

            habitacionInfo = habitacion_controller.GetHabitacionByID(idHabitacion);

            //carga datos de la habitacion
            labelNroHabitacion.Text = habitacionInfo.NroHabitacion.ToString();
            labelCantidadCamas.Text = habitacionInfo.CantidadCamas.ToString();
            labelPrecio.Text = habitacionInfo.Precio.ToString("N2");
            labelNroPiso.Text = habitacionInfo.IdPisoNavigation.NroPiso.ToString();
            labelTipo.Text = habitacionInfo.IdTipoHabNavigation.NombTipo.ToString();
        }
    }
}
