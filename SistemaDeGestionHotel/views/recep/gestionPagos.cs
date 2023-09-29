﻿using System;
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
    public partial class gestionPagos : Form
    {
        public gestionPagos()
        {
            InitializeComponent();
            cbMetodoPago.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Exito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ValidacionDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProviderNumero);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TDni.Clear();
        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnContinuar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = cbMetodoPago.SelectedIndex;

            if (indiceSeleccionado == 0)
            {
                // Primer índice, que corresponde a "Efectivo"
                FormEfectivo formEfectivo = new FormEfectivo();
                formEfectivo.ShowDialog();
            }
            else if (indiceSeleccionado == 1)
            {
                // Segundo índice, que corresponde a "Tarjeta de Débito"
                FormTarjeta form = new FormTarjeta();
                form.ShowDialog();
            }
        }
    }
}
