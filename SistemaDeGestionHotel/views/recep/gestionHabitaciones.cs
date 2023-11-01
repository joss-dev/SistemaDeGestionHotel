using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using SistemaDeGestionHotel.views.recep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionHabitaciones : Form
    {

        HabitacionController habitacion_controller = new HabitacionController();

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

        private void btnFiltroPiso1_Click(object sender, EventArgs e)
        {
            //limpia el panel
            panel1.Controls.Clear();

            List<Habitacion> habitacionesPiso1 = habitacion_controller.GetHabitacionesByNroPiso(1);

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

                    // Añadir el botón al panel
                    panel1.Controls.Add(boton);

                    // Incrementar la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }


        }

        private void btnFiltroPiso2_Click(object sender, EventArgs e)
        {
            //limpia el panel
            panel1.Controls.Clear();

            List<Habitacion> habitacionesPiso1 = habitacion_controller.GetHabitacionesByNroPiso(2);

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

                    // Añadir el botón al panel
                    panel1.Controls.Add(boton);

                    // Incrementar la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }
        }

        private void btnFiltroPiso3_Click(object sender, EventArgs e)
        {

            //limpia el panel
            panel1.Controls.Clear();

            List<Habitacion> habitacionesPiso1 = habitacion_controller.GetHabitacionesByNroPiso(3);

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

                    // Añadir el botón al panel
                    panel1.Controls.Add(boton);

                    // Incrementar la posición x para el siguiente botón
                    x += boton.Width + 10;
                }
            }
        }
    }
}
