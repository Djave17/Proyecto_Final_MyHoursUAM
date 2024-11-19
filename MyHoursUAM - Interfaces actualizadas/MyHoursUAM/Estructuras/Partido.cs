﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
    internal class Partido: Evento
    {
        public string nombrePartido { get; set; }
        public string lugarPartido { get; set; }
        public string rival { get; set; }
        public string deporteEvento { get; set; }
        public TipoEvento deporte { get; set; }

    }
}