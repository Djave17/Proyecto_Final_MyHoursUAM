using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    internal class Evento
    {  
        public class HorasLaborales
        {
            public string AreaHoras { get; set; }
            public string FechaHoras { get; set; }
            public string HorarioHoras { get; set; }
            public string LugarHoras { get; set; }
            public string ActividadDispo { get; set; }
            public int CuposHoras { get; set; }
            public int CantidadConv { get; set; }
            public string DescripcionHoras { get; set; }
        }
    }
}
