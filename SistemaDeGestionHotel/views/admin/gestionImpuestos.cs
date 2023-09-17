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
    public partial class gestionImpuestos : Form
    {
        public gestionImpuestos()
        {
            InitializeComponent();

            // Agregar elementos a las listas desplegables.
            comboBoxTipoImp.Items.Add("Nacional");
            comboBoxTipoImp.Items.Add("Provincial");
            comboBoxTipoImp.Items.Add("Tasa Municipal");


            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");

            // Establecer los elementos seleccionados por defecto.

            comboBoxTipoImp.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
        }

        private void gestionImpuestos_Load(object sender, EventArgs e)
        {

        }

        private void nombImp_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTipoImp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
