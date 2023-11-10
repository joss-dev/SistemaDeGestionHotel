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

        public bool RealizarRespaldo(string nombreArchivoRespaldo)
        {
            return d_backup.RealizarRespaldo(nombreArchivoRespaldo);
        }

        public bool RealizarRestauracion(string nombreArchivoRespaldo)
        {
            return d_backup.RealizarRestauracion(nombreArchivoRespaldo);
        }

    }
}
