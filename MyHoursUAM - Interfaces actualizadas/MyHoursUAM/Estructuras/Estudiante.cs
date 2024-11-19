using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    internal class Estudiante
    {
        public string nombreEstudiante { get; set; }

        public string apellidoEstudiante { get; set; }

        public string correoEstudiante { get; set; }
        public string cifEstudiante { get; set; }
        public string contraseñaEstudiante { get; set; }
        public string eventosAsistidos { get; set; }
        public string partidosAsistidos { get; set; }
        public int horasCompletadas { get; set; }
        public int cantidadPartidosAsistidos { get; set; }
        public string comprobanteAsistencia { get; set; }
        public string solicitudAsistencia { get; set; }
    }


}
