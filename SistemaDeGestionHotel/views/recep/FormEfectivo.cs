﻿using Microsoft.VisualBasic;
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
    public partial class FormEfectivo : Form
    {
        private double? MontoTotal;

        public FormEfectivo(double? montoTotal)
        {
            InitializeComponent();

            MontoTotal = montoTotal;

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
                }
            }
        }
    }
}
