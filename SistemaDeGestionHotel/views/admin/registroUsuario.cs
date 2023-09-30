using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class registroUsuario : Form
    {

        private readonly HotelParanaContext dbHotelParana;

        public registroUsuario()
        {
            InitializeComponent();
            dbHotelParana = new HotelParanaContext();
        }

        private void conectarbase()
        {
            

            // Crear las listas de opciones
            List<string> opciones = dbHotelParana.PerfilUsuarios
                                    .Select(perfil => perfil.Nombre) // Proyecta solo el campo Nombre
                                    .ToList();

            // Limpiar los comboBox
            comboBoxTipoPerfil.Items.Clear();

            // Agregar las opciones a los comboBoxTipoHab & comoBoxEstado
            foreach (string opcion in opciones)
            {
                comboBoxTipoPerfil.Items.Add(opcion);
            }
        }

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtNombre, errorProvider1);
        }

        private void ValidacionApellido(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtApellido, errorProvider1);
        }

        private void ValidacionDNI(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtDNI, errorProvider1);
        }


        private void ValidarDireccion(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtDireccion, errorProvider1);
        }

        private void comboBoxTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoPerfil.SelectedItem == null || string.IsNullOrEmpty(comboBoxTipoPerfil.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtNombre, txtApellido, txtDNI, txtCorreoElec, txtDireccion, txtUserName, txtPass))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {



            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }

        private void LimpiarCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    // Si el control es un TextBox, limpiar su contenido
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c is ComboBox)
                {
                    // Si el control es un ComboBox, seleccionar el primer elemento (o dejar en blanco)
                    ((ComboBox)c).SelectedIndex = 0;
                }
                else if (c is CheckBox)
                {

                    // Llamar recursivamente a LimpiarCampos para los controles secundarios (si los hay)
                    if (c.HasChildren)
                    {
                        LimpiarCampos(c);
                    }
                }
            }
        }
    }
}
