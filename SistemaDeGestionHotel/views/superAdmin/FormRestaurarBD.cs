using SistemaDeGestionHotel.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.superAdmin
{
    public partial class FormRestaurarBD : Form
    {
        BackupBdController backup_controller = new BackupBdController();
        public FormRestaurarBD()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de respaldo SQL Server (*.bak)|*.bak";
            openFileDialog.Title = "Seleccionar archivo de respaldo de base de datos";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivoRespaldo = openFileDialog.FileName;

                // Realizar la restauración desde el archivo seleccionado
                backup_controller.RealizarRestauracion(nombreArchivoRespaldo);
            }
        }
    }
}
