using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using SistemaDeGestionHotel.views.recep;
using Button = System.Windows.Forms.Button;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionHabitaciones : Form
    {

        HabitacionController habitacion_controller = new HabitacionController();
        private Usuario usuarioInicioSesion;


        public gestionHabitaciones(Usuario usuario)
        {
            InitializeComponent();

            usuarioInicioSesion = usuario;

        }



        private void gestionHabitaciones_Load(object sender, EventArgs e)
        {
            this.CargaTodasLasHabitacionesAlPanel();
        }

        private void CargaTodasLasHabitacionesAlPanel()
        {
            //limpia el panel
            panel1.Controls.Clear();

            List<Habitacion> habitacionesPiso1 = habitacion_controller.GetHabitaciones();

            // Inicializar la posición x
            int x = 100;

            foreach (Habitacion habitacion in habitacionesPiso1)
            {
                if (habitacion.IdEstado != 4 && habitacion.IdEstado != 5)
                {


                    // Crear un nuevo botón
                    Button boton = new Button();

                    //propiedades del boton 
                    boton.AutoSize = true;
                    boton.Anchor = AnchorStyles.None;
                    boton.Size = new Size(140, 55);
                    boton.FlatAppearance.BorderSize = 0;
                    //boton.FlatAppearance.BorderColor = Color.Black;
                    //boton.FlatAppearance.BorderSize = 1;

                    if (habitacion.IdEstado == 1)
                    {
                        boton.BackColor = Color.MediumSpringGreen;
                    }
                    if (habitacion.IdEstado == 2)
                    {
                        boton.BackColor = Color.Red;
                    }
                    if (habitacion.IdEstado == 3)
                    {
                        boton.BackColor = Color.SandyBrown;
                    }

                    // Establecer el texto del botón con el número de habitación
                    boton.Text = $"{habitacion.NroHabitacion}";

                    // Establecer el nombre del botón con el ID de la habitación
                    boton.Name = $"{habitacion.IdHabitacion}";

                    // Establecer la ubicación del botón
                    boton.Location = new Point(x, 100);

                    // Crear un nuevo ToolTip
                    ToolTip toolTip = new ToolTip();
                    toolTip.IsBalloon = true;
                    // Establecer el texto del ToolTip
                    toolTip.SetToolTip(boton, $"Nro de Piso: {habitacion.IdPiso}\nTipo Habitación: {habitacion.IdTipoHabNavigation.NombTipo} \nPrecio: ${habitacion.Precio} \nCantidad Camas: {habitacion.CantidadCamas}");


                    // Añadir el botón al panel
                    panel1.Controls.Add(boton);

                    if (habitacion.IdEstado == 2)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionOcupada_Click;
                    }
                    else if (habitacion.IdEstado == 3)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionReservada_Click;
                    }
                    else if (habitacion.IdEstado == 1)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += Habitacion_Click;
                    }



                    // Incrementar la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TNumHabitacion))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int nroHabitacion = int.Parse(TNumHabitacion.Text);
                List<Habitacion> habitacionesBuscadas = habitacion_controller.GetHabitacionesByNroHabitacion(nroHabitacion);

                if (habitacionesBuscadas != null && habitacionesBuscadas.Count > 0)
                {
                    panel1.Controls.Clear();
                    foreach (Habitacion habitacionBuscada in habitacionesBuscadas)
                    {
                        if (habitacionBuscada.IdEstado != 4 && habitacionBuscada.IdEstado != 5)
                        {
                            // Crear un nuevo botón
                            Button boton = new Button();

                            //propiedades del boton 
                            boton.AutoSize = true;
                            boton.Anchor = AnchorStyles.None;
                            boton.Size = new Size(140, 55);
                            boton.FlatAppearance.BorderSize = 0;

                            if (habitacionBuscada.IdEstado == 1)
                            {
                                boton.BackColor = Color.MediumSpringGreen;
                            }
                            if (habitacionBuscada.IdEstado == 2)
                            {
                                boton.BackColor = Color.Red;
                            }
                            if (habitacionBuscada.IdEstado == 3)
                            {
                                boton.BackColor = Color.SandyBrown;
                            }

                            // Establecer el texto del botón con el número de habitación
                            boton.Text = $"{habitacionBuscada.NroHabitacion}";

                            // Establecer el nombre del botón con el ID de la habitación
                            boton.Name = $"{habitacionBuscada.IdHabitacion}";

                            // Establecer la ubicación del botón
                            boton.Location = new Point(50, 80);

                            // Crear un nuevo ToolTip
                            ToolTip toolTip = new ToolTip();
                            toolTip.IsBalloon = true;
                            // Establecer el texto del ToolTip
                            toolTip.SetToolTip(boton, $"Nro de Piso: {habitacionBuscada.IdPiso}\nTipo Habitación: {habitacionBuscada.IdTipoHabNavigation.NombTipo} \nPrecio: ${habitacionBuscada.Precio} \nCantidad Camas: {habitacionBuscada.CantidadCamas}");

                            // Añadir el botón al panel
                            panel1.Controls.Add(boton);

                            if (habitacionBuscada.IdEstado == 2)
                            {
                                // Agrega el mismo manejador de eventos Click a todos los botones
                                boton.Click += HabitacionOcupada_Click;
                            }
                            else if (habitacionBuscada.IdEstado == 3)
                            {
                                // Agrega el mismo manejador de eventos Click a todos los botones
                                boton.Click += HabitacionReservada_Click;
                            }
                            else if (habitacionBuscada.IdEstado == 1)
                            {
                                // Agrega el mismo manejador de eventos Click a todos los botones
                                boton.Click += Habitacion_Click;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Habitación no encontrada");
                }
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

        private void MostrarHabitacionesPorPiso(int numeroPiso)
        {
            // Limpia el panel
            panel1.Controls.Clear();

            // Obtiene la lista de habitaciones del piso especificado
            List<Habitacion> habitaciones = habitacion_controller.GetHabitacionesByNroPiso(numeroPiso);

            // Inicializa la posición x
            int x = 50;

            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.IdEstado != 4 && habitacion.IdEstado != 5)
                {
                    // Crea un nuevo botón
                    Button boton = new Button();

                    // Propiedades del botón
                    boton.AutoSize = true;
                    boton.Anchor = AnchorStyles.None;
                    boton.Size = new Size(140, 55);
                    boton.FlatAppearance.BorderSize = 0;

                    // Establece el color del botón según el estado de la habitación
                    if (habitacion.IdEstado == 1)
                    {
                        boton.BackColor = Color.MediumSpringGreen;
                    }
                    if (habitacion.IdEstado == 2)
                    {
                        boton.BackColor = Color.Red;
                    }
                    if (habitacion.IdEstado == 3)
                    {
                        boton.BackColor = Color.SandyBrown;
                    }

                    // Establece el texto del botón con el número de habitación
                    boton.Text = $"{habitacion.NroHabitacion}";

                    // Establece el nombre del botón con el ID de la habitación
                    boton.Name = $"{habitacion.IdHabitacion}";

                    // Establece la ubicación del botón
                    boton.Location = new Point(x, 100);

                    // Crear un nuevo ToolTip
                    ToolTip toolTip = new ToolTip();
                    toolTip.IsBalloon = true;
                    // Establecer el texto del ToolTip
                    toolTip.SetToolTip(boton, $"Nro de Piso: {habitacion.IdPiso}\nTipo Habitación: {habitacion.IdTipoHabNavigation.NombTipo} \nPrecio: ${habitacion.Precio} \nCantidad Camas: {habitacion.CantidadCamas}");

                    // Añade el botón al panel
                    panel1.Controls.Add(boton);


                    if (habitacion.IdEstado == 2)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionOcupada_Click;
                    }
                    else if (habitacion.IdEstado == 3)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionReservada_Click;
                    }
                    else if (habitacion.IdEstado == 1)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += Habitacion_Click;
                    }


                    // Incrementa la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }
        }


        private void btnFiltroPiso1_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionesPorPiso(1);
        }

        private void btnFiltroPiso2_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionesPorPiso(2);
        }

        private void btnFiltroPiso3_Click(object sender, EventArgs e)
        {

            this.MostrarHabitacionesPorPiso(3);
        }

        private void MostrarHabitacionPorTipo(int tipo)
        {
            //limpia el panel
            panel1.Controls.Clear();

            List<Habitacion> habitacionesPiso1 = habitacion_controller.GetHabitacionesByTipoHabitacion(tipo);

            // Inicializar la posición x
            int x = 50;

            foreach (Habitacion habitacion in habitacionesPiso1)
            {
                if (habitacion.IdEstado != 4 && habitacion.IdEstado != 5)
                {


                    // Crear un nuevo botón
                    Button boton = new Button();

                    //propiedades del boton 
                    boton.AutoSize = true;
                    boton.Anchor = AnchorStyles.None;
                    boton.Size = new Size(140, 55);
                    boton.FlatAppearance.BorderSize = 0;
                    //boton.FlatAppearance.BorderColor = Color.Black;
                    //boton.FlatAppearance.BorderSize = 1;

                    if (habitacion.IdEstado == 1)
                    {
                        boton.BackColor = Color.MediumSpringGreen;
                    }
                    if (habitacion.IdEstado == 2)
                    {
                        boton.BackColor = Color.Red;
                    }
                    if (habitacion.IdEstado == 3)
                    {
                        boton.BackColor = Color.SandyBrown;
                    }

                    // Establecer el texto del botón con el número de habitación
                    boton.Text = $"{habitacion.NroHabitacion}";

                    // Establecer el nombre del botón con el ID de la habitación
                    boton.Name = $"{habitacion.IdHabitacion}";

                    // Establecer la ubicación del botón
                    boton.Location = new Point(x, 100);

                    // Crear un nuevo ToolTip
                    ToolTip toolTip = new ToolTip();
                    toolTip.IsBalloon = true;
                    // Establecer el texto del ToolTip
                    toolTip.SetToolTip(boton, $"Nro de Piso: {habitacion.IdPiso}\nTipo Habitación: {habitacion.IdTipoHabNavigation.NombTipo} \nPrecio: ${habitacion.Precio} \nCantidad Camas: {habitacion.CantidadCamas}");

                    // Añadir el botón al panel
                    panel1.Controls.Add(boton);

                    if (habitacion.IdEstado == 2)
                    {

                    }
                    else if (habitacion.IdEstado == 3)
                    {

                    }
                    if (habitacion.IdEstado == 2)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionOcupada_Click;
                    }
                    else if (habitacion.IdEstado == 3)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionReservada_Click;
                    }
                    else if (habitacion.IdEstado == 1)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += Habitacion_Click;
                    }

                    // Incrementar la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }
        }

        private void btnFiltroSimple_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionPorTipo(1);
        }

        private void btnFiltroDoble_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionPorTipo(2);
        }

        private void btnFiltroTriple_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionPorTipo(3);
        }

        private void MostrarHabitacionPorEstado(int estado)
        {
            //limpia el panel
            panel1.Controls.Clear();

            List<Habitacion> habitacionesPiso1 = habitacion_controller.GetHabitacionesByEstado(estado);

            // Inicializar la posición x
            int x = 50;

            foreach (Habitacion habitacion in habitacionesPiso1)
            {
                if (habitacion.IdEstado != 4 && habitacion.IdEstado != 5)
                {


                    // Crear un nuevo botón
                    Button boton = new Button();

                    //propiedades del boton 
                    boton.AutoSize = true;
                    boton.Anchor = AnchorStyles.None;
                    boton.Size = new Size(140, 55);
                    boton.FlatAppearance.BorderSize = 0;
                    //boton.FlatAppearance.BorderColor = Color.Black;
                    //boton.FlatAppearance.BorderSize = 1;

                    if (habitacion.IdEstado == 1)
                    {
                        boton.BackColor = Color.MediumSpringGreen;
                    }
                    if (habitacion.IdEstado == 2)
                    {
                        boton.BackColor = Color.Red;
                    }
                    if (habitacion.IdEstado == 3)
                    {
                        boton.BackColor = Color.SandyBrown;
                    }

                    // Establecer el texto del botón con el número de habitación
                    boton.Text = $"{habitacion.NroHabitacion}";

                    // Establecer el nombre del botón con el ID de la habitación
                    boton.Name = $"{habitacion.IdHabitacion}";

                    // Establecer la ubicación del botón
                    boton.Location = new Point(x, 100);

                    // Crear un nuevo ToolTip
                    ToolTip toolTip = new ToolTip();
                    toolTip.IsBalloon = true;
                    // Establecer el texto del ToolTip
                    toolTip.SetToolTip(boton, $"Nro de Piso: {habitacion.IdPiso}\nTipo Habitación: {habitacion.IdTipoHabNavigation.NombTipo} \nPrecio: ${habitacion.Precio} \nCantidad Camas: {habitacion.CantidadCamas}");

                    // Añadir el botón al panel
                    panel1.Controls.Add(boton);

                    if (habitacion.IdEstado == 2)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionOcupada_Click;
                    }
                    else if (habitacion.IdEstado == 3)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += HabitacionReservada_Click;
                    }
                    else if (habitacion.IdEstado == 1)
                    {
                        // Agrega el mismo manejador de eventos Click a todos los botones
                        boton.Click += Habitacion_Click;
                    }

                    // Incrementar la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }
        }

        private void btnFiltroReservado_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionPorEstado(3);
        }

        private void btnFiltroOcupado_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionPorEstado(2);
        }

        private void btnFiltroLibre_Click(object sender, EventArgs e)
        {
            this.MostrarHabitacionPorEstado(1);
        }

        private void todasLasHabitaciones_Click(object sender, EventArgs e)
        {
            this.CargaTodasLasHabitacionesAlPanel();
        }

        private void HabitacionOcupada_Click(object sender, EventArgs e)
        {
            Button botonClicado = sender as Button;

            if (botonClicado != null)
            {
                if (int.TryParse(botonClicado.Name, out int idHabitacion))
                {
                    Form form = new InfoRegistro(idHabitacion, usuarioInicioSesion);
                    form.ShowDialog();
                    this.CargaTodasLasHabitacionesAlPanel();
                }
            }
        }

        private void HabitacionReservada_Click(object sender, EventArgs e)
        {
            Button botonClicado = sender as Button;

            if (botonClicado != null)
            {
                if (int.TryParse(botonClicado.Name, out int idHabitacion))
                {
                    Form form = new InfoRegistro(idHabitacion, usuarioInicioSesion);
                    form.ShowDialog();
                    this.CargaTodasLasHabitacionesAlPanel();
                }
            }
        }

        private void Habitacion_Click(object sender, EventArgs e)
        {
            Button botonClicado = sender as Button;

            if (botonClicado != null)
            {
                if (int.TryParse(botonClicado.Name, out int idHabitacion))
                {
                    Form form = new ConsultaDni(idHabitacion, usuarioInicioSesion);
                    form.ShowDialog();
                    this.CargaTodasLasHabitacionesAlPanel();
                }
            }

        }

        private void ActualizarHabitaciones(object sender, EventArgs e)
        {
            this.CargaTodasLasHabitacionesAlPanel();
            this.Refresh();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }
    }
}
