﻿using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class registroUsuario : Form
    {

        UsuarioController usuario_controller = new UsuarioController();
        PerfilUsuarioController perfilUsuario_controller = new PerfilUsuarioController();
        private string destinationPath = "NO IMAGEN";

        public registroUsuario()
        {
            InitializeComponent();

            dataGridView1.DataSource = usuario_controller.GetUsuarios();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Limpiar los comboBox
            comboBoxTipoPerfil.Items.Clear();

            // Agregar las opciones al comboBox
            foreach (string opcion in perfilUsuario_controller.GetTiposPerfil())
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
                // Verifica que la longitud de la entrada esté entre 7 y 8.
                if (txtDNI.Text.Length < 7 || txtDNI.Text.Length > 8)
                {
                    MessageBox.Show("El DNI debe tener entre 7 y 8 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (VerificarEmail.Verificar_Email(txtCorreoElec.Text))
                    {
                        if (usuario_controller.AgregarUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreoElec.Text, txtDireccion.Text, txtUserName.Text, txtPass.Text, destinationPath, comboBoxTipoPerfil.SelectedIndex))
                        {
                            MessageBox.Show("El usuarioo se registro correctamente", "Guardar", MessageBoxButtons.OK);
                            txtApellido.Text = string.Empty;
                            txtNombre.Text = string.Empty;
                            txtDNI.Text = string.Empty;
                            txtCorreoElec.Text = string.Empty;
                            txtDireccion.Text = string.Empty;
                            txtUserName.Text = string.Empty;
                            txtPass.Text = string.Empty;
                            // Para restablecer el ComboBox a la opción predeterminada
                            comboBoxTipoPerfil.SelectedItem = 0;
                            dataGridView1.DataSource = usuario_controller.GetUsuarios();
                            destinationPath = "NO IMAGEN";
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo electronico no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                // Carga la imagen en el PictureBox
                string imagePath = row.Cells["fotoPerfil"].Value.ToString();
                if (String.Equals(imagePath, "NO IMAGEN", StringComparison.OrdinalIgnoreCase) || String.Equals(imagePath, "no imagen", StringComparison.OrdinalIgnoreCase))
                {

                }
                else
                {
                    pictureBoxUsuario.Image = Image.FromFile(imagePath);
                }

                // Aquí asumimos que el ComboBox muestra el nombre del perfil de usuario
                comboBoxTipoPerfil.SelectedIndex = int.Parse(row.Cells["IdPerfilUsuario"].Value.ToString()) - 1;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((ValidacionTextBox.ValidarNoVacio(txtNombre, txtApellido, txtDNI, txtCorreoElec, txtDireccion, txtUserName) || comboBoxTipoPerfil.SelectedIndex < 0))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idUsuario = -1; // Valor predeterminado si no se selecciona ningún usuario

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                    int rowIndex = dataGridView1.SelectedRows[0].Index;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    idUsuario = int.Parse(row.Cells["IdUsuario"].Value.ToString());
                }
                if (idUsuario != -1)
                {
                    Usuario usuarioEditar = usuario_controller.GetUsuarioByID(idUsuario);

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea editar el usuario con DNI: " + usuarioEditar.Dni.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                    if (ask == MsgBoxResult.Yes)
                    {
                        if (VerificarEmail.Verificar_Email(txtCorreoElec.Text))
                        {
                            bool result = usuario_controller.EditarUsuario(usuarioEditar.IdUsuario, txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreoElec.Text, txtDireccion.Text, txtUserName.Text, txtPass.Text, destinationPath, comboBoxTipoPerfil.SelectedIndex);
                            if (result)
                            {
                                MessageBox.Show("El Usuario con DNI: " + usuarioEditar.Dni.ToString() + " se edito correctamente", "Confirmado", MessageBoxButtons.OK);

                                idUsuario = -1;
                                dataGridView1.DataSource = usuario_controller.GetUsuarios();

                                txtApellido.Text = string.Empty;
                                txtNombre.Text = string.Empty;
                                txtDNI.Text = string.Empty;
                                txtCorreoElec.Text = string.Empty;
                                txtDireccion.Text = string.Empty;
                                txtUserName.Text = string.Empty;
                                txtPass.Text = string.Empty;
                                // Para restablecer el ComboBox a la opción predeterminada
                                comboBoxTipoPerfil.SelectedItem = 0;
                                destinationPath = "NO IMAGEN";
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El correo electronico no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No selecciono ningun usuario");
                }
            }
        }


        private void btnIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Aquí tienes la ruta de la imagen seleccionada
                string filePath = openFileDialog.FileName;

                // Carpeta de destino
                string destinationFolder = Path.Combine(Application.StartupPath, "imagenesPerfil");
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Generar un nombre de archivo aleatorio y copiar la imagen a la carpeta de destino
                string fileName = Path.GetRandomFileName() + Path.GetExtension(filePath);
                destinationPath = Path.Combine(destinationFolder, fileName);

                File.Copy(filePath, destinationPath);
            }


        }

        private void FormatoIdPerfil(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Estado"].Index)
            {
                e.Value = (int)e.Value == 0 ? "Inactivo" : "Activo";
            }
            if (e.ColumnIndex == dataGridView1.Columns["IdPerfilUsuario"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor en la celda actual
                int idPerfil = (int)dataGridView1.Rows[e.RowIndex].Cells["IdPerfilUsuario"].Value;

                // Asignar el valor que deseas mostrar
                if (idPerfil == 1)
                {
                    e.Value = "Superadmin";
                }
                else if (idPerfil == 2)
                {
                    e.Value = "Admin";
                }
                else if (idPerfil == 3)
                {
                    e.Value = "Recepcionista";
                }

                // Establecer Handled en true para indicar que hemos manejado la formateo de la celda
                e.FormattingApplied = true;
            }

            //agrega color a las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Especifica el nombre de la columna que contiene el valor para determinar el color
                string columnName = "Estado";

                // Comprueba si la columna actual es la que deseas evaluar
                if (dataGridView1.Columns[e.ColumnIndex].Name == columnName)
                {
                    // Obtiene el valor de la celda actual
                    int cellValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Cambia el color de fondo de la fila en función del valor de la celda
                    if (cellValue == 1)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (cellValue == 0)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Restablece los colores predeterminados si no se cumple ninguna condición
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuario = -1; // Valor predeterminado si no se selecciona ningún usuario

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idUsuario = int.Parse(row.Cells["IdUsuario"].Value.ToString());
            }
            if (idUsuario != -1)
            {
                Usuario usuarioBaja = usuario_controller.GetUsuarioByID(idUsuario);

                if (usuarioBaja.Estado == 0)
                {
                    MessageBox.Show("El usuario ya se encuentra eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea dar de baja el usuario con DNI: " + usuarioBaja.Dni.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                    if (ask == MsgBoxResult.Yes)
                    {
                        bool result = usuario_controller.BajaUsuario(usuarioBaja.IdUsuario);
                        if (result)
                        {
                            MessageBox.Show("El Usuario con DNI: " + usuarioBaja.Dni.ToString() + " se dio de baja correctamente", "Confirmado", MessageBoxButtons.OK);

                            idUsuario = -1;
                            dataGridView1.DataSource = usuario_controller.GetUsuarios();

                            txtApellido.Text = string.Empty;
                            txtNombre.Text = string.Empty;
                            txtDNI.Text = string.Empty;
                            txtCorreoElec.Text = string.Empty;
                            txtDireccion.Text = string.Empty;
                            txtUserName.Text = string.Empty;
                            txtPass.Text = string.Empty;
                            // Para restablecer el ComboBox a la opción predeterminada
                            comboBoxTipoPerfil.SelectedItem = 0;
                            destinationPath = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun usuario");
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            int idUsuario = -1; // Valor predeterminado si no se selecciona ningún usuario

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idUsuario = int.Parse(row.Cells["IdUsuario"].Value.ToString());
            }
            if (idUsuario != -1)
            {
                Usuario usuarioBaja = usuario_controller.GetUsuarioByID(idUsuario);

                if (usuarioBaja.Estado == 1)
                {
                    MessageBox.Show("El usuario ya se encuentra activado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea dar de alta el usuario con DNI: " + usuarioBaja.Dni.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                    if (ask == MsgBoxResult.Yes)
                    {
                        bool result = usuario_controller.AltaUsuario(usuarioBaja.IdUsuario);
                        if (result)
                        {
                            MessageBox.Show("El Usuario con DNI: " + usuarioBaja.Dni.ToString() + " se dio de alta correctamente", "Confirmado", MessageBoxButtons.OK);

                            idUsuario = -1;
                            dataGridView1.DataSource = usuario_controller.GetUsuarios();

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
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun usuario");
            }
        }
    }
}
