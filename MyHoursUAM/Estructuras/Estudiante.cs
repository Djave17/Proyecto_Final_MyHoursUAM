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
        
        public Asistencia asistencia { get; set; }
    }


}
