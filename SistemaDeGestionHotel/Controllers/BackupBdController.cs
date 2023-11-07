using SistemaDeGestionHotel.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Controllers
{
    public class BackupBdController
    {
        DBackupRestauracion d_backup = new DBackupRestauracion();

        public void RealizarRespaldo(string nombreArchivoRespaldo)
        {
            d_backup.RealizarRespaldo(nombreArchivoRespaldo);
        }

        public void RealizarRestauracion(string nombreArchivoRespaldo)
        {
            d_backup.RealizarRestauracion(nombreArchivoRespaldo);
        }

    }
}
