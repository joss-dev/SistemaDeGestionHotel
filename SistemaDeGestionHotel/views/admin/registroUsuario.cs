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

            dataGridView1.DataSource = dbHotelParana.Usuarios.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<string> opciones = dbHotelParana.PerfilUsuarios
                                    .Select(perfil => perfil.Nombre)
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
            ValidacionTextBox.ValidarTextoConEspaciosYNumeros(txtDireccion, errorProvider1);
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
            if (ValidacionTextBox.ValidarNoVacio(txtNombre, txtApellido, txtDNI, txtCorreoElec, txtDireccion, txtUserName, txtPass) || comboBoxTipoPerfil.SelectedIndex < 0)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Usuario user = new Usuario()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = int.Parse(txtDNI.Text),
                    CorreoElectronico = txtCorreoElec.Text,
                    Direccion = txtDireccion.Text,
                    NombreUsuario = txtUserName.Text,
                    Contraseña = txtPass.Text,
                    FotoPerfil = "NO IMAGEN",
                    IdPerfilUsuario = comboBoxTipoPerfil.SelectedIndex + 1
                };

                dbHotelParana.Add(user);
                dbHotelParana.SaveChanges();
                MessageBox.Show("El usuario se registro correctamente", "Guardar", MessageBoxButtons.OK);
                dataGridView1.DataSource = dbHotelParana.Usuarios.ToList();

                txtApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtDNI.Text = string.Empty;
                txtCorreoElec.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtUserName.Text = string.Empty;
                txtPass.Text = string.Empty;
                // Para restablecer el ComboBox a la opción predeterminada
                comboBoxTipoPerfil.SelectedItem = 0;

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

        private void CargaTextboxsDelDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila y carga en los TextBox y ComboBox
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
                txtCorreoElec.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtUserName.Text = row.Cells["NombreUsuario"].Value.ToString();
                txtPass.Text = row.Cells["Contraseña"].Value.ToString();

                // Aquí asumimos que el ComboBox muestra el nombre del perfil de usuario
                comboBoxTipoPerfil.SelectedIndex = int.Parse(row.Cells["IdPerfilUsuario"].Value.ToString()) - 1;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if((ValidacionTextBox.ValidarNoVacio(txtNombre, txtApellido, txtDNI, txtCorreoElec, txtDireccion, txtUserName, txtPass) || comboBoxTipoPerfil.SelectedIndex < 0))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Obtiene los valores de los textbox.
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni = int.Parse(txtDNI.Text);
                string correoElectronico = txtCorreoElec.Text;
                string direccion = txtDireccion.Text;
                string nombreUsuario = txtUserName.Text;
                string contraseña = txtPass.Text;
                int idPerfilUsuario = comboBoxTipoPerfil.SelectedIndex + 1; // Suponiendo que el índice comienza en 1

                // Realiza la actualización en la base de datos.
                Usuario usuario = dbHotelParana.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

                if (usuario != null)
                {
                    usuario.Nombre = nombre;
                    usuario.Apellido = apellido;
                    usuario.Dni = dni;
                    usuario.CorreoElectronico = correoElectronico;
                    usuario.Direccion = direccion;
                    usuario.NombreUsuario = nombreUsuario;
                    usuario.Contraseña = contraseña;
                    usuario.IdPerfilUsuario = idPerfilUsuario;

                    // Guarda los cambios en la base de datos.
                    dbHotelParana.SaveChanges();
                    // Actualiza el DataGridView
                    dataGridView1.DataSource = dbHotelParana.Usuarios.ToList();

                    txtApellido.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                    txtDNI.Text = string.Empty;
                    txtCorreoElec.Text = string.Empty;
                    txtDireccion.Text = string.Empty;
                    txtUserName.Text = string.Empty;
                    txtPass.Text = string.Empty;
                    // Para restablecer el ComboBox a la opción predeterminada
                    comboBoxTipoPerfil.SelectedItem = 0;

                    // Muestra un mensaje de éxito.
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el usuario para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
