using Microsoft.VisualBasic;
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
            Form buscarHuesped = new ConsultaDni();

            buscarHuesped.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = buscarHuesped.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TNumHabitacion))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void ValidarTextboxNroHabitacion(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TNumHabitacion, errorProvider1);
        }
    }
}
