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
    public partial class FormBackUp : Form
    {

        BackupBdController backup_controller = new BackupBdController();

        public FormBackUp()
        {
            InitializeComponent();
        }

        private void FormBackUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de respaldo SQL Server (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar respaldo de base de datos";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivoRespaldo = saveFileDialog.FileName;
                backup_controller.RealizarRespaldo(nombreArchivoRespaldo);
            }
        }
    }
}
