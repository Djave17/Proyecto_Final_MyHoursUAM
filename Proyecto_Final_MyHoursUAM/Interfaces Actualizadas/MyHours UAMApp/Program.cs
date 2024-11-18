using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp
{
        internal class Estudiante
        {
            public string cifEstudiante { get; set; }
            public string contraseñaEstudiante { get; set; }
            public string eventosAsistidos { get; set; }
            public string partidosAsistidos { get; set; }
            public int horasCompletadas { get; set; }
            public int cantidadPartidosAsistidos { get; set; }
            public string comprobanteAsistencia { get; set; }
            public string solicitudAsistencia { get; set; }


        }
        internal class Trabajador
        {
            public string cifTrabajador { get; set; }
            public string contraseñaTrabajador { get; set; }


        }

        internal class Evento
        {
            public string nombreEvento { get; set; }
            public string fechaEvento { get; set; }
            public string horaEvento { get; set; }
            public string descripcionEvento { get; set; }
            public int horasConvalidas { get; set; }
            public string organizadorEvento { get; set; }


        }

        internal class Partido
        {
            public string Rival { get; set; }
            public string fechaEvento { get; set; }
            public string horaEvento { get; set; }
            public string deporte { get; set; }
            public int partidosConvalidas { get; set; }


        }

        internal class ActividadLaboral
        {
            public string Actividad { get; set; }
            public string LugarActividad { get; set; }
            public string HorasTrabajadas { get; set; }


        }

        internal class Usuario
        {
            public string CIF { get; set; }
            public string Contraseña { get; set; }
        }
}
