using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class InfoRegistro : Form
    {
        private Habitacion habitacionInfo;
        private int idHabitacion;
        HabitacionController habitacion_controller = new HabitacionController();
        RegistroController registro_controller = new RegistroController();
        ClienteController ClienteController = new ClienteController();

        private Registro registroInfo;
        private Cliente clienteInfo;

        public InfoRegistro(int idhab)
        {
            InitializeComponent();
            idHabitacion = idhab;
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            habitacionInfo = habitacion_controller.GetHabitacionByID(idHabitacion);
            registroInfo = registro_controller.GetRegistroByIDHabitacion(idHabitacion);
            clienteInfo = ClienteController.GetClienteByID(registroInfo.IdCliente);

            if (registroInfo.EstadoOcupacion != 2)
            {
                labelApellido.Text = clienteInfo.ApellidoCliente.ToString();
                labelNombre.Text = clienteInfo.NombreCliente.ToString();
                labelTelefono.Text = clienteInfo.Telefono.ToString();
                labelDni.Text = clienteInfo.DniCliente.ToString();


                labelFechaIngreso.Text = registroInfo.FechaIngreso.ToShortDateString();
                labelFechaSalida.Text = registroInfo.FechaSalida.ToShortDateString();
                labelCantidaHuespedes.Text = registroInfo.CantidadHuespedes.ToString();


                //carga datos de la habitacion
                labelNroHabitacion.Text = habitacionInfo.NroHabitacion.ToString();
                labelCantidadCamas.Text = habitacionInfo.CantidadCamas.ToString();
                labelPrecio.Text = habitacionInfo.Precio.ToString("N2");
                labelNroPiso.Text = habitacionInfo.IdPisoNavigation.NroPiso.ToString();
                labelTipo.Text = habitacionInfo.IdTipoHabNavigation.NombTipo.ToString();
            }

            if (registroInfo.EstadoOcupacion == 0)
            {
                Button miBoton = new Button();


                miBoton.Location = new Point(311, 477);


                miBoton.Size = new Size(133, 44);

                miBoton.UseVisualStyleBackColor = true;

                miBoton.Text = "Cancelar \nReserva";

                this.Controls.Add(miBoton);

                miBoton.Click += new EventHandler(CancelarReserva_Click);
            }
        }
        private void CancelarReserva_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cancelar esta reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                bool resil = registro_controller.DarBajaReserva(registroInfo.IdRegistro);
                if (resil)
                {
                    habitacion_controller.LiberarHabitacion(registroInfo.NroHabitacion);
                    MessageBox.Show("La reserva fue cancelada correctamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cancelar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
