using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System.Data;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class gestionPagos : Form
    {

        RegistroController registro_controller = new RegistroController();
        ClienteController cliente_controller = new ClienteController();
        HabitacionController habitacion_controller = new HabitacionController();
        OfertaRecargoControllers ofertaRecargo_controller = new OfertaRecargoControllers();
        private TimeSpan diferencia;
        MedioPagoController mediopago_controller = new MedioPagoController();
        PagoController pago_controller = new PagoController();


        private Habitacion habitacionPago;
        private Registro registroPago;
        private Cliente clientePago;
        private OfertasRecargo oferta;
        private OfertasRecargo recargo;
        private double? porcentajeOferta = 0;
        private double? porcentajeRecargo = 0;
        private double subtotal = 0;
        private bool puedeFacturar = false;

        public gestionPagos()
        {
            InitializeComponent();

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

                        if (registroPago == null || registroPago.EstadoOcupacion == 0 || registroPago.EstadoOcupacion == 2)
                        {
                            MessageBox.Show("El cliente no se encuentra registrado en ninguna habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            puedeFacturar = true;
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

        private void VaciarLabels()
        {
            TDni.Clear();

            labelNombre.Text = string.Empty;
            labelApellido.Text = string.Empty;
            labelDni.Text = string.Empty;
            labelTelefono.Text = string.Empty;


            labelCantHuespedes.Text = string.Empty;
            labelFechaIngreso.Text = string.Empty;
            labelFechaSalida.Text = string.Empty;

            labelNroHabitacion.Text = string.Empty;
            labelPiso.Text = string.Empty;
            labelTipoHabitacion.Text = string.Empty;
            labelCantDias.Text = string.Empty;
            labelCantServicios.Text = string.Empty;
            labelPrecioHabitacion.Text = string.Empty;
            labelMonto.Text = string.Empty;
            labelMontoServicios.Text = string.Empty;
            labelMontoTotal.Text = string.Empty;
            labelOferta.Text = string.Empty;
            labelRecargo.Text = string.Empty;
            dataGridViewFactura.DataSource = null;
            labelSubtotal.Text = string.Empty;

        }

        private void ReiniciarDatos()
        {
            habitacionPago = null;
            registroPago = null;
            clientePago = null;
            oferta = null;
            recargo = null;
            puedeFacturar = false;
            this.VaciarLabels();
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

            return result;

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
            this.ReiniciarDatos();

        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!puedeFacturar)
            {
                MessageBox.Show("Debe buscar un cliente por su dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indiceSeleccionado = cbMetodoPago.SelectedIndex;

                if (indiceSeleccionado == 2)
                {
                    if (oferta == null)
                    {
                        // Primer índice, que corresponde a "Efectivo"
                        FormEfectivo formEfectivo = new FormEfectivo(subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo), recargo, registroPago);
                        formEfectivo.ShowDialog();
                        this.ReiniciarDatos();
                    }
                    else
                    {
                        // Primer índice, que corresponde a "Efectivo"
                        FormEfectivo formEfectivo = new FormEfectivo(subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo), oferta, registroPago);
                        formEfectivo.ShowDialog();
                        this.ReiniciarDatos();
                    }
                }
                else
                {
                    if (oferta == null)
                    {
                        if (pago_controller.AgregarPago((subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo)).Value, DateTime.Now, 1, recargo?.IdOfertaRecargo, registroPago.IdRegistro, cbMetodoPago.SelectedIndex + 1))
                        {
                            MessageBox.Show($"El cobro se realizo correctamente! se imprimira la factura correspondiente.");

                            habitacion_controller.LiberarHabitacion(registroPago.NroHabitacion);

                            registro_controller.RegistrarLiberado(registroPago.IdRegistro);

                            Pago pago = pago_controller.GetPagoByIDregistro(registroPago.IdRegistro);

                            Form verfactura = new VerFactura(pago, registroPago);
                            verfactura.StartPosition = FormStartPosition.CenterScreen;
                            verfactura.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Fallo el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (pago_controller.AgregarPago((subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo)).Value, DateTime.Now, 1, oferta?.IdOfertaRecargo, registroPago.IdRegistro, cbMetodoPago.SelectedIndex + 1))
                        {
                            MessageBox.Show($"El cobro se realizo correctamente! se imprimira la factura correspondiente.");

                            habitacion_controller.LiberarHabitacion(registroPago.NroHabitacion);

                            registro_controller.RegistrarLiberado(registroPago.IdRegistro);

                            Pago pago = pago_controller.GetPagoByIDregistro(registroPago.IdRegistro);

                            Form verfactura = new VerFactura(pago, registroPago);
                            verfactura.StartPosition = FormStartPosition.CenterScreen;
                            verfactura.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Fallo el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.ReiniciarDatos();
                }
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
            List<MediosPago> medioPago = mediopago_controller.ObtenerMedioPago();

            foreach (MediosPago me in medioPago)
            {
                cbMetodoPago.Items.Add(me.Nombre);
            }

            cbMetodoPago.SelectedIndex = 0;

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

            if (registroPago != null)
            {
                labelMontoTotal.Text = (subtotal - this.CalcularOferta(porcentajeOferta) + this.CalcularRecargo(porcentajeRecargo))?.ToString("N2");
            }

        }

        private void ReiniciarDatos(object sender, EventArgs e)
        {
            this.ReiniciarDatos();
            puedeFacturar = false;
        }
    }
}
