using SistemaDeGestionHotel.NEntidades;
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

namespace SistemaDeGestionHotel.views.recep
{
    public partial class VerFactura : Form
    {
        FacturaHtml factu = new FacturaHtml();
        private Pago pagoFactura;
        private Registro registroFactura;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        
        public VerFactura(Pago pago, Registro registro)
        {
            InitializeComponent();

            pagoFactura = pago;
            registroFactura = registro;

            webBrowser1 = new System.Windows.Forms.WebBrowser();

            // Inicializa el botón de impresión
            printButton = new System.Windows.Forms.Button();
            printButton.Text = "Guardar como Pdf";
            printButton.Click += PrintButton_Click;

            Controls.Add(printButton);

            
            this.Controls.Add(webBrowser1);
            
            webBrowser1.Dock = DockStyle.Fill;

            webBrowser1.DocumentText = factu.GeneraFactura(pagoFactura, registroFactura);

        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Imprime el contenido del WebBrowser
            webBrowser1.Print();
        }

    }
}
