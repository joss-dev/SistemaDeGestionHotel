using SistemaDeGestionHotel.LO;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.Datos;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class registroUsuario : Form
    {

        UsuarioController usuario_controller = new UsuarioController();
        PerfilUsuarioController perfilUsuario_controller = new PerfilUsuarioController();

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

                try
                {
                    usuario_controller.AgregarUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreoElec.Text, txtDireccion.Text, txtUserName.Text, txtPass.Text, "No imagen", comboBoxTipoPerfil.SelectedIndex);
                    MessageBox.Show("El usuario se registro correctamente", "Guardar", MessageBoxButtons.OK);
                }
                catch (FormatException ec)
                {
                    MessageBox.Show("Ocurrio un error al agregar el usuario" + ec.Message);
                }


                //dataGridView1.DataSource = dbHotelParana.Usuarios.ToList();

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
            //else
            //{
            //    // Obtiene los valores de los textbox.
            //    string nombre = txtNombre.Text;
            //    string apellido = txtApellido.Text;
            //    int dni = int.Parse(txtDNI.Text);
            //    string correoElectronico = txtCorreoElec.Text;
            //    string direccion = txtDireccion.Text;
            //    string nombreUsuario = txtUserName.Text;
            //    string contraseña = txtPass.Text;
            //    int idPerfilUsuario = comboBoxTipoPerfil.SelectedIndex + 1; // Suponiendo que el índice comienza en 1

            //    // Realiza la actualización en la base de datos.
            //    Usuario usuario = dbHotelParana.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            //    if (usuario != null)
            //    {
            //        usuario.Nombre = nombre;
            //        usuario.Apellido = apellido;
            //        usuario.Dni = dni;
            //        usuario.CorreoElectronico = correoElectronico;
            //        usuario.Direccion = direccion;
            //        usuario.NombreUsuario = nombreUsuario;
            //        usuario.Contraseña = contraseña;
            //        usuario.IdPerfilUsuario = idPerfilUsuario;

            //        // Guarda los cambios en la base de datos.
            //        dbHotelParana.SaveChanges();
            //        // Actualiza el DataGridView
            //        dataGridView1.DataSource = dbHotelParana.Usuarios.ToList();

            //        txtApellido.Text = string.Empty;
            //        txtNombre.Text = string.Empty;
            //        txtDNI.Text = string.Empty;
            //        txtCorreoElec.Text = string.Empty;
            //        txtDireccion.Text = string.Empty;
            //        txtUserName.Text = string.Empty;
            //        txtPass.Text = string.Empty;
            //        // Para restablecer el ComboBox a la opción predeterminada
            //        comboBoxTipoPerfil.SelectedItem = 0;

            //        // Muestra un mensaje de éxito.
            //        MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //MessageBox.Show("No se pudo encontrar el usuario para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }


        private void btnIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Generar un nombre de archivo único
                string nombreAleatorio = Path.GetRandomFileName();

                // Obtener la extensión de la imagen original
                string extension = Path.GetExtension(openFileDialog.FileName);

                // Combinar el nombre único con la extensión
                string nuevoNombreArchivo = nombreAleatorio + extension;

                string crearuta = Path.Combine(Application.StartupPath, "imagenesPerfil");

                // Ruta de destino en la carpeta "imagenesPerfil" en el directorio de tu proyecto
                string rutaDestino = Path.Combine(Application.StartupPath, "imagenesPerfil", nuevoNombreArchivo);

                if (!Directory.Exists(crearuta))
                {
                    Directory.CreateDirectory(crearuta);
                }


                // Mostrar la imagen seleccionada en el PictureBox
                pictureBoxUsuario.Image = new Bitmap(openFileDialog.FileName);

                // Obtiene la ruta completa del archivo seleccionado
                string archivoSeleccionado = openFileDialog.FileName;

                // Copia el archivo a la carpeta "imagenesPerfil" usando el nuevo nombre y la ruta completa de destino
                File.Copy(archivoSeleccionado, rutaDestino);


            }

        }

        private void FormatoIdPerfil(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
                    e.Value = "admin";
                }
                else if (idPerfil == 3)
                {
                    e.Value = "Recepcionista";
                }

                // Establecer Handled en true para indicar que hemos manejado la formateo de la celda
                e.FormattingApplied = true;
            }
        }
    }
}
