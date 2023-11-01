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
        public registrarServicio()
        {
            InitializeComponent();


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
            List<ServiciosAdicionale> serviciosAdicionales = servicios_controller.GetServiciosAdicionales();

            int y = 30;  // Inicializar la posición y

            foreach (ServiciosAdicionale servicio in serviciosAdicionales)
            {

                if (servicio.Estado == 1)
                {
                    // Crear un nuevo CheckBox
                    CheckBox checkBox = new CheckBox();
                    Label lab = new Label();

                    // Establecer la ubicación del CheckBox
                    checkBox.Location = new Point(50, y);
                    lab.Location = new Point(200, y);

                    lab.AutoSize = true;
                    checkBox.AutoSize = true;

                    lab.Text = $"Costo: $ {servicio.Precio.ToString("N2")}";


                    checkBox.Name = $"{servicio.NombServicio}";
                    // Establecer el texto del CheckBox con el nombre del servicio y su precio
                    checkBox.Text = $"{servicio.NombServicio}";

                    // Añadir el CheckBox al GroupBox
                    groupBox1.Controls.Add(checkBox);
                    groupBox1.Controls.Add(lab);

                    // Incrementar la posición y para el siguiente CheckBox
                    y += checkBox.Height + 10;
                }

            }
        }
    }
}
