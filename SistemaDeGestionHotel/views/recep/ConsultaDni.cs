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
    public partial class ConsultaDni : Form
    {
        private int idHabitacion;

        ClienteController cliente_controller = new ClienteController();
        HabitacionController habitacion_controller = new HabitacionController();

        public ConsultaDni(int IDHabitacion)
        {
            InitializeComponent();
            idHabitacion = IDHabitacion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente clienteBuscado = cliente_controller.GetClienteByDNI(int.Parse(TDni.Text));

                Habitacion habitacion = habitacion_controller.GetHabitacionByID(idHabitacion);


                Form agregarHues = new AgregarHuesped(clienteBuscado, habitacion, int.Parse(TDni.Text));

                agregarHues.StartPosition = FormStartPosition.CenterScreen;

                DialogResult result = agregarHues.ShowDialog();
            }
        }


        private void ValidarDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProvider1);
        }
    }
}
