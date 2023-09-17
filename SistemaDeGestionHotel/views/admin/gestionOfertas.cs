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
    public partial class gestionOfertas : Form
    {
        public gestionOfertas()
        {
            InitializeComponent();

            // Agregar elementos a la lista desplegable.
            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");

            // Establecer los elementos seleccionados por defecto.
            comboBoxEstado.SelectedIndex = 0;
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
