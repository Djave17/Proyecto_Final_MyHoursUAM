using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    internal class Partidos: Evento
    {
            public string nombrePartidos { get; set; }
            public string fechaPartidos { get; set; }
            public string horaPartidos { get; set; }
            public int horasConvalidas { get; set; }
            public string organizadorPartidos { get; set; }
            public string lugarPartidos { get; set; }
             public string deporteEvento { get; set; }   
            public string rival { get; set; }
            public int cupos { get; set; }

    }
}
