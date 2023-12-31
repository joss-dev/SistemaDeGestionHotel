﻿namespace SistemaDeGestionHotel
{

    public static class FormsHijos
    {


        public static void AbrirFormHija(Form formHija, Control panelContenedor)
        {


            foreach (Control control in panelContenedor.Controls)
            {
                // Si el formulario ya está abierto, lo trae al frente y termina el método.

                if (control.GetType() == formHija.GetType())
                {
                    control.BringToFront();
                    return;
                }
            }

            /* if (panelContenedor.Controls.Count > 0)
             {
                 panelContenedor.Controls.RemoveAt(0);
             }*/

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
            fh.BringToFront();
        }

    }
}