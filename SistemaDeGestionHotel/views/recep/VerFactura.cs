using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class VerFactura : Form
    {
        FacturaHtml factu = new FacturaHtml();
        private Pago pagoFactura;
        private Registro registroFactura;

        public VerFactura(Pago pago, Registro registro)
        {
            InitializeComponent();

            pagoFactura = pago;
            registroFactura = registro;

            WebBrowser webBrowser1 = new WebBrowser();
            this.Controls.Add(webBrowser1);
            webBrowser1.Dock = DockStyle.Fill;

            webBrowser1.DocumentText = factu.GeneraFactura(pagoFactura, registroFactura);

            // Crear una nueva instancia de SaveFileDialog.
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Configurar el filtro para que solo se muestren los archivos PDF.
            saveFileDialog.Filter = "PDF Files|*.pdf";

            // Mostrar el cuadro de diálogo SaveFileDialog.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //factu.generarPdf(webBrowser1, saveFileDialog.FileName);
            }
        }
    }
}
