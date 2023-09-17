using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionMediosPago : Form
    {
        public gestionMediosPago()
        {
            InitializeComponent();

            // Agregar elementos a las listas desplegables.
            comboBoxTipoMP.Items.Add("Tarjeta de crédito");
            comboBoxTipoMP.Items.Add("Tarjeta de débito");
            comboBoxTipoMP.Items.Add("Efectivo");
            comboBoxTipoMP.Items.Add("Transferencia");

            comboBoxEstadoMP.Items.Add("Activo");
            comboBoxEstadoMP.Items.Add("Inactivo");

            // Establecer los elementos seleccionados por defecto.
            comboBoxTipoMP.SelectedIndex = 0;
            comboBoxEstadoMP.SelectedIndex = 0;

        }

        private void comboBoxTipoMP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEstadoMP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
