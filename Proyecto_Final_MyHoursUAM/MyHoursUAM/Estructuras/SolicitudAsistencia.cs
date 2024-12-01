using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    internal class SolicitudAsistencia
    {
        public int Id { get; set; }
        public string EstudianteId { get; set; }
        public Evento Evento { get; set; }
        public Partido Partido { get; set; }
        public enum Estado
        {
            Pendiente,
            Aprobado,
            Rechazado
        }// Pendiente, Aprobado, Rechazado
        public Estado EstadoSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        
    }
}
