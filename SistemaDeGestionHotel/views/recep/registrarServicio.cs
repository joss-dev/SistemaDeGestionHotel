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
using System.Windows.Media;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class registrarServicio : Form
    {

        ServiciosAdicionalesController servicios_controller = new ServiciosAdicionalesController();
        private int dniCliente;
        DetalleServicioController detalle_controller = new DetalleServicioController();
        RegistroController registro_controller = new RegistroController();
        ClienteController cliente_controller = new ClienteController();

        public registrarServicio(int dni)
        {
            InitializeComponent();
            dniCliente = dni;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }

        private void CargaDatos(object sender, EventArgs e)
        {
            if (dniCliente == 0)
            {
                TDni.Text = string.Empty;
            }
            else
            {
                TDni.Text = dniCliente.ToString();
            }

            List<ServiciosAdicionale> serviciosAdicionales = servicios_controller.GetServiciosAdicionales();


            foreach (ServiciosAdicionale servicio in serviciosAdicionales)
            {

                if (servicio.Estado == 1)
                {
                    comboBoxServicios.Items.Add(servicio.NombServicio);
                }

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni) || comboBoxServicios.SelectedIndex < 0)
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
                    Cliente cliente = cliente_controller.GetClienteByDNI(int.Parse(TDni.Text));

                    if (cliente == null)
                    {
                        MessageBox.Show("El dni ingresado no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Registro registro = registro_controller.GetRegistroByIDCliente(cliente.IdCliente);
                        if (registro == null)
                        {
                            MessageBox.Show("El dni ingresado no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ServiciosAdicionale servicioAd = servicios_controller.GetServicioAdicionalByID(comboBoxServicios.SelectedIndex + 1);
                            if (registro_controller.AgregarServicioAdicional(servicioAd, registro))
                            {
                                MessageBox.Show("Servicio registrado!");
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void ValidarDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProvider);
        }

        private void CargaPrecio(object sender, EventArgs e)
        {
            ServiciosAdicionale servicio = servicios_controller.GetServicioAdicionalByID(comboBoxServicios.SelectedIndex + 1);

            labelPrecio.Text = servicio.Precio.ToString("N2");
        }
    }
}
