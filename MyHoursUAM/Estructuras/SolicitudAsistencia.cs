using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    [Serializable]
    internal class SolicitudAsistencia
    {
        public string Id { get; set; }
        public string EstudianteId { get; set; }
        public string EventoId { get; set; }
        public Evento Eventos { get; set; }
        public Partido Partidos { get; set; }
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
