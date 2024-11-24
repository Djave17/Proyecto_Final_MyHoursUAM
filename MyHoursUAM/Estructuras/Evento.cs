using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    internal class Evento
    {
        public string nombreEvento { get; set; }
        public enum EstadoEvento
        {
            Disponible,
            No_Disponible
        }

        public EstadoEvento estadoEvento { get; set; }
        public string fechaEvento { get; set; }
        public string horaEvento { get; set; }
        public string descripcionEvento { get; set; }
        public int cantidadConvalidar { get; set; }
        public string organizadorEvento { get; set; }
        public string lugarEvento { get; set; }
        public string tipoBeneficio { get; set; }
        public string idEvento { get; set; }
        public int cupos { get; set; }
        public enum TipoEvento
        {
            deportivo,
            cultural,
            social,
            voluntario
        }
        public TipoEvento tipoEvento { get; set; }

    }
}
