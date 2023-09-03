using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TUsuario_Enter(object sender, EventArgs e)
        {
            if (TUsuario.Text == "Usuario")
            {
                TUsuario.Text = "";
                TUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TUsuario_Leave(object sender, EventArgs e)
        {
            if (TUsuario.Text == "")
            {
                TUsuario.Text = "Usuario";
                TUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TPass_Enter(object sender, EventArgs e)
        {
            if (TPass.Text == "Contraseña")
            {
                TPass.Text = "";
                TPass.ForeColor = Color.LightGray;
                TPass.UseSystemPasswordChar = true;
            }
        }

        private void TPass_Leave(object sender, EventArgs e)
        {
            if (TPass.Text == "")
            {
                TPass.Text = "Contraseña";
                TPass.ForeColor = Color.DimGray;
                TPass.UseSystemPasswordChar = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
        }

        void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.Close();
            }
        }


    }
}
