using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp.Estructuras
{
    [Serializable]
    internal class Estudiante
    {
        public string nombreEstudiante { get; set; }

        public string apellidoEstudiante { get; set; }
        public int HorasCompletadas { get; set; }

        public string correoEstudiante { get; set; }
        public string cifEstudiante { get; set; }
        public string contraseñaEstudiante { get; set; }
        
       
        public List<string> eventosAsistidos { get;  set; } // IDs de eventos asistidos
        public List<string> partidosAsistidos { get; set; } // IDs de eventos asistidos
        public Asistencia asistencia { get; set; }

        // Constructor
        public Estudiante()
        {
            eventosAsistidos = new List<string>();
            asistencia = new Asistencia();
        }

        // Método para registrar asistencia y contar las horas y partidos realizados
        
    }

}



