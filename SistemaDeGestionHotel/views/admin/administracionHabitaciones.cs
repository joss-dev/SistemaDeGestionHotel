﻿using System;
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
    public partial class administracionHabitaciones : Form
    {
        public administracionHabitaciones()
        {
            InitializeComponent();

            // Crear las listas de opciones
            List<string> opciones = new List<string>() { "Sellecione", "Habitación simple", "Habitación doble", "Habitación triple" };
            List<string> opciones2 = new List<string>() { "Sellecione", "Libre", "Ocupada", "Habilitada", "Deshabilitada", "Eliminada" };

            // Limpiar los comboBox
            comboBoxTipoHab.Items.Clear();
            comboBoxEstado.Items.Clear();


            // Agregar las opciones a los comboBoxTipoHab & comoBoxEstado
            foreach (string opcion in opciones)
            {
                comboBoxTipoHab.Items.Add(opcion);
            }

            foreach (string opcion2 in opciones2)
            {
                comboBoxEstado.Items.Add(opcion2);
            }
        }

        private void txtNroHab_TextChanged(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtNroHab, errorProvider1);
        }

        private void comboBoxTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoHab.SelectedItem == null || string.IsNullOrEmpty(comboBoxTipoHab.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPiso_TextChanged(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtPiso, errorProvider1);
        }

        private void validarCantidadCamas(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtCantCamas, errorProvider1);
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstado.SelectedItem == null || string.IsNullOrEmpty(comboBoxEstado.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAgregarHabitac_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtNroHab, txtCantCamas, txtPiso, txtCosto))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
           
        }


    }
}
