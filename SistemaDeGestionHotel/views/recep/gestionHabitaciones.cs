using SistemaDeGestionHotel.views.recep;
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
    public partial class gestionHabitaciones : Form
    {
        public gestionHabitaciones()
        {
            InitializeComponent();
        }

        private void gestionHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form agregarHues = new AgregarHuesped();

            agregarHues.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = agregarHues.ShowDialog();

            // Verificar si se cerró el formulario secundario
            if (result == DialogResult.OK)
            {
                // Realizar acciones después de cerrar el formulario secundario si es necesario
            }
        }
    }
}
