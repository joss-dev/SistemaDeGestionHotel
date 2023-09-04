using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SistemaDeGestionHotel
{
    public partial class Principal : Form
    {
        //declaracion de icono y boton 
        private IconButton currentBtn;
        private Panel leftBorderBtn;


        public Principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        //metodo para resaltar el boton activo
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(28, 121, 182);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //panel izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        //metodo para desactivar el resaltado

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
