using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
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
    public partial class GestionReservas : Form
    {
        ClienteController cliente_controller = new ClienteController();
        RegistroController registro_controller = new RegistroController();
        HabitacionController habitacion_controller = new HabitacionController();
        private Registro registroBuscado;
        public GestionReservas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ValidacionDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProviderNumero);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verifica que la longitud de la entrada esté entre 7 y 8.
                if (TDni.Text.Length < 7 || TDni.Text.Length > 8)
                {
                    MessageBox.Show("El DNI debe tener entre 7 y 8 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente clienteBuscado = cliente_controller.GetClienteByDNI(int.Parse(TDni.Text));
                    if (clienteBuscado == null)
                    {
                        MessageBox.Show("Este dni no tiene asociado una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        registroBuscado = registro_controller.GetRegistroByIDCliente(clienteBuscado.IdCliente);
                        if (registroBuscado == null || registroBuscado.EstadoOcupacion == 1 || registroBuscado.EstadoOcupacion == 3)
                        {
                            MessageBox.Show("Este dni no tiene asociado una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Habitacion habitacionBuscada = habitacion_controller.GetHabitacionByID(registroBuscado.NroHabitacion);

                            labelNroHabitacion.Text = habitacionBuscada.NroHabitacion.ToString();
                            labelTipoHabitacion.Text = habitacionBuscada.IdTipoHabNavigation.NombTipo.ToString();
                            labelPrecio.Text = habitacionBuscada.Precio.ToString("N2");
                            labelCantCamas.Text = habitacionBuscada.CantidadCamas.ToString();
                            labelPiso.Text = habitacionBuscada.IdPiso.ToString();


                            labelApellido.Text = clienteBuscado.ApellidoCliente.ToString();
                            labelNombre.Text = clienteBuscado.NombreCliente.ToString();
                            labelDni.Text = clienteBuscado.DniCliente.ToString();
                            labelTelefono.Text = clienteBuscado.Telefono.ToString();

                            labelCantHuespedes.Text = registroBuscado.CantidadHuespedes.ToString();
                            labelFechaIngreso.Text = registroBuscado.FechaIngreso.ToShortDateString();
                            labelFechaSalida.Text = registroBuscado.FechaSalida.ToShortDateString();

                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            labelNroHabitacion.Text = string.Empty;
            labelTipoHabitacion.Text = string.Empty;
            labelPrecio.Text = string.Empty;
            labelCantCamas.Text = string.Empty;
            labelPiso.Text = string.Empty;


            labelApellido.Text = string.Empty;
            labelNombre.Text = string.Empty;
            labelDni.Text = string.Empty;
            labelTelefono.Text = string.Empty;

            labelCantHuespedes.Text = string.Empty;
            labelFechaIngreso.Text = string.Empty;
            labelFechaSalida.Text = string.Empty;
        }

        private void btnConfirmaLLegada_Click(object sender, EventArgs e)
        {
            if (registroBuscado == null)
            {
                MessageBox.Show("Primero debe buscar el Dni del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea confirmar la estadia de este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (result == MsgBoxResult.Yes)
                {
                    bool resil = registro_controller.RegistrarEstadia(registroBuscado.IdRegistro);
                    if (resil)
                    {
                        habitacion_controller.MarcarOcupadaHabitacion(registroBuscado.NroHabitacion);
                        MessageBox.Show("Estadia registrada correctamente!");
                        labelNroHabitacion.Text = string.Empty;
                        labelTipoHabitacion.Text = string.Empty;
                        labelPrecio.Text = string.Empty;
                        labelCantCamas.Text = string.Empty;
                        labelPiso.Text = string.Empty;


                        labelApellido.Text = string.Empty;
                        labelNombre.Text = string.Empty;
                        labelDni.Text = string.Empty;
                        labelTelefono.Text = string.Empty;

                        labelCantHuespedes.Text = string.Empty;
                        labelFechaIngreso.Text = string.Empty;
                        labelFechaSalida.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
        }

        private void BtnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (registroBuscado == null)
            {
                MessageBox.Show("Primero debe buscar el Dni del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cancelar esta reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (result == MsgBoxResult.Yes)
                {
                    bool resil = registro_controller.DarBajaReserva(registroBuscado.IdRegistro);
                    if (resil)
                    {
                        habitacion_controller.LiberarHabitacion(registroBuscado.NroHabitacion);
                        MessageBox.Show("La reserva fue cancelada correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error al cancelar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }
    }
}
