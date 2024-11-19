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
        public string fechaEvento { get; set; }
        public string horaEvento { get; set; }
        public string descripcionEvento { get; set; }
        public int horasConvalidas { get; set; }
        public string organizadorEvento { get; set; }
        public string lugarEvento { get; set; }
        public string idEvento { get; set; }



        public enum TipoEvento
        {
            deportivo,
            cultural,
            social,
            voluntario
        }
    }
}
