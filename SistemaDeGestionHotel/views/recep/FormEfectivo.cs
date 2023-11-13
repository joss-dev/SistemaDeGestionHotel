using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class FormEfectivo : Form
    {
        private double? MontoTotal;
        PagoController pago_controller = new PagoController();
        private OfertasRecargo OfertaOrecargo;
        private Registro registro;
        HabitacionController habitacion_controller = new HabitacionController();
        RegistroController registro_controller = new RegistroController();

        public FormEfectivo(double? montoTotal, OfertasRecargo ofertaOrecargo, Registro registrop)
        {
            InitializeComponent();

            MontoTotal = montoTotal;

            registro = registrop;

            OfertaOrecargo = ofertaOrecargo;

            textBoxTotalApagar.Text = montoTotal.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }

        }

        private void ValidarEfectivo(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarPrecio(textBoxEfectivo, errorProvider1);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(textBoxEfectivo))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (double.Parse(textBoxEfectivo.Text) < MontoTotal)
                {
                    MessageBox.Show("El monto ingresado no es suficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double? cambio = double.Parse(textBoxEfectivo.Text) - MontoTotal;
                    textBoxCambio.Text = cambio.ToString();



                    if (pago_controller.AgregarPago(MontoTotal.Value, DateTime.Now, 1, OfertaOrecargo?.IdOfertaRecargo, registro.IdRegistro, 3))
                    {
                        MessageBox.Show($"El cobro se realizo correctamente! su cambio es : {cambio?.ToString("N2")}");

                        habitacion_controller.LiberarHabitacion(registro.NroHabitacion);

                        registro_controller.RegistrarLiberado(registro.IdRegistro);

                        Pago pago = pago_controller.GetPagoByIDregistro(registro.IdRegistro);

                        Form verfactura = new VerFactura(pago, registro);
                        verfactura.StartPosition = FormStartPosition.CenterScreen;
                        verfactura.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fallo el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }
    }
}
