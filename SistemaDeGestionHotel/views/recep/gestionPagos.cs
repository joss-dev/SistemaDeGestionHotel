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
    public partial class gestionPagos : Form
    {

        RegistroController registro_controller = new RegistroController();
        ClienteController cliente_controller = new ClienteController();
        HabitacionController habitacion_controller = new HabitacionController();
        OfertaRecargoControllers ofertaRecargo_controller = new OfertaRecargoControllers();
        private TimeSpan diferencia;

        private Habitacion habitacionPago;
        private Registro registroPago;
        private Cliente clientePago;
        private OfertasRecargo oferta;
        private OfertasRecargo recargo;
        private double? porcentajeOferta = 0;
        private double? porcentajeRecargo = 0;
        private double subtotal = 0;

        public gestionPagos()
        {
            InitializeComponent();
            cbMetodoPago.SelectedIndex = 0;
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
                    clientePago = cliente_controller.GetClienteByDNI(int.Parse(TDni.Text));

                    if (clientePago == null)
                    {
                        MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        registroPago = registro_controller.GetRegistroByIDCliente(clientePago.IdCliente);

                        if (registroPago == null || registroPago.EstadoOcupacion == 0)
                        {
                            MessageBox.Show("El cliente no se encuentra registrado en ninguna habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            habitacionPago = habitacion_controller.GetHabitacionByID(registroPago.NroHabitacion);

                            labelNombre.Text = clientePago.NombreCliente.ToString();
                            labelApellido.Text = clientePago.ApellidoCliente.ToString();
                            labelDni.Text = clientePago.DniCliente.ToString();
                            labelTelefono.Text = clientePago.Telefono.ToString();


                            labelCantHuespedes.Text = registroPago.CantidadHuespedes.ToString();
                            labelFechaIngreso.Text = registroPago.FechaIngreso.ToShortDateString();
                            labelFechaSalida.Text = registroPago.FechaSalida.ToShortDateString();

                            labelNroHabitacion.Text = habitacionPago.NroHabitacion.ToString();
                            labelTipoHabitacion.Text = habitacionPago.IdTipoHabNavigation.NombTipo.ToString();
                            labelPiso.Text = habitacionPago.IdPiso.ToString();

                            diferencia = this.CalcularDiasEstadia(registroPago.FechaIngreso, registroPago.FechaSalida);


                            dataGridViewFactura.DataSource = registroPago.IdServicioAdics.Select(x => new { NombreServicio = x.NombServicio, Precio = x.Precio }).ToList();
                            dataGridViewFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridViewFactura.Columns["NombreServicio"].HeaderText = "Servicio";



                            labelCantDias.Text = diferencia.TotalDays.ToString();
                            labelCantServicios.Text = registroPago.IdServicioAdics.Count().ToString();
                            labelPrecioHabitacion.Text = registroPago.PrecioHabPactado.ToString("N2");

                            labelMonto.Text = this.CalcularMontoEstadia(diferencia.TotalDays, registroPago.PrecioHabPactado).ToString("N2");

                            labelMontoServicios.Text = this.CalcularMontoServicios(registroPago).ToString("N2");

                            subtotal = this.CalcularMontoServicios(registroPago) + this.CalcularMontoEstadia(diferencia.TotalDays, registroPago.PrecioHabPactado);


                            labelSubtotal.Text = subtotal.ToString("N2");

                            labelMontoTotal.Text = (subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo))?.ToString("N2");

                        }
                    }
                }   
            }
        }

        private double? CalcularOferta(double? oferta)
        {
            double subtotal = this.CalcularMontoServicios(registroPago) + this.CalcularMontoEstadia(diferencia.TotalDays, registroPago.PrecioHabPactado);
            return (subtotal * oferta) / 100;
        }

        private double? CalcularRecargo(double? recargo)
        {
            double subtotal = this.CalcularMontoServicios(registroPago) + this.CalcularMontoEstadia(diferencia.TotalDays, registroPago.PrecioHabPactado);
            return (subtotal * recargo) / 100;
        }

        private double CalcularMontoServicios(Registro registro)
        {
            double result = 0;
            foreach (ServiciosAdicionale servicio in registro.IdServicioAdics)
            {
                result += servicio.Precio;
            }

            return result * diferencia.TotalDays;

        }

        private double CalcularMontoEstadia(double cantDias, double precioPactado)
        {
            return cantDias * precioPactado;
        }

        private TimeSpan CalcularDiasEstadia(DateTime fechaIngreso, DateTime fechaSalida)
        {
            return fechaSalida - fechaIngreso;
        }

        private void ValidacionDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProviderNumero);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TDni.Clear();

            labelNombre.Text = string.Empty;
            labelApellido.Text = string.Empty;
            labelDni.Text = string.Empty;
            labelTelefono.Text = string.Empty;


            labelCantHuespedes.Text = string.Empty;
            labelFechaIngreso.Text = string.Empty;
            labelFechaSalida.Text = string.Empty;

        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnContinuar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = cbMetodoPago.SelectedIndex;

            if (indiceSeleccionado == 0)
            {
                if(oferta == null)
                {
                    // Primer índice, que corresponde a "Efectivo"
                    FormEfectivo formEfectivo = new FormEfectivo(subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo), recargo, registroPago);
                    formEfectivo.ShowDialog();
                }else
                {
                    // Primer índice, que corresponde a "Efectivo"
                    FormEfectivo formEfectivo = new FormEfectivo(subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo), oferta, registroPago);
                    formEfectivo.ShowDialog();
                }
                
            }
            else if (indiceSeleccionado == 1)
            {
                // Segundo índice, que corresponde a "Tarjeta de Débito"
                FormTarjeta form = new FormTarjeta();
                form.ShowDialog();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos(object sender, EventArgs e)
        {
            List<String> listaOfertas = ofertaRecargo_controller.ObtenerNombresOferta();
            List<String> listaRecargo = ofertaRecargo_controller.ObtenerNombresRecargo();

            foreach (string of in listaOfertas)
            {
                comboBoxOfertas.Items.Add(of);
            }


            foreach (string re in listaRecargo)
            {
                comboBoxRecargos.Items.Add(re);
            }
        }

        private void CargarOferta(object sender, EventArgs e)
        {
            comboBoxRecargos.Enabled = false;

            int indice = comboBoxOfertas.SelectedIndex;

            List<OfertasRecargo> listaOfertas = ofertaRecargo_controller.ObtenerOfertas();

            oferta = listaOfertas[indice];

            porcentajeOferta = oferta.PorcentajeDescuento;

            labelOferta.Text = (oferta.PorcentajeDescuento / 100)?.ToString("P") + " - $" + this.CalcularOferta(oferta.PorcentajeDescuento)?.ToString("N2");
            labelMontoTotal.Text = (subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo))?.ToString("N2");
        }

        private void CargarRecargo(object sender, EventArgs e)
        {
            comboBoxOfertas.Enabled = false;

            int indice = comboBoxRecargos.SelectedIndex;

            List<OfertasRecargo> listaRecargos = ofertaRecargo_controller.ObtenerRecargos();

            recargo = listaRecargos[indice];

            porcentajeRecargo = recargo.PorcentajeRecargo;

            labelRecargo.Text = (recargo.PorcentajeRecargo / 100)?.ToString("P") + " - $" + this.CalcularRecargo(recargo.PorcentajeRecargo)?.ToString("N2");
            labelMontoTotal.Text = (subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo))?.ToString("N2");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            comboBoxOfertas.Enabled = true;
            comboBoxRecargos.Enabled = true;


            porcentajeOferta = 0;
            porcentajeRecargo = 0;

            labelOferta.Text = string.Empty;
            labelRecargo.Text = string.Empty;

            labelMontoTotal.Text = (subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo))?.ToString("N2");
        }
    }
}
